﻿namespace THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_students
{
    partial class frm_add_lect_stud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_add_lect_stud));
            this.com_com_cours = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.com_lect = new System.Windows.Forms.ComboBox();
            this.com_stud = new System.Windows.Forms.ComboBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.com_group = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_l_name = new DevExpress.XtraEditors.LabelControl();
            this.txt_lect_stud_date = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
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
            this.com_com_cours.Location = new System.Drawing.Point(10, 88);
            this.com_com_cours.Name = "com_com_cours";
            this.com_com_cours.Size = new System.Drawing.Size(247, 41);
            this.com_com_cours.TabIndex = 59;
            this.com_com_cours.SelectionChangeCommitted += new System.EventHandler(this.com_spiacl_SelectionChangeCommitted);
            this.com_com_cours.SelectedValueChanged += new System.EventHandler(this.com_spiacl_SelectionChangeCommitted);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(187, 59);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 22);
            this.labelControl4.TabIndex = 58;
            this.labelControl4.Text = "اسم الكورس";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(485, 145);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 19);
            this.labelControl3.TabIndex = 57;
            this.labelControl3.Text = "اسم الدوره";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(491, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 19);
            this.labelControl2.TabIndex = 54;
            this.labelControl2.Text = "اسم الطالب";
            // 
            // com_lect
            // 
            this.com_lect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_lect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_lect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_lect.Font = new System.Drawing.Font("ae_AlArabiya", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_lect.FormattingEnabled = true;
            this.com_lect.Location = new System.Drawing.Point(286, 170);
            this.com_lect.Name = "com_lect";
            this.com_lect.Size = new System.Drawing.Size(247, 41);
            this.com_lect.TabIndex = 60;
            this.com_lect.SelectedIndexChanged += new System.EventHandler(this.com_lect_SelectedIndexChanged);
            this.com_lect.SelectionChangeCommitted += new System.EventHandler(this.com_term_year_SelectionChangeCommitted);
            this.com_lect.SelectedValueChanged += new System.EventHandler(this.com_term_year_SelectionChangeCommitted);
            // 
            // com_stud
            // 
            this.com_stud.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_stud.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_stud.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_stud.Font = new System.Drawing.Font("ae_AlArabiya", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_stud.FormattingEnabled = true;
            this.com_stud.Location = new System.Drawing.Point(286, 88);
            this.com_stud.Name = "com_stud";
            this.com_stud.Size = new System.Drawing.Size(247, 41);
            this.com_stud.TabIndex = 61;
            this.com_stud.SelectionChangeCommitted += new System.EventHandler(this.com_stud_SelectionChangeCommitted);
            this.com_stud.SelectedValueChanged += new System.EventHandler(this.com_stud_SelectionChangeCommitted);
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
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 312);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(555, 62);
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
            this.btn_save.Size = new System.Drawing.Size(274, 43);
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
            this.bunifuPanel2.Size = new System.Drawing.Size(555, 53);
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
            this.labelControl1.Location = new System.Drawing.Point(163, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(272, 26);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "شاشه اضافه وتعديل دورات الطلاب ";
            // 
            // com_group
            // 
            this.com_group.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_group.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_group.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_group.Font = new System.Drawing.Font("ae_AlArabiya", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_group.FormattingEnabled = true;
            this.com_group.Location = new System.Drawing.Point(10, 170);
            this.com_group.Name = "com_group";
            this.com_group.Size = new System.Drawing.Size(247, 41);
            this.com_group.TabIndex = 90;
            this.com_group.SelectedIndexChanged += new System.EventHandler(this.com_group_SelectedIndexChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(206, 145);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(51, 19);
            this.labelControl5.TabIndex = 89;
            this.labelControl5.Text = "اسم الدفعه";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(420, 62);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(23, 19);
            this.labelControl6.TabIndex = 91;
            this.labelControl6.Text = "اللقب";
            // 
            // lbl_l_name
            // 
            this.lbl_l_name.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_l_name.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbl_l_name.Appearance.Options.UseFont = true;
            this.lbl_l_name.Appearance.Options.UseForeColor = true;
            this.lbl_l_name.Location = new System.Drawing.Point(370, 61);
            this.lbl_l_name.Name = "lbl_l_name";
            this.lbl_l_name.Size = new System.Drawing.Size(4, 19);
            this.lbl_l_name.TabIndex = 92;
            this.lbl_l_name.Text = ".";
            // 
            // txt_lect_stud_date
            // 
            this.txt_lect_stud_date.BackColor = System.Drawing.Color.Transparent;
            this.txt_lect_stud_date.BorderRadius = 8;
            this.txt_lect_stud_date.Color = System.Drawing.Color.Silver;
            this.txt_lect_stud_date.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.txt_lect_stud_date.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.txt_lect_stud_date.DisabledColor = System.Drawing.Color.Gray;
            this.txt_lect_stud_date.DisplayWeekNumbers = false;
            this.txt_lect_stud_date.DPHeight = 0;
            this.txt_lect_stud_date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txt_lect_stud_date.FillDatePicker = false;
            this.txt_lect_stud_date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lect_stud_date.ForeColor = System.Drawing.Color.Black;
            this.txt_lect_stud_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_lect_stud_date.Icon = ((System.Drawing.Image)(resources.GetObject("txt_lect_stud_date.Icon")));
            this.txt_lect_stud_date.IconColor = System.Drawing.Color.Gray;
            this.txt_lect_stud_date.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.txt_lect_stud_date.LeftTextMargin = 5;
            this.txt_lect_stud_date.Location = new System.Drawing.Point(206, 252);
            this.txt_lect_stud_date.MinimumSize = new System.Drawing.Size(4, 32);
            this.txt_lect_stud_date.Name = "txt_lect_stud_date";
            this.txt_lect_stud_date.Size = new System.Drawing.Size(159, 32);
            this.txt_lect_stud_date.TabIndex = 94;
            this.txt_lect_stud_date.Value = new System.DateTime(2022, 12, 27, 2, 14, 19, 0);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(248, 227);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(62, 19);
            this.labelControl7.TabIndex = 95;
            this.labelControl7.Text = "تاريخ التسجيل";
            // 
            // frm_add_lect_stud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 374);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txt_lect_stud_date);
            this.Controls.Add(this.lbl_l_name);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.com_group);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.com_stud);
            this.Controls.Add(this.com_lect);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.com_com_cours);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_add_lect_stud";
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
        public System.Windows.Forms.ComboBox com_stud;
        public System.Windows.Forms.ComboBox com_group;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lbl_l_name;
        private Bunifu.UI.WinForms.BunifuDatePicker txt_lect_stud_date;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}