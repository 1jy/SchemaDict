using System;
using System.Collections;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SchemaDict.UI
{
    public partial class FrmSettings : Form
    {
        Configuration Filter;
        private int EngineChoice = Properties.Settings.Default.EngineChoice;
        private const int BING = 0;
        private const int GOOGLE = 1;
        private const int CAMBRIDGE = 2;
        private const int CUSTOMER = 3;

        public FrmSettings()
        {
            InitializeComponent();
            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
            fileMap.ExeConfigFilename = Application.StartupPath + @"\Config\Filter.config";
            Filter = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            LoadFilterData(null, null);
            this.Activated += new EventHandler(FrmSettings_Show);
            this.Deactivate += new EventHandler(FrmSettings_Hide);
            TvwNavigationBar.ExpandAll();
            TabFilter.Dock = DockStyle.Fill;
            TabFilter.Parent = splitContainer1.Panel2;
            TabSearchEngineInfo.Parent = splitContainer1.Panel2;
            TabDisplay.Parent = splitContainer1.Panel2;
            TabDisplay.Dock = DockStyle.Fill;
            TabSearchEngineInfo.Dock = DockStyle.Fill;
            TrabBrowserOpactiy.MouseLeave += new EventHandler((obj, e) => { ((UI.FrmBrowser)this.Owner).Opacity = Properties.Settings.Default.BrowserOpactiy; });
        }

        /**
         * when settings window Deactivate then set it opacity attribute values equal 0.5f
         * when settings window Activate then set it opacity attribute values equal 1f
        **/
        private void FrmSettings_Show(object sender, EventArgs e)
        {
            this.Opacity = 1f;
        }

        private void FrmSettings_Hide(object sender, EventArgs e)
        {
            this.Opacity = 0.5f;
        }

        //Key parmater is URL, Value parmater is block rule.
        private bool AppendRuleInFilter(string key, string value)
        {
            bool result = false;
            try
            {
                string[] keys = Filter.AppSettings.Settings.AllKeys;
                if (((IList)keys).Contains(key))
                {
                    Filter.AppSettings.Settings[key].Value = value;
                }
                else
                {
                    Filter.AppSettings.Settings.Add(key, value);
                }
                Filter.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return result;
        }

        private void LoadFilterData(object sender, EventArgs e)
        {
            foreach (string key in Filter.AppSettings.Settings.AllKeys)
            {
                if (!LstFilterBlackList.Items.Contains(key))
                    LstFilterBlackList.Items.Add(key);
            }
        }

        public void FrmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Deactivate -= new EventHandler(FrmSettings_Hide);
        }

        private void NavBar_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Filter":
                    TabFilter.Visible = true;
                    TabDisplay.Visible = false;
                    TabFilter.SelectedIndex = 0;
                    TabSearchEngineInfo.Visible = false;
                    break;
                case "Block Rules":
                case "New Rule":
                    TabFilter.Visible = true;
                    TabDisplay.Visible = false;
                    TabSearchEngineInfo.Visible = false;
                    TabFilter.SelectTab(e.Node.Index);
                    break;
                case "Display":
                    TabFilter.Visible = false;
                    TabDisplay.Visible = true;
                    LoadDisplayConfig();
                    TabSearchEngineInfo.Visible = false;
                    break;
                case "Search Engine":
                    TabSearchEngineInfo.Visible = true;
                    TabFilter.Visible = false;
                    TabDisplay.Visible = false;
                    TabSearchEngineInfo.SelectedIndex = 0;
                    TabSelectDefaultEngine_Enter(null, null);
                    break;
                case "Select":
                case "URL":
                    TabSelectDefaultEngine_Enter(null, null);
                    TabSearchEngineInfo_Enter(null, null);
                    TabDisplay.Visible = false;
                    TabSearchEngineInfo.Visible = true;
                    TabFilter.Visible = false;
                    TabSearchEngineInfo.SelectTab(e.Node.Index);
                    break;
            }
        }

        private void LoadDisplayConfig()
        {
            TxtUserAgent.Text = Properties.Settings.Default.UserAgent;
            TxtFormWidth.Text = Properties.Settings.Default.FormWidth.ToString();
            TxtFormHeight.Text = Properties.Settings.Default.FormHeight.ToString();
            ChkFlowMouse.Checked = Properties.Settings.Default.FlowMouse;
            ChkAhaMoment.Checked = Properties.Settings.Default.AhaMoment;
            TrabBrowserOpactiy.Value = (int)(Properties.Settings.Default.BrowserOpactiy * 100);
        }

        private void LstFilterBlackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TabFilter.SelectTab(1);
            if(LstFilterBlackList.SelectedItem != null)
                TxtBlockURL.Text = LstFilterBlackList.SelectedItem.ToString();
            if (Filter.AppSettings.Settings[TxtBlockURL.Text] == null)
            {
                TxtBlockRule.Text = "";
            }
            else
            {
                TxtBlockRule.Text = Filter.AppSettings.Settings[TxtBlockURL.Text].Value;
            }
            LstFilterBlackList.ClearSelected();
        }

        private void BtnUpdateFilter_Click(object sender, EventArgs e)
        {
            string key = TxtBlockURL.Text, value = TxtBlockRule.Text;
            if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(value))
            {
                MessageBox.Show("URL and Block Rule Can't be empty.");
                TxtBlockRule.Clear();
            }
            else
            {
                MessageBox.Show(AppendRuleInFilter(key, value) ? "Update Success" : "Error",
                    "Msg",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void TxtBlockRule_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                BtnUpdateFilter_Click(null, null);
            }
        }

        private void BtnApplyChangeEngine_Click(object sender, EventArgs e)
        {
            switch (EngineChoice)
            {
                case BING:
                    Properties.Settings.Default.DefaultEngine = Properties.Settings.Default.BingURL;
                    break;
                case GOOGLE:
                    Properties.Settings.Default.DefaultEngine = Properties.Settings.Default.GoogleURL;
                    break;
                case CAMBRIDGE:
                    Properties.Settings.Default.DefaultEngine = Properties.Settings.Default.CambridgeURL;
                    break;
                case CUSTOMER:
                    if (string.IsNullOrEmpty(TxtCustomerURL.Text))
                    {
                        MessageBox.Show("Customer URL can't be empty.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        Properties.Settings.Default.DefaultEngine = TxtCustomerURL.Text;
                    }
                break;
                default:
                    MessageBox.Show("Oops!Got a problem.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    return;
            }

            Properties.Settings.Default.EngineChoice = EngineChoice;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            ((UI.FrmBrowser)this.Owner).DefaultEngine = Properties.Settings.Default.DefaultEngine;
            MessageBox.Show("Apply Success.",
                            "Info",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void RbtnCustomerURL_Click(object sender, EventArgs e)
        {
            if (TxtCustomerURL.Text.Equals(string.Empty))
            {
                TxtCustomerURL.Focus();
            }
            EngineChoice = 3;
        }

        private void RbtnCambridge_Click(object sender, EventArgs e)
        {
            EngineChoice = CAMBRIDGE;
        }

        private void RbtnGoogle_Click(object sender, EventArgs e)
        {
            EngineChoice = GOOGLE;
        }

        private void RbtnBing_Click(object sender, EventArgs e)
        {
            EngineChoice = BING;
        }

        private void TabSelectDefaultEngine_Enter(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.EngineChoice)
            {
                case BING:
                    RbtnBing.Checked = true;
                    break;
                case GOOGLE:
                    RbtnGoogle.Checked = true;
                    break;
                case CAMBRIDGE:
                    RbtnCambridge.Checked = true;
                    break;
                case CUSTOMER:
                    RbtnCustomerURL.Checked = true;
                    TxtCustomerURL.Text = Properties.Settings.Default.DefaultEngine;
                    break;
            }
        }

        private void BtnSearchEngineMotify_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BingURL = TxtBingURL.Text;
            Properties.Settings.Default.CambridgeURL = TxtCambridgeURL.Text;
            Properties.Settings.Default.GoogleURL = TxtGoogleURL.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Success.",
                        "Search Engine",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
        }

        private void BtnDisplayConfigSave_Click(object sender, EventArgs e)
        {
            FrmBrowser browser = (FrmBrowser)this.Owner;
            int formWidthValue = 0;
            int formHeightValue = 0;

            formWidthValue = Convert.ToInt32(TxtFormWidth.Text);
            formHeightValue = Convert.ToInt32(TxtFormHeight.Text);

            Properties.Settings.Default.UserAgent = TxtUserAgent.Text;
            Properties.Settings.Default.FormWidth = Convert.ToInt32(TxtFormWidth.Text);
            Properties.Settings.Default.FormHeight = Convert.ToInt32(TxtFormHeight.Text);
            Properties.Settings.Default.BrowserOpactiy = TrabBrowserOpactiy.Value / 100.0;
            browser.Opacity = Properties.Settings.Default.BrowserOpactiy;
            Properties.Settings.Default.FlowMouse = ChkFlowMouse.Checked;
            Properties.Settings.Default.AhaMoment = ChkAhaMoment.Checked;
            Properties.Settings.Default.Save();


            if (!browser.USER_AGENT.Equals(TxtUserAgent.Text)) LblTips.Visible = true;
            if (this.Owner.Width != formWidthValue) this.Owner.Width = formWidthValue;
            if (this.Owner.Height != formHeightValue) this.Owner.Height = formHeightValue;
            MessageBox.Show("Success.",
                        "Display",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
        }

        private void TabSearchEngineInfo_Enter(object sender, EventArgs e)
        {
            TxtBingURL.Text = Properties.Settings.Default.BingURL;
            TxtCambridgeURL.Text = Properties.Settings.Default.CambridgeURL;
            TxtGoogleURL.Text = Properties.Settings.Default.GoogleURL;
        }

        private void TrabBrowserOpactiy_Scroll(object sender, EventArgs e)
        {
            ((UI.FrmBrowser)this.Owner).Opacity = TrabBrowserOpactiy.Value / 100.0;
        }

        private void TrabBrowserOpactiy_MouseUp(object sender, MouseEventArgs e)
        {
            ((UI.FrmBrowser)this.Owner).Opacity = Properties.Settings.Default.BrowserOpactiy;
        }

        private void newRule_Leave(object sender, EventArgs e)
        {
            TxtBlockRule.Clear();
            TxtBlockURL.Clear();
        }

        private void TxtFormWidth_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(TxtFormWidth.Text, "[^(0-9)]").Value.Equals(string.Empty))
            {
                label7.Text = '\'' + TxtFormWidth.Text + "'\nis not a number or Positive \nnumber.";
                BtnDisplayConfigSave.Enabled = false;
            }
            else
            {
                label7.Text = "";
                if (label8.Text.Equals(string.Empty))
                    BtnDisplayConfigSave.Enabled = true;
            }
        }

        private void TxtFormHeight_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(TxtFormHeight.Text, "[^(0-9)]").Value.Equals(string.Empty))
            {
                label8.Text = '\'' + TxtFormHeight.Text + "\nis not a number or Positive \nnumber.";
                BtnDisplayConfigSave.Enabled = false;
            }
            else
            {
                label8.Text = "";
                if(label7.Text.Equals(string.Empty))
                    BtnDisplayConfigSave.Enabled = true;
            }
        }

        private void blockRules_Enter(object sender, EventArgs e)
        {
            LoadFilterData(null, null);
        }

        private void newRule_Enter(object sender, EventArgs e)
        {
            TxtBlockRule.Focus();
        }
    }
}
