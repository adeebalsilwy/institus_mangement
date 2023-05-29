namespace THAGBAN_INST.FORM.FRM_EMP_MANEGER.attends
{
    partial class add_attends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_attends));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.com_emp_name = new System.Windows.Forms.ComboBox();
            this.btn_emp_list = new DevExpress.XtraEditors.SimpleButton();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_attends_date = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_get_emp = new System.Windows.Forms.NumericUpDown();
            this.txt_go_emp = new System.Windows.Forms.NumericUpDown();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_get_emp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_go_emp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 304);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 58);
            this.panel1.TabIndex = 73;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl11.LineVisible = true;
            this.labelControl11.Location = new System.Drawing.Point(273, 54);
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
            this.com_emp_name.Location = new System.Drawing.Point(103, 84);
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
            this.btn_emp_list.Location = new System.Drawing.Point(37, 84);
            this.btn_emp_list.Name = "btn_emp_list";
            this.btn_emp_list.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_emp_list.Size = new System.Drawing.Size(60, 41);
            this.btn_emp_list.TabIndex = 80;
            this.btn_emp_list.Click += new System.EventHandler(this.btn_emp_list_Click);
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
            this.bunifuPanel2.Size = new System.Drawing.Size(418, 44);
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
            this.labelControl1.Location = new System.Drawing.Point(108, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(170, 26);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "شاشه تحضير الموظفين";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "label1";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(126, 218);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(220, 19);
            this.labelControl5.TabIndex = 90;
            this.labelControl5.Text = "تاريخ  التحضير  (يتم اخذ تاريخ اليوم عند التحضير ) ";
            // 
            // txt_attends_date
            // 
            this.txt_attends_date.BackColor = System.Drawing.Color.Transparent;
            this.txt_attends_date.BorderRadius = 8;
            this.txt_attends_date.Color = System.Drawing.Color.Silver;
            this.txt_attends_date.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.txt_attends_date.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.txt_attends_date.DisabledColor = System.Drawing.Color.Gray;
            this.txt_attends_date.DisplayWeekNumbers = false;
            this.txt_attends_date.DPHeight = 0;
            this.txt_attends_date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txt_attends_date.FillDatePicker = false;
            this.txt_attends_date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_attends_date.ForeColor = System.Drawing.Color.Black;
            this.txt_attends_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_attends_date.Icon = ((System.Drawing.Image)(resources.GetObject("txt_attends_date.Icon")));
            this.txt_attends_date.IconColor = System.Drawing.Color.Gray;
            this.txt_attends_date.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.txt_attends_date.LeftTextMargin = 5;
            this.txt_attends_date.Location = new System.Drawing.Point(27, 243);
            this.txt_attends_date.MinimumSize = new System.Drawing.Size(4, 32);
            this.txt_attends_date.Name = "txt_attends_date";
            this.txt_attends_date.Size = new System.Drawing.Size(319, 32);
            this.txt_attends_date.TabIndex = 89;
            this.txt_attends_date.Value = new System.DateTime(2022, 12, 27, 2, 14, 19, 0);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(242, 141);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 19);
            this.labelControl3.TabIndex = 92;
            this.labelControl3.Text = "وقت حضور الموظف";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(80, 141);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 19);
            this.labelControl2.TabIndex = 94;
            this.labelControl2.Text = "وقت انصراف الموظف";
            // 
            // txt_get_emp
            // 
            this.txt_get_emp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_get_emp.Location = new System.Drawing.Point(226, 173);
            this.txt_get_emp.Name = "txt_get_emp";
            this.txt_get_emp.Size = new System.Drawing.Size(120, 30);
            this.txt_get_emp.TabIndex = 95;
            this.txt_get_emp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_go_emp
            // 
            this.txt_go_emp.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_go_emp.Location = new System.Drawing.Point(53, 173);
            this.txt_go_emp.Name = "txt_go_emp";
            this.txt_go_emp.Size = new System.Drawing.Size(120, 30);
            this.txt_go_emp.TabIndex = 97;
            this.txt_go_emp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.simpleButton1.Location = new System.Drawing.Point(12, 8);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton1.Size = new System.Drawing.Size(139, 43);
            this.simpleButton1.TabIndex = 77;
            this.simpleButton1.Text = "مسح";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
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
            this.btn_save.Location = new System.Drawing.Point(226, 8);
            this.btn_save.Name = "btn_save";
            this.btn_save.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_save.Size = new System.Drawing.Size(164, 43);
            this.btn_save.TabIndex = 76;
            this.btn_save.Text = "اضافة";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // add_attends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 362);
            this.Controls.Add(this.txt_go_emp);
            this.Controls.Add(this.txt_get_emp);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txt_attends_date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_emp_list);
            this.Controls.Add(this.com_emp_name);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_attends";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_add_emp";
            this.Load += new System.EventHandler(this.frm_add_emp_Load);
            this.panel1.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_get_emp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_go_emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        public System.Windows.Forms.ComboBox com_emp_name;
        public DevExpress.XtraEditors.SimpleButton btn_emp_list;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Bunifu.UI.WinForms.BunifuDatePicker txt_attends_date;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraEditors.SimpleButton btn_save;
        private System.Windows.Forms.NumericUpDown txt_get_emp;
        private System.Windows.Forms.NumericUpDown txt_go_emp;
    }
}