using THAGBAN_INST.DATA;

namespace THAGBAN_INST.FORM.FRM_LECTUER_MANG.reports
{
    partial class frm_mange_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mange_report));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSEND_STUD_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSEND_STUD_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPAID_UP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLECT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTUD_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTBL_LECTUER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTUD_LECT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTBL_STUD_LECT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ch_lect = new DevExpress.XtraEditors.CheckEdit();
            this.ch_grou = new DevExpress.XtraEditors.CheckEdit();
            this.ch_stud = new DevExpress.XtraEditors.CheckEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.com_lect = new System.Windows.Forms.ComboBox();
            this.lbl_lect = new DevExpress.XtraEditors.LabelControl();
            this.lbl_l_name = new DevExpress.XtraEditors.LabelControl();
            this.lbl_grou = new DevExpress.XtraEditors.LabelControl();
            this.com_stud = new System.Windows.Forms.ComboBox();
            this.com_group = new System.Windows.Forms.ComboBox();
            this.lbl_stud = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ch_lect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_grou.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_stud.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 548);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1040, 548);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 548);
            this.panel2.TabIndex = 9;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panel5);
            this.panelControl1.Controls.Add(this.panel4);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1040, 548);
            this.panelControl1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gridControl1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(2, 102);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1036, 444);
            this.panel5.TabIndex = 127;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(THAGBAN_INST.DATA.TBL_SEND_STUD_LECT);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(1036, 444);
            this.gridControl1.TabIndex = 126;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
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
            this.colSEND_STUD_DATE,
            this.colSEND_STUD_ID,
            this.colPAID_UP,
            this.colLECT_ID,
            this.colREST,
            this.colSTUD_ID,
            this.colTBL_LECTUER,
            this.colSTUD_LECT_ID,
            this.colTBL_STUD_LECT});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsPrint.AllowMultilineHeaders = true;
            this.gridView2.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridView2.OptionsPrint.ExpandAllDetails = true;
            this.gridView2.OptionsPrint.PrintDetails = true;
            this.gridView2.OptionsPrint.PrintFilterInfo = true;
            this.gridView2.OptionsPrint.PrintPreview = true;
            this.gridView2.OptionsPrint.ShowPrintExportProgress = false;
            this.gridView2.OptionsPrint.SplitDataCellAcrossPages = true;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colSEND_STUD_DATE
            // 
            this.colSEND_STUD_DATE.Caption = "تاريخ الدفع";
            this.colSEND_STUD_DATE.FieldName = "SEND_STUD_DATE";
            this.colSEND_STUD_DATE.Name = "colSEND_STUD_DATE";
            this.colSEND_STUD_DATE.Visible = true;
            this.colSEND_STUD_DATE.VisibleIndex = 8;
            this.colSEND_STUD_DATE.Width = 131;
            // 
            // colSEND_STUD_ID
            // 
            this.colSEND_STUD_ID.Caption = "التسلسل";
            this.colSEND_STUD_ID.FieldName = "SEND_STUD_ID";
            this.colSEND_STUD_ID.Name = "colSEND_STUD_ID";
            this.colSEND_STUD_ID.Visible = true;
            this.colSEND_STUD_ID.VisibleIndex = 0;
            this.colSEND_STUD_ID.Width = 74;
            // 
            // colPAID_UP
            // 
            this.colPAID_UP.Caption = "المدفوع";
            this.colPAID_UP.FieldName = "PAID_UP";
            this.colPAID_UP.Name = "colPAID_UP";
            this.colPAID_UP.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PAID_UP", "SUM={0:0.##}")});
            this.colPAID_UP.Visible = true;
            this.colPAID_UP.VisibleIndex = 6;
            this.colPAID_UP.Width = 130;
            // 
            // colLECT_ID
            // 
            this.colLECT_ID.Caption = "الدوره";
            this.colLECT_ID.FieldName = "TBL_STUD_LECT.TBL_LECTUER.LECT_NAME";
            this.colLECT_ID.Name = "colLECT_ID";
            this.colLECT_ID.Visible = true;
            this.colLECT_ID.VisibleIndex = 4;
            this.colLECT_ID.Width = 95;
            // 
            // colREST
            // 
            this.colREST.Caption = "المتبقي";
            this.colREST.FieldName = "REST";
            this.colREST.Name = "colREST";
            this.colREST.Visible = true;
            this.colREST.VisibleIndex = 7;
            this.colREST.Width = 135;
            // 
            // colSTUD_ID
            // 
            this.colSTUD_ID.Caption = "اسم الطالب";
            this.colSTUD_ID.FieldName = "TBL_STUDENTS.STUD_NAME";
            this.colSTUD_ID.Name = "colSTUD_ID";
            this.colSTUD_ID.Visible = true;
            this.colSTUD_ID.VisibleIndex = 1;
            this.colSTUD_ID.Width = 142;
            // 
            // colTBL_LECTUER
            // 
            this.colTBL_LECTUER.Caption = "الكورس";
            this.colTBL_LECTUER.FieldName = "TBL_STUD_LECT.TBL_LECTUER.TBL_LECT_COURS.LECT_COURS_NAME";
            this.colTBL_LECTUER.Name = "colTBL_LECTUER";
            this.colTBL_LECTUER.Visible = true;
            this.colTBL_LECTUER.VisibleIndex = 3;
            this.colTBL_LECTUER.Width = 98;
            // 
            // colSTUD_LECT_ID
            // 
            this.colSTUD_LECT_ID.Caption = "اللقب";
            this.colSTUD_LECT_ID.FieldName = "TBL_STUDENTS.STUD_LNAME";
            this.colSTUD_LECT_ID.Name = "colSTUD_LECT_ID";
            this.colSTUD_LECT_ID.Visible = true;
            this.colSTUD_LECT_ID.VisibleIndex = 2;
            this.colSTUD_LECT_ID.Width = 102;
            // 
            // colTBL_STUD_LECT
            // 
            this.colTBL_STUD_LECT.Caption = "الجروب ";
            this.colTBL_STUD_LECT.FieldName = "TBL_LECT_TECH_COURS.GROUP_NAME";
            this.colTBL_STUD_LECT.Name = "colTBL_STUD_LECT";
            this.colTBL_STUD_LECT.Visible = true;
            this.colTBL_STUD_LECT.VisibleIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ch_lect);
            this.panel4.Controls.Add(this.ch_grou);
            this.panel4.Controls.Add(this.ch_stud);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1036, 100);
            this.panel4.TabIndex = 126;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // ch_lect
            // 
            this.ch_lect.Location = new System.Drawing.Point(680, 0);
            this.ch_lect.Name = "ch_lect";
            this.ch_lect.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_lect.Properties.Appearance.Options.UseFont = true;
            this.ch_lect.Properties.Caption = "اختيار الدوره ";
            this.ch_lect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ch_lect.Size = new System.Drawing.Size(149, 28);
            this.ch_lect.TabIndex = 133;
            this.ch_lect.CheckedChanged += new System.EventHandler(this.ch_lect_CheckedChanged);
            // 
            // ch_grou
            // 
            this.ch_grou.Location = new System.Drawing.Point(476, 0);
            this.ch_grou.Name = "ch_grou";
            this.ch_grou.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_grou.Properties.Appearance.Options.UseFont = true;
            this.ch_grou.Properties.Caption = "اختيار اسم الدفعه";
            this.ch_grou.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ch_grou.Size = new System.Drawing.Size(149, 28);
            this.ch_grou.TabIndex = 132;
            this.ch_grou.CheckedChanged += new System.EventHandler(this.ch_grou_CheckedChanged);
            // 
            // ch_stud
            // 
            this.ch_stud.Location = new System.Drawing.Point(278, -2);
            this.ch_stud.Name = "ch_stud";
            this.ch_stud.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_stud.Properties.Appearance.Options.UseFont = true;
            this.ch_stud.Properties.Caption = "تحديد طالب محدد";
            this.ch_stud.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ch_stud.Size = new System.Drawing.Size(149, 28);
            this.ch_stud.TabIndex = 131;
            this.ch_stud.CheckedChanged += new System.EventHandler(this.ch_stud_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.com_lect);
            this.groupBox1.Controls.Add(this.lbl_lect);
            this.groupBox1.Controls.Add(this.lbl_l_name);
            this.groupBox1.Controls.Add(this.lbl_grou);
            this.groupBox1.Controls.Add(this.com_stud);
            this.groupBox1.Controls.Add(this.com_group);
            this.groupBox1.Controls.Add(this.lbl_stud);
            this.groupBox1.Location = new System.Drawing.Point(59, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 72);
            this.groupBox1.TabIndex = 130;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "كشف  حساب دوره ";
            // 
            // simpleButton2
            // 
            this.simpleButton2.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(121, 12);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton2.Size = new System.Drawing.Size(151, 50);
            this.simpleButton2.TabIndex = 118;
            this.simpleButton2.Text = "كشف حساب ";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_2);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(390, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 22);
            this.labelControl1.TabIndex = 119;
            this.labelControl1.Text = "اللقب";
            // 
            // com_lect
            // 
            this.com_lect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_lect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_lect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_lect.Font = new System.Drawing.Font("ae_AlArabiya", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_lect.FormattingEnabled = true;
            this.com_lect.Location = new System.Drawing.Point(711, 20);
            this.com_lect.Name = "com_lect";
            this.com_lect.Size = new System.Drawing.Size(185, 41);
            this.com_lect.TabIndex = 118;
            this.com_lect.SelectionChangeCommitted += new System.EventHandler(this.com_lect_SelectionChangeCommitted);
            this.com_lect.SelectedValueChanged += new System.EventHandler(this.com_lect_SelectionChangeCommitted);
            // 
            // lbl_lect
            // 
            this.lbl_lect.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lect.Appearance.Options.UseFont = true;
            this.lbl_lect.Location = new System.Drawing.Point(842, 4);
            this.lbl_lect.Name = "lbl_lect";
            this.lbl_lect.Size = new System.Drawing.Size(48, 19);
            this.lbl_lect.TabIndex = 117;
            this.lbl_lect.Text = "اسم الدوره";
            // 
            // lbl_l_name
            // 
            this.lbl_l_name.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_l_name.Appearance.Options.UseFont = true;
            this.lbl_l_name.Location = new System.Drawing.Point(331, 5);
            this.lbl_l_name.Name = "lbl_l_name";
            this.lbl_l_name.Size = new System.Drawing.Size(32, 22);
            this.lbl_l_name.TabIndex = 115;
            this.lbl_l_name.Text = "اللقب";
            // 
            // lbl_grou
            // 
            this.lbl_grou.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grou.Appearance.Options.UseFont = true;
            this.lbl_grou.Location = new System.Drawing.Point(628, 3);
            this.lbl_grou.Name = "lbl_grou";
            this.lbl_grou.Size = new System.Drawing.Size(51, 19);
            this.lbl_grou.TabIndex = 93;
            this.lbl_grou.Text = "اسم الدفعه";
            // 
            // com_stud
            // 
            this.com_stud.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_stud.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_stud.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_stud.Font = new System.Drawing.Font("ae_AlArabiya", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_stud.FormattingEnabled = true;
            this.com_stud.Location = new System.Drawing.Point(320, 25);
            this.com_stud.Name = "com_stud";
            this.com_stud.Size = new System.Drawing.Size(227, 34);
            this.com_stud.TabIndex = 114;
            this.com_stud.SelectionChangeCommitted += new System.EventHandler(this.com_stud_SelectionChangeCommitted);
            this.com_stud.SelectedValueChanged += new System.EventHandler(this.com_stud_SelectionChangeCommitted);
            // 
            // com_group
            // 
            this.com_group.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.com_group.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.com_group.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_group.Font = new System.Drawing.Font("ae_AlArabiya", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_group.FormattingEnabled = true;
            this.com_group.Location = new System.Drawing.Point(562, 22);
            this.com_group.Name = "com_group";
            this.com_group.Size = new System.Drawing.Size(132, 41);
            this.com_group.TabIndex = 94;
            this.com_group.SelectionChangeCommitted += new System.EventHandler(this.com_group_SelectionChangeCommitted);
            this.com_group.SelectedValueChanged += new System.EventHandler(this.com_group_SelectionChangeCommitted);
            // 
            // lbl_stud
            // 
            this.lbl_stud.Appearance.Font = new System.Drawing.Font("ae_AlArabiya", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stud.Appearance.Options.UseFont = true;
            this.lbl_stud.Location = new System.Drawing.Point(446, 3);
            this.lbl_stud.Name = "lbl_stud";
            this.lbl_stud.Size = new System.Drawing.Size(65, 22);
            this.lbl_stud.TabIndex = 113;
            this.lbl_stud.Text = "اسم الطالب";
            // 
            // frm_mange_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Name = "frm_mange_report";
            this.Size = new System.Drawing.Size(1040, 548);
            this.Load += new System.EventHandler(this.frm_mange_report_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ch_lect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_grou.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_stud.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colSEND_STUD_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colSEND_STUD_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPAID_UP;
        private DevExpress.XtraGrid.Columns.GridColumn colLECT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colREST;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colTBL_LECTUER;
        private DevExpress.XtraGrid.Columns.GridColumn colSTUD_LECT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colTBL_STUD_LECT;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.CheckEdit ch_lect;
        private DevExpress.XtraEditors.CheckEdit ch_grou;
        private DevExpress.XtraEditors.CheckEdit ch_stud;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public System.Windows.Forms.ComboBox com_lect;
        private DevExpress.XtraEditors.LabelControl lbl_lect;
        private DevExpress.XtraEditors.LabelControl lbl_l_name;
        private DevExpress.XtraEditors.LabelControl lbl_grou;
        public System.Windows.Forms.ComboBox com_stud;
        public System.Windows.Forms.ComboBox com_group;
        private DevExpress.XtraEditors.LabelControl lbl_stud;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}
