namespace THAGBAN_INST.FORM.FRM_EMP_MANEGER.holidays
{
    partial class frm_add_hloidy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_hloidy));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.com_holiday_type = new System.Windows.Forms.ComboBox();
            this.lbl_dept = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.com_emp_name = new System.Windows.Forms.ComboBox();
            this.btn_emp_list = new DevExpress.XtraEditors.SimpleButton();
            this.btn_list_dept = new DevExpress.XtraEditors.SimpleButton();
            this.txt_hliday_start = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_n_day = new Bunifu.UI.WinForms.BunifuTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_hliday_end = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_note = new Bunifu.UI.WinForms.BunifuTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // com_holiday_type
            // 
            this.com_holiday_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_holiday_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_holiday_type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_holiday_type.Font = new System.Drawing.Font("ae_AlArabiya", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_holiday_type.FormattingEnabled = true;
            this.com_holiday_type.Location = new System.Drawing.Point(430, 179);
            this.com_holiday_type.Name = "com_holiday_type";
            this.com_holiday_type.Size = new System.Drawing.Size(243, 41);
            this.com_holiday_type.TabIndex = 61;
            this.com_holiday_type.SelectedIndexChanged += new System.EventHandler(this.com_dept_SelectedIndexChanged);
            this.com_holiday_type.SelectionChangeCommitted += new System.EventHandler(this.com_dept_SelectionChangeCommitted);
            // 
            // lbl_dept
            // 
            this.lbl_dept.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dept.Appearance.Options.UseFont = true;
            this.lbl_dept.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbl_dept.LineVisible = true;
            this.lbl_dept.Location = new System.Drawing.Point(610, 149);
            this.lbl_dept.Name = "lbl_dept";
            this.lbl_dept.Size = new System.Drawing.Size(63, 24);
            this.lbl_dept.TabIndex = 60;
            this.lbl_dept.Text = "نوع الاجازه ";
            this.lbl_dept.Click += new System.EventHandler(this.lbl_dept_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(260, 65);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(84, 19);
            this.labelControl6.TabIndex = 65;
            this.labelControl6.Text = "تاريخ  بدايه الاجازه ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 58);
            this.panel1.TabIndex = 73;
            // 
            // simpleButton1
            // 
            this.simpleButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.simpleButton1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(129, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton1.Size = new System.Drawing.Size(90, 43);
            this.simpleButton1.TabIndex = 75;
            this.simpleButton1.Text = "مسح";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
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
            this.btn_save.Location = new System.Drawing.Point(438, 12);
            this.btn_save.Name = "btn_save";
            this.btn_save.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_save.Size = new System.Drawing.Size(90, 43);
            this.btn_save.TabIndex = 74;
            this.btn_save.Text = "اضافة";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl11.LineVisible = true;
            this.labelControl11.Location = new System.Drawing.Point(600, 60);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(73, 24);
            this.labelControl11.TabIndex = 78;
            this.labelControl11.Text = "اسم الموظف";
            // 
            // com_emp_name
            // 
            this.com_emp_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_emp_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_emp_name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_emp_name.Font = new System.Drawing.Font("ae_AlArabiya", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_emp_name.FormattingEnabled = true;
            this.com_emp_name.Location = new System.Drawing.Point(430, 90);
            this.com_emp_name.Name = "com_emp_name";
            this.com_emp_name.Size = new System.Drawing.Size(243, 41);
            this.com_emp_name.TabIndex = 79;
            this.com_emp_name.SelectionChangeCommitted += new System.EventHandler(this.com_emp_name_SelectionChangeCommitted);
            // 
            // btn_emp_list
            // 
            this.btn_emp_list.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.btn_emp_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_emp_list.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emp_list.Appearance.Options.UseBorderColor = true;
            this.btn_emp_list.Appearance.Options.UseFont = true;
            this.btn_emp_list.Appearance.Options.UseTextOptions = true;
            this.btn_emp_list.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_emp_list.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.btn_emp_list.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_emp_list.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_emp_list.ImageOptions.Image")));
            this.btn_emp_list.Location = new System.Drawing.Point(365, 90);
            this.btn_emp_list.Name = "btn_emp_list";
            this.btn_emp_list.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_emp_list.Size = new System.Drawing.Size(44, 0);
            this.btn_emp_list.TabIndex = 80;
            this.btn_emp_list.Click += new System.EventHandler(this.btn_emp_list_Click);
            // 
            // btn_list_dept
            // 
            this.btn_list_dept.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.btn_list_dept.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_list_dept.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_list_dept.Appearance.Options.UseBorderColor = true;
            this.btn_list_dept.Appearance.Options.UseFont = true;
            this.btn_list_dept.Appearance.Options.UseTextOptions = true;
            this.btn_list_dept.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_list_dept.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.btn_list_dept.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_list_dept.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_list_dept.ImageOptions.Image")));
            this.btn_list_dept.Location = new System.Drawing.Point(365, 179);
            this.btn_list_dept.Name = "btn_list_dept";
            this.btn_list_dept.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_list_dept.Size = new System.Drawing.Size(44, 0);
            this.btn_list_dept.TabIndex = 76;
            this.btn_list_dept.Click += new System.EventHandler(this.btn_list_dept_Click);
            // 
            // txt_hliday_start
            // 
            this.txt_hliday_start.BackColor = System.Drawing.Color.Transparent;
            this.txt_hliday_start.BorderRadius = 8;
            this.txt_hliday_start.Color = System.Drawing.Color.Silver;
            this.txt_hliday_start.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.txt_hliday_start.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.txt_hliday_start.DisabledColor = System.Drawing.Color.Gray;
            this.txt_hliday_start.DisplayWeekNumbers = false;
            this.txt_hliday_start.DPHeight = 0;
            this.txt_hliday_start.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txt_hliday_start.FillDatePicker = false;
            this.txt_hliday_start.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hliday_start.ForeColor = System.Drawing.Color.Black;
            this.txt_hliday_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_hliday_start.Icon = ((System.Drawing.Image)(resources.GetObject("txt_hliday_start.Icon")));
            this.txt_hliday_start.IconColor = System.Drawing.Color.Gray;
            this.txt_hliday_start.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.txt_hliday_start.LeftTextMargin = 5;
            this.txt_hliday_start.Location = new System.Drawing.Point(12, 90);
            this.txt_hliday_start.MinimumSize = new System.Drawing.Size(4, 32);
            this.txt_hliday_start.Name = "txt_hliday_start";
            this.txt_hliday_start.Size = new System.Drawing.Size(319, 32);
            this.txt_hliday_start.TabIndex = 64;
            this.txt_hliday_start.Value = new System.DateTime(2022, 12, 27, 2, 14, 19, 0);
            this.txt_hliday_start.ValueChanged += new System.EventHandler(this.txt_hliday_start_ValueChanged);
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
            this.bunifuPanel2.Size = new System.Drawing.Size(695, 44);
            this.bunifuPanel2.TabIndex = 48;
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_delete.ImageOptions.SvgImage")));
            this.btn_delete.Location = new System.Drawing.Point(3, 0);
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
            this.labelControl1.Location = new System.Drawing.Point(195, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(281, 26);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "شاشه اضافه وتعديل اجازات الموظفين";
            // 
            // txt_n_day
            // 
            this.txt_n_day.AcceptsReturn = false;
            this.txt_n_day.AcceptsTab = false;
            this.txt_n_day.AnimationSpeed = 200;
            this.txt_n_day.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_n_day.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_n_day.AutoSize = true;
            this.txt_n_day.BackColor = System.Drawing.Color.White;
            this.txt_n_day.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_n_day.BackgroundImage")));
            this.txt_n_day.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_n_day.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_n_day.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_n_day.BorderColorIdle = System.Drawing.Color.Black;
            this.txt_n_day.BorderRadius = 8;
            this.txt_n_day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_n_day.BorderThickness = 3;
            this.txt_n_day.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_n_day.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_n_day.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_n_day.DefaultText = "";
            this.txt_n_day.FillColor = System.Drawing.Color.White;
            this.txt_n_day.HideSelection = true;
            this.txt_n_day.IconLeft = null;
            this.txt_n_day.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_n_day.IconPadding = 10;
            this.txt_n_day.IconRight = null;
            this.txt_n_day.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_n_day.Lines = new string[0];
            this.txt_n_day.Location = new System.Drawing.Point(430, 266);
            this.txt_n_day.MaxLength = 32767;
            this.txt_n_day.MinimumSize = new System.Drawing.Size(2, 2);
            this.txt_n_day.Modified = false;
            this.txt_n_day.Multiline = true;
            this.txt_n_day.Name = "txt_n_day";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_n_day.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_n_day.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_n_day.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Black;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_n_day.OnIdleState = stateProperties4;
            this.txt_n_day.Padding = new System.Windows.Forms.Padding(3);
            this.txt_n_day.PasswordChar = '\0';
            this.txt_n_day.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_n_day.PlaceholderText = "حدد التاريخ لحساب عدد الايام تلقائيا ";
            this.txt_n_day.ReadOnly = false;
            this.txt_n_day.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_n_day.SelectedText = "";
            this.txt_n_day.SelectionLength = 0;
            this.txt_n_day.SelectionStart = 0;
            this.txt_n_day.ShortcutsEnabled = true;
            this.txt_n_day.Size = new System.Drawing.Size(243, 57);
            this.txt_n_day.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_n_day.TabIndex = 63;
            this.txt_n_day.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_n_day.TextMarginBottom = 0;
            this.txt_n_day.TextMarginLeft = 3;
            this.txt_n_day.TextMarginTop = 2;
            this.txt_n_day.TextPlaceholder = "حدد التاريخ لحساب عدد الايام تلقائيا ";
            this.txt_n_day.UseSystemPasswordChar = false;
            this.txt_n_day.WordWrap = true;
            this.txt_n_day.TextChanged += new System.EventHandler(this.txt_n_day_TextChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(260, 140);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 19);
            this.labelControl2.TabIndex = 82;
            this.labelControl2.Text = "تاريخ  نهايه الاجازه ";
            // 
            // txt_hliday_end
            // 
            this.txt_hliday_end.BackColor = System.Drawing.Color.Transparent;
            this.txt_hliday_end.BorderRadius = 8;
            this.txt_hliday_end.Color = System.Drawing.Color.Silver;
            this.txt_hliday_end.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.txt_hliday_end.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.txt_hliday_end.DisabledColor = System.Drawing.Color.Gray;
            this.txt_hliday_end.DisplayWeekNumbers = false;
            this.txt_hliday_end.DPHeight = 0;
            this.txt_hliday_end.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txt_hliday_end.FillDatePicker = false;
            this.txt_hliday_end.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hliday_end.ForeColor = System.Drawing.Color.Black;
            this.txt_hliday_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_hliday_end.Icon = ((System.Drawing.Image)(resources.GetObject("txt_hliday_end.Icon")));
            this.txt_hliday_end.IconColor = System.Drawing.Color.Gray;
            this.txt_hliday_end.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.txt_hliday_end.LeftTextMargin = 5;
            this.txt_hliday_end.Location = new System.Drawing.Point(12, 165);
            this.txt_hliday_end.MinimumSize = new System.Drawing.Size(4, 32);
            this.txt_hliday_end.Name = "txt_hliday_end";
            this.txt_hliday_end.Size = new System.Drawing.Size(319, 32);
            this.txt_hliday_end.TabIndex = 81;
            this.txt_hliday_end.Value = new System.DateTime(2022, 12, 27, 2, 14, 19, 0);
            this.txt_hliday_end.ValueChanged += new System.EventHandler(this.txt_hliday_end_ValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(587, 241);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 19);
            this.labelControl3.TabIndex = 83;
            this.labelControl3.Text = "عدد ايام الاجازه";
            // 
            // txt_note
            // 
            this.txt_note.AcceptsReturn = false;
            this.txt_note.AcceptsTab = false;
            this.txt_note.AnimationSpeed = 200;
            this.txt_note.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_note.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_note.AutoSize = true;
            this.txt_note.BackColor = System.Drawing.Color.White;
            this.txt_note.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_note.BackgroundImage")));
            this.txt_note.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_note.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_note.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_note.BorderColorIdle = System.Drawing.Color.Black;
            this.txt_note.BorderRadius = 8;
            this.txt_note.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_note.BorderThickness = 3;
            this.txt_note.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_note.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_note.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_note.DefaultText = "";
            this.txt_note.FillColor = System.Drawing.Color.White;
            this.txt_note.HideSelection = true;
            this.txt_note.IconLeft = null;
            this.txt_note.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_note.IconPadding = 10;
            this.txt_note.IconRight = null;
            this.txt_note.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_note.Lines = new string[0];
            this.txt_note.Location = new System.Drawing.Point(12, 256);
            this.txt_note.MaxLength = 32767;
            this.txt_note.MinimumSize = new System.Drawing.Size(2, 2);
            this.txt_note.Modified = false;
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_note.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_note.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_note.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Black;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_note.OnIdleState = stateProperties8;
            this.txt_note.Padding = new System.Windows.Forms.Padding(3);
            this.txt_note.PasswordChar = '\0';
            this.txt_note.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_note.PlaceholderText = "هل لديك ملاحضات اكتبها";
            this.txt_note.ReadOnly = false;
            this.txt_note.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_note.SelectedText = "";
            this.txt_note.SelectionLength = 0;
            this.txt_note.SelectionStart = 0;
            this.txt_note.ShortcutsEnabled = true;
            this.txt_note.Size = new System.Drawing.Size(306, 57);
            this.txt_note.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_note.TabIndex = 84;
            this.txt_note.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_note.TextMarginBottom = 0;
            this.txt_note.TextMarginLeft = 3;
            this.txt_note.TextMarginTop = 2;
            this.txt_note.TextPlaceholder = "هل لديك ملاحضات اكتبها";
            this.txt_note.UseSystemPasswordChar = false;
            this.txt_note.WordWrap = true;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(284, 219);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 19);
            this.labelControl4.TabIndex = 85;
            this.labelControl4.Text = "ملاحضات ";
            // 
            // simpleButton2
            // 
            this.simpleButton2.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseTextOptions = true;
            this.simpleButton2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton2.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.simpleButton2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(380, 90);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton2.Size = new System.Drawing.Size(44, 41);
            this.simpleButton2.TabIndex = 86;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseBorderColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseTextOptions = true;
            this.simpleButton3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton3.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.simpleButton3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(380, 179);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton3.Size = new System.Drawing.Size(44, 41);
            this.simpleButton3.TabIndex = 87;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "label1";
            // 
            // frm_add_hloidy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 386);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_hliday_end);
            this.Controls.Add(this.btn_emp_list);
            this.Controls.Add(this.com_emp_name);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.btn_list_dept);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txt_hliday_start);
            this.Controls.Add(this.txt_n_day);
            this.Controls.Add(this.com_holiday_type);
            this.Controls.Add(this.lbl_dept);
            this.Controls.Add(this.bunifuPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_add_hloidy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_add_emp";
            this.Load += new System.EventHandler(this.frm_add_emp_Load);
            this.panel1.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public System.Windows.Forms.ComboBox com_holiday_type;
        private DevExpress.XtraEditors.LabelControl lbl_dept;
        private Bunifu.UI.WinForms.BunifuDatePicker txt_hliday_start;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.SimpleButton btn_save;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraEditors.SimpleButton btn_list_dept;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        public System.Windows.Forms.ComboBox com_emp_name;
        public DevExpress.XtraEditors.SimpleButton btn_emp_list;
        public Bunifu.UI.WinForms.BunifuTextBox txt_n_day;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Bunifu.UI.WinForms.BunifuDatePicker txt_hliday_end;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public Bunifu.UI.WinForms.BunifuTextBox txt_note;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.SimpleButton simpleButton2;
        public DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.Label label1;
    }
}