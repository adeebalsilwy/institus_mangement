using THAGBAN_INST.DATA;

namespace THAGBAN_INST.FORM.FRM_EMP_MANEGER.lsits
{
    partial class emp_list
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEMP_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMP_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJOB_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJOB_ID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(TBL_EMPLOYEES);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(553, 420);
            this.gridControl1.TabIndex = 9;
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
            this.gridView2.Appearance.ViewCaption.Font = new System.Drawing.Font("ae_AlArabiya", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEMP_ID,
            this.colEMP_NAME,
            this.colJOB_ID,
            this.colJOB_ID1});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // colEMP_ID
            // 
            this.colEMP_ID.Caption = "التسلسل";
            this.colEMP_ID.FieldName = "EMP_ID";
            this.colEMP_ID.Name = "colEMP_ID";
            this.colEMP_ID.Visible = true;
            this.colEMP_ID.VisibleIndex = 0;
            this.colEMP_ID.Width = 89;
            // 
            // colEMP_NAME
            // 
            this.colEMP_NAME.Caption = "اسم الموظف";
            this.colEMP_NAME.FieldName = "EMP_NAME";
            this.colEMP_NAME.Name = "colEMP_NAME";
            this.colEMP_NAME.Visible = true;
            this.colEMP_NAME.VisibleIndex = 1;
            this.colEMP_NAME.Width = 194;
            // 
            // colJOB_ID
            // 
            this.colJOB_ID.Caption = "الوظيفه";
            this.colJOB_ID.FieldName = "TBL_JOB.JOB_NAME";
            this.colJOB_ID.Name = "colJOB_ID";
            this.colJOB_ID.Visible = true;
            this.colJOB_ID.VisibleIndex = 2;
            this.colJOB_ID.Width = 122;
            // 
            // colJOB_ID1
            // 
            this.colJOB_ID1.Caption = "القسم";
            this.colJOB_ID1.FieldName = "TBL_JOB.TBL_DEPT.DEPT_NAME";
            this.colJOB_ID1.Name = "colJOB_ID1";
            this.colJOB_ID1.Visible = true;
            this.colJOB_ID1.VisibleIndex = 3;
            this.colJOB_ID1.Width = 123;
            // 
            // emp_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 420);
            this.Controls.Add(this.gridControl1);
            this.Name = "emp_list";
            this.Text = "job_list";
            this.Load += new System.EventHandler(this.job_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colEMP_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colEMP_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colJOB_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colJOB_ID1;
    }
}