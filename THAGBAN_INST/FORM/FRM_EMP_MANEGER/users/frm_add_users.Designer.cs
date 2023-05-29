namespace THAGBAN_INST.FORM.FRM_EMP_MANEGER.users
{
    partial class frm_add_users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_users));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.com_dept = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.com_emp = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_job_type = new DevExpress.XtraEditors.LabelControl();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_user_pass = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txt_user_name = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btn_jon_list = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.com_job = new System.Windows.Forms.ComboBox();
            this.btn_emp_list = new DevExpress.XtraEditors.SimpleButton();
            this.btn_dept_list = new DevExpress.XtraEditors.SimpleButton();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // com_dept
            // 
            this.com_dept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_dept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_dept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_dept.Font = new System.Drawing.Font("ae_AlArabiya", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_dept.FormattingEnabled = true;
            this.com_dept.Location = new System.Drawing.Point(57, 68);
            this.com_dept.Name = "com_dept";
            this.com_dept.Size = new System.Drawing.Size(226, 41);
            this.com_dept.TabIndex = 59;
            this.com_dept.SelectedIndexChanged += new System.EventHandler(this.com_dept_SelectionChangeCommitted);
            this.com_dept.SelectionChangeCommitted += new System.EventHandler(this.com_dept_SelectionChangeCommitted);
            this.com_dept.SelectedValueChanged += new System.EventHandler(this.com_dept_SelectionChangeCommitted);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(298, 85);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 22);
            this.labelControl4.TabIndex = 58;
            this.labelControl4.Text = "اسم القسم ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(303, 356);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 19);
            this.labelControl3.TabIndex = 57;
            this.labelControl3.Text = "كلمه السر";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(294, 265);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 19);
            this.labelControl2.TabIndex = 54;
            this.labelControl2.Text = "اسم المستخدم";
            // 
            // com_emp
            // 
            this.com_emp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_emp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_emp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_emp.Font = new System.Drawing.Font("ae_AlArabiya", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_emp.FormattingEnabled = true;
            this.com_emp.Location = new System.Drawing.Point(57, 193);
            this.com_emp.Name = "com_emp";
            this.com_emp.Size = new System.Drawing.Size(226, 41);
            this.com_emp.TabIndex = 62;
            this.com_emp.SelectedIndexChanged += new System.EventHandler(this.com_emp_SelectionChangeCommitted);
            this.com_emp.SelectionChangeCommitted += new System.EventHandler(this.com_emp_SelectionChangeCommitted);
            this.com_emp.SelectedValueChanged += new System.EventHandler(this.com_emp_SelectionChangeCommitted);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(289, 204);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(71, 22);
            this.labelControl5.TabIndex = 61;
            this.labelControl5.Text = "اسم الموظف";
            // 
            // lbl_job_type
            // 
            this.lbl_job_type.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_job_type.Appearance.Options.UseFont = true;
            this.lbl_job_type.Location = new System.Drawing.Point(157, 258);
            this.lbl_job_type.Name = "lbl_job_type";
            this.lbl_job_type.Size = new System.Drawing.Size(0, 19);
            this.lbl_job_type.TabIndex = 64;
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
            this.bunifuPanel1.Controls.Add(this.simpleButton1);
            this.bunifuPanel1.Controls.Add(this.btn_save);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 445);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(418, 62);
            this.bunifuPanel1.TabIndex = 53;
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
            this.simpleButton1.Location = new System.Drawing.Point(56, 14);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton1.Size = new System.Drawing.Size(87, 43);
            this.simpleButton1.TabIndex = 105;
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
            this.btn_save.Location = new System.Drawing.Point(222, 14);
            this.btn_save.Name = "btn_save";
            this.btn_save.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_save.Size = new System.Drawing.Size(97, 43);
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
            this.bunifuPanel2.Size = new System.Drawing.Size(418, 53);
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
            this.labelControl1.Location = new System.Drawing.Point(90, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(247, 26);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "شاشه اضافه وتعديل المستخدمين";
            // 
            // txt_user_pass
            // 
            this.txt_user_pass.AcceptsReturn = false;
            this.txt_user_pass.AcceptsTab = false;
            this.txt_user_pass.AnimationSpeed = 200;
            this.txt_user_pass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_user_pass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_user_pass.AutoSize = true;
            this.txt_user_pass.BackColor = System.Drawing.Color.White;
            this.txt_user_pass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_user_pass.BackgroundImage")));
            this.txt_user_pass.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_user_pass.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_user_pass.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_user_pass.BorderColorIdle = System.Drawing.Color.Black;
            this.txt_user_pass.BorderRadius = 8;
            this.txt_user_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_user_pass.BorderThickness = 3;
            this.txt_user_pass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_user_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user_pass.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_user_pass.DefaultText = "";
            this.txt_user_pass.FillColor = System.Drawing.Color.White;
            this.txt_user_pass.HideSelection = true;
            this.txt_user_pass.IconLeft = null;
            this.txt_user_pass.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user_pass.IconPadding = 10;
            this.txt_user_pass.IconRight = null;
            this.txt_user_pass.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user_pass.Lines = new string[0];
            this.txt_user_pass.Location = new System.Drawing.Point(41, 381);
            this.txt_user_pass.MaxLength = 32767;
            this.txt_user_pass.MinimumSize = new System.Drawing.Size(2, 2);
            this.txt_user_pass.Modified = false;
            this.txt_user_pass.Multiline = true;
            this.txt_user_pass.Name = "txt_user_pass";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_user_pass.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_user_pass.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_user_pass.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Black;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_user_pass.OnIdleState = stateProperties12;
            this.txt_user_pass.Padding = new System.Windows.Forms.Padding(3);
            this.txt_user_pass.PasswordChar = '\0';
            this.txt_user_pass.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_user_pass.PlaceholderText = "ادخل كلمه المرور ";
            this.txt_user_pass.ReadOnly = false;
            this.txt_user_pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_user_pass.SelectedText = "";
            this.txt_user_pass.SelectionLength = 0;
            this.txt_user_pass.SelectionStart = 0;
            this.txt_user_pass.ShortcutsEnabled = true;
            this.txt_user_pass.Size = new System.Drawing.Size(319, 57);
            this.txt_user_pass.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_user_pass.TabIndex = 60;
            this.txt_user_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_user_pass.TextMarginBottom = 0;
            this.txt_user_pass.TextMarginLeft = 3;
            this.txt_user_pass.TextMarginTop = 2;
            this.txt_user_pass.TextPlaceholder = "ادخل كلمه المرور ";
            this.txt_user_pass.UseSystemPasswordChar = false;
            this.txt_user_pass.WordWrap = true;
            // 
            // txt_user_name
            // 
            this.txt_user_name.AcceptsReturn = false;
            this.txt_user_name.AcceptsTab = false;
            this.txt_user_name.AnimationSpeed = 200;
            this.txt_user_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_user_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_user_name.BackColor = System.Drawing.Color.Transparent;
            this.txt_user_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_user_name.BackgroundImage")));
            this.txt_user_name.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_user_name.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_user_name.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_user_name.BorderColorIdle = System.Drawing.Color.Black;
            this.txt_user_name.BorderRadius = 8;
            this.txt_user_name.BorderThickness = 3;
            this.txt_user_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_user_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user_name.DefaultFont = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_user_name.DefaultText = "";
            this.txt_user_name.FillColor = System.Drawing.Color.White;
            this.txt_user_name.HideSelection = true;
            this.txt_user_name.IconLeft = null;
            this.txt_user_name.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user_name.IconPadding = 10;
            this.txt_user_name.IconRight = null;
            this.txt_user_name.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user_name.Lines = new string[0];
            this.txt_user_name.Location = new System.Drawing.Point(41, 290);
            this.txt_user_name.MaxLength = 32767;
            this.txt_user_name.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_user_name.Modified = false;
            this.txt_user_name.Multiline = false;
            this.txt_user_name.Name = "txt_user_name";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_user_name.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_user_name.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_user_name.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Black;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_user_name.OnIdleState = stateProperties16;
            this.txt_user_name.Padding = new System.Windows.Forms.Padding(3);
            this.txt_user_name.PasswordChar = '\0';
            this.txt_user_name.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_user_name.PlaceholderText = "ادخل اسم المستخدم";
            this.txt_user_name.ReadOnly = false;
            this.txt_user_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_user_name.SelectedText = "";
            this.txt_user_name.SelectionLength = 0;
            this.txt_user_name.SelectionStart = 0;
            this.txt_user_name.ShortcutsEnabled = true;
            this.txt_user_name.Size = new System.Drawing.Size(319, 54);
            this.txt_user_name.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_user_name.TabIndex = 56;
            this.txt_user_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_user_name.TextMarginBottom = 0;
            this.txt_user_name.TextMarginLeft = 3;
            this.txt_user_name.TextMarginTop = 0;
            this.txt_user_name.TextPlaceholder = "ادخل اسم المستخدم";
            this.txt_user_name.UseSystemPasswordChar = false;
            this.txt_user_name.WordWrap = true;
            // 
            // btn_jon_list
            // 
            this.btn_jon_list.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.btn_jon_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_jon_list.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_jon_list.Appearance.Options.UseBorderColor = true;
            this.btn_jon_list.Appearance.Options.UseFont = true;
            this.btn_jon_list.Appearance.Options.UseTextOptions = true;
            this.btn_jon_list.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_jon_list.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.btn_jon_list.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_jon_list.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_jon_list.ImageOptions.Image")));
            this.btn_jon_list.Location = new System.Drawing.Point(4, 130);
            this.btn_jon_list.Name = "btn_jon_list";
            this.btn_jon_list.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_jon_list.Size = new System.Drawing.Size(41, 41);
            this.btn_jon_list.TabIndex = 91;
            this.btn_jon_list.Click += new System.EventHandler(this.btn_jon_list_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl9.LineVisible = true;
            this.labelControl9.Location = new System.Drawing.Point(300, 140);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(46, 24);
            this.labelControl9.TabIndex = 90;
            this.labelControl9.Text = "الوظيفه";
            // 
            // com_job
            // 
            this.com_job.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_job.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_job.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_job.Font = new System.Drawing.Font("ae_AlArabiya", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_job.FormattingEnabled = true;
            this.com_job.Location = new System.Drawing.Point(57, 130);
            this.com_job.Name = "com_job";
            this.com_job.Size = new System.Drawing.Size(226, 41);
            this.com_job.TabIndex = 89;
            this.com_job.SelectedIndexChanged += new System.EventHandler(this.com_job_SelectionChangeCommitted);
            this.com_job.SelectionChangeCommitted += new System.EventHandler(this.com_job_SelectionChangeCommitted);
            this.com_job.SelectedValueChanged += new System.EventHandler(this.com_job_SelectionChangeCommitted);
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
            this.btn_emp_list.Location = new System.Drawing.Point(6, 193);
            this.btn_emp_list.Name = "btn_emp_list";
            this.btn_emp_list.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_emp_list.Size = new System.Drawing.Size(41, 41);
            this.btn_emp_list.TabIndex = 92;
            this.btn_emp_list.Click += new System.EventHandler(this.btn_emp_list_Click);
            // 
            // btn_dept_list
            // 
            this.btn_dept_list.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.btn_dept_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dept_list.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dept_list.Appearance.Options.UseBorderColor = true;
            this.btn_dept_list.Appearance.Options.UseFont = true;
            this.btn_dept_list.Appearance.Options.UseTextOptions = true;
            this.btn_dept_list.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btn_dept_list.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.btn_dept_list.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btn_dept_list.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_dept_list.ImageOptions.Image")));
            this.btn_dept_list.Location = new System.Drawing.Point(6, 66);
            this.btn_dept_list.Name = "btn_dept_list";
            this.btn_dept_list.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_dept_list.Size = new System.Drawing.Size(41, 41);
            this.btn_dept_list.TabIndex = 93;
            this.btn_dept_list.Click += new System.EventHandler(this.btn_dept_list_Click);
            // 
            // frm_add_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 507);
            this.Controls.Add(this.btn_dept_list);
            this.Controls.Add(this.btn_emp_list);
            this.Controls.Add(this.btn_jon_list);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.com_job);
            this.Controls.Add(this.lbl_job_type);
            this.Controls.Add(this.com_emp);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.txt_user_pass);
            this.Controls.Add(this.com_dept);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_user_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_add_users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_add_job";
            this.Load += new System.EventHandler(this.frm_add_job_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        public DevExpress.XtraEditors.SimpleButton btn_save;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        public Bunifu.UI.WinForms.BunifuTextBox txt_user_pass;
        public System.Windows.Forms.ComboBox com_dept;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public Bunifu.UI.WinForms.BunifuTextBox txt_user_name;
        public System.Windows.Forms.ComboBox com_emp;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lbl_job_type;
        public DevExpress.XtraEditors.SimpleButton btn_jon_list;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        public System.Windows.Forms.ComboBox com_job;
        public DevExpress.XtraEditors.SimpleButton btn_emp_list;
        public DevExpress.XtraEditors.SimpleButton btn_dept_list;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}