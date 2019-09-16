namespace SchemaDict.UI
{
    partial class FrmBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBrowser));
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyIconTips = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TmrBrowserOpactiyShower = new System.Windows.Forms.Timer(this.components);
            this.NotifyIconTips.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotifyIcon
            // 
            resources.ApplyResources(this.NotifyIcon, "NotifyIcon");
            this.NotifyIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseUp);
            // 
            // NotifyIconTips
            // 
            this.NotifyIconTips.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.NotifyIconTips.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.NotifyIconTips.Name = "contextMenuStrip1";
            this.NotifyIconTips.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            resources.ApplyResources(this.NotifyIconTips, "NotifyIconTips");
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // TmrBrowserOpactiyShower
            // 
            this.TmrBrowserOpactiyShower.Enabled = true;
            this.TmrBrowserOpactiyShower.Interval = 70;
            this.TmrBrowserOpactiyShower.Tick += new System.EventHandler(this.TmrBrowserOpactiyShower_Tick);
            // 
            // FrmBrowser
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FrmBrowser";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBrowser_FormClosing);
            this.SizeChanged += new System.EventHandler(this.Browser_SizeChanged);
            this.Resize += new System.EventHandler(this.Browser_Resize);
            this.NotifyIconTips.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip NotifyIconTips;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.Timer TmrBrowserOpactiyShower;
    }
}