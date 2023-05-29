namespace THAGBAN_INST.FORM.FRM_LECTUER_MANG.students
{
    partial class frm_mang_stud
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mang_stud));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTUD_ADDRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTUD_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTUD_GENDER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTUD_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTUD_LNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTUD_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTUD_PHONE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTUD_STATE1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_export = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edite = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.colTBL_STUD_SPEC1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTBL_STUD_SPEC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTUD_STATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTUD_PHONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 548);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 484);
            this.panel2.TabIndex = 9;
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = typeof(THAGBAN_INST.DATA.TBL_STUDENTS);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(925, 484);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
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
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTUD_ADDRESS,
            this.colSTUD_DATE,
            this.colSTUD_GENDER,
            this.colSTUD_ID,
            this.colSTUD_LNAME,
            this.colSTUD_NAME,
            this.colSTUD_PHONE1,
            this.colSTUD_STATE1});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // colSTUD_ADDRESS
            // 
            this.colSTUD_ADDRESS.Caption = "العنوان ";
            this.colSTUD_ADDRESS.FieldName = "STUD_ADDRESS";
            this.colSTUD_ADDRESS.Name = "colSTUD_ADDRESS";
            this.colSTUD_ADDRESS.Visible = true;
            this.colSTUD_ADDRESS.VisibleIndex = 3;
            this.colSTUD_ADDRESS.Width = 109;
            // 
            // colSTUD_DATE
            // 
            this.colSTUD_DATE.Caption = "تاريخ الميلاد";
            this.colSTUD_DATE.FieldName = "STUD_DATE";
            this.colSTUD_DATE.Name = "colSTUD_DATE";
            this.colSTUD_DATE.Visible = true;
            this.colSTUD_DATE.VisibleIndex = 6;
            this.colSTUD_DATE.Width = 109;
            // 
            // colSTUD_GENDER
            // 
            this.colSTUD_GENDER.Caption = "الجنس";
            this.colSTUD_GENDER.FieldName = "STUD_GENDER";
            this.colSTUD_GENDER.Name = "colSTUD_GENDER";
            this.colSTUD_GENDER.Visible = true;
            this.colSTUD_GENDER.VisibleIndex = 4;
            this.colSTUD_GENDER.Width = 109;
            // 
            // colSTUD_ID
            // 
            this.colSTUD_ID.Caption = "التسلسل";
            this.colSTUD_ID.FieldName = "STUD_ID";
            this.colSTUD_ID.Name = "colSTUD_ID";
            this.colSTUD_ID.Visible = true;
            this.colSTUD_ID.VisibleIndex = 0;
            this.colSTUD_ID.Width = 97;
            // 
            // colSTUD_LNAME
            // 
            this.colSTUD_LNAME.Caption = "اللقب";
            this.colSTUD_LNAME.FieldName = "STUD_LNAME";
            this.colSTUD_LNAME.Name = "colSTUD_LNAME";
            this.colSTUD_LNAME.Visible = true;
            this.colSTUD_LNAME.VisibleIndex = 2;
            this.colSTUD_LNAME.Width = 109;
            // 
            // colSTUD_NAME
            // 
            this.colSTUD_NAME.Caption = "اسم الطالب";
            this.colSTUD_NAME.FieldName = "STUD_NAME";
            this.colSTUD_NAME.Name = "colSTUD_NAME";
            this.colSTUD_NAME.Visible = true;
            this.colSTUD_NAME.VisibleIndex = 1;
            this.colSTUD_NAME.Width = 147;
            // 
            // colSTUD_PHONE1
            // 
            this.colSTUD_PHONE1.Caption = "رقم الهاتف";
            this.colSTUD_PHONE1.FieldName = "STUD_PHONE";
            this.colSTUD_PHONE1.Name = "colSTUD_PHONE1";
            this.colSTUD_PHONE1.Visible = true;
            this.colSTUD_PHONE1.VisibleIndex = 5;
            this.colSTUD_PHONE1.Width = 109;
            // 
            // colSTUD_STATE1
            // 
            this.colSTUD_STATE1.Caption = "الحاله ";
            this.colSTUD_STATE1.FieldName = "STUD_STATE";
            this.colSTUD_STATE1.Name = "colSTUD_STATE1";
            this.colSTUD_STATE1.Visible = true;
            this.colSTUD_STATE1.VisibleIndex = 7;
            this.colSTUD_STATE1.Width = 118;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Black;
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.SlateGray;
            this.panelControl1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.Appearance.Options.UseFont = true;
            this.panelControl1.Appearance.Options.UseForeColor = true;
            this.panelControl1.Appearance.Options.UseTextOptions = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.CausesValidation = false;
            this.panelControl1.ContentImage = global::THAGBAN_INST.Properties.Resources.icons8_classroom_3;
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.btn_export);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.btn_delete);
            this.panelControl1.Controls.Add(this.btn_edite);
            this.panelControl1.Controls.Add(this.btn_save);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.FireScrollEventOnMouseWheel = true;
            this.panelControl1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.panelControl1.Location = new System.Drawing.Point(0, 484);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(925, 64);
            this.panelControl1.TabIndex = 8;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // simpleButton2
            // 
            this.simpleButton2.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(135, 9);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton2.Size = new System.Drawing.Size(102, 50);
            this.simpleButton2.TabIndex = 48;
            this.simpleButton2.Text = " استيراد ";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btn_export
            // 
            this.btn_export.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.btn_export.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_export.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_export.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.Appearance.Options.UseBackColor = true;
            this.btn_export.Appearance.Options.UseBorderColor = true;
            this.btn_export.Appearance.Options.UseFont = true;
            this.btn_export.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_export.ImageOptions.SvgImage")));
            this.btn_export.Location = new System.Drawing.Point(260, 9);
            this.btn_export.Name = "btn_export";
            this.btn_export.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_export.Size = new System.Drawing.Size(102, 50);
            this.btn_export.TabIndex = 47;
            this.btn_export.Text = "تصدير ";
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
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
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(382, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton1.Size = new System.Drawing.Size(101, 50);
            this.simpleButton1.TabIndex = 45;
            this.simpleButton1.Text = "تحديث";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseBackColor = true;
            this.btn_delete.Appearance.Options.UseBorderColor = true;
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.Location = new System.Drawing.Point(513, 9);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_delete.Size = new System.Drawing.Size(101, 50);
            this.btn_delete.TabIndex = 44;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edite
            // 
            this.btn_edite.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.btn_edite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_edite.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_edite.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edite.Appearance.Options.UseBackColor = true;
            this.btn_edite.Appearance.Options.UseBorderColor = true;
            this.btn_edite.Appearance.Options.UseFont = true;
            this.btn_edite.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edite.ImageOptions.Image")));
            this.btn_edite.Location = new System.Drawing.Point(638, 9);
            this.btn_edite.Name = "btn_edite";
            this.btn_edite.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_edite.Size = new System.Drawing.Size(101, 50);
            this.btn_edite.TabIndex = 43;
            this.btn_edite.Text = "تعديل";
            this.btn_edite.Click += new System.EventHandler(this.btn_edite_Click);
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_save.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_save.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_save.Appearance.Options.UseBackColor = true;
            this.btn_save.Appearance.Options.UseBorderColor = true;
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageOptions.Image")));
            this.btn_save.Location = new System.Drawing.Point(764, 9);
            this.btn_save.Name = "btn_save";
            this.btn_save.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_save.Size = new System.Drawing.Size(101, 50);
            this.btn_save.TabIndex = 42;
            this.btn_save.Text = "اضافة";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // colTBL_STUD_SPEC1
            // 
            this.colTBL_STUD_SPEC1.Caption = "تاريخ التسجيل ";
            this.colTBL_STUD_SPEC1.FieldName = "TBL_STUD_SPEC";
            this.colTBL_STUD_SPEC1.Name = "colTBL_STUD_SPEC1";
            this.colTBL_STUD_SPEC1.Width = 108;
            // 
            // colTBL_STUD_SPEC
            // 
            this.colTBL_STUD_SPEC.Caption = "التخصص";
            this.colTBL_STUD_SPEC.FieldName = "TBL_STUD_SPEC";
            this.colTBL_STUD_SPEC.Name = "colTBL_STUD_SPEC";
            this.colTBL_STUD_SPEC.Width = 88;
            // 
            // colSTUD_STATE
            // 
            this.colSTUD_STATE.Caption = "حاله الطالب";
            this.colSTUD_STATE.FieldName = "STUD_STATE";
            this.colSTUD_STATE.Name = "colSTUD_STATE";
            this.colSTUD_STATE.Width = 88;
            // 
            // colSTUD_PHONE
            // 
            this.colSTUD_PHONE.Caption = "الهاتف";
            this.colSTUD_PHONE.FieldName = "STUD_PHONE";
            this.colSTUD_PHONE.Name = "colSTUD_PHONE";
            this.colSTUD_PHONE.Width = 88;
            // 
            // frm_mang_stud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "frm_mang_stud";
            this.Size = new System.Drawing.Size(925, 548);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_edite;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraGrid.Columns.GridColumn colTBL_STUD_SPEC1;
        private DevExpress.XtraGrid.Columns.GridColumn colTBL_STUD_SPEC;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_STATE;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_PHONE;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_ADDRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_GENDER;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_LNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_PHONE1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_STATE1;
        private DevExpress.XtraEditors.SimpleButton btn_export;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}
