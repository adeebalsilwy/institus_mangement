using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Data.Entity.Migrations;
using System.Threading;
using System.Diagnostics;
using DeviceId;
using THAGBAN_INST.DATA;
using THAGBAN_INST.adl;

namespace THAGBAN_INST.FORM.FRM_SYSTEM
{
    public partial class FRM_A : DevExpress.XtraEditors.XtraForm
    {
        //DBEPSEntities db;
        //TB_ABC add;
       db_max_instEntities con = new db_max_instEntities();
        DeviceIdBuilder DEVIECE = new DeviceIdBuilder();
        string mac_address = "";
        string tempkey = "";
        private string key;
        private string full_key = "";
        string address_test;

        public FRM_A()
        {
            InitializeComponent();

            anacalis();

        }

      
       void anacalis()
        {
            mac_address = DEVIECE.AddMacAddress(excludeWireless: true).ToString();
            txt_name.Text = mac_address;
            lbl_key.Text = mac_address.Substring(0, 5);
            tempkey = mac_address.Substring(0, 5) + mac_address.Substring(10, 5);

            label4.Text = tempkey;
            label4.Text = new string(mac_address.Where(char.IsDigit).ToArray());
            decimal test_key = decimal.Parse(label4.Text);
            address_test = label4.Text;

            string tt = label4.Text.Substring(0, 5);


            label4.Text = address_test.ToString();

            int temp = Convert.ToInt32(tt) + 1697402;

            lbl_key.Text = temp.ToString();
            key = temp.ToString();
           // lbl_key.Visible = true;
            full_key = "deebo" + key + "1697402";

            // label4.Text = key.ToString();


        }

        private void CheckState()
        {
            try
            {


                db_max_instEntities con = new db_max_instEntities();
                // MessageBox.Show(mac_address);
                var active_syste = con.TBL_ACTIVE_SYSTEM.Find(address_test);
                // var rs1 = con.TBL_ACTIVE_SYSTEM.Where(w).First();
                //  var cheak_full = con.TBL_ACTIVE_SYSTEM.Where(w=>w.FLUL_ACTIVE==true).First();
               
                if (active_syste==null)
                {

                  //  MessageBox.Show(mac_address);
                    txt_state.Text = "هل تمتلك مفتاح تفعيل مرخص , يمكنك التفعيل الان ";
                    pic_key.BringToFront();
                    panel2.Enabled = true; 
                    Properties.Settings.Default.ISActive = false;
                  
                    Properties.Settings.Default.Save();
                } 
                else if (active_syste.FLUL_ACTIVE == true)
                {
                    txt_state.Text = "انت مستخدم النسخه الغير منتهيه ";
                    pic_done.BringToFront();

                    txt_seryal.Text = "تم التفعيل بواسطه المطور";
                    panel2.Enabled = false;
                    Properties.Settings.Default.ISActive = true;

                    Properties.Settings.Default.Save();
                }
                else if (active_syste.SUB_ACTIVE == true && active_syste.FLUL_ACTIVE==false)
                {
                    var test_date = active_syste.Added_date.Value;

                    TimeSpan timeSpan = test_date - DateTime.Now;

                    int day = Convert.ToInt32(timeSpan.TotalDays);
                  

                        if (DateTime.Now > active_syste.Added_date.Value.AddYears(1) )
                    {
                        key = "";
                        txt_state.Text = "تم انتهاء النسخه السنويه, يمكنك التفعيل الان ";
                        pic_key.BringToFront();
                        panel2.Enabled = true;
                        Properties.Settings.Default.ISActive = false;

                        Properties.Settings.Default.Save();

                    }
                    else
                    {
                        txt_state.Text = "انت مستخدم النسخه  السنويه ";
                        pic_done.BringToFront();

                        txt_seryal.Text = "تم التفعيل بواسطه المطور";
                        panel2.Enabled = false;
                    }
                   
                }
                else if (active_syste.SUB_ACTIVE == true )
                {
                    txt_state.Text = "انت مستخدم النسخه  السنويه ";
                    pic_done.BringToFront();

                    txt_seryal.Text = "تم التفعيل بواسطه المطور";
                    panel2.Enabled = false;
                }            
            }
            catch
            {

            }
        
    }

        private void txt_state_Click(object sender, EventArgs e)
        {
           

        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            if ( txt_seryal.Text == "")
            {
                MessageBox.Show("قم بمليء الحقول رجاءا");
            }
            else
            {
                try
                {
                    db_max_instEntities con = new db_max_instEntities();
                    TBL_ACTIVE_SYSTEM tbl = new TBL_ACTIVE_SYSTEM();
                    txt_state.Text = " ...يتم تفعيل المنتج الان ";
                    await Task.Run(() => Thread.Sleep(2000));
                  
                 
                 
                    tbl.Mack_address =address_test.ToString();

                    tbl.Added_date = DateTime.Now;


                    if (key.Trim()== txt_seryal.Text.Trim())
                    {
                        tbl.Key = key.ToString();
                        tbl.SUB_ACTIVE = true;
                        tbl.FLUL_ACTIVE = false;
                        con.TBL_ACTIVE_SYSTEM.AddOrUpdate(tbl);
                        con.SaveChanges();
                        CheckState();
                        Properties.Settings.Default.ISActive = true;
                        Properties.Settings.Default.Save();
                       
                       
                        MessageBox.Show("تهانينا :) تم تفعيل البرنامج بنجاح , سيتم اعادة تشغيل البرنامج لضبط كافة الاعدادات");
                        Application.ExitThread();
                        Application.Restart();
                    }
                    else if (full_key.Trim() == txt_seryal.Text.Trim())
                    {
                        tbl.FULT_ACTIVE_KEY = full_key;
                        tbl.FLUL_ACTIVE = true;
                        tbl.SUB_ACTIVE = true;
                        con.TBL_ACTIVE_SYSTEM.AddOrUpdate(tbl);
                        Properties.Settings.Default.ISActive = true;
                        Properties.Settings.Default.ISfull_ACTIVE = true;
                        con.SaveChanges();
                        CheckState();
                       
                       // THAGBAN_INST.Properties.Settings.Default.End_Date = DateTime.Now.AddYears(100);
                        Properties.Settings.Default.Save();
                        MessageBox.Show("تهانينا :) تم تفعيل البرنامج بنجاح , سيتم اعادة تشغيل البرنامج لضبط كافة الاعدادات");
                        Application.ExitThread();
                        Application.Restart();
                    }

                    else
                    {
                        CheckState();
                        txt_state.Text = "خطأ مفتاح المنتج غير صالح ";
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message +ex.InnerException);


                    //   MessageBox.Show("يبدو انك غير متصل في الشبكة , عملية التفعيل تحتاج الى توفر الاتصال في الشبكة");

                }
            }





        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("enter url here");
        }

        private void FRM_A_Load(object sender, EventArgs e)
        {
            CheckState();
        }
    }

    class DataDone
    {
        public string UserName { get; set; }
        public string Code { get; set; }
    }
    
}