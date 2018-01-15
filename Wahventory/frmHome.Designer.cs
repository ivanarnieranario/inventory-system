namespace Wahventory
{
    partial class frmHome
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
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblUser = new ns1.BunifuCustomLabel();
            this.lblUserFullName = new ns1.BunifuCustomLabel();
            this.lblConnection = new ns1.BunifuCustomLabel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.linkAbout = new System.Windows.Forms.LinkLabel();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblLimitRecords = new ns1.BunifuCustomLabel();
            this.cbLimiteRecords = new System.Windows.Forms.ComboBox();
            this.btnSwitchAccount = new ns1.BunifuFlatButton();
            this.btnSettings = new ns1.BunifuFlatButton();
            this.btnTechBag = new ns1.BunifuFlatButton();
            this.btnDisposeItem = new ns1.BunifuFlatButton();
            this.btnReturn = new ns1.BunifuFlatButton();
            this.btnInventory = new ns1.BunifuFlatButton();
            this.btnReports = new ns1.BunifuFlatButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblTime = new ns1.BunifuCustomLabel();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.lblDate = new ns1.BunifuCustomLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.ctrl_Reports1 = new Wahventory.controls.ctrl_Reports();
            this.ctrl_Settings1 = new Wahventory.controls.ctrl_Settings();
            this.ctrl_Inventory1 = new Wahventory.ctrl_Inventory();
            this.ctrl_Dispose1 = new Wahventory.controls.ctrl_Dispose();
            this.ctrl_Return1 = new Wahventory.controls.ctrl_Return();
            this.ctrl_Techbag1 = new Wahventory.controls.ctrl_Techbag();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new ns1.BunifuCustomLabel();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.btnMaximize = new ns1.BunifuFlatButton();
            this.btnClose = new ns1.BunifuFlatButton();
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.transitionReports = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.transitionInventory = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.transitionSettings = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.transitionDispose = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.transitionReturn = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl3 = new ns1.BunifuDragControl(this.components);
            this.transitionTechBag = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new ns1.BunifuDragControl(this.components);
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel3.Controls.Add(this.lblUser);
            this.panel3.Controls.Add(this.lblUserFullName);
            this.panel3.Controls.Add(this.lblConnection);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.bunifuCustomLabel4);
            this.panel3.Controls.Add(this.bunifuCustomLabel2);
            this.transitionTechBag.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 655);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 73);
            this.panel3.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.transitionTechBag.SetDecoration(this.lblUser, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.lblUser, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.lblUser, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.lblUser, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.lblUser, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this.lblUser, BunifuAnimatorNS.DecorationType.None);
            this.lblUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblUser.Location = new System.Drawing.Point(234, 15);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(39, 16);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "User:";
            // 
            // lblUserFullName
            // 
            this.transitionTechBag.SetDecoration(this.lblUserFullName, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.lblUserFullName, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.lblUserFullName, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.lblUserFullName, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.lblUserFullName, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this.lblUserFullName, BunifuAnimatorNS.DecorationType.None);
            this.lblUserFullName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFullName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblUserFullName.Location = new System.Drawing.Point(279, 6);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.Size = new System.Drawing.Size(232, 32);
            this.lblUserFullName.TabIndex = 8;
            this.lblUserFullName.Text = "Ranario, Ivan Arnie";
            this.lblUserFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConnection
            // 
            this.transitionTechBag.SetDecoration(this.lblConnection, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.lblConnection, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.lblConnection, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.lblConnection, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.lblConnection, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this.lblConnection, BunifuAnimatorNS.DecorationType.None);
            this.lblConnection.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblConnection.Location = new System.Drawing.Point(503, 16);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(391, 48);
            this.lblConnection.TabIndex = 7;
            this.lblConnection.Text = "Connection failed.";
            this.lblConnection.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.linkAbout);
            this.panel9.Controls.Add(this.bunifuCustomLabel3);
            this.transitionTechBag.SetDecoration(this.panel9, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.panel9, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.panel9, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.panel9, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this.panel9, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.panel9, BunifuAnimatorNS.DecorationType.None);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(932, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(92, 73);
            this.panel9.TabIndex = 5;
            // 
            // linkAbout
            // 
            this.linkAbout.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.transitionReturn.SetDecoration(this.linkAbout, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.linkAbout, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.linkAbout, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.linkAbout, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.linkAbout, BunifuAnimatorNS.DecorationType.None);
            this.transitionTechBag.SetDecoration(this.linkAbout, BunifuAnimatorNS.DecorationType.None);
            this.linkAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkAbout.Font = new System.Drawing.Font("Microsoft MHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAbout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.linkAbout.Location = new System.Drawing.Point(0, 0);
            this.linkAbout.Name = "linkAbout";
            this.linkAbout.Size = new System.Drawing.Size(92, 44);
            this.linkAbout.TabIndex = 1;
            this.linkAbout.TabStop = true;
            this.linkAbout.Text = "About";
            this.linkAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAbout_LinkClicked);
            // 
            // bunifuCustomLabel3
            // 
            this.transitionTechBag.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Gray;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(0, 39);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(92, 34);
            this.bunifuCustomLabel3.TabIndex = 3;
            this.bunifuCustomLabel3.Text = "Version 1.4";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.transitionTechBag.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(16, 39);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(59, 16);
            this.bunifuCustomLabel4.TabIndex = 4;
            this.bunifuCustomLabel4.Text = "Inventory";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.transitionTechBag.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(15, 20);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(170, 20);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Wireless Access for Health";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel5.Controls.Add(this.lblLimitRecords);
            this.panel5.Controls.Add(this.cbLimiteRecords);
            this.panel5.Controls.Add(this.btnSwitchAccount);
            this.panel5.Controls.Add(this.btnSettings);
            this.panel5.Controls.Add(this.btnTechBag);
            this.panel5.Controls.Add(this.btnDisposeItem);
            this.panel5.Controls.Add(this.btnReturn);
            this.panel5.Controls.Add(this.btnInventory);
            this.panel5.Controls.Add(this.btnReports);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.flowLayoutPanel1);
            this.transitionTechBag.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(206, 655);
            this.panel5.TabIndex = 2;
            // 
            // lblLimitRecords
            // 
            this.lblLimitRecords.AutoSize = true;
            this.transitionTechBag.SetDecoration(this.lblLimitRecords, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.lblLimitRecords, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.lblLimitRecords, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.lblLimitRecords, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.lblLimitRecords, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this.lblLimitRecords, BunifuAnimatorNS.DecorationType.None);
            this.lblLimitRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimitRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblLimitRecords.Location = new System.Drawing.Point(12, 558);
            this.lblLimitRecords.Name = "lblLimitRecords";
            this.lblLimitRecords.Size = new System.Drawing.Size(105, 21);
            this.lblLimitRecords.TabIndex = 227;
            this.lblLimitRecords.Text = "Limit Records";
            this.lblLimitRecords.Visible = false;
            // 
            // cbLimiteRecords
            // 
            this.cbLimiteRecords.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLimiteRecords.BackColor = System.Drawing.SystemColors.Window;
            this.cbLimiteRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionReturn.SetDecoration(this.cbLimiteRecords, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.cbLimiteRecords, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.cbLimiteRecords, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.cbLimiteRecords, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.cbLimiteRecords, BunifuAnimatorNS.DecorationType.None);
            this.transitionTechBag.SetDecoration(this.cbLimiteRecords, BunifuAnimatorNS.DecorationType.None);
            this.cbLimiteRecords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLimiteRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLimiteRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLimiteRecords.ForeColor = System.Drawing.Color.Black;
            this.cbLimiteRecords.FormattingEnabled = true;
            this.cbLimiteRecords.Items.AddRange(new object[] {
            "All",
            "5",
            "10",
            "15",
            "20",
            "30",
            "50",
            "70",
            "100"});
            this.cbLimiteRecords.Location = new System.Drawing.Point(123, 550);
            this.cbLimiteRecords.Name = "cbLimiteRecords";
            this.cbLimiteRecords.Size = new System.Drawing.Size(73, 29);
            this.cbLimiteRecords.TabIndex = 226;
            this.cbLimiteRecords.Visible = false;
            this.cbLimiteRecords.SelectedIndexChanged += new System.EventHandler(this.cbLimiteRecords_SelectedIndexChanged);
            // 
            // btnSwitchAccount
            // 
            this.btnSwitchAccount.Activecolor = System.Drawing.Color.Transparent;
            this.btnSwitchAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnSwitchAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSwitchAccount.BorderRadius = 0;
            this.btnSwitchAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSwitchAccount.ButtonText = "LOGOUT";
            this.btnSwitchAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionReturn.SetDecoration(this.btnSwitchAccount, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.btnSwitchAccount, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.btnSwitchAccount, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.btnSwitchAccount, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.btnSwitchAccount, BunifuAnimatorNS.DecorationType.None);
            this.transitionTechBag.SetDecoration(this.btnSwitchAccount, BunifuAnimatorNS.DecorationType.None);
            this.btnSwitchAccount.DisabledColor = System.Drawing.Color.Gray;
            this.btnSwitchAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSwitchAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchAccount.ForeColor = System.Drawing.Color.Teal;
            this.btnSwitchAccount.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSwitchAccount.Iconimage = null;
            this.btnSwitchAccount.Iconimage_right = null;
            this.btnSwitchAccount.Iconimage_right_Selected = null;
            this.btnSwitchAccount.Iconimage_Selected = null;
            this.btnSwitchAccount.IconMarginLeft = 0;
            this.btnSwitchAccount.IconMarginRight = 0;
            this.btnSwitchAccount.IconRightVisible = true;
            this.btnSwitchAccount.IconRightZoom = 0D;
            this.btnSwitchAccount.IconVisible = true;
            this.btnSwitchAccount.IconZoom = 90D;
            this.btnSwitchAccount.IsTab = true;
            this.btnSwitchAccount.Location = new System.Drawing.Point(0, 591);
            this.btnSwitchAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSwitchAccount.Name = "btnSwitchAccount";
            this.btnSwitchAccount.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSwitchAccount.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnSwitchAccount.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSwitchAccount.selected = false;
            this.btnSwitchAccount.Size = new System.Drawing.Size(206, 64);
            this.btnSwitchAccount.TabIndex = 29;
            this.btnSwitchAccount.Text = "LOGOUT";
            this.btnSwitchAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSwitchAccount.Textcolor = System.Drawing.Color.Turquoise;
            this.btnSwitchAccount.TextFont = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchAccount.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.BorderRadius = 0;
            this.btnSettings.ButtonText = "        SETTINGS";
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionReturn.SetDecoration(this.btnSettings, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.btnSettings, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.btnSettings, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.btnSettings, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.btnSettings, BunifuAnimatorNS.DecorationType.None);
            this.transitionTechBag.SetDecoration(this.btnSettings, BunifuAnimatorNS.DecorationType.None);
            this.btnSettings.DisabledColor = System.Drawing.Color.Gray;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSettings.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSettings.Iconimage = null;
            this.btnSettings.Iconimage_right = null;
            this.btnSettings.Iconimage_right_Selected = null;
            this.btnSettings.Iconimage_Selected = null;
            this.btnSettings.IconMarginLeft = 0;
            this.btnSettings.IconMarginRight = 0;
            this.btnSettings.IconRightVisible = true;
            this.btnSettings.IconRightZoom = 0D;
            this.btnSettings.IconVisible = true;
            this.btnSettings.IconZoom = 90D;
            this.btnSettings.IsTab = true;
            this.btnSettings.Location = new System.Drawing.Point(0, 467);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnSettings.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSettings.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSettings.selected = false;
            this.btnSettings.Size = new System.Drawing.Size(206, 64);
            this.btnSettings.TabIndex = 28;
            this.btnSettings.Text = "        SETTINGS";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Textcolor = System.Drawing.Color.White;
            this.btnSettings.TextFont = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnTechBag
            // 
            this.btnTechBag.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTechBag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnTechBag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTechBag.BorderRadius = 0;
            this.btnTechBag.ButtonText = "        TECH BAG";
            this.btnTechBag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionReturn.SetDecoration(this.btnTechBag, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.btnTechBag, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.btnTechBag, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.btnTechBag, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.btnTechBag, BunifuAnimatorNS.DecorationType.None);
            this.transitionTechBag.SetDecoration(this.btnTechBag, BunifuAnimatorNS.DecorationType.None);
            this.btnTechBag.DisabledColor = System.Drawing.Color.Gray;
            this.btnTechBag.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTechBag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechBag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTechBag.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTechBag.Iconimage = null;
            this.btnTechBag.Iconimage_right = null;
            this.btnTechBag.Iconimage_right_Selected = null;
            this.btnTechBag.Iconimage_Selected = null;
            this.btnTechBag.IconMarginLeft = 0;
            this.btnTechBag.IconMarginRight = 0;
            this.btnTechBag.IconRightVisible = true;
            this.btnTechBag.IconRightZoom = 0D;
            this.btnTechBag.IconVisible = true;
            this.btnTechBag.IconZoom = 90D;
            this.btnTechBag.IsTab = true;
            this.btnTechBag.Location = new System.Drawing.Point(0, 403);
            this.btnTechBag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTechBag.Name = "btnTechBag";
            this.btnTechBag.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnTechBag.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnTechBag.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTechBag.selected = false;
            this.btnTechBag.Size = new System.Drawing.Size(206, 64);
            this.btnTechBag.TabIndex = 27;
            this.btnTechBag.Text = "        TECH BAG";
            this.btnTechBag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTechBag.Textcolor = System.Drawing.Color.White;
            this.btnTechBag.TextFont = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechBag.Click += new System.EventHandler(this.btnTechBag_Click);
            // 
            // btnDisposeItem
            // 
            this.btnDisposeItem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDisposeItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnDisposeItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDisposeItem.BorderRadius = 0;
            this.btnDisposeItem.ButtonText = "        LOST && DISPOSE ITEM";
            this.btnDisposeItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionReturn.SetDecoration(this.btnDisposeItem, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.btnDisposeItem, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.btnDisposeItem, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.btnDisposeItem, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.btnDisposeItem, BunifuAnimatorNS.DecorationType.None);
            this.transitionTechBag.SetDecoration(this.btnDisposeItem, BunifuAnimatorNS.DecorationType.None);
            this.btnDisposeItem.DisabledColor = System.Drawing.Color.Gray;
            this.btnDisposeItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDisposeItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisposeItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDisposeItem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDisposeItem.Iconimage = null;
            this.btnDisposeItem.Iconimage_right = null;
            this.btnDisposeItem.Iconimage_right_Selected = null;
            this.btnDisposeItem.Iconimage_Selected = null;
            this.btnDisposeItem.IconMarginLeft = 0;
            this.btnDisposeItem.IconMarginRight = 0;
            this.btnDisposeItem.IconRightVisible = true;
            this.btnDisposeItem.IconRightZoom = 0D;
            this.btnDisposeItem.IconVisible = true;
            this.btnDisposeItem.IconZoom = 90D;
            this.btnDisposeItem.IsTab = true;
            this.btnDisposeItem.Location = new System.Drawing.Point(0, 339);
            this.btnDisposeItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisposeItem.Name = "btnDisposeItem";
            this.btnDisposeItem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnDisposeItem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnDisposeItem.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDisposeItem.selected = false;
            this.btnDisposeItem.Size = new System.Drawing.Size(206, 64);
            this.btnDisposeItem.TabIndex = 23;
            this.btnDisposeItem.Text = "        LOST && DISPOSE ITEM";
            this.btnDisposeItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDisposeItem.Textcolor = System.Drawing.Color.White;
            this.btnDisposeItem.TextFont = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisposeItem.Click += new System.EventHandler(this.btnDisposeItem_Click_1);
            // 
            // btnReturn
            // 
            this.btnReturn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.BorderRadius = 0;
            this.btnReturn.ButtonText = "        RETURN ITEM";
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionReturn.SetDecoration(this.btnReturn, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.btnReturn, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.btnReturn, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.btnReturn, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.btnReturn, BunifuAnimatorNS.DecorationType.None);
            this.transitionTechBag.SetDecoration(this.btnReturn, BunifuAnimatorNS.DecorationType.None);
            this.btnReturn.DisabledColor = System.Drawing.Color.Gray;
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReturn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReturn.Iconimage = null;
            this.btnReturn.Iconimage_right = null;
            this.btnReturn.Iconimage_right_Selected = null;
            this.btnReturn.Iconimage_Selected = null;
            this.btnReturn.IconMarginLeft = 0;
            this.btnReturn.IconMarginRight = 0;
            this.btnReturn.IconRightVisible = true;
            this.btnReturn.IconRightZoom = 0D;
            this.btnReturn.IconVisible = true;
            this.btnReturn.IconZoom = 90D;
            this.btnReturn.IsTab = true;
            this.btnReturn.Location = new System.Drawing.Point(0, 275);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnReturn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnReturn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReturn.selected = false;
            this.btnReturn.Size = new System.Drawing.Size(206, 64);
            this.btnReturn.TabIndex = 21;
            this.btnReturn.Text = "        RETURN ITEM";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Textcolor = System.Drawing.Color.White;
            this.btnReturn.TextFont = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventory.BorderRadius = 0;
            this.btnInventory.ButtonText = "        INVENTORY";
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionReturn.SetDecoration(this.btnInventory, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.btnInventory, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.btnInventory, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.btnInventory, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.btnInventory, BunifuAnimatorNS.DecorationType.None);
            this.transitionTechBag.SetDecoration(this.btnInventory, BunifuAnimatorNS.DecorationType.None);
            this.btnInventory.DisabledColor = System.Drawing.Color.Gray;
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInventory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInventory.Iconimage = null;
            this.btnInventory.Iconimage_right = null;
            this.btnInventory.Iconimage_right_Selected = null;
            this.btnInventory.Iconimage_Selected = null;
            this.btnInventory.IconMarginLeft = 0;
            this.btnInventory.IconMarginRight = 0;
            this.btnInventory.IconRightVisible = true;
            this.btnInventory.IconRightZoom = 0D;
            this.btnInventory.IconVisible = true;
            this.btnInventory.IconZoom = 90D;
            this.btnInventory.IsTab = true;
            this.btnInventory.Location = new System.Drawing.Point(0, 211);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnInventory.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnInventory.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInventory.selected = false;
            this.btnInventory.Size = new System.Drawing.Size(206, 64);
            this.btnInventory.TabIndex = 13;
            this.btnInventory.Text = "        INVENTORY";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Textcolor = System.Drawing.Color.White;
            this.btnInventory.TextFont = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnReports
            // 
            this.btnReports.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReports.BorderRadius = 0;
            this.btnReports.ButtonText = "        REPORTS";
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionReturn.SetDecoration(this.btnReports, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.btnReports, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.btnReports, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.btnReports, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.btnReports, BunifuAnimatorNS.DecorationType.None);
            this.transitionTechBag.SetDecoration(this.btnReports, BunifuAnimatorNS.DecorationType.None);
            this.btnReports.DisabledColor = System.Drawing.Color.Gray;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReports.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReports.Iconimage = null;
            this.btnReports.Iconimage_right = null;
            this.btnReports.Iconimage_right_Selected = null;
            this.btnReports.Iconimage_Selected = null;
            this.btnReports.IconMarginLeft = 0;
            this.btnReports.IconMarginRight = 0;
            this.btnReports.IconRightVisible = true;
            this.btnReports.IconRightZoom = 0D;
            this.btnReports.IconVisible = true;
            this.btnReports.IconZoom = 90D;
            this.btnReports.IsTab = true;
            this.btnReports.Location = new System.Drawing.Point(0, 147);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnReports.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnReports.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReports.selected = true;
            this.btnReports.Size = new System.Drawing.Size(206, 64);
            this.btnReports.TabIndex = 12;
            this.btnReports.Text = "        REPORTS";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Textcolor = System.Drawing.Color.White;
            this.btnReports.TextFont = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblTime);
            this.panel7.Controls.Add(this.bunifuSeparator1);
            this.panel7.Controls.Add(this.lblDate);
            this.transitionTechBag.SetDecoration(this.panel7, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.panel7, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.panel7, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.panel7, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this.panel7, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.panel7, BunifuAnimatorNS.DecorationType.None);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 104);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(206, 43);
            this.panel7.TabIndex = 6;
            // 
            // lblTime
            // 
            this.transitionTechBag.SetDecoration(this.lblTime, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.lblTime, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.lblTime, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.lblTime, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.lblTime, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this.lblTime, BunifuAnimatorNS.DecorationType.None);
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Silver;
            this.lblTime.Location = new System.Drawing.Point(0, 19);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(206, 19);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "8:13 AM";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.transitionTechBag.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 38);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(206, 5);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblDate
            // 
            this.transitionTechBag.SetDecoration(this.lblDate, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.lblDate, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.lblDate, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.lblDate, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.lblDate, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this.lblDate, BunifuAnimatorNS.DecorationType.None);
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Silver;
            this.lblDate.Location = new System.Drawing.Point(0, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(206, 19);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "6/15/2017";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.transitionReturn.SetDecoration(this.flowLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.flowLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.flowLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.flowLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.flowLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.transitionTechBag.SetDecoration(this.flowLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(206, 104);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.transitionReturn.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.transitionTechBag.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel6.Controls.Add(this.pnlContainer);
            this.panel6.Controls.Add(this.pnlTop);
            this.transitionTechBag.SetDecoration(this.panel6, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.panel6, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.panel6, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.panel6, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this.panel6, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.panel6, BunifuAnimatorNS.DecorationType.None);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(206, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(818, 655);
            this.panel6.TabIndex = 3;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.ctrl_Reports1);
            this.pnlContainer.Controls.Add(this.ctrl_Settings1);
            this.pnlContainer.Controls.Add(this.ctrl_Inventory1);
            this.pnlContainer.Controls.Add(this.ctrl_Dispose1);
            this.pnlContainer.Controls.Add(this.ctrl_Return1);
            this.pnlContainer.Controls.Add(this.ctrl_Techbag1);
            this.transitionTechBag.SetDecoration(this.pnlContainer, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.pnlContainer, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.pnlContainer, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.pnlContainer, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this.pnlContainer, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.pnlContainer, BunifuAnimatorNS.DecorationType.None);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 44);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(818, 611);
            this.pnlContainer.TabIndex = 1;
            // 
            // ctrl_Reports1
            // 
            this.ctrl_Reports1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.transitionSettings.SetDecoration(this.ctrl_Reports1, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.ctrl_Reports1, BunifuAnimatorNS.DecorationType.None);
            this.transitionTechBag.SetDecoration(this.ctrl_Reports1, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.ctrl_Reports1, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.ctrl_Reports1, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this.ctrl_Reports1, BunifuAnimatorNS.DecorationType.None);
            this.ctrl_Reports1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl_Reports1.Location = new System.Drawing.Point(0, 0);
            this.ctrl_Reports1.Name = "ctrl_Reports1";
            this.ctrl_Reports1.Size = new System.Drawing.Size(818, 611);
            this.ctrl_Reports1.TabIndex = 2;
            this.ctrl_Reports1.Load += new System.EventHandler(this.ctrl_Reports1_Load);
            // 
            // ctrl_Settings1
            // 
            this.ctrl_Settings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.transitionSettings.SetDecoration(this.ctrl_Settings1, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.ctrl_Settings1, BunifuAnimatorNS.DecorationType.None);
            this.transitionTechBag.SetDecoration(this.ctrl_Settings1, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.ctrl_Settings1, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.ctrl_Settings1, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this.ctrl_Settings1, BunifuAnimatorNS.DecorationType.None);
            this.ctrl_Settings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl_Settings1.Location = new System.Drawing.Point(0, 0);
            this.ctrl_Settings1.Name = "ctrl_Settings1";
            this.ctrl_Settings1.Size = new System.Drawing.Size(818, 611);
            this.ctrl_Settings1.TabIndex = 1;
            this.ctrl_Settings1.Visible = false;
            // 
            // ctrl_Inventory1
            // 
            this.ctrl_Inventory1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.transitionSettings.SetDecoration(this.ctrl_Inventory1, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.ctrl_Inventory1, BunifuAnimatorNS.DecorationType.None);
            this.transitionTechBag.SetDecoration(this.ctrl_Inventory1, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.ctrl_Inventory1, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.ctrl_Inventory1, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this.ctrl_Inventory1, BunifuAnimatorNS.DecorationType.None);
            this.ctrl_Inventory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl_Inventory1.Location = new System.Drawing.Point(0, 0);
            this.ctrl_Inventory1.Name = "ctrl_Inventory1";
            this.ctrl_Inventory1.Size = new System.Drawing.Size(818, 611);
            this.ctrl_Inventory1.TabIndex = 0;
            this.ctrl_Inventory1.Visible = false;
            // 
            // ctrl_Dispose1
            // 
            this.ctrl_Dispose1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.transitionSettings.SetDecoration(this.ctrl_Dispose1, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.ctrl_Dispose1, BunifuAnimatorNS.DecorationType.None);
            this.transitionTechBag.SetDecoration(this.ctrl_Dispose1, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.ctrl_Dispose1, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.ctrl_Dispose1, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this.ctrl_Dispose1, BunifuAnimatorNS.DecorationType.None);
            this.ctrl_Dispose1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl_Dispose1.Location = new System.Drawing.Point(0, 0);
            this.ctrl_Dispose1.Name = "ctrl_Dispose1";
            this.ctrl_Dispose1.Size = new System.Drawing.Size(818, 611);
            this.ctrl_Dispose1.TabIndex = 3;
            // 
            // ctrl_Return1
            // 
            this.ctrl_Return1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.transitionSettings.SetDecoration(this.ctrl_Return1, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.ctrl_Return1, BunifuAnimatorNS.DecorationType.None);
            this.transitionTechBag.SetDecoration(this.ctrl_Return1, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.ctrl_Return1, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.ctrl_Return1, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this.ctrl_Return1, BunifuAnimatorNS.DecorationType.None);
            this.ctrl_Return1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl_Return1.Location = new System.Drawing.Point(0, 0);
            this.ctrl_Return1.Name = "ctrl_Return1";
            this.ctrl_Return1.Size = new System.Drawing.Size(818, 611);
            this.ctrl_Return1.TabIndex = 4;
            // 
            // ctrl_Techbag1
            // 
            this.ctrl_Techbag1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.transitionSettings.SetDecoration(this.ctrl_Techbag1, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.ctrl_Techbag1, BunifuAnimatorNS.DecorationType.None);
            this.transitionTechBag.SetDecoration(this.ctrl_Techbag1, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.ctrl_Techbag1, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.ctrl_Techbag1, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this.ctrl_Techbag1, BunifuAnimatorNS.DecorationType.None);
            this.ctrl_Techbag1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl_Techbag1.Location = new System.Drawing.Point(0, 0);
            this.ctrl_Techbag1.Name = "ctrl_Techbag1";
            this.ctrl_Techbag1.Size = new System.Drawing.Size(818, 611);
            this.ctrl_Techbag1.TabIndex = 5;
            this.ctrl_Techbag1.Visible = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.bunifuFlatButton1);
            this.pnlTop.Controls.Add(this.btnMaximize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.transitionTechBag.SetDecoration(this.pnlTop, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.pnlTop, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.pnlTop, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.pnlTop, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this.pnlTop, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.pnlTop, BunifuAnimatorNS.DecorationType.None);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(818, 44);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDoubleClick);
            // 
            // lblTitle
            // 
            this.transitionTechBag.SetDecoration(this.lblTitle, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.lblTitle, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.lblTitle, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.lblTitle, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.lblTitle, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this.lblTitle, BunifuAnimatorNS.DecorationType.None);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Cyan;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(352, 44);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "     REPORTS";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionReturn.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.transitionTechBag.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(686, 0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(44, 44);
            this.bunifuFlatButton1.TabIndex = 3;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Activecolor = System.Drawing.Color.Transparent;
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximize.BorderRadius = 0;
            this.btnMaximize.ButtonText = "";
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionReturn.SetDecoration(this.btnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.btnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.btnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.btnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.btnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.transitionTechBag.SetDecoration(this.btnMaximize, BunifuAnimatorNS.DecorationType.None);
            this.btnMaximize.DisabledColor = System.Drawing.Color.Gray;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMaximize.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Iconimage")));
            this.btnMaximize.Iconimage_right = null;
            this.btnMaximize.Iconimage_right_Selected = null;
            this.btnMaximize.Iconimage_Selected = null;
            this.btnMaximize.IconMarginLeft = 0;
            this.btnMaximize.IconMarginRight = 0;
            this.btnMaximize.IconRightVisible = true;
            this.btnMaximize.IconRightZoom = 0D;
            this.btnMaximize.IconVisible = true;
            this.btnMaximize.IconZoom = 90D;
            this.btnMaximize.IsTab = false;
            this.btnMaximize.Location = new System.Drawing.Point(730, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMaximize.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnMaximize.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMaximize.selected = false;
            this.btnMaximize.Size = new System.Drawing.Size(44, 44);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaximize.Textcolor = System.Drawing.Color.White;
            this.btnMaximize.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Activecolor = System.Drawing.Color.Transparent;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.BorderRadius = 0;
            this.btnClose.ButtonText = "";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionReturn.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.transitionTechBag.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.DisabledColor = System.Drawing.Color.Gray;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClose.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClose.Iconimage")));
            this.btnClose.Iconimage_right = null;
            this.btnClose.Iconimage_right_Selected = null;
            this.btnClose.Iconimage_Selected = null;
            this.btnClose.IconMarginLeft = 0;
            this.btnClose.IconMarginRight = 0;
            this.btnClose.IconRightVisible = true;
            this.btnClose.IconRightZoom = 0D;
            this.btnClose.IconVisible = true;
            this.btnClose.IconZoom = 90D;
            this.btnClose.IsTab = false;
            this.btnClose.Location = new System.Drawing.Point(774, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Normalcolor = System.Drawing.Color.Transparent;
            this.btnClose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnClose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClose.selected = false;
            this.btnClose.Size = new System.Drawing.Size(44, 44);
            this.btnClose.TabIndex = 1;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Textcolor = System.Drawing.Color.White;
            this.btnClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Tick += new System.EventHandler(this.tmrDateTime_Tick);
            // 
            // transitionReports
            // 
            this.transitionReports.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.transitionReports.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 1F;
            this.transitionReports.DefaultAnimation = animation4;
            this.transitionReports.Interval = 5;
            this.transitionReports.MaxAnimationTime = 1000;
            // 
            // transitionInventory
            // 
            this.transitionInventory.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.transitionInventory.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 1F;
            this.transitionInventory.DefaultAnimation = animation5;
            // 
            // transitionSettings
            // 
            this.transitionSettings.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.transitionSettings.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.transitionSettings.DefaultAnimation = animation1;
            // 
            // transitionDispose
            // 
            this.transitionDispose.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.transitionDispose.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.transitionDispose.DefaultAnimation = animation2;
            // 
            // transitionReturn
            // 
            this.transitionReturn.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.transitionReturn.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 1F;
            this.transitionReturn.DefaultAnimation = animation6;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.lblTitle;
            this.bunifuDragControl3.Vertical = true;
            // 
            // transitionTechBag
            // 
            this.transitionTechBag.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.transitionTechBag.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 1F;
            this.transitionTechBag.DefaultAnimation = animation3;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pictureBox1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.pnlTop;
            this.bunifuDragControl2.Vertical = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1024, 728);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.transitionTechBag.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.transitionReports.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.transitionDispose.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.transitionSettings.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.transitionInventory.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.transitionReturn.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WAH - Inventory System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkAbout;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.Timer tmrDateTime;
        private ns1.BunifuFlatButton btnInventory;
        private ns1.BunifuFlatButton btnReports;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlContainer;
        private ctrl_Inventory ctrl_Inventory1;
        private System.Windows.Forms.Panel panel9;
        private ns1.BunifuFlatButton btnClose;
        private ns1.BunifuFlatButton bunifuFlatButton1;
        private ns1.BunifuFlatButton btnMaximize;
        private System.Windows.Forms.Panel panel7;
        private ns1.BunifuCustomLabel lblTime;
        private ns1.BunifuSeparator bunifuSeparator1;
        private ns1.BunifuCustomLabel lblDate;
        private controls.ctrl_Settings ctrl_Settings1;
        private BunifuAnimatorNS.BunifuTransition transitionReports;
        private BunifuAnimatorNS.BunifuTransition transitionSettings;
        private BunifuAnimatorNS.BunifuTransition transitionInventory;
        private controls.ctrl_Reports ctrl_Reports1;
        private ns1.BunifuCustomLabel lblTitle;
        private ns1.BunifuCustomLabel lblConnection;
        private controls.ctrl_Dispose ctrl_Dispose1;
        private BunifuAnimatorNS.BunifuTransition transitionDispose;
        private ns1.BunifuFlatButton btnReturn;
        private ns1.BunifuFlatButton btnDisposeItem;
        private controls.ctrl_Return ctrl_Return1;
        private BunifuAnimatorNS.BunifuTransition transitionReturn;
        private ns1.BunifuDragControl bunifuDragControl3;
        private controls.ctrl_Techbag ctrl_Techbag1;
        private ns1.BunifuFlatButton btnTechBag;
        private ns1.BunifuFlatButton btnSettings;
        private BunifuAnimatorNS.BunifuTransition transitionTechBag;
        private ns1.BunifuCustomLabel lblUserFullName;
        private ns1.BunifuCustomLabel lblUser;
        private ns1.BunifuFlatButton btnSwitchAccount;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuDragControl bunifuDragControl2;
        private ns1.BunifuCustomLabel lblLimitRecords;
        private System.Windows.Forms.ComboBox cbLimiteRecords;

    }
}

