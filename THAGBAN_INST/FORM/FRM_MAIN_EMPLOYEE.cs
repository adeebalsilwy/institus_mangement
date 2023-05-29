using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.attends;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.holidays;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.job;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.part_salary;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.users;
using THAGBAN_INST.reports.emp_reports;

namespace THAGBAN_INST.FORM
{
    public partial class FRM_MAIN_EMPLOYEE : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        bool PageStageClose;
        XtraTabPage XtraPage;
        public FRM_MAIN_EMPLOYEE()
        {
            InitializeComponent();
        }
      


        private void FRM_MAIN_Load(object sender, EventArgs e)
        {

        }

        private void SelectPage(DevExpress.XtraEditors.XtraUserControl control, string PageTitle)
        {
            try
            {
                foreach (XtraTabPage pageindex in xtraTabControl1.TabPages)
                {
                    if (pageindex.Text == PageTitle)
                    {
                        PageStageClose = false;
                        XtraPage = pageindex;
                        break;

                    }
                    else
                    {
                        PageStageClose = true;
                    }
                }
                if (PageStageClose == true)
                {
                    control.Dock = DockStyle.Fill;
                    xtraTabControl1.TabPages.Add();
                    var CurrentPage = xtraTabControl1.TabPages.Last();
                    xtraTabControl1.SelectedTabPage = CurrentPage;
                    CurrentPage.Text = PageTitle;
                    CurrentPage.Controls.Add(control);
                }
                else
                {
                    xtraTabControl1.SelectedTabPage = XtraPage;
                }
            }
            catch { }

        }
        private void btn_suppliers_Click(object sender, EventArgs e)
        {
            frm_mang_emp frm = new frm_mang_emp();
            //xtrahomepage.ControlAdded(frm_deot);
            SelectPage(frm, "الموظفين");
        }

        private void btn_groups_Click(object sender, EventArgs e)
        {
            frm_mange_dept frm_deot =new frm_mange_dept();
            //xtrahomepage.ControlAdded(frm_deot);
            SelectPage(frm_deot, "الاقسام");
            
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            // close tab bage 
            if (xtraTabControl1.SelectedTabPage != xtraTabControl1.TabPages[0])
            {
                xtraTabControl1.TabPages.Remove(xtraTabControl1.SelectedTabPage);

            }
        }

        private void btn_categories_Click(object sender, EventArgs e)
        {

            frm_mang_jobs frm_deot = new frm_mang_jobs();
            //xtrahomepage.ControlAdded(frm_deot);
            SelectPage(frm_deot, "الوظائف");
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            frm_mang_holiday_type frm = new frm_mang_holiday_type();
            SelectPage(frm, "انواع الاجازات ");
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            frm_mang_holiday frm = new frm_mang_holiday();
            SelectPage(frm, " الاجازات ");
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            frm_mang_attends frm = new frm_mang_attends();
            SelectPage(frm, " سجل الدوام  ");
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            frm_mang_users frm = new frm_mang_users();
            SelectPage(frm, "المستخدمين ");
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            frm_mang_part frm = new frm_mang_part();
            SelectPage(frm, "الاقساط");

        }

        private void btn_anylsis_Click(object sender, EventArgs e)
        {
            frm_mang_reptort_emp frm =new frm_mang_reptort_emp();
            SelectPage(frm, "التقارير ");
        }
    }


}
