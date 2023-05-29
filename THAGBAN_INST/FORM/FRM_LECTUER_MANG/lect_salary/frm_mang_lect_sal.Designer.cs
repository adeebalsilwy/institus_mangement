using THAGBAN_INST.DATA;

namespace THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_salary
{
    partial class frm_mang_lect_sal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mang_lect_sal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLECT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSEND_TECH_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSEND_STUD_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPAID_UP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTBL_EMPLOYEES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ch_lect = new DevExpress.XtraEditors.CheckEdit();
            this.ch_grou = new DevExpress.XtraEditors.CheckEdit();
            this.com_lect = new System.Windows.Forms.ComboBox();
            this.com_group = new System.Windows.Forms.ComboBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edite = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ch_lect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_grou.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
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
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 493);
            this.panel2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gridControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(925, 418);
            this.panel4.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(THAGBAN_INST.DATA.TBL_SEND_TECT_LECT);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(925, 418);
            this.gridControl1.TabIndex = 11;
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
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView2.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView2.Appearance.OddRow.Options.UseFont = true;
            this.gridView2.Appearance.Row.Options.UseTextOptions = true;
            this.gridView2.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView2.Appearance.ViewCaption.Font = new System.Drawing.Font("ae_AlArabiya", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLECT_ID,
            this.colSEND_TECH_DATE,
            this.colSEND_STUD_ID,
            this.colREST,
            this.colPAID_UP,
            this.colTBL_EMPLOYEES});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridView2.OptionsPrint.ExpandAllDetails = true;
            this.gridView2.OptionsPrint.PrintDetails = true;
            this.gridView2.OptionsPrint.PrintFilterInfo = true;
            this.gridView2.OptionsPrint.PrintPreview = true;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView2_SelectionChanged_1);
            // 
            // colLECT_ID
            // 
            this.colLECT_ID.Caption = "الدوره";
            this.colLECT_ID.FieldName = "TBL_LECTUER.LECT_NAME";
            this.colLECT_ID.Name = "colLECT_ID";
            this.colLECT_ID.Visible = true;
            this.colLECT_ID.VisibleIndex = 2;
            this.colLECT_ID.Width = 160;
            // 
            // colSEND_TECH_DATE
            // 
            this.colSEND_TECH_DATE.Caption = "تاريخ الدفع";
            this.colSEND_TECH_DATE.FieldName = "SEND_TECH_DATE";
            this.colSEND_TECH_DATE.Name = "colSEND_TECH_DATE";
            this.colSEND_TECH_DATE.Visible = true;
            this.colSEND_TECH_DATE.VisibleIndex = 5;
            this.colSEND_TECH_DATE.Width = 71;
            // 
            // colSEND_STUD_ID
            // 
            this.colSEND_STUD_ID.Caption = "التسلسل";
            this.colSEND_STUD_ID.FieldName = "SEND_STUD_ID";
            this.colSEND_STUD_ID.Name = "colSEND_STUD_ID";
            this.colSEND_STUD_ID.Visible = true;
            this.colSEND_STUD_ID.VisibleIndex = 0;
            this.colSEND_STUD_ID.Width = 89;
            // 
            // colREST
            // 
            this.colREST.Caption = "المتبقي";
            this.colREST.FieldName = "REST";
            this.colREST.Name = "colREST";
            this.colREST.Visible = true;
            this.colREST.VisibleIndex = 4;
            this.colREST.Width = 95;
            // 
            // colPAID_UP
            // 
            this.colPAID_UP.Caption = "المدفوع";
            this.colPAID_UP.FieldName = "PAID_UP";
            this.colPAID_UP.Name = "colPAID_UP";
            this.colPAID_UP.Visible = true;
            this.colPAID_UP.VisibleIndex = 3;
            this.colPAID_UP.Width = 118;
            // 
            // colTBL_EMPLOYEES
            // 
            this.colTBL_EMPLOYEES.Caption = "اسم المدرس";
            this.colTBL_EMPLOYEES.FieldName = "TBL_EMPLOYEES.EMP_NAME";
            this.colTBL_EMPLOYEES.Name = "colTBL_EMPLOYEES";
            this.colTBL_EMPLOYEES.Visible = true;
            this.colTBL_EMPLOYEES.VisibleIndex = 1;
            this.colTBL_EMPLOYEES.Width = 200;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ch_lect);
            this.panel3.Controls.Add(this.ch_grou);
            this.panel3.Controls.Add(this.com_lect);
            this.panel3.Controls.Add(this.com_group);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(925, 75);
            this.panel3.TabIndex = 0;
            // 
            // ch_lect
            // 
            this.ch_lect.Location = new System.Drawing.Point(736, 23);
            this.ch_lect.Name = "ch_lect";
            this.ch_lect.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_lect.Properties.Appearance.Options.UseFont = true;
            this.ch_lect.Properties.Caption = "اختيار الدوره ";
            this.ch_lect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ch_lect.Size = new System.Drawing.Size(149, 28);
            this.ch_lect.TabIndex = 135;
            this.ch_lect.CheckedChanged += new System.EventHandler(this.ch_lect_CheckedChanged);
            // 
            // ch_grou
            // 
            this.ch_grou.Location = new System.Drawing.Point(362, 23);
            this.ch_grou.Name = "ch_grou";
            this.ch_grou.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_grou.Properties.Appearance.Options.UseFont = true;
            this.ch_grou.Properties.Caption = "اختيار اسم الدفعه";
            this.ch_grou.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ch_grou.Size = new System.Drawing.Size(149, 28);
            this.ch_grou.TabIndex = 134;
            this.ch_grou.CheckedChanged += new System.EventHandler(this.ch_grou_CheckedChanged);
            // 
            // com_lect
            // 
            this.com_lect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_lect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_lect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_lect.Font = new System.Drawing.Font("ae_AlArabiya", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_lect.FormattingEnabled = true;
            this.com_lect.Location = new System.Drawing.Point(534, 18);
            this.com_lect.Name = "com_lect";
            this.com_lect.Size = new System.Drawing.Size(185, 41);
            this.com_lect.TabIndex = 120;
            this.com_lect.SelectedIndexChanged += new System.EventHandler(this.com_lect_SelectedIndexChanged);
            this.com_lect.SelectionChangeCommitted += new System.EventHandler(this.com_lect_SelectionChangeCommitted);
            this.com_lect.SelectedValueChanged += new System.EventHandler(this.com_lect_SelectionChangeCommitted);
            // 
            // com_group
            // 
            this.com_group.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_group.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_group.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_group.Font = new System.Drawing.Font("ae_AlArabiya", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_group.FormattingEnabled = true;
            this.com_group.Location = new System.Drawing.Point(184, 18);
            this.com_group.Name = "com_group";
            this.com_group.Size = new System.Drawing.Size(132, 41);
            this.com_group.TabIndex = 119;
            this.com_group.SelectionChangeCommitted += new System.EventHandler(this.com_group_SelectionChangeCommitted);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.btn_delete);
            this.panelControl1.Controls.Add(this.btn_edite);
            this.panelControl1.Controls.Add(this.btn_save);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 493);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(925, 55);
            this.panelControl1.TabIndex = 8;
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
            this.simpleButton2.Location = new System.Drawing.Point(71, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton2.Size = new System.Drawing.Size(101, 50);
            this.simpleButton2.TabIndex = 42;
            this.simpleButton2.Text = "طباعه";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
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
            this.simpleButton1.Location = new System.Drawing.Point(215, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton1.Size = new System.Drawing.Size(101, 50);
            this.simpleButton1.TabIndex = 41;
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
            this.btn_delete.Location = new System.Drawing.Point(345, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_delete.Size = new System.Drawing.Size(101, 50);
            this.btn_delete.TabIndex = 40;
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
            this.btn_edite.Location = new System.Drawing.Point(495, 2);
            this.btn_edite.Name = "btn_edite";
            this.btn_edite.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_edite.Size = new System.Drawing.Size(101, 50);
            this.btn_edite.TabIndex = 39;
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
            this.btn_save.Location = new System.Drawing.Point(609, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btn_save.Size = new System.Drawing.Size(101, 50);
            this.btn_save.TabIndex = 38;
            this.btn_save.Text = "اضافة";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // frm_mang_lect_sal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "frm_mang_lect_sal";
            this.Size = new System.Drawing.Size(925, 548);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ch_lect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_grou.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_edite;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colLECT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSEND_TECH_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colSEND_STUD_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colREST;
        private DevExpress.XtraGrid.Columns.GridColumn colPAID_UP;
        private DevExpress.XtraGrid.Columns.GridColumn colTBL_EMPLOYEES;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ComboBox com_lect;
        public System.Windows.Forms.ComboBox com_group;
        private DevExpress.XtraEditors.CheckEdit ch_lect;
        private DevExpress.XtraEditors.CheckEdit ch_grou;
    }
}
