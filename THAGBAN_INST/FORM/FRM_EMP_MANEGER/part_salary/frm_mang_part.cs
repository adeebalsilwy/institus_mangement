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
using THAGBAN_INST.reports.emp_reports;
using DevExpress.XtraReports.UI;
using DevExpress.DocumentServices.ServiceModel.DataContracts;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.CodeParser;
using System.Drawing.Imaging;

namespace THAGBAN_INST.FORM.FRM_EMP_MANEGER.part_salary
{
    public partial class frm_mang_part : DevExpress.XtraEditors.XtraUserControl
    {
        db_max_instEntities con = new db_max_instEntities();
        tost toast = new tost();
        dialge dialge = new dialge();
        public int emp_id = 0;
        public int part_id = 0;
        public int part_paid = 0;
        public int part_rest;
        public int emp_salary;
        public int part_month;
        public string emp_name;
        public int part_year;
        public int total_amount;
        public int total_paid;


        public DateTime part_date;


        public frm_mang_part()
        {
            InitializeComponent();


            get_data();
        }
        void get_data()
        {
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            db_max_instEntities dbContext = new db_max_instEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TBL_PART_SALARY.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TBL_PART_SALARY.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            part_id = 0;
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
                    part_id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("PART_ID").ToString());
                   
                }catch (Exception ex)
                {

                }
            }
        }

        private void btn_edite_Click(object sender, EventArgs e)
        {
            frm_add_part frm = new frm_add_part();
            get_sel();
            frm.part_id = part_id;
            frm.btn_save.Text = "تعديل";
            frm.ShowDialog();
            get_data();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            frm_add_part frm = new frm_add_part();
            frm.part_id = 0;
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
            if (part_id != 0)
            {
                try
                {
                    DialogResult res = MessageBox.Show("هل تريد تاكيد الحذف ", "تحذير الحذف ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (res == DialogResult.OK)
                    {
                        TBL_PART_SALARY del_cle = con.TBL_PART_SALARY.Find(part_id);
                        // del_doc.DOC_ID = holiday_type_id;

                        con.TBL_PART_SALARY.Remove(del_cle);
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            reports_part_salary report = new reports_part_salary();
            List<TBL_PART_SALARY> list=new List<TBL_PART_SALARY>();
           
            for (int i = 0; i <gridView2.RowCount; i++)
            {
                list.Add(gridView2.GetRow(i) as TBL_PART_SALARY);
            }
            report.DataSource = list;
       report.DataMember = "";
            adl.method method= new adl.method();
            int inst_id = THAGBAN_INST.Properties.Settings.Default.inst_id;
            TBL_INST tbl=con.TBL_INST.Find(inst_id);
            method.data = tbl.INST_LOGO;
            report.Watermark.Image=Image.FromStream(method.convert_image());
            report.ShowRibbonPreview();
        }
    }
}
