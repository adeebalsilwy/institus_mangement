namespace THAGBAN_INST.FORM.FRM_LECTUER_MANG.matrial
{
    partial class frm_add_matrial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_matrial));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.com_com_cours = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.com_lect = new System.Windows.Forms.ComboBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_matrial_name = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // com_com_cours
            // 
            this.com_com_cours.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_com_cours.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_com_cours.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_com_cours.Font = new System.Drawing.Font("ae_AlArabiya", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_com_cours.FormattingEnabled = true;
            this.com_com_cours.Location = new System.Drawing.Point(29, 59);
            this.com_com_cours.Name = "com_com_cours";
            this.com_com_cours.Size = new System.Drawing.Size(247, 41);
            this.com_com_cours.TabIndex = 59;
            this.com_com_cours.SelectedIndexChanged += new System.EventHandler(this.com_spiacl_SelectedIndexChanged);
            this.com_com_cours.SelectionChangeCommitted += new System.EventHandler(this.com_spiacl_SelectionChangeCommitted);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(282, 70);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 22);
            this.labelControl4.TabIndex = 58;
            this.labelControl4.Text = "اسم الكورس";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(296, 134);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 19);
            this.labelControl3.TabIndex = 57;
            this.labelControl3.Text = "اسم الدوره";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(297, 215);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 19);
            this.labelControl2.TabIndex = 54;
            this.labelControl2.Text = "اسم الماده";
            // 
            // com_lect
            // 
            this.com_lect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_lect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_lect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_lect.Font = new System.Drawing.Font("ae_AlArabiya", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_lect.FormattingEnabled = true;
            this.com_lect.Location = new System.Drawing.Point(29, 121);
            this.com_lect.Name = "com_lect";
            this.com_lect.Size = new System.Drawing.Size(247, 41);
            this.com_lect.TabIndex = 60;
            this.com_lect.SelectionChangeCommitted += new System.EventHandler(this.com_term_year_SelectionChangeCommitted);
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
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 269);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(371, 62);
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
            this.btn_save.Size = new System.Drawing.Size(90, 43);
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
            this.bunifuPanel2.Size = new System.Drawing.Size(371, 53);
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
            this.labelControl1.Location = new System.Drawing.Point(99, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(210, 26);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "شاشه اضافه وتعديل المواد ";
            // 
            // txt_matrial_name
            // 
            this.txt_matrial_name.AcceptsReturn = false;
            this.txt_matrial_name.AcceptsTab = false;
            this.txt_matrial_name.AnimationSpeed = 200;
            this.txt_matrial_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_matrial_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_matrial_name.BackColor = System.Drawing.Color.Transparent;
            this.txt_matrial_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_matrial_name.BackgroundImage")));
            this.txt_matrial_name.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_matrial_name.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_matrial_name.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_matrial_name.BorderColorIdle = System.Drawing.Color.Black;
            this.txt_matrial_name.BorderRadius = 8;
            this.txt_matrial_name.BorderThickness = 3;
            this.txt_matrial_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_matrial_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_matrial_name.DefaultFont = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_matrial_name.DefaultText = "";
            this.txt_matrial_name.FillColor = System.Drawing.Color.White;
            this.txt_matrial_name.HideSelection = true;
            this.txt_matrial_name.IconLeft = null;
            this.txt_matrial_name.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_matrial_name.IconPadding = 10;
            this.txt_matrial_name.IconRight = null;
            this.txt_matrial_name.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_matrial_name.Lines = new string[0];
            this.txt_matrial_name.Location = new System.Drawing.Point(29, 195);
            this.txt_matrial_name.MaxLength = 32767;
            this.txt_matrial_name.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_matrial_name.Modified = false;
            this.txt_matrial_name.Multiline = false;
            this.txt_matrial_name.Name = "txt_matrial_name";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_matrial_name.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_matrial_name.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_matrial_name.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Black;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_matrial_name.OnIdleState = stateProperties4;
            this.txt_matrial_name.Padding = new System.Windows.Forms.Padding(3);
            this.txt_matrial_name.PasswordChar = '\0';
            this.txt_matrial_name.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_matrial_name.PlaceholderText = "ادخل اسم الماده";
            this.txt_matrial_name.ReadOnly = false;
            this.txt_matrial_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_matrial_name.SelectedText = "";
            this.txt_matrial_name.SelectionLength = 0;
            this.txt_matrial_name.SelectionStart = 0;
            this.txt_matrial_name.ShortcutsEnabled = true;
            this.txt_matrial_name.Size = new System.Drawing.Size(247, 54);
            this.txt_matrial_name.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_matrial_name.TabIndex = 61;
            this.txt_matrial_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_matrial_name.TextMarginBottom = 0;
            this.txt_matrial_name.TextMarginLeft = 3;
            this.txt_matrial_name.TextMarginTop = 0;
            this.txt_matrial_name.TextPlaceholder = "ادخل اسم الماده";
            this.txt_matrial_name.UseSystemPasswordChar = false;
            this.txt_matrial_name.WordWrap = true;
            // 
            // frm_add_matrial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 331);
            this.Controls.Add(this.txt_matrial_name);
            this.Controls.Add(this.com_lect);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.com_com_cours);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_add_matrial";
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
        public System.Windows.Forms.ComboBox com_com_cours;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public System.Windows.Forms.ComboBox com_lect;
        public Bunifu.UI.WinForms.BunifuTextBox txt_matrial_name;
    }
}