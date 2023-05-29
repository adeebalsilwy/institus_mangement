using THAGBAN_INST.DATA;

namespace THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_mark
{
    partial class frm_mang_lect_marks
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mang_lect_marks));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMARK_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTUD_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTUD_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOURS_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLECT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLECT_TECH_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLECT_TECH_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATRIAL_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMARK_VALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edite = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.com_group = new System.Windows.Forms.ComboBox();
            this.com_lect = new System.Windows.Forms.ComboBox();
            this.ch_grou = new DevExpress.XtraEditors.CheckEdit();
            this.ch_lect = new DevExpress.XtraEditors.CheckEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ch_grou.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_lect.Properties)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 478);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gridControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(925, 409);
            this.panel4.TabIndex = 10;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(THAGBAN_INST.DATA.TBL_LECT_MARK);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(925, 409);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click_1);
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
            this.colMARK_ID,
            this.colSTUD_ID,
            this.colSTUD_ID1,
            this.colCOURS_ID,
            this.colLECT_ID,
            this.colLECT_TECH_ID1,
            this.colLECT_TECH_ID,
            this.colMATRIAL_ID,
            this.colMARK_VALUE});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.RowAutoHeight = true;
            this.gridView2.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView2_SelectionChanged);
            // 
            // colMARK_ID
            // 
            this.colMARK_ID.Caption = "التسلسل";
            this.colMARK_ID.FieldName = "MARK_ID";
            this.colMARK_ID.Name = "colMARK_ID";
            this.colMARK_ID.Visible = true;
            this.colMARK_ID.VisibleIndex = 0;
            this.colMARK_ID.Width = 69;
            // 
            // colSTUD_ID
            // 
            this.colSTUD_ID.Caption = "اسم الطالب";
            this.colSTUD_ID.FieldName = "TBL_STUDENTS.STUD_NAME";
            this.colSTUD_ID.Name = "colSTUD_ID";
            this.colSTUD_ID.Visible = true;
            this.colSTUD_ID.VisibleIndex = 1;
            this.colSTUD_ID.Width = 143;
            // 
            // colSTUD_ID1
            // 
            this.colSTUD_ID1.Caption = "اللقب";
            this.colSTUD_ID1.FieldName = "TBL_STUDENTS.STUD_LNAME";
            this.colSTUD_ID1.Name = "colSTUD_ID1";
            this.colSTUD_ID1.Visible = true;
            this.colSTUD_ID1.VisibleIndex = 2;
            this.colSTUD_ID1.Width = 73;
            // 
            // colCOURS_ID
            // 
            this.colCOURS_ID.Caption = "الكورس";
            this.colCOURS_ID.FieldName = "TBL_LECT_COURS.LECT_COURS_NAME";
            this.colCOURS_ID.Name = "colCOURS_ID";
            this.colCOURS_ID.Visible = true;
            this.colCOURS_ID.VisibleIndex = 3;
            this.colCOURS_ID.Width = 137;
            // 
            // colLECT_ID
            // 
            this.colLECT_ID.Caption = "الدوره";
            this.colLECT_ID.FieldName = "TBL_LECTUER.LECT_NAME";
            this.colLECT_ID.Name = "colLECT_ID";
            this.colLECT_ID.Visible = true;
            this.colLECT_ID.VisibleIndex = 4;
            this.colLECT_ID.Width = 104;
            // 
            // colLECT_TECH_ID1
            // 
            this.colLECT_TECH_ID1.Caption = "اسم الدفعه";
            this.colLECT_TECH_ID1.FieldName = "TBL_LECT_TECH_COURS.GROUP_NAME";
            this.colLECT_TECH_ID1.Name = "colLECT_TECH_ID1";
            this.colLECT_TECH_ID1.Visible = true;
            this.colLECT_TECH_ID1.VisibleIndex = 6;
            this.colLECT_TECH_ID1.Width = 81;
            // 
            // colLECT_TECH_ID
            // 
            this.colLECT_TECH_ID.Caption = "المدرس";
            this.colLECT_TECH_ID.FieldName = "TBL_LECT_TECH_COURS.TBL_EMPLOYEES.EMP_NAME";
            this.colLECT_TECH_ID.Name = "colLECT_TECH_ID";
            this.colLECT_TECH_ID.Visible = true;
            this.colLECT_TECH_ID.VisibleIndex = 5;
            this.colLECT_TECH_ID.Width = 114;
            // 
            // colMATRIAL_ID
            // 
            this.colMATRIAL_ID.Caption = "الماده";
            this.colMATRIAL_ID.FieldName = "TBL_LECT_MATRIAL.MATRIAL_LECT_NAME";
            this.colMATRIAL_ID.Name = "colMATRIAL_ID";
            this.colMATRIAL_ID.Visible = true;
            this.colMATRIAL_ID.VisibleIndex = 7;
            this.colMATRIAL_ID.Width = 117;
            // 
            // colMARK_VALUE
            // 
            this.colMARK_VALUE.Caption = "الدرجه";
            this.colMARK_VALUE.FieldName = "MARK_VALUE";
            this.colMARK_VALUE.Name = "colMARK_VALUE";
            this.colMARK_VALUE.Visible = true;
            this.colMARK_VALUE.VisibleIndex = 8;
            this.colMARK_VALUE.Width = 69;
            // 
            // panelControl1
            // 
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
            // simpleButton2
            // 
            this.simpleButton2.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(101, 10);
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
            this.simpleButton1.Location = new System.Drawing.Point(255, 10);
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
            this.btn_delete.Location = new System.Drawing.Point(385, 10);
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
            this.btn_edite.Location = new System.Drawing.Point(522, 10);
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
            this.btn_save.Location = new System.Drawing.Point(649, 10);
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
            this.com_group.SelectedIndexChanged += new System.EventHandler(this.com_group_SelectedIndexChanged);
            this.com_group.SelectionChangeCommitted += new System.EventHandler(this.com_group_SelectedIndexChanged);
            this.com_group.SelectedValueChanged += new System.EventHandler(this.com_group_SelectedIndexChanged);
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
            this.com_lect.SelectionChangeCommitted += new System.EventHandler(this.com_lect_SelectedIndexChanged);
            this.com_lect.SelectedValueChanged += new System.EventHandler(this.com_lect_SelectedIndexChanged);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.ch_lect);
            this.panel3.Controls.Add(this.ch_grou);
            this.panel3.Controls.Add(this.com_lect);
            this.panel3.Controls.Add(this.com_group);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(925, 69);
            this.panel3.TabIndex = 9;
            // 
            // frm_mang_lect_marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "frm_mang_lect_marks";
            this.Size = new System.Drawing.Size(925, 548);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ch_grou.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_lect.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMARK_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colCOURS_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colLECT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colLECT_TECH_ID1;
        private DevExpress.XtraGrid.Columns.GridColumn colLECT_TECH_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMATRIAL_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colMARK_VALUE;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.CheckEdit ch_lect;
        private DevExpress.XtraEditors.CheckEdit ch_grou;
        public System.Windows.Forms.ComboBox com_lect;
        public System.Windows.Forms.ComboBox com_group;
    }
}
