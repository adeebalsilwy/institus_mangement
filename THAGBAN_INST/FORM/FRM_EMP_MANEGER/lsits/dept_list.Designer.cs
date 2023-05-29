namespace THAGBAN_INST.FORM.FRM_EMP_MANEGER.lsits
{
    partial class dept_list
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
            this.colDEPT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPT_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPT_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPT_STATE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(648, 416);
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
            this.colDEPT_ID,
            this.colDEPT_NAME,
            this.colDEPT_DESC,
            this.colDEPT_STATE});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // colDEPT_ID
            // 
            this.colDEPT_ID.Caption = "التسلسل";
            this.colDEPT_ID.FieldName = "DEPT_ID";
            this.colDEPT_ID.Name = "colDEPT_ID";
            this.colDEPT_ID.Visible = true;
            this.colDEPT_ID.VisibleIndex = 0;
            this.colDEPT_ID.Width = 129;
            // 
            // colDEPT_NAME
            // 
            this.colDEPT_NAME.Caption = "اسم القسم";
            this.colDEPT_NAME.FieldName = "DEPT_NAME";
            this.colDEPT_NAME.Name = "colDEPT_NAME";
            this.colDEPT_NAME.Visible = true;
            this.colDEPT_NAME.VisibleIndex = 1;
            this.colDEPT_NAME.Width = 217;
            // 
            // colDEPT_DESC
            // 
            this.colDEPT_DESC.Caption = "وصف القسم";
            this.colDEPT_DESC.FieldName = "DEPT_DESC";
            this.colDEPT_DESC.Name = "colDEPT_DESC";
            this.colDEPT_DESC.Visible = true;
            this.colDEPT_DESC.VisibleIndex = 2;
            this.colDEPT_DESC.Width = 356;
            // 
            // colDEPT_STATE
            // 
            this.colDEPT_STATE.Caption = "حاله القسم";
            this.colDEPT_STATE.FieldName = "DEPT_STATE";
            this.colDEPT_STATE.Name = "colDEPT_STATE";
            this.colDEPT_STATE.Visible = true;
            this.colDEPT_STATE.VisibleIndex = 3;
            this.colDEPT_STATE.Width = 198;
            // 
            // dept_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 416);
            this.Controls.Add(this.gridControl1);
            this.Name = "dept_list";
            this.Text = "dept_list";
            this.Load += new System.EventHandler(this.dept_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPT_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPT_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPT_STATE;
    }
}