using THAGBAN_INST.DATA;

namespace THAGBAN_INST.reports.emp_reports
{ 
    partial class frm_mang_reptort_emp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mang_reptort_emp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPART_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPART_MONTH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPART_PAID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPART_YEAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLAARY_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPART_YEAR1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(925, 483);
            this.panel2.TabIndex = 9;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(THAGBAN_INST.DATA.TBL_PART_SALARY);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(925, 483);
            this.gridControl1.TabIndex = 12;
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
            this.colPART_ID,
            this.colPART_MONTH,
            this.colPART_PAID,
            this.colPART_YEAR,
            this.colSLAARY_DATE,
            this.colEMP_ID,
            this.colPART_YEAR1});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            // 
            // colPART_ID
            // 
            this.colPART_ID.Caption = "التسلسل";
            this.colPART_ID.FieldName = "PART_ID";
            this.colPART_ID.Name = "colPART_ID";
            this.colPART_ID.Visible = true;
            this.colPART_ID.VisibleIndex = 0;
            this.colPART_ID.Width = 90;
            // 
            // colPART_MONTH
            // 
            this.colPART_MONTH.Caption = "شهر القسط ";
            this.colPART_MONTH.FieldName = "PART_MONTH";
            this.colPART_MONTH.Name = "colPART_MONTH";
            this.colPART_MONTH.Visible = true;
            this.colPART_MONTH.VisibleIndex = 2;
            this.colPART_MONTH.Width = 106;
            // 
            // colPART_PAID
            // 
            this.colPART_PAID.Caption = "المدفوع";
            this.colPART_PAID.FieldName = "PART_PAID";
            this.colPART_PAID.Name = "colPART_PAID";
            this.colPART_PAID.Visible = true;
            this.colPART_PAID.VisibleIndex = 4;
            this.colPART_PAID.Width = 86;
            // 
            // colPART_YEAR
            // 
            this.colPART_YEAR.Caption = "سنه القسط";
            this.colPART_YEAR.FieldName = "PART_YEAR";
            this.colPART_YEAR.Name = "colPART_YEAR";
            this.colPART_YEAR.Visible = true;
            this.colPART_YEAR.VisibleIndex = 3;
            this.colPART_YEAR.Width = 98;
            // 
            // colSLAARY_DATE
            // 
            this.colSLAARY_DATE.Caption = "تاريخ الدفع ";
            this.colSLAARY_DATE.FieldName = "SLAARY_DATE";
            this.colSLAARY_DATE.Name = "colSLAARY_DATE";
            this.colSLAARY_DATE.OptionsFilter.AllowFilter = false;
            this.colSLAARY_DATE.Visible = true;
            this.colSLAARY_DATE.VisibleIndex = 6;
            this.colSLAARY_DATE.Width = 160;
            // 
            // colEMP_ID
            // 
            this.colEMP_ID.Caption = "اسم الموظف ";
            this.colEMP_ID.FieldName = "TBL_EMPLOYEES.EMP_NAME";
            this.colEMP_ID.Name = "colEMP_ID";
            this.colEMP_ID.Visible = true;
            this.colEMP_ID.VisibleIndex = 1;
            this.colEMP_ID.Width = 175;
            // 
            // colPART_YEAR1
            // 
            this.colPART_YEAR1.Caption = "المتبقي";
            this.colPART_YEAR1.FieldName = "PAID_REST";
            this.colPART_YEAR1.Name = "colPART_YEAR1";
            this.colPART_YEAR1.Visible = true;
            this.colPART_YEAR1.VisibleIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 483);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(925, 65);
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
            this.simpleButton2.Location = new System.Drawing.Point(412, 7);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton2.Size = new System.Drawing.Size(101, 50);
            this.simpleButton2.TabIndex = 109;
            this.simpleButton2.Text = "طباعه";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // frm_mang_reptort_emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "frm_mang_reptort_emp";
            this.Size = new System.Drawing.Size(925, 548);
            this.Load += new System.EventHandler(this.frm_mang_reptort_emp_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private DevExpress.XtraEditors.PanelControl panelControl1;
    private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colPART_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPART_MONTH;
        private DevExpress.XtraGrid.Columns.GridColumn colPART_PAID;
        private DevExpress.XtraGrid.Columns.GridColumn colPART_YEAR;
        private DevExpress.XtraGrid.Columns.GridColumn colSLAARY_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colEMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPART_YEAR1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}
