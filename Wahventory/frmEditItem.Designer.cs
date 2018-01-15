namespace Wahventory
{
    partial class frmEditItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditItem));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.pnlDrag = new System.Windows.Forms.Panel();
            this.pnlDragControl = new System.Windows.Forms.Panel();
            this.lblTitle = new ns1.BunifuCustomLabel();
            this.btnClose = new ns1.BunifuFlatButton();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.bunifuCustomLabel16 = new ns1.BunifuCustomLabel();
            this.txtPropertyNo = new ns1.BunifuMaterialTextbox();
            this.rtDetails = new System.Windows.Forms.RichTextBox();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.rbDonated = new System.Windows.Forms.RadioButton();
            this.rbPurchased = new System.Windows.Forms.RadioButton();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.dtpProcured = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel6 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.txtCost = new ns1.BunifuMaterialTextbox();
            this.btnDepreciation = new ns1.BunifuImageButton();
            this.btnSave = new ns1.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblMultipleUpdate = new ns1.BunifuCustomLabel();
            this.pnlDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDepreciation)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            this.pnlDrag.Size = new System.Drawing.Size(615, 43);
            this.pnlDrag.TabIndex = 153;
            // 
            // pnlDragControl
            // 
            this.pnlDragControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDragControl.Location = new System.Drawing.Point(129, 0);
            this.pnlDragControl.Name = "pnlDragControl";
            this.pnlDragControl.Size = new System.Drawing.Size(442, 43);
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
            this.lblTitle.Text = "   Modify Item";
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
            this.btnClose.Location = new System.Drawing.Point(571, 0);
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
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlDragControl;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(19, 89);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(122, 21);
            this.bunifuCustomLabel16.TabIndex = 212;
            this.bunifuCustomLabel16.Text = "WAH Property #";
            // 
            // txtPropertyNo
            // 
            this.txtPropertyNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPropertyNo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertyNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPropertyNo.HintForeColor = System.Drawing.Color.Empty;
            this.txtPropertyNo.HintText = "";
            this.txtPropertyNo.isPassword = false;
            this.txtPropertyNo.LineFocusedColor = System.Drawing.Color.White;
            this.txtPropertyNo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPropertyNo.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtPropertyNo.LineThickness = 2;
            this.txtPropertyNo.Location = new System.Drawing.Point(148, 81);
            this.txtPropertyNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPropertyNo.Name = "txtPropertyNo";
            this.txtPropertyNo.Size = new System.Drawing.Size(235, 32);
            this.txtPropertyNo.TabIndex = 213;
            this.txtPropertyNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // rtDetails
            // 
            this.rtDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtDetails.Location = new System.Drawing.Point(148, 208);
            this.rtDetails.Name = "rtDetails";
            this.rtDetails.Size = new System.Drawing.Size(235, 97);
            this.rtDetails.TabIndex = 214;
            this.rtDetails.Text = "";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(70, 211);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(71, 21);
            this.bunifuCustomLabel2.TabIndex = 215;
            this.bunifuCustomLabel2.Text = "Details: *";
            // 
            // rbDonated
            // 
            this.rbDonated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDonated.AutoSize = true;
            this.rbDonated.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbDonated.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDonated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbDonated.Location = new System.Drawing.Point(254, 329);
            this.rbDonated.Name = "rbDonated";
            this.rbDonated.Size = new System.Drawing.Size(92, 25);
            this.rbDonated.TabIndex = 221;
            this.rbDonated.Text = "Donation";
            this.rbDonated.UseVisualStyleBackColor = true;
            // 
            // rbPurchased
            // 
            this.rbPurchased.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbPurchased.AutoSize = true;
            this.rbPurchased.Checked = true;
            this.rbPurchased.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPurchased.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPurchased.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbPurchased.Location = new System.Drawing.Point(148, 329);
            this.rbPurchased.Name = "rbPurchased";
            this.rbPurchased.Size = new System.Drawing.Size(100, 25);
            this.rbPurchased.TabIndex = 220;
            this.rbPurchased.TabStop = true;
            this.rbPurchased.Text = "Purchased";
            this.rbPurchased.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(74, 150);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(56, 21);
            this.bunifuCustomLabel1.TabIndex = 223;
            this.bunifuCustomLabel1.Text = "Type: *";
            // 
            // cbType
            // 
            this.cbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbType.BackColor = System.Drawing.SystemColors.Window;
            this.cbType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.ForeColor = System.Drawing.Color.Black;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(147, 145);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(236, 29);
            this.cbType.TabIndex = 222;
            // 
            // dtpProcured
            // 
            this.dtpProcured.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpProcured.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpProcured.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpProcured.Location = new System.Drawing.Point(421, 101);
            this.dtpProcured.Name = "dtpProcured";
            this.dtpProcured.Size = new System.Drawing.Size(165, 29);
            this.dtpProcured.TabIndex = 224;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(417, 76);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(123, 21);
            this.bunifuCustomLabel6.TabIndex = 225;
            this.bunifuCustomLabel6.Text = "Date Procured: *";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(417, 149);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(68, 21);
            this.bunifuCustomLabel4.TabIndex = 227;
            this.bunifuCustomLabel4.Text = "FROM: *";
            // 
            // cbFrom
            // 
            this.cbFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFrom.BackColor = System.Drawing.SystemColors.Window;
            this.cbFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFrom.ForeColor = System.Drawing.Color.Black;
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Location = new System.Drawing.Point(421, 173);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(163, 29);
            this.cbFrom.TabIndex = 226;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(417, 233);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(41, 21);
            this.bunifuCustomLabel3.TabIndex = 230;
            this.bunifuCustomLabel3.Text = "Cost";
            // 
            // txtCost
            // 
            this.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCost.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCost.HintForeColor = System.Drawing.Color.Empty;
            this.txtCost.HintText = "";
            this.txtCost.isPassword = false;
            this.txtCost.LineFocusedColor = System.Drawing.Color.White;
            this.txtCost.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCost.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtCost.LineThickness = 3;
            this.txtCost.Location = new System.Drawing.Point(421, 258);
            this.txtCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(163, 47);
            this.txtCost.TabIndex = 228;
            this.txtCost.Text = "0.00";
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCost.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCost_KeyUp);
            this.txtCost.Leave += new System.EventHandler(this.txtCost_Leave);
            // 
            // btnDepreciation
            // 
            this.btnDepreciation.BackColor = System.Drawing.Color.Transparent;
            this.btnDepreciation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepreciation.Image = ((System.Drawing.Image)(resources.GetObject("btnDepreciation.Image")));
            this.btnDepreciation.ImageActive = null;
            this.btnDepreciation.Location = new System.Drawing.Point(544, 223);
            this.btnDepreciation.Name = "btnDepreciation";
            this.btnDepreciation.Size = new System.Drawing.Size(40, 31);
            this.btnDepreciation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDepreciation.TabIndex = 229;
            this.btnDepreciation.TabStop = false;
            this.btnDepreciation.Zoom = 10;
            this.btnDepreciation.Click += new System.EventHandler(this.btnDepreciation_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSave.ActiveForecolor = System.Drawing.Color.White;
            this.btnSave.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "Save Changes";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.Color.White;
            this.btnSave.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Location = new System.Drawing.Point(421, 351);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 70);
            this.btnSave.TabIndex = 231;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 392);
            this.panel1.TabIndex = 232;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(610, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 392);
            this.panel2.TabIndex = 233;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 430);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(605, 5);
            this.panel3.TabIndex = 234;
            // 
            // lblMultipleUpdate
            // 
            this.lblMultipleUpdate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultipleUpdate.ForeColor = System.Drawing.Color.Orange;
            this.lblMultipleUpdate.Location = new System.Drawing.Point(19, 318);
            this.lblMultipleUpdate.Name = "lblMultipleUpdate";
            this.lblMultipleUpdate.Size = new System.Drawing.Size(364, 103);
            this.lblMultipleUpdate.TabIndex = 235;
            this.lblMultipleUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMultipleUpdate.Visible = false;
            // 
            // frmEditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(615, 435);
            this.Controls.Add(this.lblMultipleUpdate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.btnDepreciation);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.cbFrom);
            this.Controls.Add(this.dtpProcured);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.rbDonated);
            this.Controls.Add(this.rbPurchased);
            this.Controls.Add(this.rtDetails);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtPropertyNo);
            this.Controls.Add(this.bunifuCustomLabel16);
            this.Controls.Add(this.pnlDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmEditItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Item";
            this.Load += new System.EventHandler(this.frmEditItem_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEditItem_KeyDown);
            this.pnlDrag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDepreciation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlDrag;
        private System.Windows.Forms.Panel pnlDragControl;
        private ns1.BunifuCustomLabel lblTitle;
        private ns1.BunifuFlatButton btnClose;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuCustomLabel bunifuCustomLabel16;
        private ns1.BunifuMaterialTextbox txtPropertyNo;
        private System.Windows.Forms.RichTextBox rtDetails;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.RadioButton rbDonated;
        private System.Windows.Forms.RadioButton rbPurchased;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.DateTimePicker dtpProcured;
        private ns1.BunifuCustomLabel bunifuCustomLabel6;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.ComboBox cbFrom;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuMaterialTextbox txtCost;
        private ns1.BunifuImageButton btnDepreciation;
        private ns1.BunifuThinButton2 btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private ns1.BunifuCustomLabel lblMultipleUpdate;
    }
}