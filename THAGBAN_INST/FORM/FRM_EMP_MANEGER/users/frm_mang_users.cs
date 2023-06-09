﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using THAGBAN_INST;
using THAGBAN_INST.DATA;

namespace THAGBAN_INST.FORM.FRM_EMP_MANEGER.users
{
    public partial class frm_mang_users : DevExpress.XtraEditors.XtraUserControl
    {


        db_max_instEntities con = new db_max_instEntities();
        tost toast = new tost();
        dialge dialge = new dialge();
        public int emp_id = 0;
        public int user_id = 0;
        public int job_id = 0;
        public string job_name;
        public string emp_name;
        public string user_name;
        public string user_pass;
        public int dept_id;
        public string dept_name;

        public frm_mang_users()
        {
            InitializeComponent();
            get_data();


          
        }

        public void get_data()
        {
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            db_max_instEntities dbContext = new db_max_instEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TBL_USERS.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TBL_USERS.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            frm_add_users add =new frm_add_users();
            add.user_id =0;
            add.ShowDialog();
            get_data();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            get_data();
        }

        private void btn_edite_Click(object sender, EventArgs e)
        {
            frm_add_users frm = new frm_add_users();
            //frm.holiday_type_name=holiday_type_name;
            frm.user_id = user_id;
            
            frm.user_name = user_name;
            frm.user_pass=user_pass;
            frm.emp_id=emp_id;
            frm.emp_name=emp_name;
            frm.dept_id=dept_id;
            frm.dept_name  =dept_name;
            frm.job_id=job_id;
            frm.job_name = job_name;

            frm.ShowDialog();
           // MessageBox.Show(user_id.ToString());
            get_data();
        }

        void delete()
        {
            if (user_id != 0)
            {
                try
                {
                    DialogResult res = MessageBox.Show("هل تريد تاكيد الحذف ", "تحذير الحذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (res == DialogResult.OK)
                    {
                        TBL_USERS del_cle = con.TBL_USERS.Find(user_id);
                        // del_doc.DOC_ID = holiday_type_id;

                        con.TBL_USERS.Remove(del_cle);
                        con.SaveChanges();
                        tost not = new tost();
                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.DeleteNotificationText, THAGBAN_INST.Properties.Resources.Delete_32px);
                        notifiction.Show();
                    }
                    get_data();
                }catch (Exception ex) { }
            }
        }

        void get_sele()
        {
            if (gridView2.SelectedRowsCount > 0)

            {
                user_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("USER_ID").ToString());
                user_name = gridView2.GetFocusedRowCellValue("USER_NAME").ToString();
                user_pass = gridView2.GetFocusedRowCellValue("USER_PASS").ToString();
                emp_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("EMP_ID").ToString());
               // spiacla_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("DEPT_ID").ToString());
               // tech_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("JOB_NAME").ToString());
               // matrial_name =gridView2.GetFocusedRowCellValue("JOB_NAME").ToString();

                emp_name = con.TBL_EMPLOYEES.Find(emp_id).EMP_NAME;
                job_id=Convert.ToInt32(con.TBL_EMPLOYEES.Find(emp_id).JOB_ID);

                dept_id = Convert.ToInt32(con.TBL_JOB.Find(job_id).DEPT_ID);
                dept_name = con.TBL_DEPT.Find(dept_id).DEPT_NAME;
                job_name = con.TBL_JOB.Find(job_id).JOB_NAME;

            }
    }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            get_sele();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            delete();
            get_data();
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            get_sele();
        }

        private void gridView2_Click(object sender, EventArgs e)
        {
            get_sele();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            get_sele();
        }

        private void gridView2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            get_sele();
        }

        private void gridView2_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            get_sele();
        }
    }
}
