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
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.employees;
using THAGBAN_INST.DATA;

namespace THAGBAN_INST.FORM.FRM_EMP_MANEGER.attends
{
    public partial class frm_mang_attends : DevExpress.XtraEditors.XtraUserControl
    {
        db_max_instEntities con = new db_max_instEntities();
        tost toast = new tost();
        dialge dialge = new dialge();
        public int emp_id = 0;
        public string emp_name;
        public string note;

        public int GET_EMP;
        public int attend_id;
        public int GO_EMP;
        public DateTime attend_date;

        public frm_mang_attends()
        {
            InitializeComponent();



            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            db_max_instEntities dbContext = new db_max_instEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TBL_ATTENDS.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.TBL_ATTENDS.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        void get_data()
        {
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            db_max_instEntities dbContext = new db_max_instEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TBL_ATTENDS.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TBL_ATTENDS.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void gridView2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            get_sel();
        }
        void get_sel()
        {
            if (gridView2.SelectedRowsCount > 0)
            {
                try
                {
                    attend_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("ATTEND_ID").ToString());
                    emp_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("EMP_ID").ToString());
                    GET_EMP = Convert.ToInt32(gridView2.GetFocusedRowCellValue("ATTEND_GIT").ToString());
                    attend_date = Convert.ToDateTime(gridView2.GetFocusedRowCellValue("ATTEND_DATE").ToString());
                    GO_EMP = Convert.ToInt32(gridView2.GetFocusedRowCellValue("ATTEND_GO").ToString());

                    emp_name = con.TBL_EMPLOYEES.Find(emp_id).EMP_NAME;
                    //holiday_type_name = con.TBL_HOLIDAY_TYPE.Find(holiday_type_id).HOLIDAY_TYPE_NAME;

                }
                catch (Exception ex)
                {

                }
            }
        }

        private void btn_edite_Click(object sender, EventArgs e)
        {
            add_attends frm = new add_attends();
            get_sel();
            frm.attend_id = attend_id;
            frm.emp_id = emp_id;
            frm.attend_date= attend_date;
            frm.GO_EMP = GO_EMP;
            frm.GET_EMP= GET_EMP;
            frm.emp_name=emp_name;
            frm.btn_save.Text = "تعديل";
            frm.ShowDialog();
            get_data();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            add_attends frm = new add_attends();
            frm.attend_id = 0;
            frm.ShowDialog();
            get_data();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            get_data();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            delete();
        }
        void delete()
        {
            if (attend_id != 0)
            {
                try
                {
                    DialogResult res = MessageBox.Show("هل تريد تاكيد الحذف ", "تحذير الحذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (res == DialogResult.OK)
                    {
                        TBL_ATTENDS del_cle = con.TBL_ATTENDS.Find(attend_id);
                        // del_doc.DOC_ID = holiday_type_id;

                        con.TBL_ATTENDS.Remove(del_cle);
                        con.SaveChanges();
                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.DeleteNotificationText, THAGBAN_INST.Properties.Resources.Delete_32px);
                        notifiction.Show();
                    }
                    get_data();
                }catch(Exception ex) { }
            }
        }

        private void gridView2_SelectionChanged_1(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            get_sel();

        }
    }
}
