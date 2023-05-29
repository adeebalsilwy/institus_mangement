using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THAGBAN_INST.DATA;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.job;
using THAGBAN_INST.FORM.FRM_EMP_MANEGER.lsits;

namespace THAGBAN_INST.FORM.FRM_LECTUER_MANG.techers
{
    public partial class frm_add_tech : DevExpress.XtraEditors.XtraForm
    {

        db_max_instEntities con = new db_max_instEntities();
        tost toast = new tost();
        dialge dialge = new dialge();
       
        public int tech_id = 0;

      
        public string tech_name;
        public string tech_phone;
        public string tech_address;
        public string tech_gender;
        public string tech_spical;
        public DateTime tech_date;

        public string emp_desc;
        public frm_add_tech()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

       

      

        void clear()
        {
            tech_id =0;
            txt_emp_address.Text = "";
            txt_emp_date.Value = DateTime.Now;
            txt_emp_desc.Text = "";
            txt_emp_name.Text = "";
            txt_emp_phone.Text = "";
           




        }
        bool is_empty()
        {
            if (txt_emp_name.Text != "" && txt_emp_phone.Text != "" &&   txt_emp_address.Text != "" )
            {
                return false;
            }
            else
                return true;

        }

        void add_emp()
        {

            tost toast = new tost();
            dialge dialge = new dialge();
            if (is_empty() != true)
            {
                //cheak add or edit 
                try
                {
                    //TBL_LECT_TECHER cl = new TBL_LECT_TECHER();
                   
                    //cl.TECHER_ADDRESS = txt_emp_address.Text;
                    //cl.TECHER_NAME =txt_emp_name.Text ;
                    //cl.TECHER_PHONE =Convert.ToInt32(txt_emp_phone.Text);
                  
                    //    cl.TECHER_GENDER = tech_gender;
                    // string aa = string.Format("{0:dd-MM-yyyy}", txt_emp_date.Value);
                    //tech_date = DateTime.ParseExact(aa, "dd-MM-yyyy", null);
                    //cl.TECHER_RIGSTER = tech_date.Date;
                    //cl.TECHER_SPICAL = txt_emp_desc.Text ;
                   
                    if (tech_id != 0)
                    {
                        //add 
                        //cl.TECHER_ID = Convert.ToInt32(tech_id);
                        //con.TBL_LECT_TECHER.AddOrUpdate(cl);
                        //con.SaveChanges();

                        toast.lbl_mess.Text = "تم التعديل بنجاح";
                        toast.Show();
                        clear();
                        //MessageBox.Show("تم التعديل بنجاح ");
                    }
                    else
                    {
                        //update 
                       // con.TBL_LECT_TECHER.AddOrUpdate(cl);
                        con.SaveChanges();
                        toast.lbl_mess.Text = "تم الاضافه ينجاح  بنجاح";
                        toast.Show();
                        clear();

                    }
                }
                catch (Exception ex)
                {


                    dialge.Width = this.Width;
                    dialge.lbl_mess.Text ="تاكد من ادخال البيانات بالشكل الصحيح ";
                    dialge.Show();
                }
              
            }
            else
            {
                dialge.Width = this.Width;
                dialge.lbl_mess.Text = "الرجاء ادخال جميع البيانات ";
                dialge.Show();



            }


        }

        void cheack()
        {

            if (ch_mal.Checked == true)
            {

                ch_fmel.Checked = false;
                tech_gender = "ذكر";
            }
            else
                ch_fmel.Checked = true;
            if (ch_fmel.Checked == true)
            {

                ch_mal.Checked = false;
                tech_gender = "انثى";
            }
            else
                ch_mal.Checked = true;
        }
        private void frm_add_emp_Load(object sender, EventArgs e)
        {

         
            cheack();

            if (tech_id != 0)
            {
                //TBL_LECT_TECHER tbl = con.TBL_LECT_TECHER.Find(tech_id);
                //txt_emp_address.Text = tbl.TECHER_ADDRESS;
                //txt_emp_date.Value=tbl.TECHER_RIGSTER.Value;
                //txt_emp_desc.Text = tbl.TECHER_SPICAL;
                //txt_emp_name.Text = tbl.TECHER_NAME;
                //txt_emp_phone.Text = tbl.TECHER_PHONE.ToString();
          
                //if(tbl.TECHER_GENDER=="ذكر")
                //    ch_mal.Checked=true;
                //else
                //ch_fmel.Checked=true;
                
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            clear();
          

        }

        private void com_dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void com_dept_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
         
        }

        private void lbl_dept_Click(object sender, EventArgs e)
        {
          
        }

        private void labelControl9_Click(object sender, EventArgs e)
        {
            frm_add_job frm = new frm_add_job();
            frm.ShowDialog(this);

        }

        private void btn_list_dept_Click(object sender, EventArgs e)
        {
          
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void ch_mal_CheckedChanged(object sender, EventArgs e)
        {
            //if (ch_mal.Checked == true)
            //{

            //    ch_fmel.Checked = false;
            //    stud_gender = "ذكر";
            //}
            //else
            //    ch_fmel.Checked = true;
            cheack();


        }

        private void ch_fmel_CheckedChanged(object sender, EventArgs e)
        {
            //    if (ch_fmel.Checked == true)
            //    {

            //        ch_mal.Checked = false;
            //        stud_gender = "انثى";
            //    }
            //    else
            //        ch_mal.Checked = true;
            cheack();


    }

    private void btn_save_Click(object sender, EventArgs e)
        {
            add_emp();

        }

        private void com_job_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void txt_emp_desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }
    }
}