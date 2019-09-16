using CefSharp;
using CefSharp.WinForms;
using System;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing;
using System.Text.RegularExpressions;

namespace SchemaDict.UI
{
    public partial class FrmBrowser : Form
    {
        public string DefaultEngine;
        public readonly string USER_AGENT = Properties.Settings.Default.UserAgent;
        private const int WM_DRAWCLIPBORAD = 776;
        private ChromiumWebBrowser Browser;
        private Class.Picker Picker;
        private static Configuration Filter;
        private Helper.SQLiteHelper DBHelper;
        private readonly int SYS_WIDTH = SystemInformation.PrimaryMonitorSize.Width;
        private readonly int SYS_HEIGHT = SystemInformation.PrimaryMonitorSize.Height;
        private bool BrowserVisibleStatus = false; //Browser Visible Status

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_DRAWCLIPBORAD) 
            {
                string str = Clipboard.GetText().ToLower().Trim();
                if (!string.IsNullOrWhiteSpace(str) && Regex.Match(str, "[^\\w ].*").Value.Equals(""))
                {
                    this.Text = str;
                    Browser.Load(string.Format(DefaultEngine, str));
                    if (this.Visible == false)
                        this.Show();
                    if (this.WindowState == FormWindowState.Minimized)
                        this.WindowState = FormWindowState.Normal;
                    this.BringToFront();
                    this.Activate();
                    if (Properties.Settings.Default.FlowMouse && Picker != null)
                    {
                        this.Visible = false;
                        if(Picker.MouseEventArgs != null)
                        {
                            int x = Picker.MouseEventArgs.X, y = Picker.MouseEventArgs.Y;
                            this.Height = (int)(SYS_HEIGHT * 0.5);
                            this.Width = (int)(SYS_WIDTH * 0.2);
                            if (y > (int)(SYS_HEIGHT * 0.55))
                            {
                                y = y - this.Height;
                            }
                            if(x > SYS_WIDTH / 2)
                            {
                                x = x - this.Width;
                            }
                            this.Location = new Point(x, y);
                        }
                        this.Visible = true;
                    }
                    //this.Focus();
                    DBHelper.Append(str);
                }
            }
        }

        public FrmBrowser()
        {
            DBHelper = new Helper.SQLiteHelper();
            Clipboard.Clear();
            InitializeComponent();
            InitialzeBrowser();
            this.Width = Properties.Settings.Default.FormWidth;
            this.Height = Properties.Settings.Default.FormHeight;
            this.Location = new Point(Properties.Settings.Default.FormX,
                                    Properties.Settings.Default.FormY);
            this.DoubleBuffered = true;
            this.Browser_Resize(null, null);
            Picker = new Class.Picker(Handle); //handle 传递给Picker 类 让 browser 响应任务
        }

        private void InitialzeBrowser()
        {
            //Load App.cofig and Filter.config
            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
            fileMap.ExeConfigFilename = Application.StartupPath + @"\Config\Filter.config";
            Filter = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            DefaultEngine = Properties.Settings.Default.DefaultEngine;
            CefSettings setting = new CefSettings();
            setting.UserAgent = USER_AGENT; //改成手机端请求头，让网页响应页面
            //setting.CachePath = string.Empty; //incognito mode
            setting.SetOffScreenRenderingBestPerformanceArgs(); //设置屏幕渲染最佳性能参数，解决高DPI错位问题
            setting.Locale = "en-US";
            Cef.Initialize(setting);
            string word = DBHelper.GetTopTimesWord();
            Browser = new ChromiumWebBrowser(string.Format(DefaultEngine, word)); 
            Browser.FrameLoadStart += new EventHandler<FrameLoadStartEventArgs>(FramLoadStart_Event);
            this.Text = word;

            //Cef.EnableHighDPISupport(); //对高DPI的支持
            if (Properties.Settings.Default.FlowMouse)
            {
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.MaximizeBox = false;
                //this.MinimizeBox = false;
            }
            this.panel1.Controls.Add(Browser);
        }

        //TODO 下个版本用response 实现拦截
        private void FramLoadStart_Event(Object obj, FrameLoadStartEventArgs args)
        {
            if (args.Browser.IsLoading)
            {
                string url = "";
                try
                {
                    //FILTER DOMAIN NAME
                    url = Regex.Match((Browser.GetMainFrame().Url), "(https://|http://)[^/]*").Value;
                    string blockContent = Filter.AppSettings.Settings[url].Value;
                    Browser.ExecuteScriptAsync(blockContent);
                }
                catch (NullReferenceException)
                {
                    //do nothing
                    //MessageBox.Show(url);
                }
            }
        }

        private void Browser_Resize(object sender, EventArgs e)
        {
            panel1.Width = this.Width - 6;
            panel1.Height = this.Height;
        }

        private void FrmBrowser_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!Properties.Settings.Default.FlowMouse)
                {
                    Properties.Settings.Default.FormHeight = this.Height;
                    Properties.Settings.Default.FormWidth = this.Width;
                    Properties.Settings.Default.FormX = this.Bounds.X;
                    Properties.Settings.Default.FormY = this.Bounds.Y;
                    Properties.Settings.Default.Save();
                }
                Picker.Dispose();
                Cef.Shutdown();
                if (settings != null)
                    settings.FrmSettings_FormClosing(null, null); // 防止setting失去活动出错
                DBHelper.CloseAll();
            }
            catch (Exception)
            {
                //DO NOTHING
            }
        }

        private void Browser_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                //this.Hide();
                this.BrowserVisibleStatus = true;
                this.NotifyIcon.Visible = true;
            }
        }

        private void notifyIcon1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //MessageBox.Show("r");
                this.NotifyIconTips.Show(MousePosition.X, MousePosition.Y);
            }else if(e.Button == MouseButtons.Left)
            {
                //MessageBox.Show("l");
                if (BrowserVisibleStatus)
                {
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                }
                else
                {
                    this.Hide();
                }
                BrowserVisibleStatus = !BrowserVisibleStatus;
            }
        }

        UI.FrmSettings settings;
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings == null || settings.IsDisposed)
            {
                settings = new UI.FrmSettings();
                settings.Owner = this;
            }
            else
            {
                settings.Activate();
            }
            settings.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private double OpacityValue = Properties.Settings.Default.BrowserOpactiy;
        private void TmrBrowserOpactiyShower_Tick(object sender, EventArgs e)
        {
            if(Opacity <= OpacityValue)
            {
                TmrBrowserOpactiyShower.Enabled = false;
            }else if(Opacity > OpacityValue)
            {
                Opacity -= 0.01;
            }
        }
    }
}
