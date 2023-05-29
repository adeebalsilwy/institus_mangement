using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using THAGBAN_INST.adl;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.employees;
using THAGBAN_INST.DATA;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.users;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraScheduler.Native;

namespace THAGBAN_INST.FORM.FRM_SYSTEM
{
    public partial class FRM_Start : SplashScreen
    {
        int st;
        Active_System active_System;
        public FRM_Start()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 2021-" + DateTime.Now.Year.ToString();
            active_System = new Active_System(this);
          active_System.cheak_trial();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void peImage_EditValueChanged(object sender, EventArgs e)
        {

        }

        private async void FRM_Start_Load(object sender, EventArgs e)
        {
            await Task.Run(() => Thread.Sleep(1500));

            // Check Login 
          
              
                lb_state.Text = "... الاتصال بقاعدة البيانات";
                int state = await Task.Run(() => CheckLogin());
                if (state == 1)
                {
                  
                    if (this.Enabled == true)
                    {
                        FRM_LOGIN _Login = new FRM_LOGIN();
                        _Login.Show();

                        Hide();
                    }
                }
                else if (state == 0)
                {

                    db_max_instEntities con = new db_max_instEntities();
                    var temp = con.TBL_EMPLOYEES.ToList();
                if (this.Enabled == true)
                {

                    if (temp.Count <= 0)
                    {
                        frm_setting inst = new frm_setting();

                        inst.navigationFrame1.SelectedPage = inst.nav_page_home;
                        inst.ShowDialog(this);

                         frm_add_emp page = new frm_add_emp();
                        page.btn_save.Text = "تسجيل واعادة تشغيل";
                        page.ShowDialog(this);
                        int emp_id = page.emp_id;
                        frm_setting user = new frm_setting();
                        user.emp_id = emp_id;
                        user.navigationFrame1.SelectedPage = user.nav_page_rouls;
                        user.ch_admin.Checked = true;
                        user.ch_sett.Checked = true;
                        user.ShowDialog(this);
                        Application.Restart();


                    }





                }
                else
                {
                    if (this.Enabled == true)
                    {

                        frm_setting user = new frm_setting();
                        user.emp_id = temp.FirstOrDefault().EMP_ID;
                        user.navigationFrame1.SelectedPage = user.nav_page_rouls;
                        user.ch_admin.Checked = true;
                        user.ch_sett.Checked = true;

                        user.ShowDialog(this);
                        Application.Restart();
                    }
                }



                    






                }
                else
                {

                    DialogResult res = MessageBox.Show("خطأ في الاتصال في قاعدة البيانات , يبدو ان لديك مشكلة في عملية تثبيت البرنامج ", "هل تريد ضبط اعدادات الاتصال ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (res == DialogResult.OK)
                    {

                        frm_setting user = new frm_setting();
                        user.navigationFrame1.SelectedPage = user.nav_page_server;

                        user.ShowDialog();
                        Application.Restart();
                    }
                    else
                    {
                    Application.ExitThread();
                    Application.Exit();
                    }


                }
            }
        

        private int CheckLogin()
        {
            try
            {
                db_max_instEntities db = new db_max_instEntities();

                var data = db.TBL_USERS.Select(x => x.USER_ID).ToList();
                if (data.Count > 0)
                {
                    st = 1;
                }
                else
                {
                    st = 0;
                }

                return st;
            }
            catch
            {
                
                return 2;
            }

        }
        }
}