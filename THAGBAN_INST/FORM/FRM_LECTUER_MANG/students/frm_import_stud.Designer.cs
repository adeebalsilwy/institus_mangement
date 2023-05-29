using THAGBAN_INST.DATA;

namespace THAGBAN_INST.FORM.FRM_LECTUER_MANG.students
{
    partial class frm_import_stud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_import_stud));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ch_lect = new DevExpress.XtraEditors.CheckEdit();
            this.ch_grou = new DevExpress.XtraEditors.CheckEdit();
            this.com_group = new System.Windows.Forms.ComboBox();
            this.com_lect = new System.Windows.Forms.ComboBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_brows = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_path = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.excelDataSource2 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTUD_ADDRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTUD_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTUD_GENDER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTUD_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTUD_LNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTUD_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTUD_PHONE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTUD_STATE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ch_lect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_grou.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ch_lect);
            this.panel1.Controls.Add(this.ch_grou);
            this.panel1.Controls.Add(this.com_group);
            this.panel1.Controls.Add(this.com_lect);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btn_brows);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 51);
            this.panel1.TabIndex = 0;
            // 
            // ch_lect
            // 
            this.ch_lect.Location = new System.Drawing.Point(682, 15);
            this.ch_lect.Name = "ch_lect";
            this.ch_lect.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_lect.Properties.Appearance.Options.UseFont = true;
            this.ch_lect.Properties.Caption = "الدوره ";
            this.ch_lect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ch_lect.Size = new System.Drawing.Size(65, 20);
            this.ch_lect.TabIndex = 122;
            this.ch_lect.CheckedChanged += new System.EventHandler(this.ch_lect_CheckedChanged);
            // 
            // ch_grou
            // 
            this.ch_grou.Location = new System.Drawing.Point(402, 12);
            this.ch_grou.Name = "ch_grou";
            this.ch_grou.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_grou.Properties.Appearance.Options.UseFont = true;
            this.ch_grou.Properties.Caption = "الدفعه";
            this.ch_grou.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ch_grou.Size = new System.Drawing.Size(63, 20);
            this.ch_grou.TabIndex = 121;
            this.ch_grou.CheckedChanged += new System.EventHandler(this.ch_grou_CheckedChanged);
            // 
            // com_group
            // 
            this.com_group.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_group.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_group.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_group.Font = new System.Drawing.Font("ae_AlArabiya", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_group.FormattingEnabled = true;
            this.com_group.Location = new System.Drawing.Point(211, 4);
            this.com_group.Name = "com_group";
            this.com_group.Size = new System.Drawing.Size(185, 41);
            this.com_group.TabIndex = 92;
            this.com_group.SelectedIndexChanged += new System.EventHandler(this.com_group_SelectedIndexChanged);
            // 
            // com_lect
            // 
            this.com_lect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_lect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_lect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_lect.Font = new System.Drawing.Font("ae_AlArabiya", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_lect.FormattingEnabled = true;
            this.com_lect.Location = new System.Drawing.Point(483, 4);
            this.com_lect.Name = "com_lect";
            this.com_lect.Size = new System.Drawing.Size(193, 41);
            this.com_lect.TabIndex = 91;
            this.com_lect.SelectedIndexChanged += new System.EventHandler(this.com_lect_SelectedIndexChanged);
            this.com_lect.SelectionChangeCommitted += new System.EventHandler(this.com_lect_SelectedIndexChanged);
            this.com_lect.SelectedValueChanged += new System.EventHandler(this.com_lect_SelectedIndexChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(34, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton1.Size = new System.Drawing.Size(126, 38);
            this.simpleButton1.TabIndex = 47;
            this.simpleButton1.Text = "حفظ ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_brows
            // 
            this.btn_brows.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.btn_brows.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_brows.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_brows.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_brows.Appearance.Options.UseBackColor = true;
            this.btn_brows.Appearance.Options.UseBorderColor = true;
            this.btn_brows.Appearance.Options.UseFont = true;
            this.btn_brows.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_brows.ImageOptions.SvgImage")));
            this.btn_brows.Location = new System.Drawing.Point(753, 7);
            this.btn_brows.Name = "btn_brows";
            this.btn_brows.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_brows.Size = new System.Drawing.Size(154, 38);
            this.btn_brows.TabIndex = 46;
            this.btn_brows.Text = "تصفح الملفات";
            this.btn_brows.Click += new System.EventHandler(this.btn_brows_Click);
            // 
            // lbl_path
            // 
            this.lbl_path.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_path.Appearance.Options.UseFont = true;
            this.lbl_path.Location = new System.Drawing.Point(616, 20);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(100, 18);
            this.lbl_path.TabIndex = 48;
            this.lbl_path.Text = "labelControl1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_path);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 50);
            this.panel2.TabIndex = 1;
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.Name = "excelDataSource1";
            // 
            // excelDataSource2
            // 
            this.excelDataSource2.Name = "excelDataSource2";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.excelDataSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(919, 319);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView3,
            this.gridView1});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView2.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView2.Appearance.EvenRow.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("ae_AlArabiya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView2.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView2.Appearance.OddRow.Options.UseFont = true;
            this.gridView2.Appearance.ViewCaption.Font = new System.Drawing.Font("ae_AlArabiya", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView2_SelectionChanged);
            // 
            // gridView3
            // 
            this.gridView3.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView3.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView3.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView3.Appearance.EvenRow.Options.UseFont = true;
            this.gridView3.Appearance.HeaderPanel.Font = new System.Drawing.Font("ae_AlArabiya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView3.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView3.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView3.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView3.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView3.Appearance.OddRow.Options.UseFont = true;
            this.gridView3.Appearance.ViewCaption.Font = new System.Drawing.Font("ae_AlArabiya", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView3.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTUD_ADDRESS,
            this.colSTUD_DATE,
            this.colSTUD_GENDER,
            this.colSTUD_ID,
            this.colSTUD_LNAME,
            this.colSTUD_NAME,
            this.colSTUD_PHONE1,
            this.colSTUD_STATE1});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView3.OptionsView.EnableAppearanceOddRow = true;
            this.gridView3.OptionsView.ShowFooter = true;
            // 
            // colSTUD_ADDRESS
            // 
            this.colSTUD_ADDRESS.Caption = "العنوان ";
            this.colSTUD_ADDRESS.Name = "colSTUD_ADDRESS";
            this.colSTUD_ADDRESS.Visible = true;
            this.colSTUD_ADDRESS.VisibleIndex = 3;
            this.colSTUD_ADDRESS.Width = 109;
            // 
            // colSTUD_DATE
            // 
            this.colSTUD_DATE.Caption = "تاريخ الميلاد";
            this.colSTUD_DATE.Name = "colSTUD_DATE";
            this.colSTUD_DATE.Visible = true;
            this.colSTUD_DATE.VisibleIndex = 6;
            this.colSTUD_DATE.Width = 109;
            // 
            // colSTUD_GENDER
            // 
            this.colSTUD_GENDER.Caption = "الجنس";
            this.colSTUD_GENDER.Name = "colSTUD_GENDER";
            this.colSTUD_GENDER.Visible = true;
            this.colSTUD_GENDER.VisibleIndex = 4;
            this.colSTUD_GENDER.Width = 109;
            // 
            // colSTUD_ID
            // 
            this.colSTUD_ID.Caption = "التسلسل";
            this.colSTUD_ID.Name = "colSTUD_ID";
            this.colSTUD_ID.Visible = true;
            this.colSTUD_ID.VisibleIndex = 0;
            this.colSTUD_ID.Width = 97;
            // 
            // colSTUD_LNAME
            // 
            this.colSTUD_LNAME.Caption = "اللقب";
            this.colSTUD_LNAME.Name = "colSTUD_LNAME";
            this.colSTUD_LNAME.Visible = true;
            this.colSTUD_LNAME.VisibleIndex = 2;
            this.colSTUD_LNAME.Width = 109;
            // 
            // colSTUD_NAME
            // 
            this.colSTUD_NAME.Caption = "اسم الطالب";
            this.colSTUD_NAME.Name = "colSTUD_NAME";
            this.colSTUD_NAME.Visible = true;
            this.colSTUD_NAME.VisibleIndex = 1;
            this.colSTUD_NAME.Width = 147;
            // 
            // colSTUD_PHONE1
            // 
            this.colSTUD_PHONE1.Caption = "رقم الهاتف";
            this.colSTUD_PHONE1.Name = "colSTUD_PHONE1";
            this.colSTUD_PHONE1.Visible = true;
            this.colSTUD_PHONE1.VisibleIndex = 5;
            this.colSTUD_PHONE1.Width = 109;
            // 
            // colSTUD_STATE1
            // 
            this.colSTUD_STATE1.Caption = "الحاله ";
            this.colSTUD_STATE1.Name = "colSTUD_STATE1";
            this.colSTUD_STATE1.Visible = true;
            this.colSTUD_STATE1.VisibleIndex = 7;
            this.colSTUD_STATE1.Width = 118;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(919, 319);
            this.panel3.TabIndex = 2;
            // 
            // frm_import_stud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 420);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_import_stud";
            this.Text = "job_list";
            this.Activated += new System.EventHandler(this.frm_import_stud_Activated);
            this.Load += new System.EventHandler(this.job_list_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ch_lect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_grou.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lbl_path;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_brows;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_ADDRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_GENDER;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_LNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_PHONE1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_STATE1;
        public System.Windows.Forms.ComboBox com_group;
        public System.Windows.Forms.ComboBox com_lect;
        private DevExpress.XtraEditors.CheckEdit ch_lect;
        private DevExpress.XtraEditors.CheckEdit ch_grou;
    }
}