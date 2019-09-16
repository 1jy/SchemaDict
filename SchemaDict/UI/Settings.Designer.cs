namespace SchemaDict.UI
{
    partial class FrmSettings
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Block Rules");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("New Rule");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Filter", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Display");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Select");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("URL");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Search Engine", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("About SchemaDict");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TvwNavigationBar = new System.Windows.Forms.TreeView();
            this.TabDisplay = new System.Windows.Forms.TabControl();
            this.TabScreen = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ChkFlowMouse = new System.Windows.Forms.CheckBox();
            this.ChkAhaMoment = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TrabBrowserOpactiy = new System.Windows.Forms.TrackBar();
            this.LblTips = new System.Windows.Forms.Label();
            this.BtnDisplayConfigSave = new System.Windows.Forms.Button();
            this.TxtFormHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFormWidth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtUserAgent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TabFilter = new System.Windows.Forms.TabControl();
            this.blockRules = new System.Windows.Forms.TabPage();
            this.LstFilterBlackList = new System.Windows.Forms.ListBox();
            this.newRule = new System.Windows.Forms.TabPage();
            this.TxtBlockRule = new System.Windows.Forms.TextBox();
            this.BtnUpdateFilter = new System.Windows.Forms.Button();
            this.TxtBlockURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TabSearchEngineInfo = new System.Windows.Forms.TabControl();
            this.TabSelectDefaultEngine = new System.Windows.Forms.TabPage();
            this.RbtnCustomerURL = new System.Windows.Forms.RadioButton();
            this.TxtCustomerURL = new System.Windows.Forms.TextBox();
            this.BtnApplyChangeEngine = new System.Windows.Forms.Button();
            this.RbtnCambridge = new System.Windows.Forms.RadioButton();
            this.RbtnGoogle = new System.Windows.Forms.RadioButton();
            this.RbtnBing = new System.Windows.Forms.RadioButton();
            this.TabSearchEngineURLMotify = new System.Windows.Forms.TabPage();
            this.BtnSearchEngineMotify = new System.Windows.Forms.Button();
            this.TxtGoogleURL = new System.Windows.Forms.TextBox();
            this.LblGoogleURL = new System.Windows.Forms.Label();
            this.TxtCambridgeURL = new System.Windows.Forms.TextBox();
            this.LblCambridgeURL = new System.Windows.Forms.Label();
            this.TxtBingURL = new System.Windows.Forms.TextBox();
            this.LblBingURL = new System.Windows.Forms.Label();
            this.TTErrorTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TabDisplay.SuspendLayout();
            this.TabScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrabBrowserOpactiy)).BeginInit();
            this.TabFilter.SuspendLayout();
            this.blockRules.SuspendLayout();
            this.newRule.SuspendLayout();
            this.TabSearchEngineInfo.SuspendLayout();
            this.TabSelectDefaultEngine.SuspendLayout();
            this.TabSearchEngineURLMotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.TvwNavigationBar);
            this.splitContainer1.Panel1MinSize = 10;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.TabDisplay);
            this.splitContainer1.Panel2.Controls.Add(this.TabFilter);
            this.splitContainer1.Panel2.Controls.Add(this.TabSearchEngineInfo);
            this.splitContainer1.Size = new System.Drawing.Size(519, 523);
            this.splitContainer1.SplitterDistance = 123;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // TvwNavigationBar
            // 
            this.TvwNavigationBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TvwNavigationBar.LineColor = System.Drawing.Color.Red;
            this.TvwNavigationBar.Location = new System.Drawing.Point(0, 0);
            this.TvwNavigationBar.Margin = new System.Windows.Forms.Padding(2);
            this.TvwNavigationBar.Name = "TvwNavigationBar";
            treeNode1.Name = "blockRules";
            treeNode1.Text = "Block Rules";
            treeNode2.Name = "newRule";
            treeNode2.Text = "New Rule";
            treeNode3.Name = "filter";
            treeNode3.Text = "Filter";
            treeNode4.Name = "display";
            treeNode4.Text = "Display";
            treeNode5.Name = "SelectSE";
            treeNode5.Text = "Select";
            treeNode6.Name = "SearchEngineUrl";
            treeNode6.Text = "URL";
            treeNode7.Name = "searchEngine";
            treeNode7.Text = "Search Engine";
            treeNode8.Name = "Node0";
            treeNode8.Text = "About SchemaDict";
            this.TvwNavigationBar.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode7,
            treeNode8});
            this.TvwNavigationBar.Size = new System.Drawing.Size(130, 334);
            this.TvwNavigationBar.TabIndex = 1;
            this.TvwNavigationBar.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.NavBar_AfterSelect);
            // 
            // TabDisplay
            // 
            this.TabDisplay.Controls.Add(this.TabScreen);
            this.TabDisplay.Location = new System.Drawing.Point(13, 303);
            this.TabDisplay.Name = "TabDisplay";
            this.TabDisplay.SelectedIndex = 0;
            this.TabDisplay.Size = new System.Drawing.Size(381, 217);
            this.TabDisplay.TabIndex = 2;
            // 
            // TabScreen
            // 
            this.TabScreen.Controls.Add(this.label8);
            this.TabScreen.Controls.Add(this.label7);
            this.TabScreen.Controls.Add(this.ChkFlowMouse);
            this.TabScreen.Controls.Add(this.ChkAhaMoment);
            this.TabScreen.Controls.Add(this.label6);
            this.TabScreen.Controls.Add(this.TrabBrowserOpactiy);
            this.TabScreen.Controls.Add(this.LblTips);
            this.TabScreen.Controls.Add(this.BtnDisplayConfigSave);
            this.TabScreen.Controls.Add(this.TxtFormHeight);
            this.TabScreen.Controls.Add(this.label4);
            this.TabScreen.Controls.Add(this.TxtFormWidth);
            this.TabScreen.Controls.Add(this.label5);
            this.TabScreen.Controls.Add(this.TxtUserAgent);
            this.TabScreen.Controls.Add(this.label3);
            this.TabScreen.Location = new System.Drawing.Point(4, 22);
            this.TabScreen.Name = "TabScreen";
            this.TabScreen.Padding = new System.Windows.Forms.Padding(3);
            this.TabScreen.Size = new System.Drawing.Size(373, 191);
            this.TabScreen.TabIndex = 1;
            this.TabScreen.Text = "Screen";
            this.TabScreen.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(196, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 12);
            this.label8.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(196, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 12);
            this.label7.TabIndex = 25;
            // 
            // ChkFlowMouse
            // 
            this.ChkFlowMouse.AutoSize = true;
            this.ChkFlowMouse.Location = new System.Drawing.Point(136, 252);
            this.ChkFlowMouse.Name = "ChkFlowMouse";
            this.ChkFlowMouse.Size = new System.Drawing.Size(174, 16);
            this.ChkFlowMouse.TabIndex = 24;
            this.ChkFlowMouse.Text = "Immediately display popup";
            this.ChkFlowMouse.UseVisualStyleBackColor = true;
            // 
            // ChkAhaMoment
            // 
            this.ChkAhaMoment.AutoSize = true;
            this.ChkAhaMoment.Location = new System.Drawing.Point(18, 252);
            this.ChkAhaMoment.Name = "ChkAhaMoment";
            this.ChkAhaMoment.Size = new System.Drawing.Size(102, 16);
            this.ChkAhaMoment.TabIndex = 23;
            this.ChkAhaMoment.Text = "\"aha!\" moment";
            this.ChkAhaMoment.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "Browser Opactiy:";
            // 
            // TrabBrowserOpactiy
            // 
            this.TrabBrowserOpactiy.AccessibleName = "";
            this.TrabBrowserOpactiy.BackColor = System.Drawing.Color.White;
            this.TrabBrowserOpactiy.Location = new System.Drawing.Point(123, 187);
            this.TrabBrowserOpactiy.Maximum = 100;
            this.TrabBrowserOpactiy.Minimum = 50;
            this.TrabBrowserOpactiy.Name = "TrabBrowserOpactiy";
            this.TrabBrowserOpactiy.Size = new System.Drawing.Size(237, 45);
            this.TrabBrowserOpactiy.SmallChange = 10;
            this.TrabBrowserOpactiy.TabIndex = 21;
            this.TrabBrowserOpactiy.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrabBrowserOpactiy.Value = 50;
            this.TrabBrowserOpactiy.Scroll += new System.EventHandler(this.TrabBrowserOpactiy_Scroll);
            this.TrabBrowserOpactiy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrabBrowserOpactiy_MouseUp);
            // 
            // LblTips
            // 
            this.LblTips.AutoSize = true;
            this.LblTips.ForeColor = System.Drawing.Color.DarkRed;
            this.LblTips.Location = new System.Drawing.Point(15, 10);
            this.LblTips.Name = "LblTips";
            this.LblTips.Size = new System.Drawing.Size(167, 12);
            this.LblTips.TabIndex = 20;
            this.LblTips.Text = "*after reboot takes effect.";
            this.LblTips.Visible = false;
            // 
            // BtnDisplayConfigSave
            // 
            this.BtnDisplayConfigSave.Location = new System.Drawing.Point(13, 289);
            this.BtnDisplayConfigSave.Name = "BtnDisplayConfigSave";
            this.BtnDisplayConfigSave.Size = new System.Drawing.Size(75, 33);
            this.BtnDisplayConfigSave.TabIndex = 19;
            this.BtnDisplayConfigSave.Text = "Save";
            this.BtnDisplayConfigSave.UseVisualStyleBackColor = true;
            this.BtnDisplayConfigSave.Click += new System.EventHandler(this.BtnDisplayConfigSave_Click);
            // 
            // TxtFormHeight
            // 
            this.TxtFormHeight.Location = new System.Drawing.Point(91, 140);
            this.TxtFormHeight.MaxLength = 5;
            this.TxtFormHeight.Name = "TxtFormHeight";
            this.TxtFormHeight.Size = new System.Drawing.Size(91, 21);
            this.TxtFormHeight.TabIndex = 18;
            this.TxtFormHeight.TextChanged += new System.EventHandler(this.TxtFormHeight_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "Height:";
            // 
            // TxtFormWidth
            // 
            this.TxtFormWidth.Location = new System.Drawing.Point(91, 103);
            this.TxtFormWidth.MaxLength = 5;
            this.TxtFormWidth.Name = "TxtFormWidth";
            this.TxtFormWidth.Size = new System.Drawing.Size(91, 21);
            this.TxtFormWidth.TabIndex = 16;
            this.TxtFormWidth.TextChanged += new System.EventHandler(this.TxtFormWidth_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "Width:";
            // 
            // TxtUserAgent
            // 
            this.TxtUserAgent.Location = new System.Drawing.Point(91, 31);
            this.TxtUserAgent.MaxLength = 100;
            this.TxtUserAgent.Multiline = true;
            this.TxtUserAgent.Name = "TxtUserAgent";
            this.TxtUserAgent.Size = new System.Drawing.Size(269, 59);
            this.TxtUserAgent.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "User Agent:";
            // 
            // TabFilter
            // 
            this.TabFilter.Controls.Add(this.blockRules);
            this.TabFilter.Controls.Add(this.newRule);
            this.TabFilter.Location = new System.Drawing.Point(3, 0);
            this.TabFilter.Margin = new System.Windows.Forms.Padding(2);
            this.TabFilter.Name = "TabFilter";
            this.TabFilter.SelectedIndex = 0;
            this.TabFilter.Size = new System.Drawing.Size(433, 104);
            this.TabFilter.TabIndex = 0;
            this.TabFilter.Visible = false;
            // 
            // blockRules
            // 
            this.blockRules.BackColor = System.Drawing.SystemColors.Control;
            this.blockRules.Controls.Add(this.LstFilterBlackList);
            this.blockRules.Location = new System.Drawing.Point(4, 22);
            this.blockRules.Margin = new System.Windows.Forms.Padding(2);
            this.blockRules.Name = "blockRules";
            this.blockRules.Padding = new System.Windows.Forms.Padding(2);
            this.blockRules.Size = new System.Drawing.Size(425, 78);
            this.blockRules.TabIndex = 0;
            this.blockRules.Text = "Block Rules";
            this.blockRules.Enter += new System.EventHandler(this.blockRules_Enter);
            // 
            // LstFilterBlackList
            // 
            this.LstFilterBlackList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LstFilterBlackList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstFilterBlackList.ForeColor = System.Drawing.Color.Black;
            this.LstFilterBlackList.FormattingEnabled = true;
            this.LstFilterBlackList.ItemHeight = 12;
            this.LstFilterBlackList.Items.AddRange(new object[] {
            "测试一哈"});
            this.LstFilterBlackList.Location = new System.Drawing.Point(2, 2);
            this.LstFilterBlackList.Margin = new System.Windows.Forms.Padding(2);
            this.LstFilterBlackList.Name = "LstFilterBlackList";
            this.LstFilterBlackList.Size = new System.Drawing.Size(421, 74);
            this.LstFilterBlackList.TabIndex = 0;
            this.LstFilterBlackList.SelectedIndexChanged += new System.EventHandler(this.LstFilterBlackList_SelectedIndexChanged);
            // 
            // newRule
            // 
            this.newRule.BackColor = System.Drawing.Color.White;
            this.newRule.Controls.Add(this.TxtBlockRule);
            this.newRule.Controls.Add(this.BtnUpdateFilter);
            this.newRule.Controls.Add(this.TxtBlockURL);
            this.newRule.Controls.Add(this.label2);
            this.newRule.Controls.Add(this.label1);
            this.newRule.Location = new System.Drawing.Point(4, 22);
            this.newRule.Margin = new System.Windows.Forms.Padding(2);
            this.newRule.Name = "newRule";
            this.newRule.Padding = new System.Windows.Forms.Padding(2);
            this.newRule.Size = new System.Drawing.Size(425, 78);
            this.newRule.TabIndex = 1;
            this.newRule.Text = "Make Rule";
            this.newRule.Enter += new System.EventHandler(this.newRule_Enter);
            this.newRule.Leave += new System.EventHandler(this.newRule_Leave);
            // 
            // TxtBlockRule
            // 
            this.TxtBlockRule.Location = new System.Drawing.Point(49, 49);
            this.TxtBlockRule.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBlockRule.Multiline = true;
            this.TxtBlockRule.Name = "TxtBlockRule";
            this.TxtBlockRule.Size = new System.Drawing.Size(314, 204);
            this.TxtBlockRule.TabIndex = 3;
            this.TxtBlockRule.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBlockRule_KeyUp);
            // 
            // BtnUpdateFilter
            // 
            this.BtnUpdateFilter.Location = new System.Drawing.Point(161, 268);
            this.BtnUpdateFilter.Margin = new System.Windows.Forms.Padding(2);
            this.BtnUpdateFilter.Name = "BtnUpdateFilter";
            this.BtnUpdateFilter.Size = new System.Drawing.Size(75, 29);
            this.BtnUpdateFilter.TabIndex = 2;
            this.BtnUpdateFilter.Text = "Update";
            this.BtnUpdateFilter.UseVisualStyleBackColor = true;
            this.BtnUpdateFilter.Click += new System.EventHandler(this.BtnUpdateFilter_Click);
            // 
            // TxtBlockURL
            // 
            this.TxtBlockURL.Location = new System.Drawing.Point(49, 12);
            this.TxtBlockURL.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBlockURL.MaxLength = 100;
            this.TxtBlockURL.Name = "TxtBlockURL";
            this.TxtBlockURL.Size = new System.Drawing.Size(314, 21);
            this.TxtBlockURL.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "rule:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL:";
            // 
            // TabSearchEngineInfo
            // 
            this.TabSearchEngineInfo.Controls.Add(this.TabSelectDefaultEngine);
            this.TabSearchEngineInfo.Controls.Add(this.TabSearchEngineURLMotify);
            this.TabSearchEngineInfo.Location = new System.Drawing.Point(9, 122);
            this.TabSearchEngineInfo.Margin = new System.Windows.Forms.Padding(2);
            this.TabSearchEngineInfo.Name = "TabSearchEngineInfo";
            this.TabSearchEngineInfo.SelectedIndex = 0;
            this.TabSearchEngineInfo.ShowToolTips = true;
            this.TabSearchEngineInfo.Size = new System.Drawing.Size(385, 176);
            this.TabSearchEngineInfo.TabIndex = 1;
            this.TabSearchEngineInfo.Enter += new System.EventHandler(this.TabSearchEngineInfo_Enter);
            // 
            // TabSelectDefaultEngine
            // 
            this.TabSelectDefaultEngine.Controls.Add(this.RbtnCustomerURL);
            this.TabSelectDefaultEngine.Controls.Add(this.TxtCustomerURL);
            this.TabSelectDefaultEngine.Controls.Add(this.BtnApplyChangeEngine);
            this.TabSelectDefaultEngine.Controls.Add(this.RbtnCambridge);
            this.TabSelectDefaultEngine.Controls.Add(this.RbtnGoogle);
            this.TabSelectDefaultEngine.Controls.Add(this.RbtnBing);
            this.TabSelectDefaultEngine.Location = new System.Drawing.Point(4, 22);
            this.TabSelectDefaultEngine.Margin = new System.Windows.Forms.Padding(2);
            this.TabSelectDefaultEngine.Name = "TabSelectDefaultEngine";
            this.TabSelectDefaultEngine.Padding = new System.Windows.Forms.Padding(2);
            this.TabSelectDefaultEngine.Size = new System.Drawing.Size(377, 150);
            this.TabSelectDefaultEngine.TabIndex = 1;
            this.TabSelectDefaultEngine.Text = "Select";
            this.TabSelectDefaultEngine.UseVisualStyleBackColor = true;
            this.TabSelectDefaultEngine.Enter += new System.EventHandler(this.TabSelectDefaultEngine_Enter);
            // 
            // RbtnCustomerURL
            // 
            this.RbtnCustomerURL.AutoSize = true;
            this.RbtnCustomerURL.Location = new System.Drawing.Point(12, 94);
            this.RbtnCustomerURL.Margin = new System.Windows.Forms.Padding(2);
            this.RbtnCustomerURL.Name = "RbtnCustomerURL";
            this.RbtnCustomerURL.Size = new System.Drawing.Size(77, 16);
            this.RbtnCustomerURL.TabIndex = 6;
            this.RbtnCustomerURL.Text = "Customer:";
            this.RbtnCustomerURL.UseVisualStyleBackColor = true;
            this.RbtnCustomerURL.Click += new System.EventHandler(this.RbtnCustomerURL_Click);
            // 
            // TxtCustomerURL
            // 
            this.TxtCustomerURL.Location = new System.Drawing.Point(90, 93);
            this.TxtCustomerURL.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustomerURL.MaxLength = 100;
            this.TxtCustomerURL.Name = "TxtCustomerURL";
            this.TxtCustomerURL.Size = new System.Drawing.Size(274, 21);
            this.TxtCustomerURL.TabIndex = 5;
            // 
            // BtnApplyChangeEngine
            // 
            this.BtnApplyChangeEngine.Location = new System.Drawing.Point(11, 121);
            this.BtnApplyChangeEngine.Margin = new System.Windows.Forms.Padding(2);
            this.BtnApplyChangeEngine.Name = "BtnApplyChangeEngine";
            this.BtnApplyChangeEngine.Size = new System.Drawing.Size(75, 33);
            this.BtnApplyChangeEngine.TabIndex = 3;
            this.BtnApplyChangeEngine.Text = "Apply";
            this.BtnApplyChangeEngine.UseVisualStyleBackColor = true;
            this.BtnApplyChangeEngine.Click += new System.EventHandler(this.BtnApplyChangeEngine_Click);
            // 
            // RbtnCambridge
            // 
            this.RbtnCambridge.AutoSize = true;
            this.RbtnCambridge.Location = new System.Drawing.Point(11, 65);
            this.RbtnCambridge.Margin = new System.Windows.Forms.Padding(2);
            this.RbtnCambridge.Name = "RbtnCambridge";
            this.RbtnCambridge.Size = new System.Drawing.Size(143, 16);
            this.RbtnCambridge.TabIndex = 2;
            this.RbtnCambridge.Text = "Cambridge Dictionary";
            this.RbtnCambridge.UseVisualStyleBackColor = true;
            this.RbtnCambridge.Click += new System.EventHandler(this.RbtnCambridge_Click);
            // 
            // RbtnGoogle
            // 
            this.RbtnGoogle.AutoSize = true;
            this.RbtnGoogle.Location = new System.Drawing.Point(11, 39);
            this.RbtnGoogle.Margin = new System.Windows.Forms.Padding(2);
            this.RbtnGoogle.Name = "RbtnGoogle";
            this.RbtnGoogle.Size = new System.Drawing.Size(119, 16);
            this.RbtnGoogle.TabIndex = 1;
            this.RbtnGoogle.Text = "Google Translate";
            this.RbtnGoogle.UseVisualStyleBackColor = true;
            this.RbtnGoogle.Click += new System.EventHandler(this.RbtnGoogle_Click);
            // 
            // RbtnBing
            // 
            this.RbtnBing.AutoSize = true;
            this.RbtnBing.Location = new System.Drawing.Point(12, 16);
            this.RbtnBing.Margin = new System.Windows.Forms.Padding(2);
            this.RbtnBing.Name = "RbtnBing";
            this.RbtnBing.Size = new System.Drawing.Size(77, 16);
            this.RbtnBing.TabIndex = 0;
            this.RbtnBing.Text = "Bing Dict";
            this.RbtnBing.UseVisualStyleBackColor = true;
            this.RbtnBing.Click += new System.EventHandler(this.RbtnBing_Click);
            // 
            // TabSearchEngineURLMotify
            // 
            this.TabSearchEngineURLMotify.Controls.Add(this.BtnSearchEngineMotify);
            this.TabSearchEngineURLMotify.Controls.Add(this.TxtGoogleURL);
            this.TabSearchEngineURLMotify.Controls.Add(this.LblGoogleURL);
            this.TabSearchEngineURLMotify.Controls.Add(this.TxtCambridgeURL);
            this.TabSearchEngineURLMotify.Controls.Add(this.LblCambridgeURL);
            this.TabSearchEngineURLMotify.Controls.Add(this.TxtBingURL);
            this.TabSearchEngineURLMotify.Controls.Add(this.LblBingURL);
            this.TabSearchEngineURLMotify.Location = new System.Drawing.Point(4, 22);
            this.TabSearchEngineURLMotify.Margin = new System.Windows.Forms.Padding(2);
            this.TabSearchEngineURLMotify.Name = "TabSearchEngineURLMotify";
            this.TabSearchEngineURLMotify.Padding = new System.Windows.Forms.Padding(2);
            this.TabSearchEngineURLMotify.Size = new System.Drawing.Size(377, 150);
            this.TabSearchEngineURLMotify.TabIndex = 2;
            this.TabSearchEngineURLMotify.Text = "Search Engine URL";
            this.TabSearchEngineURLMotify.UseVisualStyleBackColor = true;
            // 
            // BtnSearchEngineMotify
            // 
            this.BtnSearchEngineMotify.Location = new System.Drawing.Point(14, 132);
            this.BtnSearchEngineMotify.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSearchEngineMotify.Name = "BtnSearchEngineMotify";
            this.BtnSearchEngineMotify.Size = new System.Drawing.Size(75, 33);
            this.BtnSearchEngineMotify.TabIndex = 6;
            this.BtnSearchEngineMotify.Text = "Motify";
            this.BtnSearchEngineMotify.UseVisualStyleBackColor = true;
            this.BtnSearchEngineMotify.Click += new System.EventHandler(this.BtnSearchEngineMotify_Click);
            // 
            // TxtGoogleURL
            // 
            this.TxtGoogleURL.Location = new System.Drawing.Point(78, 94);
            this.TxtGoogleURL.Margin = new System.Windows.Forms.Padding(2);
            this.TxtGoogleURL.MaxLength = 100;
            this.TxtGoogleURL.Name = "TxtGoogleURL";
            this.TxtGoogleURL.Size = new System.Drawing.Size(279, 21);
            this.TxtGoogleURL.TabIndex = 5;
            // 
            // LblGoogleURL
            // 
            this.LblGoogleURL.AutoSize = true;
            this.LblGoogleURL.Location = new System.Drawing.Point(11, 97);
            this.LblGoogleURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblGoogleURL.Name = "LblGoogleURL";
            this.LblGoogleURL.Size = new System.Drawing.Size(47, 12);
            this.LblGoogleURL.TabIndex = 4;
            this.LblGoogleURL.Text = "Google:";
            // 
            // TxtCambridgeURL
            // 
            this.TxtCambridgeURL.Location = new System.Drawing.Point(78, 58);
            this.TxtCambridgeURL.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCambridgeURL.MaxLength = 100;
            this.TxtCambridgeURL.Name = "TxtCambridgeURL";
            this.TxtCambridgeURL.Size = new System.Drawing.Size(279, 21);
            this.TxtCambridgeURL.TabIndex = 3;
            // 
            // LblCambridgeURL
            // 
            this.LblCambridgeURL.AutoSize = true;
            this.LblCambridgeURL.Location = new System.Drawing.Point(11, 60);
            this.LblCambridgeURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCambridgeURL.Name = "LblCambridgeURL";
            this.LblCambridgeURL.Size = new System.Drawing.Size(65, 12);
            this.LblCambridgeURL.TabIndex = 2;
            this.LblCambridgeURL.Text = "Cambridge:";
            // 
            // TxtBingURL
            // 
            this.TxtBingURL.Location = new System.Drawing.Point(78, 17);
            this.TxtBingURL.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBingURL.MaxLength = 100;
            this.TxtBingURL.Name = "TxtBingURL";
            this.TxtBingURL.Size = new System.Drawing.Size(279, 21);
            this.TxtBingURL.TabIndex = 1;
            // 
            // LblBingURL
            // 
            this.LblBingURL.AutoSize = true;
            this.LblBingURL.Location = new System.Drawing.Point(11, 19);
            this.LblBingURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblBingURL.Name = "LblBingURL";
            this.LblBingURL.Size = new System.Drawing.Size(35, 12);
            this.LblBingURL.TabIndex = 0;
            this.LblBingURL.Text = "Bing:";
            // 
            // TTErrorTip
            // 
            this.TTErrorTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 523);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSettings_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.TabDisplay.ResumeLayout(false);
            this.TabScreen.ResumeLayout(false);
            this.TabScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrabBrowserOpactiy)).EndInit();
            this.TabFilter.ResumeLayout(false);
            this.blockRules.ResumeLayout(false);
            this.newRule.ResumeLayout(false);
            this.newRule.PerformLayout();
            this.TabSearchEngineInfo.ResumeLayout(false);
            this.TabSelectDefaultEngine.ResumeLayout(false);
            this.TabSelectDefaultEngine.PerformLayout();
            this.TabSearchEngineURLMotify.ResumeLayout(false);
            this.TabSearchEngineURLMotify.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView TvwNavigationBar;
        private System.Windows.Forms.TabControl TabSearchEngineInfo;
        private System.Windows.Forms.TabPage TabSelectDefaultEngine;
        private System.Windows.Forms.RadioButton RbtnCambridge;
        private System.Windows.Forms.RadioButton RbtnGoogle;
        private System.Windows.Forms.RadioButton RbtnBing;
        private System.Windows.Forms.Button BtnApplyChangeEngine;
        private System.Windows.Forms.TextBox TxtCustomerURL;
        private System.Windows.Forms.RadioButton RbtnCustomerURL;
        private System.Windows.Forms.TabPage TabSearchEngineURLMotify;
        private System.Windows.Forms.TextBox TxtCambridgeURL;
        private System.Windows.Forms.Label LblCambridgeURL;
        private System.Windows.Forms.TextBox TxtBingURL;
        private System.Windows.Forms.Label LblBingURL;
        private System.Windows.Forms.TabControl TabFilter;
        private System.Windows.Forms.TabPage blockRules;
        private System.Windows.Forms.ListBox LstFilterBlackList;
        private System.Windows.Forms.TabPage newRule;
        private System.Windows.Forms.Button BtnUpdateFilter;
        private System.Windows.Forms.TextBox TxtBlockURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtGoogleURL;
        private System.Windows.Forms.Label LblGoogleURL;
        private System.Windows.Forms.Button BtnSearchEngineMotify;
        private System.Windows.Forms.TextBox TxtBlockRule;
        private System.Windows.Forms.TabControl TabDisplay;
        private System.Windows.Forms.TabPage TabScreen;
        private System.Windows.Forms.CheckBox ChkFlowMouse;
        private System.Windows.Forms.CheckBox ChkAhaMoment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar TrabBrowserOpactiy;
        private System.Windows.Forms.Label LblTips;
        private System.Windows.Forms.Button BtnDisplayConfigSave;
        private System.Windows.Forms.TextBox TxtFormHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtFormWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtUserAgent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip TTErrorTip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}