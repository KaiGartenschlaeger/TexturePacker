namespace TexturePacker
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.slbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbbNew = new System.Windows.Forms.ToolStripButton();
            this.tbbSave = new System.Windows.Forms.ToolStripButton();
            this.btnAddPictures = new System.Windows.Forms.ToolStripButton();
            this.btnInfo = new System.Windows.Forms.ToolStripButton();
            this.lbxFilelist = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panPreview = new System.Windows.Forms.Panel();
            this.pbxPreview = new System.Windows.Forms.PictureBox();
            this.panProperties = new System.Windows.Forms.Panel();
            this.grpCanvas = new System.Windows.Forms.GroupBox();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.chbBackgroundTransparent = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudColumns = new System.Windows.Forms.NumericUpDown();
            this.btnPreview = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudFrameHeight = new System.Windows.Forms.NumericUpDown();
            this.nudFrameWidth = new System.Windows.Forms.NumericUpDown();
            this.chbFixedFrameSize = new System.Windows.Forms.CheckBox();
            this.btnBorderColor2 = new System.Windows.Forms.Button();
            this.btnBorderColor1 = new System.Windows.Forms.Button();
            this.nudBorderSize = new System.Windows.Forms.NumericUpDown();
            this.lblColumnPadding = new System.Windows.Forms.Label();
            this.chbBorder = new System.Windows.Forms.CheckBox();
            this.nudInnerPadding = new System.Windows.Forms.NumericUpDown();
            this.lblPadding = new System.Windows.Forms.Label();
            this.lblRowPadding = new System.Windows.Forms.Label();
            this.nudRowPadding = new System.Windows.Forms.NumericUpDown();
            this.nudColumnPadding = new System.Windows.Forms.NumericUpDown();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusBar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPreview)).BeginInit();
            this.panProperties.SuspendLayout();
            this.grpCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInnerPadding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowPadding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumnPadding)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slbStatus});
            this.statusBar.Location = new System.Drawing.Point(0, 540);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(784, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // slbStatus
            // 
            this.slbStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.slbStatus.Name = "slbStatus";
            this.slbStatus.Size = new System.Drawing.Size(47, 17);
            this.slbStatus.Text = "[Status]";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbbNew,
            this.tbbSave,
            this.btnAddPictures,
            this.toolStripSeparator1,
            this.btnInfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStrip1.Size = new System.Drawing.Size(784, 33);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbbNew
            // 
            this.tbbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbNew.Image = ((System.Drawing.Image)(resources.GetObject("tbbNew.Image")));
            this.tbbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbNew.Name = "tbbNew";
            this.tbbNew.Size = new System.Drawing.Size(23, 20);
            this.tbbNew.Text = "Neu";
            this.tbbNew.Click += new System.EventHandler(this.tbbNew_Click);
            // 
            // tbbSave
            // 
            this.tbbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbSave.Image = ((System.Drawing.Image)(resources.GetObject("tbbSave.Image")));
            this.tbbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbSave.Name = "tbbSave";
            this.tbbSave.Size = new System.Drawing.Size(23, 20);
            this.tbbSave.Text = "Speichern";
            this.tbbSave.Click += new System.EventHandler(this.tbbSave_Click);
            // 
            // btnAddPictures
            // 
            this.btnAddPictures.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddPictures.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPictures.Image")));
            this.btnAddPictures.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddPictures.Name = "btnAddPictures";
            this.btnAddPictures.Size = new System.Drawing.Size(23, 20);
            this.btnAddPictures.Text = "Bilder hinzufügen";
            this.btnAddPictures.Click += new System.EventHandler(this.btnAddPictures_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(23, 20);
            this.btnInfo.Text = "Informationen";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lbxFilelist
            // 
            this.lbxFilelist.AllowDrop = true;
            this.lbxFilelist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxFilelist.FormattingEnabled = true;
            this.lbxFilelist.IntegralHeight = false;
            this.lbxFilelist.Location = new System.Drawing.Point(587, 3);
            this.lbxFilelist.Name = "lbxFilelist";
            this.lbxFilelist.ScrollAlwaysVisible = true;
            this.lbxFilelist.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxFilelist.Size = new System.Drawing.Size(194, 501);
            this.lbxFilelist.TabIndex = 5;
            this.lbxFilelist.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbxFilelist_DragDrop);
            this.lbxFilelist.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbxFilelist_DragEnter);
            this.lbxFilelist.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lbxFilelist_KeyUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lbxFilelist, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panPreview, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panProperties, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 507);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panPreview
            // 
            this.panPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panPreview.AutoScroll = true;
            this.panPreview.BackColor = System.Drawing.SystemColors.Control;
            this.panPreview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panPreview.BackgroundImage")));
            this.panPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panPreview.Controls.Add(this.pbxPreview);
            this.panPreview.Location = new System.Drawing.Point(200, 3);
            this.panPreview.Name = "panPreview";
            this.panPreview.Size = new System.Drawing.Size(381, 501);
            this.panPreview.TabIndex = 4;
            this.panPreview.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panPreview_Scroll);
            this.panPreview.Resize += new System.EventHandler(this.panPreview_Resize);
            // 
            // pbxPreview
            // 
            this.pbxPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbxPreview.Location = new System.Drawing.Point(0, 0);
            this.pbxPreview.Name = "pbxPreview";
            this.pbxPreview.Size = new System.Drawing.Size(98, 94);
            this.pbxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxPreview.TabIndex = 0;
            this.pbxPreview.TabStop = false;
            // 
            // panProperties
            // 
            this.panProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panProperties.Controls.Add(this.grpCanvas);
            this.panProperties.Controls.Add(this.btnPreview);
            this.panProperties.Controls.Add(this.groupBox1);
            this.panProperties.Location = new System.Drawing.Point(3, 3);
            this.panProperties.Name = "panProperties";
            this.panProperties.Size = new System.Drawing.Size(191, 501);
            this.panProperties.TabIndex = 6;
            // 
            // grpCanvas
            // 
            this.grpCanvas.Controls.Add(this.btnBackgroundColor);
            this.grpCanvas.Controls.Add(this.chbBackgroundTransparent);
            this.grpCanvas.Controls.Add(this.label1);
            this.grpCanvas.Controls.Add(this.nudColumns);
            this.grpCanvas.Location = new System.Drawing.Point(11, 7);
            this.grpCanvas.Name = "grpCanvas";
            this.grpCanvas.Size = new System.Drawing.Size(169, 131);
            this.grpCanvas.TabIndex = 5;
            this.grpCanvas.TabStop = false;
            this.grpCanvas.Text = "Leinwand";
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.BackColor = System.Drawing.Color.White;
            this.btnBackgroundColor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnBackgroundColor.FlatAppearance.BorderSize = 2;
            this.btnBackgroundColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBackgroundColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBackgroundColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackgroundColor.Location = new System.Drawing.Point(14, 94);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(144, 23);
            this.btnBackgroundColor.TabIndex = 10;
            this.btnBackgroundColor.UseVisualStyleBackColor = false;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // chbBackgroundTransparent
            // 
            this.chbBackgroundTransparent.AutoSize = true;
            this.chbBackgroundTransparent.Checked = true;
            this.chbBackgroundTransparent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbBackgroundTransparent.Location = new System.Drawing.Point(14, 75);
            this.chbBackgroundTransparent.Name = "chbBackgroundTransparent";
            this.chbBackgroundTransparent.Size = new System.Drawing.Size(83, 17);
            this.chbBackgroundTransparent.TabIndex = 8;
            this.chbBackgroundTransparent.Text = "Transparent";
            this.chbBackgroundTransparent.UseVisualStyleBackColor = true;
            this.chbBackgroundTransparent.CheckedChanged += new System.EventHandler(this.chbBackgroundTransparent_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maximale Anzahl an Spalten";
            // 
            // nudColumns
            // 
            this.nudColumns.Location = new System.Drawing.Point(14, 39);
            this.nudColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudColumns.Name = "nudColumns";
            this.nudColumns.Size = new System.Drawing.Size(144, 20);
            this.nudColumns.TabIndex = 0;
            this.nudColumns.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudColumns.ValueChanged += new System.EventHandler(this.nudColumns_ValueChanged);
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.Location = new System.Drawing.Point(12, 457);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(168, 24);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "Aktualisieren";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudFrameHeight);
            this.groupBox1.Controls.Add(this.nudFrameWidth);
            this.groupBox1.Controls.Add(this.chbFixedFrameSize);
            this.groupBox1.Controls.Add(this.btnBorderColor2);
            this.groupBox1.Controls.Add(this.btnBorderColor1);
            this.groupBox1.Controls.Add(this.nudBorderSize);
            this.groupBox1.Controls.Add(this.lblColumnPadding);
            this.groupBox1.Controls.Add(this.chbBorder);
            this.groupBox1.Controls.Add(this.nudInnerPadding);
            this.groupBox1.Controls.Add(this.lblPadding);
            this.groupBox1.Controls.Add(this.lblRowPadding);
            this.groupBox1.Controls.Add(this.nudRowPadding);
            this.groupBox1.Controls.Add(this.nudColumnPadding);
            this.groupBox1.Location = new System.Drawing.Point(11, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 293);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abstände";
            // 
            // nudFrameHeight
            // 
            this.nudFrameHeight.Location = new System.Drawing.Point(87, 259);
            this.nudFrameHeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudFrameHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFrameHeight.Name = "nudFrameHeight";
            this.nudFrameHeight.Size = new System.Drawing.Size(68, 20);
            this.nudFrameHeight.TabIndex = 13;
            this.nudFrameHeight.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudFrameHeight.ValueChanged += new System.EventHandler(this.nudFrameHeight_ValueChanged);
            // 
            // nudFrameWidth
            // 
            this.nudFrameWidth.Location = new System.Drawing.Point(13, 259);
            this.nudFrameWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudFrameWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFrameWidth.Name = "nudFrameWidth";
            this.nudFrameWidth.Size = new System.Drawing.Size(68, 20);
            this.nudFrameWidth.TabIndex = 14;
            this.nudFrameWidth.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudFrameWidth.ValueChanged += new System.EventHandler(this.nudFrameWidth_ValueChanged);
            // 
            // chbFixedFrameSize
            // 
            this.chbFixedFrameSize.AutoSize = true;
            this.chbFixedFrameSize.Location = new System.Drawing.Point(13, 239);
            this.chbFixedFrameSize.Name = "chbFixedFrameSize";
            this.chbFixedFrameSize.Size = new System.Drawing.Size(104, 17);
            this.chbFixedFrameSize.TabIndex = 12;
            this.chbFixedFrameSize.Text = "Fixe Framegröße";
            this.chbFixedFrameSize.UseVisualStyleBackColor = true;
            this.chbFixedFrameSize.CheckedChanged += new System.EventHandler(this.chbFixedFrameSize_CheckedChanged);
            // 
            // btnBorderColor2
            // 
            this.btnBorderColor2.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBorderColor2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnBorderColor2.FlatAppearance.BorderSize = 2;
            this.btnBorderColor2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnBorderColor2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnBorderColor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorderColor2.Location = new System.Drawing.Point(74, 200);
            this.btnBorderColor2.Name = "btnBorderColor2";
            this.btnBorderColor2.Size = new System.Drawing.Size(55, 23);
            this.btnBorderColor2.TabIndex = 11;
            this.btnBorderColor2.UseVisualStyleBackColor = false;
            this.btnBorderColor2.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnBorderColor1
            // 
            this.btnBorderColor1.BackColor = System.Drawing.Color.DimGray;
            this.btnBorderColor1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.btnBorderColor1.FlatAppearance.BorderSize = 2;
            this.btnBorderColor1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnBorderColor1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnBorderColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorderColor1.Location = new System.Drawing.Point(13, 200);
            this.btnBorderColor1.Name = "btnBorderColor1";
            this.btnBorderColor1.Size = new System.Drawing.Size(55, 23);
            this.btnBorderColor1.TabIndex = 11;
            this.btnBorderColor1.UseVisualStyleBackColor = false;
            this.btnBorderColor1.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // nudBorderSize
            // 
            this.nudBorderSize.Location = new System.Drawing.Point(13, 174);
            this.nudBorderSize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudBorderSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBorderSize.Name = "nudBorderSize";
            this.nudBorderSize.Size = new System.Drawing.Size(67, 20);
            this.nudBorderSize.TabIndex = 9;
            this.nudBorderSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudBorderSize.ValueChanged += new System.EventHandler(this.nudBorderSize_ValueChanged);
            // 
            // lblColumnPadding
            // 
            this.lblColumnPadding.AutoSize = true;
            this.lblColumnPadding.Location = new System.Drawing.Point(10, 62);
            this.lblColumnPadding.Name = "lblColumnPadding";
            this.lblColumnPadding.Size = new System.Drawing.Size(81, 13);
            this.lblColumnPadding.TabIndex = 1;
            this.lblColumnPadding.Text = "Spaltenabstand";
            // 
            // chbBorder
            // 
            this.chbBorder.AutoSize = true;
            this.chbBorder.Location = new System.Drawing.Point(13, 155);
            this.chbBorder.Name = "chbBorder";
            this.chbBorder.Size = new System.Drawing.Size(116, 17);
            this.chbBorder.TabIndex = 6;
            this.chbBorder.Text = "Ränder hinzufügen";
            this.chbBorder.UseVisualStyleBackColor = true;
            this.chbBorder.CheckedChanged += new System.EventHandler(this.chbBorder_CheckedChanged);
            // 
            // nudInnerPadding
            // 
            this.nudInnerPadding.Location = new System.Drawing.Point(13, 119);
            this.nudInnerPadding.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudInnerPadding.Name = "nudInnerPadding";
            this.nudInnerPadding.Size = new System.Drawing.Size(143, 20);
            this.nudInnerPadding.TabIndex = 0;
            this.nudInnerPadding.ValueChanged += new System.EventHandler(this.nudInnerPadding_ValueChanged);
            // 
            // lblPadding
            // 
            this.lblPadding.AutoSize = true;
            this.lblPadding.Location = new System.Drawing.Point(10, 103);
            this.lblPadding.Name = "lblPadding";
            this.lblPadding.Size = new System.Drawing.Size(82, 13);
            this.lblPadding.TabIndex = 1;
            this.lblPadding.Text = "Innerer Abstand";
            // 
            // lblRowPadding
            // 
            this.lblRowPadding.AutoSize = true;
            this.lblRowPadding.Location = new System.Drawing.Point(10, 21);
            this.lblRowPadding.Name = "lblRowPadding";
            this.lblRowPadding.Size = new System.Drawing.Size(74, 13);
            this.lblRowPadding.TabIndex = 1;
            this.lblRowPadding.Text = "Zeilenabstand";
            // 
            // nudRowPadding
            // 
            this.nudRowPadding.Location = new System.Drawing.Point(13, 37);
            this.nudRowPadding.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudRowPadding.Name = "nudRowPadding";
            this.nudRowPadding.Size = new System.Drawing.Size(143, 20);
            this.nudRowPadding.TabIndex = 0;
            this.nudRowPadding.ValueChanged += new System.EventHandler(this.nudRowPadding_ValueChanged);
            // 
            // nudColumnPadding
            // 
            this.nudColumnPadding.Location = new System.Drawing.Point(13, 78);
            this.nudColumnPadding.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudColumnPadding.Name = "nudColumnPadding";
            this.nudColumnPadding.Size = new System.Drawing.Size(143, 20);
            this.nudColumnPadding.TabIndex = 0;
            this.nudColumnPadding.ValueChanged += new System.EventHandler(this.nudColumnPadding_ValueChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormMain";
            this.Text = "Texture Packer";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panPreview.ResumeLayout(false);
            this.panPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPreview)).EndInit();
            this.panProperties.ResumeLayout(false);
            this.grpCanvas.ResumeLayout(false);
            this.grpCanvas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumns)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInnerPadding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRowPadding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColumnPadding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel slbStatus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbbNew;
        private System.Windows.Forms.ToolStripButton tbbSave;
        private System.Windows.Forms.Panel panPreview;
        private System.Windows.Forms.ListBox lbxFilelist;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panProperties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudColumns;
        private System.Windows.Forms.Label lblColumnPadding;
        private System.Windows.Forms.Label lblRowPadding;
        private System.Windows.Forms.Label lblPadding;
        private System.Windows.Forms.NumericUpDown nudColumnPadding;
        private System.Windows.Forms.NumericUpDown nudRowPadding;
        private System.Windows.Forms.NumericUpDown nudInnerPadding;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.GroupBox grpCanvas;
        private System.Windows.Forms.PictureBox pbxPreview;
        private System.Windows.Forms.CheckBox chbBorder;
        private System.Windows.Forms.CheckBox chbBackgroundTransparent;
        private System.Windows.Forms.NumericUpDown nudBorderSize;
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.ToolStripButton btnAddPictures;
        private System.Windows.Forms.Button btnBorderColor2;
        private System.Windows.Forms.Button btnBorderColor1;
        private System.Windows.Forms.ToolStripButton btnInfo;
        private System.Windows.Forms.NumericUpDown nudFrameHeight;
        private System.Windows.Forms.NumericUpDown nudFrameWidth;
        private System.Windows.Forms.CheckBox chbFixedFrameSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

