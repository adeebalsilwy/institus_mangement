namespace THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_mark
{
    partial class frm_add_lect_mark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_lect_mark));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.com_lect = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.com_group = new System.Windows.Forms.ComboBox();
            this.com_stud = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_mark_value = new Bunifu.UI.WinForms.BunifuTextBox();
            this.com_matrial = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_l_name = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // com_lect
            // 
            this.com_lect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_lect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_lect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_lect.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_lect.FormattingEnabled = true;
            this.com_lect.Location = new System.Drawing.Point(44, 87);
            this.com_lect.Name = "com_lect";
            this.com_lect.Size = new System.Drawing.Size(227, 34);
            this.com_lect.TabIndex = 59;
            this.com_lect.SelectedIndexChanged += new System.EventHandler(this.com_spiacl_SelectionChangeCommitted);
            this.com_lect.SelectionChangeCommitted += new System.EventHandler(this.com_spiacl_SelectionChangeCommitted);
            this.com_lect.SelectedValueChanged += new System.EventHandler(this.com_spiacl_SelectionChangeCommitted);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(238, 59);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 22);
            this.labelControl4.TabIndex = 58;
            this.labelControl4.Text = "الدوره";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(511, 138);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 19);
            this.labelControl2.TabIndex = 54;
            this.labelControl2.Text = "اسم الدفعه";
            // 
            // com_group
            // 
            this.com_group.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_group.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_group.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_group.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_group.FormattingEnabled = true;
            this.com_group.Location = new System.Drawing.Point(332, 163);
            this.com_group.Name = "com_group";
            this.com_group.Size = new System.Drawing.Size(227, 34);
            this.com_group.TabIndex = 65;
            this.com_group.SelectedIndexChanged += new System.EventHandler(this.com_cours_SelectionChangeCommitted);
            this.com_group.SelectionChangeCommitted += new System.EventHandler(this.com_cours_SelectionChangeCommitted);
            this.com_group.SelectedValueChanged += new System.EventHandler(this.com_cours_SelectionChangeCommitted);
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
            this.com_stud.SelectedIndexChanged += new System.EventHandler(this.com_stud_SelectionChangeCommitted);
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
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(279, 214);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(72, 19);
            this.labelControl7.TabIndex = 69;
            this.labelControl7.Text = "الدرجه المستحقه";
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
            this.txt_mark_value.Location = new System.Drawing.Point(238, 248);
            this.txt_mark_value.MaxLength = 32767;
            this.txt_mark_value.MinimumSize = new System.Drawing.Size(2, 2);
            this.txt_mark_value.Modified = false;
            this.txt_mark_value.Multiline = true;
            this.txt_mark_value.Name = "txt_mark_value";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_mark_value.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_mark_value.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_mark_value.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Black;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_mark_value.OnIdleState = stateProperties12;
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
            this.txt_mark_value.TextChanged += new System.EventHandler(this.txt_mark_value_TextChanged);
            // 
            // com_matrial
            // 
            this.com_matrial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_matrial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_matrial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_matrial.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_matrial.FormattingEnabled = true;
            this.com_matrial.Location = new System.Drawing.Point(44, 166);
            this.com_matrial.Name = "com_matrial";
            this.com_matrial.Size = new System.Drawing.Size(227, 34);
            this.com_matrial.TabIndex = 72;
            this.com_matrial.SelectionChangeCommitted += new System.EventHandler(this.com_matrial_SelectionChangeCommitted);
            this.com_matrial.SelectedValueChanged += new System.EventHandler(this.com_matrial_SelectionChangeCommitted);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(223, 138);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 19);
            this.labelControl5.TabIndex = 71;
            this.labelControl5.Text = "اسم الماده";
            // 
            // lbl_l_name
            // 
            this.lbl_l_name.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_l_name.Appearance.Options.UseFont = true;
            this.lbl_l_name.Location = new System.Drawing.Point(448, 59);
            this.lbl_l_name.Name = "lbl_l_name";
            this.lbl_l_name.Size = new System.Drawing.Size(32, 22);
            this.lbl_l_name.TabIndex = 73;
            this.lbl_l_name.Text = "اللقب";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(410, 59);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(5, 22);
            this.labelControl8.TabIndex = 74;
            this.labelControl8.Text = ".";
            // 
            // frm_add_lect_mark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 413);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.lbl_l_name);
            this.Controls.Add(this.com_matrial);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txt_mark_value);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.com_stud);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.com_group);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.com_lect);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_add_lect_mark";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
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
        public System.Windows.Forms.ComboBox com_lect;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public System.Windows.Forms.ComboBox com_group;
        public System.Windows.Forms.ComboBox com_stud;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        public Bunifu.UI.WinForms.BunifuTextBox txt_mark_value;
        public System.Windows.Forms.ComboBox com_matrial;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lbl_l_name;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}