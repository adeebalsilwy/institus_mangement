using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THAGBAN_INST.DATA;

namespace THAGBAN_INST.FORM.FRM_MANG_STUD
{
    public partial class frm_mange_cours : DevExpress.XtraEditors.XtraUserControl
    {
        public int cours_id=0;
        db_max_instEntities con = new db_max_instEntities();
        tost toast = new tost();
        dialge dialge = new dialge();

        public frm_mange_cours()
        {
            InitializeComponent();
            get_data();


           
        }

        void get_data()
        {
            THAGBAN_INST.DATA.db_max_instEntities dbContext = new THAGBAN_INST.DATA.db_max_instEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TBL_COURS.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TBL_COURS.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
            private void simpleButton1_Click(object sender, EventArgs e)
        {

            get_data();
        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            FRM_ADD_COURS FRM = new FRM_ADD_COURS();
            FRM.cours_id = 0;
           

            FRM.ShowDialog();
            get_data();
        }


        private void btn_edite_Click(object sender, EventArgs e)
        {
                FRM_ADD_COURS FRM = new FRM_ADD_COURS();
            FRM.cours_id = cours_id;
            FRM.btn_save.Text = "تعديل ";
          
            FRM.ShowDialog();
            get_data();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            get_data();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            delete();
            
        }
        void delete()
        {
            if (cours_id != 0)
            {
                try
                {
                    DialogResult res = MessageBox.Show("هل تريد تاكيد الحذف ", "تحذير الحذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (res == DialogResult.OK)
                    {
                        TBL_COURS del_cle = con.TBL_COURS.Find(cours_id);
                        // del_doc.DOC_ID = holiday_type_id;

                        con.TBL_COURS.Remove(del_cle);
                        con.SaveChanges();
                        tost not = new tost();
                        //not.Width = this.Width;
                        not.lbl_mess.Text = "تم الحذف بنجاح ";
                    }
                    get_data();
                }catch (Exception ex)
                {

                }
            }
        }

        void get_sele()
        {
            if (gridView2.RowCount > 0)
            {
                
                cours_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("COURS_ID").ToString());

            }
        }
       

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            get_sele();
        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            get_sele();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView2_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            get_sele();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            get_sele();
        }
    }
}
