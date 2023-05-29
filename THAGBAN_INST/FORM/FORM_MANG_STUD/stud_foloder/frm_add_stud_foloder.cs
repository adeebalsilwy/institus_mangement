using DevExpress.Utils.Extensions;
using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using THAGBAN_INST.DATA;
using System.IO;
using System.Threading;

namespace THAGBAN_INST.FORM.FRM_MANG_STUD.stud_foloder
{
    public partial class frm_add_stud_foloder : DevExpress.XtraEditors.XtraForm
    {

        db_max_instEntities con = new db_max_instEntities();
        tost toast = new tost();
        dialge dialge = new dialge();
        public MemoryStream ms = new MemoryStream();
        public byte[] data;
        public int stud_id = 0;
        public int folder_id = 0;

        public string stud_name;
        public string stud_lname;
        public bool CRTIFIVATE_CHEAK;
        public bool CART_CHEAK;
        public bool STUD_IMG_CHEAK;
        public bool INST_NOTE_CHEAK;
        public byte[] CRTIFIVATE_IMG;
        public byte[] CART_IMG;
        public byte[] STUD_IMG;
        public byte[] INST_NOTE_IMG;


        public frm_add_stud_foloder()
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
            stud_id = 0;
            txt_stud_lname.Text = "";
           



        }
        void cheack()
        {
            
           
            
          
        }
        bool is_empty()
        {
            if (com_stud_name.Text != ""  )
            {
                return false;
            }
            else
                return true;

        }

        void add_stud()
        {

            tost toast = new tost();
            dialge dialge = new dialge();
            if (is_empty() != true)
            {
                //cheak add or edit 
                try
                {
                    TBL_FOLDER cl = new TBL_FOLDER();
                    cl.STUD_ID = Convert.ToInt32(com_stud_name.SelectedValue.ToString());
                    if(ch_stud_img.Checked==true)
                    {
                        //if (pic_stud_img.Image != null)
                        //{
                        //    pic_stud_img.Image.Save(method.ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        //    cl.STUD_IMG = method.convert_byte();
                        //}
                        cl.STUD_IMG_CHEAK = true;
                        cl.STUD_IMG = STUD_IMG;
                    }
                    else
                    {
                        cl.STUD_IMG_CHEAK = false;
                    }
                    if (ch_card.Checked == true)
                    {
                        //if (pic_card.Image != null)
                        //{
                        //    pic_card.Image.Save(method.ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        //    cl.CART_IMG = method.convert_byte();
                        //}
                        cl.CART_CHEAK = true;
                        cl.CART_IMG = CART_IMG;
                    }
                    else
                    {
                        cl.CART_CHEAK = false;
                    }
                    if (ch_crtif.Checked == true)
                    {
                        //if (pic_crtf.Image != null)
                        //{
                        //    pic_crtf.Image.Save(method.ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        //    cl.CRTIFIVATE_IMG = method.convert_byte();
                        //}
                        cl.CRTIFIVATE_IMG = CRTIFIVATE_IMG;
                        cl.CRTIFIVATE_CHEAK = true;
                    }
                    else
                    {
                        cl.CRTIFIVATE_CHEAK = false;
                    }
                    if (ch_note.Checked == true)
                    {
                        //if (pic_note.Image != null)
                        //{
                        //    pic_note.Image.Save(method.ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        //    cl.INST_NOTE_IMG = method.convert_byte();
                        //}
                        cl.INST_NOTE_CHEAK = true;
                        cl.INST_NOTE_IMG = INST_NOTE_IMG;
                    }
                    else
                    {
                        cl.INST_NOTE_CHEAK = false;
                    }

                    if (folder_id != 0)
                    {
                        //add 
                        cl.FOLDER_ID = Convert.ToInt32(folder_id);

                        con.TBL_FOLDER.AddOrUpdate(cl);
                        con.SaveChanges();

                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.EditNotificationText, THAGBAN_INST.Properties.Resources.edit_32px);
                        notifiction.Show();
                        clear();
                        //MessageBox.Show("تم التعديل بنجاح ");
                    }
                    else
                    {
                        //update 
                        con.TBL_FOLDER.AddOrUpdate(cl);
                        con.SaveChanges();
                        adl.NotifictionUser notifiction = new adl.NotifictionUser(THAGBAN_INST.Properties.Resources.AddNotificationText, THAGBAN_INST.Properties.Resources.add_32px);
                        notifiction.Show();
                        clear();

                    }
                    this.Close();
                }
                catch (Exception ex)
                {


                    MessageBox.Show(ex.Message + ex.InnerException.ToString());
                    //dialge.Width = this.Width;
                    //dialge.lbl_mess.Text ="تاكد من ادخال البيانات بالشكل الصحيح ";
                    //dialge.Show();
                }
              
            }
            else
            {
                dialge.Width = this.Width;
                dialge.lbl_mess.Text = "الرجاء ادخال جميع البيانات ";
                dialge.Show();



            }


        }

      
        public void get_data()
        {

            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            db_max_instEntities dbContext = new db_max_instEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TBL_STUDENTS.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                com_stud_name.DataSource = dbContext.TBL_STUDENTS.Local.ToBindingList();
                com_stud_name.DisplayMember = "STUD_NAME";
                com_stud_name.ValueMember = "STUD_ID";
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
       
        private void frm_add_emp_Load(object sender, EventArgs e)
        {

         


            
            if (stud_id != 0 && folder_id!=0 )
            {
                
                com_stud_name.DataSource = con.TBL_STUDENTS.ToList();
                com_stud_name.DisplayMember = "STUD_NAME";
                com_stud_name.ValueMember = "STUD_ID";
                com_stud_name.SelectedValue = stud_id;
                get_info();

            }
            else
            {
                get_data();
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            clear();
          

        }

       

       

      
       
    private void btn_save_Click(object sender, EventArgs e)
        {
           
           add_stud();
           
        }
        

        private void txt_stud_address_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pic_stud_img_EditValueChanged(object sender, EventArgs e)
        {
            if (pic_stud_img.Image != null)
            {
                MemoryStream me1 = new MemoryStream();
                ch_stud_img.Checked = true;
                pic_stud_img.Image.Save(me1, System.Drawing.Imaging.ImageFormat.Jpeg);
               STUD_IMG = me1.ToArray();
            }
            else
            {
                ch_stud_img.Checked = false;
            }
        }

        private void pic_crtf_EditValueChanged(object sender, EventArgs e)
        {
            if (pic_crtf.Image != null)
            {
                MemoryStream me1 = new MemoryStream();
                ch_crtif.Checked = true;
                pic_crtf.Image.Save(me1, System.Drawing.Imaging.ImageFormat.Jpeg);
                CRTIFIVATE_IMG = me1.ToArray();
            }
            else
            {
                ch_crtif.Checked = false;
            }
        }

       
        private void pic_note_EditValueChanged(object sender, EventArgs e)
        {
            if (pic_note.Image != null)
            {
                MemoryStream me1 = new MemoryStream();
                ch_note.Checked = true;
               
                pic_note.Image.Save(me1, System.Drawing.Imaging.ImageFormat.Jpeg);
                INST_NOTE_IMG = me1.ToArray();
            }
            else
            {
                ch_note.Checked = false;
            }
        }

        private void pic_card_EditValueChanged(object sender, EventArgs e)
        {
              
            if (pic_card.Image != null)
            {
                MemoryStream me1 = new MemoryStream();
                ch_card.Checked = true;
                pic_card.Image.Save(me1, System.Drawing.Imaging.ImageFormat.Jpeg);
                CART_IMG = me1.ToArray();
            }
            else
            {
                ch_card.Checked = false;
            }
        }

        private void com_stud_name_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        public byte[] convert_byte()
        {
            return ms.ToArray();
        }
        public MemoryStream convert_image(byte[] data)
        {
            if (data != null)
            {
                ms = new MemoryStream(data);
                return ms;
            }
            else
                return null;
        }
        private void txt_stud_lname_TextChanged(object sender, EventArgs e)
        {
            // Bind data to control when loading complete
            //if (txt_stud_lname.Text != "")
            //{


            //    com_stud_name.DataSource = con.TBL_STUDENTS.Where(w => w.STUD_LNAME.Contains(txt_stud_lname.Text)).ToList();
            //    com_stud_name.DisplayMember = "STUD_NAME";
            //    com_stud_name.ValueMember = "STUD_ID";
            //}
        }
       

        TBL_FOLDER test = new TBL_FOLDER();
        void  get_info()
        {
            adl.method methods = new adl.method();


            db_max_instEntities dbContext = new db_max_instEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
           
            
                // Bind data to control when loading complete
                test = dbContext.TBL_FOLDER.Where(w => w.STUD_ID == stud_id).FirstOrDefault();
                if (test != null)
                {
                folder_id = test.FOLDER_ID;
                if (test.CART_IMG != null)
                    {
                       // pic_card.Image = Image.FromStream(new MemoryStream(test.CART_IMG));
                   
                       //  pic_card.Image = Image.FromStream(convert_image(CART_IMG));
                    methods.data = test.CART_IMG;
              
                    pic_card.Image = Image.FromStream(methods.convert_image());
                    pic_card.Refresh();
                    }
                    if (test.STUD_IMG != null)
                    {
                   // data=test.STUD_IMG;
                    pic_stud_img.Image = Image.FromStream(new MemoryStream(test.STUD_IMG));
                    pic_stud_img.Refresh();
                    }
                    if (test.INST_NOTE_IMG != null)
                    {

                    pic_note.Image = Image.FromStream(new MemoryStream(test.INST_NOTE_IMG));
                    pic_note.Refresh();
                }
                if (test.CRTIFIVATE_IMG != null)
                        {

                    pic_crtf.Image = Image.FromStream(new MemoryStream(test.CRTIFIVATE_IMG));
                    pic_crtf.Refresh();
                }
                    }


                


             
        }
        private void com_stud_name_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            if (com_stud_name.Text != "")
            {
                if (com_stud_name.SelectedValue != null)
                    stud_id = Convert.ToInt32(com_stud_name.SelectedValue.ToString());
                txt_stud_lname.Text = con.TBL_STUDENTS.Where(w => w.STUD_ID == stud_id).FirstOrDefault().STUD_LNAME.ToString();

                get_info();
            }
            
        }
    }
}