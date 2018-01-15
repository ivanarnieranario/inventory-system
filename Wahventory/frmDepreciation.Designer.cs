namespace Wahventory
{
    partial class frmDepreciation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepreciation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuCustomLabel7 = new ns1.BunifuCustomLabel();
            this.txtSalvageValue = new ns1.BunifuMaterialTextbox();
            this.lblCost = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.txtLifespan = new ns1.BunifuMaterialTextbox();
            this.bunifuCustomLabel10 = new ns1.BunifuCustomLabel();
            this.lblDepreciation = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new ns1.BunifuCustomLabel();
            this.lblTotal = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGenerate = new ns1.BunifuFlatButton();
            this.lblDateProcured = new ns1.BunifuCustomLabel();
            this.btnAddDepreciation = new ns1.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSave = new ns1.BunifuFlatButton();
            this.btnLost = new ns1.BunifuThinButton2();
            this.lblPercentage = new ns1.BunifuCustomLabel();
            this.gPercentage = new ns1.BunifuGauge();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pnlLost = new System.Windows.Forms.Panel();
            this.lblPlusten = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.lblYear = new ns1.BunifuCustomLabel();
            this.lblBookValue = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new ns1.BunifuCustomLabel();
            this.dgvBookValues = new ns1.BunifuCustomDataGrid();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.pnlDrag = new System.Windows.Forms.Panel();
            this.pnlDragControl = new System.Windows.Forms.Panel();
            this.lblTitle = new ns1.BunifuCustomLabel();
            this.btnClose = new ns1.BunifuFlatButton();
            this.bunifuDragControl2 = new ns1.BunifuDragControl(this.components);
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnlLost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookValues)).BeginInit();
            this.pnlDrag.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(604, 13);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(109, 21);
            this.bunifuCustomLabel7.TabIndex = 145;
            this.bunifuCustomLabel7.Text = "Date Procured";
            // 
            // txtSalvageValue
            // 
            this.txtSalvageValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalvageValue.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalvageValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSalvageValue.HintForeColor = System.Drawing.Color.Empty;
            this.txtSalvageValue.HintText = "";
            this.txtSalvageValue.isPassword = false;
            this.txtSalvageValue.LineFocusedColor = System.Drawing.Color.White;
            this.txtSalvageValue.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSalvageValue.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtSalvageValue.LineThickness = 2;
            this.txtSalvageValue.Location = new System.Drawing.Point(138, 66);
            this.txtSalvageValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalvageValue.Name = "txtSalvageValue";
            this.txtSalvageValue.Size = new System.Drawing.Size(137, 32);
            this.txtSalvageValue.TabIndex = 144;
            this.txtSalvageValue.Text = "0.00";
            this.txtSalvageValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSalvageValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSalvageValue_KeyUp);
            this.txtSalvageValue.Leave += new System.EventHandler(this.txtSalvageValue_Leave);
            // 
            // lblCost
            // 
            this.lblCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCost.Location = new System.Drawing.Point(399, 34);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(157, 36);
            this.lblCost.TabIndex = 148;
            this.lblCost.Text = "0.00";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(395, 13);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(44, 21);
            this.bunifuCustomLabel2.TabIndex = 147;
            this.bunifuCustomLabel2.Text = "Cost:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 77);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(119, 21);
            this.bunifuCustomLabel1.TabIndex = 149;
            this.bunifuCustomLabel1.Text = "Salvage value: *";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(12, 117);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(82, 21);
            this.bunifuCustomLabel3.TabIndex = 151;
            this.bunifuCustomLabel3.Text = "Lifespan: *";
            // 
            // txtLifespan
            // 
            this.txtLifespan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLifespan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLifespan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLifespan.HintForeColor = System.Drawing.Color.Empty;
            this.txtLifespan.HintText = "";
            this.txtLifespan.isPassword = false;
            this.txtLifespan.LineFocusedColor = System.Drawing.Color.White;
            this.txtLifespan.LineIdleColor = System.Drawing.Color.Gray;
            this.txtLifespan.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtLifespan.LineThickness = 2;
            this.txtLifespan.Location = new System.Drawing.Point(138, 106);
            this.txtLifespan.Margin = new System.Windows.Forms.Padding(4);
            this.txtLifespan.Name = "txtLifespan";
            this.txtLifespan.Size = new System.Drawing.Size(80, 32);
            this.txtLifespan.TabIndex = 150;
            this.txtLifespan.Text = "0";
            this.txtLifespan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLifespan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLifespan_KeyUp);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(593, 22);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(89, 21);
            this.bunifuCustomLabel10.TabIndex = 154;
            this.bunifuCustomLabel10.Text = "Percentage:";
            // 
            // lblDepreciation
            // 
            this.lblDepreciation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDepreciation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepreciation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblDepreciation.Location = new System.Drawing.Point(399, 139);
            this.lblDepreciation.Name = "lblDepreciation";
            this.lblDepreciation.Size = new System.Drawing.Size(179, 33);
            this.lblDepreciation.TabIndex = 153;
            this.lblDepreciation.Text = "0.00";
            this.lblDepreciation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(395, 112);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(161, 21);
            this.bunifuCustomLabel8.TabIndex = 152;
            this.bunifuCustomLabel8.Text = "Depreciation expense:";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTotal.Location = new System.Drawing.Point(399, 49);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(179, 33);
            this.lblTotal.TabIndex = 151;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(395, 22);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(45, 21);
            this.bunifuCustomLabel4.TabIndex = 150;
            this.bunifuCustomLabel4.Text = "Total:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGenerate);
            this.panel3.Controls.Add(this.lblDateProcured);
            this.panel3.Controls.Add(this.bunifuCustomLabel7);
            this.panel3.Controls.Add(this.lblCost);
            this.panel3.Controls.Add(this.bunifuCustomLabel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(763, 114);
            this.panel3.TabIndex = 155;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Activecolor = System.Drawing.Color.Transparent;
            this.btnGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerate.BackgroundImage")));
            this.btnGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerate.BorderRadius = 0;
            this.btnGenerate.ButtonText = "";
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.DisabledColor = System.Drawing.Color.Gray;
            this.btnGenerate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGenerate.Iconimage = null;
            this.btnGenerate.Iconimage_right = null;
            this.btnGenerate.Iconimage_right_Selected = null;
            this.btnGenerate.Iconimage_Selected = null;
            this.btnGenerate.IconMarginLeft = 0;
            this.btnGenerate.IconMarginRight = 0;
            this.btnGenerate.IconRightVisible = true;
            this.btnGenerate.IconRightZoom = 0D;
            this.btnGenerate.IconVisible = true;
            this.btnGenerate.IconZoom = 90D;
            this.btnGenerate.IsTab = false;
            this.btnGenerate.Location = new System.Drawing.Point(237, 62);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Normalcolor = System.Drawing.Color.Transparent;
            this.btnGenerate.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnGenerate.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnGenerate.selected = false;
            this.btnGenerate.Size = new System.Drawing.Size(37, 35);
            this.btnGenerate.TabIndex = 150;
            this.btnGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerate.Textcolor = System.Drawing.Color.White;
            this.btnGenerate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblDateProcured
            // 
            this.lblDateProcured.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateProcured.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateProcured.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDateProcured.Location = new System.Drawing.Point(608, 34);
            this.lblDateProcured.Name = "lblDateProcured";
            this.lblDateProcured.Size = new System.Drawing.Size(130, 36);
            this.lblDateProcured.TabIndex = 149;
            this.lblDateProcured.Text = "0/0/0000";
            this.lblDateProcured.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddDepreciation
            // 
            this.btnAddDepreciation.Activecolor = System.Drawing.Color.Transparent;
            this.btnAddDepreciation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddDepreciation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddDepreciation.BorderRadius = 0;
            this.btnAddDepreciation.ButtonText = "Add to item";
            this.btnAddDepreciation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDepreciation.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddDepreciation.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddDepreciation.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddDepreciation.Iconimage")));
            this.btnAddDepreciation.Iconimage_right = null;
            this.btnAddDepreciation.Iconimage_right_Selected = null;
            this.btnAddDepreciation.Iconimage_Selected = null;
            this.btnAddDepreciation.IconMarginLeft = 0;
            this.btnAddDepreciation.IconMarginRight = 0;
            this.btnAddDepreciation.IconRightVisible = true;
            this.btnAddDepreciation.IconRightZoom = 0D;
            this.btnAddDepreciation.IconVisible = true;
            this.btnAddDepreciation.IconZoom = 90D;
            this.btnAddDepreciation.IsTab = false;
            this.btnAddDepreciation.Location = new System.Drawing.Point(608, 235);
            this.btnAddDepreciation.Name = "btnAddDepreciation";
            this.btnAddDepreciation.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddDepreciation.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(180)))));
            this.btnAddDepreciation.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddDepreciation.selected = false;
            this.btnAddDepreciation.Size = new System.Drawing.Size(138, 55);
            this.btnAddDepreciation.TabIndex = 88;
            this.btnAddDepreciation.Text = "Add to item";
            this.btnAddDepreciation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDepreciation.Textcolor = System.Drawing.Color.White;
            this.btnAddDepreciation.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDepreciation.Click += new System.EventHandler(this.btnAddDepreciation_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.btnLost);
            this.panel4.Controls.Add(this.lblPercentage);
            this.panel4.Controls.Add(this.gPercentage);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.btnAddDepreciation);
            this.panel4.Controls.Add(this.bunifuCustomLabel10);
            this.panel4.Controls.Add(this.bunifuCustomLabel4);
            this.panel4.Controls.Add(this.lblDepreciation);
            this.panel4.Controls.Add(this.lblTotal);
            this.panel4.Controls.Add(this.bunifuCustomLabel8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 157);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(763, 310);
            this.panel4.TabIndex = 156;
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.Transparent;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "SAVE";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 90D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(608, 235);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(180)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(138, 55);
            this.btnSave.TabIndex = 213;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLost
            // 
            this.btnLost.ActiveBorderThickness = 1;
            this.btnLost.ActiveCornerRadius = 20;
            this.btnLost.ActiveFillColor = System.Drawing.Color.Honeydew;
            this.btnLost.ActiveForecolor = System.Drawing.Color.Black;
            this.btnLost.ActiveLineColor = System.Drawing.Color.Red;
            this.btnLost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnLost.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLost.BackgroundImage")));
            this.btnLost.ButtonText = "OK";
            this.btnLost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLost.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLost.ForeColor = System.Drawing.Color.Black;
            this.btnLost.IdleBorderThickness = 1;
            this.btnLost.IdleCornerRadius = 20;
            this.btnLost.IdleFillColor = System.Drawing.Color.Red;
            this.btnLost.IdleForecolor = System.Drawing.Color.White;
            this.btnLost.IdleLineColor = System.Drawing.Color.Honeydew;
            this.btnLost.Location = new System.Drawing.Point(399, 226);
            this.btnLost.Margin = new System.Windows.Forms.Padding(5);
            this.btnLost.Name = "btnLost";
            this.btnLost.Size = new System.Drawing.Size(124, 64);
            this.btnLost.TabIndex = 212;
            this.btnLost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLost.Visible = false;
            this.btnLost.Click += new System.EventHandler(this.btnLost_Click);
            // 
            // lblPercentage
            // 
            this.lblPercentage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblPercentage.Location = new System.Drawing.Point(681, 17);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(76, 30);
            this.lblPercentage.TabIndex = 158;
            this.lblPercentage.Text = "0%";
            this.lblPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gPercentage
            // 
            this.gPercentage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gPercentage.BackgroundImage")));
            this.gPercentage.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.gPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gPercentage.Location = new System.Drawing.Point(608, 47);
            this.gPercentage.Margin = new System.Windows.Forms.Padding(6);
            this.gPercentage.Name = "gPercentage";
            this.gPercentage.ProgressBgColor = System.Drawing.Color.Gray;
            this.gPercentage.ProgressColor1 = System.Drawing.Color.SeaGreen;
            this.gPercentage.ProgressColor2 = System.Drawing.Color.Tomato;
            this.gPercentage.Size = new System.Drawing.Size(147, 126);
            this.gPercentage.TabIndex = 157;
            this.gPercentage.Thickness = 20;
            this.gPercentage.Value = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 310);
            this.panel1.TabIndex = 156;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pnlLost);
            this.panel8.Controls.Add(this.dgvBookValues);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(21, 22);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(325, 268);
            this.panel8.TabIndex = 133;
            // 
            // pnlLost
            // 
            this.pnlLost.Controls.Add(this.lblPlusten);
            this.pnlLost.Controls.Add(this.bunifuCustomLabel5);
            this.pnlLost.Controls.Add(this.lblYear);
            this.pnlLost.Controls.Add(this.lblBookValue);
            this.pnlLost.Controls.Add(this.bunifuCustomLabel12);
            this.pnlLost.Controls.Add(this.bunifuCustomLabel9);
            this.pnlLost.Location = new System.Drawing.Point(6, 5);
            this.pnlLost.Name = "pnlLost";
            this.pnlLost.Size = new System.Drawing.Size(313, 257);
            this.pnlLost.TabIndex = 165;
            this.pnlLost.Visible = false;
            // 
            // lblPlusten
            // 
            this.lblPlusten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlusten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPlusten.Location = new System.Drawing.Point(3, 193);
            this.lblPlusten.Name = "lblPlusten";
            this.lblPlusten.Size = new System.Drawing.Size(217, 33);
            this.lblPlusten.TabIndex = 164;
            this.lblPlusten.Text = "1200.00";
            this.lblPlusten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(6, 84);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(96, 23);
            this.bunifuCustomLabel5.TabIndex = 159;
            this.bunifuCustomLabel5.Text = "Book Value:";
            // 
            // lblYear
            // 
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblYear.Location = new System.Drawing.Point(6, 32);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(291, 33);
            this.lblYear.TabIndex = 163;
            this.lblYear.Text = "0";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBookValue
            // 
            this.lblBookValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblBookValue.Location = new System.Drawing.Point(6, 107);
            this.lblBookValue.Name = "lblBookValue";
            this.lblBookValue.Size = new System.Drawing.Size(217, 33);
            this.lblBookValue.TabIndex = 160;
            this.lblBookValue.Text = "1200.00";
            this.lblBookValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(6, 9);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(60, 23);
            this.bunifuCustomLabel12.TabIndex = 162;
            this.bunifuCustomLabel12.Text = "Year/s:";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(6, 170);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(59, 23);
            this.bunifuCustomLabel9.TabIndex = 161;
            this.bunifuCustomLabel9.Text = "+ 10%";
            // 
            // dgvBookValues
            // 
            this.dgvBookValues.AllowUserToAddRows = false;
            this.dgvBookValues.AllowUserToDeleteRows = false;
            this.dgvBookValues.AllowUserToResizeColumns = false;
            this.dgvBookValues.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvBookValues.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBookValues.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvBookValues.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvBookValues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBookValues.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookValues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookValues.DoubleBuffered = true;
            this.dgvBookValues.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBookValues.EnableHeadersVisualStyles = false;
            this.dgvBookValues.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dgvBookValues.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvBookValues.Location = new System.Drawing.Point(0, 0);
            this.dgvBookValues.MultiSelect = false;
            this.dgvBookValues.Name = "dgvBookValues";
            this.dgvBookValues.ReadOnly = true;
            this.dgvBookValues.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookValues.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            this.dgvBookValues.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBookValues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookValues.Size = new System.Drawing.Size(325, 268);
            this.dgvBookValues.TabIndex = 128;
            this.dgvBookValues.TabStop = false;
            this.dgvBookValues.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvBookValues_UserDeletingRow);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(21, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(325, 22);
            this.panel7.TabIndex = 132;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(21, 290);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(325, 20);
            this.panel6.TabIndex = 131;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(346, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(21, 310);
            this.panel5.TabIndex = 130;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(21, 310);
            this.panel2.TabIndex = 129;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlDrag;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pnlDrag
            // 
            this.pnlDrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlDrag.Controls.Add(this.pnlDragControl);
            this.pnlDrag.Controls.Add(this.lblTitle);
            this.pnlDrag.Controls.Add(this.btnClose);
            this.pnlDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDrag.Location = new System.Drawing.Point(0, 0);
            this.pnlDrag.Name = "pnlDrag";
            this.pnlDrag.Size = new System.Drawing.Size(763, 43);
            this.pnlDrag.TabIndex = 152;
            // 
            // pnlDragControl
            // 
            this.pnlDragControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDragControl.Location = new System.Drawing.Point(129, 0);
            this.pnlDragControl.Name = "pnlDragControl";
            this.pnlDragControl.Size = new System.Drawing.Size(590, 43);
            this.pnlDragControl.TabIndex = 154;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Cyan;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(129, 43);
            this.lblTitle.TabIndex = 153;
            this.lblTitle.Text = "   Depreciation";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.Activecolor = System.Drawing.Color.Transparent;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.BorderRadius = 0;
            this.btnClose.ButtonText = "";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnClose.Location = new System.Drawing.Point(719, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Normalcolor = System.Drawing.Color.Transparent;
            this.btnClose.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnClose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClose.selected = false;
            this.btnClose.Size = new System.Drawing.Size(44, 43);
            this.btnClose.TabIndex = 3;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Textcolor = System.Drawing.Color.White;
            this.btnClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.pnlDragControl;
            this.bunifuDragControl2.Vertical = true;
            // 
            // frmDepreciation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(763, 467);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtLifespan);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtSalvageValue);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDepreciation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depreciation";
            this.Load += new System.EventHandler(this.frmDepreciation_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.pnlLost.ResumeLayout(false);
            this.pnlLost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookValues)).EndInit();
            this.pnlDrag.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuCustomLabel bunifuCustomLabel7;
        private ns1.BunifuMaterialTextbox txtSalvageValue;
        private ns1.BunifuCustomLabel lblCost;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuMaterialTextbox txtLifespan;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel10;
        private ns1.BunifuCustomLabel lblDepreciation;
        private ns1.BunifuCustomLabel bunifuCustomLabel8;
        private ns1.BunifuCustomLabel lblTotal;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private ns1.BunifuFlatButton btnAddDepreciation;
        private ns1.BunifuCustomLabel lblDateProcured;
        private ns1.BunifuFlatButton btnGenerate;
        private ns1.BunifuCustomDataGrid dgvBookValues;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private ns1.BunifuCustomLabel lblPercentage;
        private ns1.BunifuGauge gPercentage;
        private ns1.BunifuCustomLabel lblBookValue;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuCustomLabel lblPlusten;
        private ns1.BunifuCustomLabel lblYear;
        private ns1.BunifuCustomLabel bunifuCustomLabel12;
        private ns1.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.Panel pnlLost;
        private ns1.BunifuThinButton2 btnLost;
        private ns1.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel pnlDrag;
        private ns1.BunifuCustomLabel lblTitle;
        private ns1.BunifuFlatButton btnClose;
        private System.Windows.Forms.Panel pnlDragControl;
        private ns1.BunifuDragControl bunifuDragControl2;
        private ns1.BunifuFlatButton btnSave;
    }
}