using THAGBAN_INST.DATA;

namespace THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_stud
{
    partial class frm_mang_lect_tech
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mang_lect_tech));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCOURS_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGROUP_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLECT_END_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLECT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLECT_START_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLECT_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTECH_LECT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTECHER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTECHER_SALARY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTECH_LECT_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edite = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 478);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(THAGBAN_INST.DATA.TBL_LECT_TECH_COURS);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(925, 478);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView2.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView2.Appearance.EvenRow.Options.UseFont = true;
            this.gridView2.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.GroupRow.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView2.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView2.Appearance.OddRow.Options.UseFont = true;
            this.gridView2.Appearance.ViewCaption.Font = new System.Drawing.Font("ae_AlArabiya", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOURS_ID,
            this.colGROUP_NAME,
            this.colLECT_END_DATE,
            this.colLECT_ID,
            this.colLECT_START_DATE,
            this.colLECT_TIME,
            this.colTECH_LECT_ID,
            this.colTECHER_ID,
            this.colTECHER_SALARY,
            this.colTECH_LECT_ID1});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.RowAutoHeight = true;
            this.gridView2.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView2_RowClick);
            this.gridView2.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView2_RowCellClick);
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            this.gridView2.Click += new System.EventHandler(this.gridView2_Click);
            // 
            // colCOURS_ID
            // 
            this.colCOURS_ID.Caption = "الكورس";
            this.colCOURS_ID.FieldName = "TBL_LECTUER.TBL_LECT_COURS.LECT_COURS_NAME";
            this.colCOURS_ID.Name = "colCOURS_ID";
            this.colCOURS_ID.Visible = true;
            this.colCOURS_ID.VisibleIndex = 2;
            this.colCOURS_ID.Width = 92;
            // 
            // colGROUP_NAME
            // 
            this.colGROUP_NAME.Caption = "اسم الدفعه";
            this.colGROUP_NAME.FieldName = "GROUP_NAME";
            this.colGROUP_NAME.Name = "colGROUP_NAME";
            this.colGROUP_NAME.Visible = true;
            this.colGROUP_NAME.VisibleIndex = 3;
            this.colGROUP_NAME.Width = 84;
            // 
            // colLECT_END_DATE
            // 
            this.colLECT_END_DATE.Caption = "تاريخ الانتهاء";
            this.colLECT_END_DATE.FieldName = "LECT_END_DATE";
            this.colLECT_END_DATE.Name = "colLECT_END_DATE";
            this.colLECT_END_DATE.Visible = true;
            this.colLECT_END_DATE.VisibleIndex = 8;
            this.colLECT_END_DATE.Width = 114;
            // 
            // colLECT_ID
            // 
            this.colLECT_ID.Caption = "الدوره";
            this.colLECT_ID.FieldName = "TBL_LECTUER.LECT_NAME";
            this.colLECT_ID.Name = "colLECT_ID";
            this.colLECT_ID.Visible = true;
            this.colLECT_ID.VisibleIndex = 1;
            this.colLECT_ID.Width = 101;
            // 
            // colLECT_START_DATE
            // 
            this.colLECT_START_DATE.Caption = "تاريخ البدايه";
            this.colLECT_START_DATE.FieldName = "LECT_START_DATE";
            this.colLECT_START_DATE.Name = "colLECT_START_DATE";
            this.colLECT_START_DATE.Visible = true;
            this.colLECT_START_DATE.VisibleIndex = 7;
            this.colLECT_START_DATE.Width = 84;
            // 
            // colLECT_TIME
            // 
            this.colLECT_TIME.Caption = "وقت الدوره";
            this.colLECT_TIME.FieldName = "LECT_TIME";
            this.colLECT_TIME.Name = "colLECT_TIME";
            this.colLECT_TIME.Visible = true;
            this.colLECT_TIME.VisibleIndex = 6;
            this.colLECT_TIME.Width = 84;
            // 
            // colTECH_LECT_ID
            // 
            this.colTECH_LECT_ID.Caption = "التسلسل";
            this.colTECH_LECT_ID.FieldName = "TECH_LECT_ID";
            this.colTECH_LECT_ID.Name = "colTECH_LECT_ID";
            this.colTECH_LECT_ID.Visible = true;
            this.colTECH_LECT_ID.VisibleIndex = 0;
            this.colTECH_LECT_ID.Width = 70;
            // 
            // colTECHER_ID
            // 
            this.colTECHER_ID.Caption = "المدرس";
            this.colTECHER_ID.FieldName = "TBL_EMPLOYEES.EMP_NAME";
            this.colTECHER_ID.Name = "colTECHER_ID";
            this.colTECHER_ID.Visible = true;
            this.colTECHER_ID.VisibleIndex = 4;
            this.colTECHER_ID.Width = 127;
            // 
            // colTECHER_SALARY
            // 
            this.colTECHER_SALARY.Caption = "راتب الدوره";
            this.colTECHER_SALARY.FieldName = "TECHER_SALARY";
            this.colTECHER_SALARY.Name = "colTECHER_SALARY";
            this.colTECHER_SALARY.Visible = true;
            this.colTECHER_SALARY.VisibleIndex = 5;
            this.colTECHER_SALARY.Width = 85;
            // 
            // colTECH_LECT_ID1
            // 
            this.colTECH_LECT_ID1.Caption = "الحاله";
            this.colTECH_LECT_ID1.FieldName = "STATE";
            this.colTECH_LECT_ID1.Name = "colTECH_LECT_ID1";
            this.colTECH_LECT_ID1.Visible = true;
            this.colTECH_LECT_ID1.VisibleIndex = 9;
            this.colTECH_LECT_ID1.Width = 66;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton4);
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.btn_delete);
            this.panelControl1.Controls.Add(this.btn_edite);
            this.panelControl1.Controls.Add(this.btn_save);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 478);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(925, 70);
            this.panelControl1.TabIndex = 8;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // simpleButton4
            // 
            this.simpleButton4.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.simpleButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseBorderColor = true;
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(141, 10);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton4.Size = new System.Drawing.Size(101, 50);
            this.simpleButton4.TabIndex = 40;
            this.simpleButton4.Text = "فتح";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.simpleButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseBorderColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(273, 10);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton3.Size = new System.Drawing.Size(101, 50);
            this.simpleButton3.TabIndex = 39;
            this.simpleButton3.Text = "اغلاق";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(5, 10);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton2.Size = new System.Drawing.Size(101, 50);
            this.simpleButton2.TabIndex = 38;
            this.simpleButton2.Text = "طباعه";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(398, 10);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton1.Size = new System.Drawing.Size(101, 50);
            this.simpleButton1.TabIndex = 37;
            this.simpleButton1.Text = "تحديث";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseBorderColor = true;
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.Location = new System.Drawing.Point(516, 10);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_delete.Size = new System.Drawing.Size(101, 50);
            this.btn_delete.TabIndex = 35;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edite
            // 
            this.btn_edite.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.btn_edite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_edite.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edite.Appearance.Options.UseBorderColor = true;
            this.btn_edite.Appearance.Options.UseFont = true;
            this.btn_edite.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_edite.ImageOptions.Image")));
            this.btn_edite.Location = new System.Drawing.Point(633, 10);
            this.btn_edite.Name = "btn_edite";
            this.btn_edite.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_edite.Size = new System.Drawing.Size(101, 50);
            this.btn_edite.TabIndex = 34;
            this.btn_edite.Text = "تعديل";
            this.btn_edite.Click += new System.EventHandler(this.btn_edite_Click);
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseBorderColor = true;
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageOptions.Image")));
            this.btn_save.Location = new System.Drawing.Point(753, 10);
            this.btn_save.Name = "btn_save";
            this.btn_save.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_save.Size = new System.Drawing.Size(101, 50);
            this.btn_save.TabIndex = 33;
            this.btn_save.Text = "اضافة";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "اسم الطالب";
            this.gridColumn1.FieldName = "TBL_STUDENTS.STUD_NAME";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 163;
            // 
            // frm_mang_lect_tech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "frm_mang_lect_tech";
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
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_edite;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.Columns.GridColumn colCOURS_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colGROUP_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colLECT_END_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colLECT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colLECT_START_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colLECT_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colTECH_LECT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colTECHER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colTECHER_SALARY;
        private DevExpress.XtraGrid.Columns.GridColumn colTECH_LECT_ID1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
    }
}
