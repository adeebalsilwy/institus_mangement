using DevExpress.XtraRichEdit.Model;
using DeviceId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THAGBAN_INST.DATA;
using THAGBAN_INST.FORM;
using THAGBAN_INST.FORM.FRM_SYSTEM;

namespace THAGBAN_INST.adl
{
    public class Active_System
    {
        private readonly FRM_Start main;
        string mac_address;
        db_max_instEntities con = new db_max_instEntities();
        DeviceIdBuilder DEVIECE = new DeviceIdBuilder();
         
        string address_test;

        public Active_System(FRM_Start main) {
           this.main = main;
          

        }
        public void cheak_trial()
        {
            DeviceIdBuilder DEVIECE = new DeviceIdBuilder();

            mac_address = DEVIECE.AddMacAddress(excludeWireless: true).ToString();



            string t = new string(mac_address.Where(char.IsDigit).ToArray());

            address_test = t;
            if (Properties.Settings.Default.IsFirstOpen != true)

            {
                DateTime cournt_date = DateTime.Now;
                Properties.Settings.Default.Start_Date = DateTime.Now;
                Properties.Settings.Default.End_Date = cournt_date.AddDays(30);
                Properties.Settings.Default.IsFirstOpen = true;
                Properties.Settings.Default.Save();
                MessageBox.Show("انت تستخدم النسخع التجريبيه حتى تاريخ  '" + Properties.Settings.Default.End_Date.ToString() + "'  ");
            }
            else
            {

                try {
                    var active_system = con.TBL_ACTIVE_SYSTEM.Find(address_test);

                    if (active_system != null)
                    {
                        var test_date = active_system.Added_date.Value;

                        TimeSpan timeSpan = test_date - DateTime.Now;

                        int day = Convert.ToInt32(timeSpan.TotalDays);
                        if (day >=0)
                        {
                            if (active_system.FLUL_ACTIVE != true)
                            {
                                var curnt_date = active_system.Added_date.Value.AddYears(1);
                                //  MessageBox.Show(curnt_date.ToString());
                                DateTime dateTime = DateTime.Now;
                                switch (active_system.SUB_ACTIVE)
                                {
                                    case true:

                                        if (dateTime > curnt_date)
                                        {
                                            main.Enabled = false;
                                            FRM_A frm = new FRM_A();
                                            frm.Show();

                                            break;
                                        }

                                        break;
                                    case false:

                                        if (dateTime > curnt_date)
                                        {
                                            main.Enabled = false;
                                            FRM_A frm = new FRM_A();
                                            frm.Show();
                                            break;
                                        }

                                        break;

                                }


                            }
                        }
                        else
                        {
                            main.Enabled = false;
                            FRM_A frm = new FRM_A();
                            frm.Show();
                        }
                        
                    }

                    else
                    {
                        var test_date = THAGBAN_INST.Properties.Settings.Default.End_Date;

                        TimeSpan timeSpan = test_date - DateTime.Now;

                        int day = Convert.ToInt32(timeSpan.TotalDays);
                        if (day < 0)
                        {
                            main.Enabled = false;
                            FRM_A frm = new FRM_A();
                            frm.Show();

                        }

                    }
                }
                catch { }
                }

        }

    }
}
