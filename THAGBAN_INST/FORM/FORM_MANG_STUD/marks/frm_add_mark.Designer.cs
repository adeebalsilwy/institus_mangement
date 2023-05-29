namespace THAGBAN_INST.FORM.FRM_MANG_STUD.marks
{
    partial class frm_add_mark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_mark));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.com_spiacl = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.com_term = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.com_cours = new System.Windows.Forms.ComboBox();
            this.com_year = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.com_stud = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_mark_value = new Bunifu.UI.WinForms.BunifuTextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txt_mark_date = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.ch_year = new System.Windows.Forms.CheckBox();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // com_spiacl
            // 
            this.com_spiacl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_spiacl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_spiacl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_spiacl.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_spiacl.FormattingEnabled = true;
            this.com_spiacl.Location = new System.Drawing.Point(28, 76);
            this.com_spiacl.Name = "com_spiacl";
            this.com_spiacl.Size = new System.Drawing.Size(227, 34);
            this.com_spiacl.TabIndex = 59;
            this.com_spiacl.SelectionChangeCommitted += new System.EventHandler(this.com_spiacl_SelectionChangeCommitted);
            this.com_spiacl.SelectedValueChanged += new System.EventHandler(this.com_spiacl_SelectionChangeCommitted);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(261, 87);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 22);
            this.labelControl4.TabIndex = 58;
            this.labelControl4.Text = "التخصص";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(511, 138);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 19);
            this.labelControl2.TabIndex = 54;
            this.labelControl2.Text = "اسم الماده";
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 5;
            this.bunifuPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuPanel1.BorderThickness = 2;
            this.bunifuPanel1.Controls.Add(this.btn_save);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 351);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(584, 62);
            this.bunifuPanel1.TabIndex = 53;
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseBorderColor = true;
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.Appearance.Options.UseTextOptions = true;
            this.btn_save.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_save.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.btn_save.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageOptions.Image")));
            this.btn_save.Location = new System.Drawing.Point(141, 6);
            this.btn_save.Name = "btn_save";
            this.btn_save.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_save.Size = new System.Drawing.Size(303, 43);
            this.btn_save.TabIndex = 54;
            this.btn_save.Text = "اضافة";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 5;
            this.bunifuPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.btn_delete);
            this.bunifuPanel2.Controls.Add(this.labelControl1);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(584, 53);
            this.bunifuPanel2.TabIndex = 55;
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_delete.ImageOptions.SvgImage")));
            this.btn_delete.Location = new System.Drawing.Point(3, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_delete.Size = new System.Drawing.Size(43, 43);
            this.btn_delete.TabIndex = 44;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(206, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(219, 26);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "شاشه اضافه وتعديل الدرجات";
            // 
            // com_term
            // 
            this.com_term.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_term.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_term.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_term.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_term.FormattingEnabled = true;
            this.com_term.Location = new System.Drawing.Point(32, 48);
            this.com_term.Name = "com_term";
            this.com_term.Size = new System.Drawing.Size(227, 34);
            this.com_term.TabIndex = 64;
            this.com_term.SelectionChangeCommitted += new System.EventHandler(this.com_term_SelectionChangeCommitted);
            this.com_term.DataSourceChanged += new System.EventHandler(this.com_term_DataSourceChanged);
            this.com_term.SelectedValueChanged += new System.EventHandler(this.com_term_SelectedValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(253, 20);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(22, 22);
            this.labelControl6.TabIndex = 63;
            this.labelControl6.Text = "الترم";
            // 
            // com_cours
            // 
            this.com_cours.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_cours.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_cours.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_cours.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_cours.FormattingEnabled = true;
            this.com_cours.Location = new System.Drawing.Point(332, 163);
            this.com_cours.Name = "com_cours";
            this.com_cours.Size = new System.Drawing.Size(227, 34);
            this.com_cours.TabIndex = 65;
            this.com_cours.SelectionChangeCommitted += new System.EventHandler(this.com_cours_SelectionChangeCommitted);
            this.com_cours.SelectedValueChanged += new System.EventHandler(this.com_cours_SelectedValueChanged);
            // 
            // com_year
            // 
            this.com_year.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_year.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_year.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_year.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_year.FormattingEnabled = true;
            this.com_year.Location = new System.Drawing.Point(302, 48);
            this.com_year.Name = "com_year";
            this.com_year.Size = new System.Drawing.Size(227, 34);
            this.com_year.TabIndex = 62;
            this.com_year.SelectionChangeCommitted += new System.EventHandler(this.com_year_SelectionChangeCommitted);
            this.com_year.SelectedValueChanged += new System.EventHandler(this.com_year_SelectionChangeCommitted);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(466, 20);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 22);
            this.labelControl5.TabIndex = 61;
            this.labelControl5.Text = "السنه ";
            // 
            // com_stud
            // 
            this.com_stud.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_stud.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_stud.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_stud.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_stud.FormattingEnabled = true;
            this.com_stud.Location = new System.Drawing.Point(332, 87);
            this.com_stud.Name = "com_stud";
            this.com_stud.Size = new System.Drawing.Size(227, 34);
            this.com_stud.TabIndex = 67;
            this.com_stud.SelectionChangeCommitted += new System.EventHandler(this.com_stud_SelectionChangeCommitted);
            this.com_stud.SelectedValueChanged += new System.EventHandler(this.com_stud_SelectionChangeCommitted);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(507, 59);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 22);
            this.labelControl3.TabIndex = 66;
            this.labelControl3.Text = "اسم الطالب";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.com_year);
            this.groupBox1.Controls.Add(this.com_term);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(15, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 100);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            // 
            // txt_mark_value
            // 
            this.txt_mark_value.AcceptsReturn = false;
            this.txt_mark_value.AcceptsTab = false;
            this.txt_mark_value.AnimationSpeed = 200;
            this.txt_mark_value.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_mark_value.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_mark_value.AutoSize = true;
            this.txt_mark_value.BackColor = System.Drawing.Color.White;
            this.txt_mark_value.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_mark_value.BackgroundImage")));
            this.txt_mark_value.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_mark_value.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_mark_value.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_mark_value.BorderColorIdle = System.Drawing.Color.Black;
            this.txt_mark_value.BorderRadius = 8;
            this.txt_mark_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mark_value.BorderThickness = 3;
            this.txt_mark_value.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_mark_value.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mark_value.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_mark_value.DefaultText = "";
            this.txt_mark_value.FillColor = System.Drawing.Color.White;
            this.txt_mark_value.HideSelection = true;
            this.txt_mark_value.IconLeft = null;
            this.txt_mark_value.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mark_value.IconPadding = 10;
            this.txt_mark_value.IconRight = null;
            this.txt_mark_value.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mark_value.Lines = new string[0];
            this.txt_mark_value.Location = new System.Drawing.Point(90, 151);
            this.txt_mark_value.MaxLength = 32767;
            this.txt_mark_value.MinimumSize = new System.Drawing.Size(2, 2);
            this.txt_mark_value.Modified = false;
            this.txt_mark_value.Multiline = true;
            this.txt_mark_value.Name = "txt_mark_value";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_mark_value.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_mark_value.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_mark_value.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Black;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_mark_value.OnIdleState = stateProperties4;
            this.txt_mark_value.Padding = new System.Windows.Forms.Padding(3);
            this.txt_mark_value.PasswordChar = '\0';
            this.txt_mark_value.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_mark_value.PlaceholderText = "ادخل الدرجه";
            this.txt_mark_value.ReadOnly = false;
            this.txt_mark_value.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_mark_value.SelectedText = "";
            this.txt_mark_value.SelectionLength = 0;
            this.txt_mark_value.SelectionStart = 0;
            this.txt_mark_value.ShortcutsEnabled = true;
            this.txt_mark_value.Size = new System.Drawing.Size(129, 46);
            this.txt_mark_value.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_mark_value.TabIndex = 70;
            this.txt_mark_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_mark_value.TextMarginBottom = 0;
            this.txt_mark_value.TextMarginLeft = 3;
            this.txt_mark_value.TextMarginTop = 2;
            this.txt_mark_value.TextPlaceholder = "ادخل الدرجه";
            this.txt_mark_value.UseSystemPasswordChar = false;
            this.txt_mark_value.WordWrap = true;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(238, 163);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(72, 19);
            this.labelControl7.TabIndex = 69;
            this.labelControl7.Text = "الدرجه المستحقه";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(268, 216);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(25, 19);
            this.labelControl8.TabIndex = 86;
            this.labelControl8.Text = "التاريخ";
            // 
            // txt_mark_date
            // 
            this.txt_mark_date.BackColor = System.Drawing.Color.Transparent;
            this.txt_mark_date.BorderRadius = 8;
            this.txt_mark_date.Color = System.Drawing.Color.Silver;
            this.txt_mark_date.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.txt_mark_date.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.txt_mark_date.DisabledColor = System.Drawing.Color.Gray;
            this.txt_mark_date.DisplayWeekNumbers = false;
            this.txt_mark_date.DPHeight = 0;
            this.txt_mark_date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txt_mark_date.FillDatePicker = false;
            this.txt_mark_date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mark_date.ForeColor = System.Drawing.Color.Black;
            this.txt_mark_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_mark_date.Icon = ((System.Drawing.Image)(resources.GetObject("txt_mark_date.Icon")));
            this.txt_mark_date.IconColor = System.Drawing.Color.Gray;
            this.txt_mark_date.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.txt_mark_date.LeftTextMargin = 5;
            this.txt_mark_date.Location = new System.Drawing.Point(47, 203);
            this.txt_mark_date.MinimumSize = new System.Drawing.Size(4, 32);
            this.txt_mark_date.Name = "txt_mark_date";
            this.txt_mark_date.Size = new System.Drawing.Size(191, 32);
            this.txt_mark_date.TabIndex = 85;
            this.txt_mark_date.Value = new System.DateTime(2022, 12, 27, 2, 14, 19, 0);
            // 
            // ch_year
            // 
            this.ch_year.AutoSize = true;
            this.ch_year.Location = new System.Drawing.Point(362, 222);
            this.ch_year.Name = "ch_year";
            this.ch_year.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ch_year.Size = new System.Drawing.Size(197, 17);
            this.ch_year.TabIndex = 87;
            this.ch_year.Text = "هل تريد تحديد السنه الدراسيه والترم ";
            this.ch_year.UseVisualStyleBackColor = true;
            this.ch_year.CheckedChanged += new System.EventHandler(this.ch_year_CheckedChanged);
            // 
            // frm_add_mark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 413);
            this.Controls.Add(this.ch_year);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txt_mark_date);
            this.Controls.Add(this.txt_mark_value);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.com_stud);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.com_cours);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.com_spiacl);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_add_mark";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_add_job";
            this.Load += new System.EventHandler(this.frm_add_job_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        public DevExpress.XtraEditors.SimpleButton btn_save;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        public System.Windows.Forms.ComboBox com_spiacl;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public System.Windows.Forms.ComboBox com_term;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        public System.Windows.Forms.ComboBox com_cours;
        public System.Windows.Forms.ComboBox com_year;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        public System.Windows.Forms.ComboBox com_stud;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.GroupBox groupBox1;
        public Bunifu.UI.WinForms.BunifuTextBox txt_mark_value;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private Bunifu.UI.WinForms.BunifuDatePicker txt_mark_date;
        private System.Windows.Forms.CheckBox ch_year;
    }
}