using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THAGBAN_INST.adl;
using THAGBAN_INST.DATA;
using THAGBAN_INST.FORM.FRM_LECTUER_MANG.lect_report;

namespace THAGBAN_INST.FORM.FRM_LECTUER_MANG
{
    public partial class analsiys_lect_main : DevExpress.XtraEditors.XtraUserControl
    {
        db_max_instEntities con = new db_max_instEntities();
        private int lect_id;
        private int tech_lect_id;
        private int stud_id;
        private int stud_lect_id;
        private object temp_tech_lect_id;
        private int total_paid;

        public analsiys_lect_main()
        {
            InitializeComponent();
            get_count();
           get_lect();
            Get_piad();
        }


        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {
            cheack_change();
            Get_piad();
        }
        public void get_lect()
        {
            var tbl = con.TBL_LECT_TECH_COURS.Where(w => w.STATE == true)
                .Join(con.TBL_LECTUER, l => l.TBL_LECTUER.LECT_ID, tl => tl.LECT_ID,
                (l, tl) => new
                {

                    l.LECT_ID,

                    tl.LECT_NAME,

                }).Distinct();


            if (tbl != null)
            {
                com_lect.DataSource = tbl.ToList();
                com_lect.DisplayMember = "LECT_NAME";
                com_lect.ValueMember = "LECT_ID";
                lbl_lect.Text = tbl.Count().ToString();
                get_group();


            }
            else
            {
                com_lect.DataSource = null;
                com_lect.Items.Clear();
                com_lect.Text = "";
            }
        }
        public void get_group()
        {
            try
            {

                lect_id = Convert.ToInt32(com_lect.SelectedValue);
                var temp = con.TBL_LECT_TECH_COURS.Where(w => w.LECT_ID == lect_id).Distinct().ToList();
                if (temp != null)
                {
                    com_group.DataSource = temp;
                    com_group.DisplayMember = "GROUP_NAME";
                    com_group.ValueMember = "TECH_LECT_ID";


                }
                else
                {
                    com_group.DataSource = null;
                    com_group.Items.Clear();
                    com_group.Text = "";
                }
            }
            catch (Exception ex) { }


        }
        public void get_stud()
        {


            try
            {
                tech_lect_id = Convert.ToInt32(com_group.SelectedValue);
                lect_id=Convert.ToInt32(com_lect.SelectedValue);
                com_stud.DataSource = con.TBL_STUD_LECT.Where(w => w.LECT_TECH_ID
                == tech_lect_id && w.LECT_ID == lect_id).Join(
                    con.TBL_STUDENTS, sl => sl.STUD_ID, stud => stud.STUD_ID,
                    (stud, sl) => new
                    {
                        sl.STUD_NAME,
                        sl.STUD_LNAME,
                        stud.STUD_ID
                    }).Distinct().ToList();

                com_stud.DisplayMember = "STUD_NAME";
                com_stud.ValueMember = "STUD_ID";
            }catch (Exception ex) { }

            
        }
        void get_count()
        {
            var stud = con.TBL_STUDENTS.ToList();
            lbl_mal.Text = stud.Where(w=>w.STUD_GENDER.Trim().Equals("ذكر")).Count().ToString();
            lbl_femal.Text = stud.Where(w => w.STUD_GENDER.Trim().Equals("انثى")).Count().ToString();
            lbl_lect_tech.Text = con.TBL_EMPLOYEES.Join(con.TBL_JOB.Where(w => w.JOB_NAME.Equals("مدرس")), w => w.JOB_ID, s => s.JOB_ID
             , (tec, job) => new
             {
                 tec.EMP_ID

             }
             ).Count().ToString();

            lbl_cours.Text=con.TBL_LECT_COURS.Count().ToString();

        }
        void Get_piad()
        {

            try
            {

                int piad_count = 0;
                if (com_lect.Enabled == true && com_group.Enabled==false)
                {
                    if (com_lect.SelectedValue != null)
                        lect_id = Convert.ToInt32(com_lect.SelectedValue);
                    var result = con.TBL_SEND_STUD_LECT
        .GroupBy(cGrp => new { cGrp.TECH_LECT_ID, cGrp.LECT_ID, cGrp.STUD_ID })
        .Select(g => new { Name = g, Guns = g.Sum(x => x.PAID_UP) })
        .ToList();

                   
                    foreach (var g in result.Where(w=>w.Name.Key.LECT_ID==lect_id).ToList())
                    {
                        if (g.Guns < Convert.ToInt32(con.TBL_LECTUER.Find(g.Name.Key.LECT_ID).LECT_PRICE))
                        {
                            piad_count++;
                        }
                    }
                    lbl_rest.Text = piad_count.ToString();
                }
                else if (com_lect.Enabled==true && com_group.Enabled==true)
                {
                    if (com_lect.SelectedValue != null)
                        tech_lect_id = Convert.ToInt32(com_group.SelectedValue);
                    var result = con.TBL_SEND_STUD_LECT
        .GroupBy(cGrp => new { cGrp.TECH_LECT_ID, cGrp.LECT_ID, cGrp.STUD_ID })
        .Select(g => new { Name = g, Guns = g.Sum(x => x.PAID_UP) })
        .ToList();


                    foreach (var g in result.Where(w => w.Name.Key.LECT_ID == lect_id && w.Name.Key.TECH_LECT_ID==tech_lect_id).ToList())
                    {
                        if (g.Guns < Convert.ToInt32(con.TBL_LECTUER.Find(g.Name.Key.LECT_ID).LECT_PRICE))
                        {
                            piad_count++;
                        }
                    }
                    lbl_rest.Text = piad_count.ToString();
                }

                else
                {
                    var result = con.TBL_SEND_STUD_LECT
        .GroupBy(cGrp => new { cGrp.TECH_LECT_ID, cGrp.LECT_ID, cGrp.STUD_ID })
        .Select(g => new { Name = g, Guns = g.Sum(x => x.PAID_UP) })
        .ToList();


                    foreach (var g in result)
                    {
                        if (g.Guns < Convert.ToInt32(con.TBL_LECTUER.Find(g.Name.Key.LECT_ID).LECT_PRICE))
                        {
                            piad_count++;
                        }
                    }
                    lbl_rest.Text = piad_count.ToString();
                }
               
            }
            catch (Exception ex) { }

        }

        private void com_lect_SelectionChangeCommitted(object sender, EventArgs e)
        {
            get_group();
            Get_piad();
        }

        private void com_group_SelectionChangeCommitted(object sender, EventArgs e)
        {
           //Get_piad();
            get_stud();
            Get_piad();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                report_send_stud report = new report_send_stud();


                int temp = con.TBL_SEND_STUD_LECT.Count();
                if(temp>0)
                {
                    reort_send_lect _Lect = new reort_send_lect();
                   // _Lect.DataSource = temp;
                    _Lect.ShowPreview();
                }
                else
                {
                    NotifictionUser notif = new NotifictionUser("لايوجد طلاب مسددين في هذه الدوره ",THAGBAN_INST.Properties.Resources.icons8_Notification_128px);
                    notif.StartPosition=FormStartPosition.CenterScreen;
                    notif.Show();
                }
           

                
                


            }
            catch (Exception ex) { }

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            cheack_change();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            cheack_change();
            print_report();
        }
        void print_report()
        {
            reort_send_lect _Lect = new reort_send_lect();

            if (com_lect.Enabled==true && com_group.Enabled==false && com_stud.Enabled==false)
            {
                if(com_lect.SelectedValue!=null)
                lect_id = Convert.ToInt32(com_lect.SelectedValue);
                var temp_lec = con.TBL_SEND_STUD_LECT.Where(w =>  w.LECT_ID == lect_id).ToList();
                
                // _Lect.DataSource=con.TBL_SEND_STUD_LECT.Where(w=>w.id)
                if (temp_lec.Count > 0)
                {
                  
                    _Lect.DataSource = temp_lec.ToList();



                    _Lect.DataMember = "";
                    _Lect.ShowPreview();
                   // _Lect.ShowRibbonPreview();

                }
                else
                {
                    NotifictionUser notif = new NotifictionUser("    لايوجد طلاب مسددين  في هذه الدوره ", THAGBAN_INST.Properties.Resources.icons8_Notification_128px);
                    notif.StartPosition = FormStartPosition.CenterScreen;
                    notif.Show();
                }
            }


            else if (com_lect.Enabled == true && com_group.Enabled == true && com_stud.Enabled == false)
            {
                if (com_group.SelectedValue != null)
                    tech_lect_id = Convert.ToInt32(com_group.SelectedValue);
                var temp_tech = con.TBL_SEND_STUD_LECT.Where(w => w.LECT_ID == lect_id && w.TECH_LECT_ID == tech_lect_id).ToList();
                // _Lect.DataSource=con.TBL_SEND_STUD_LECT.Where(w=>w.id)
                if (temp_tech.Count > 0)
                {
                    _Lect.DataSource = temp_tech;
                    _Lect.DataMember = "";
                    _Lect.ShowPreview();
                    //_Lect.ShowRibbonPreview();
                }
                else
                {
                    NotifictionUser notif = new NotifictionUser("    لايوجد طلاب مسددين  في هذه الدوره ", THAGBAN_INST.Properties.Resources.icons8_Notification_128px);
                    notif.StartPosition = FormStartPosition.CenterScreen;
                    notif.Show();
                }
            }

            else if (com_lect.Enabled == true && com_group.Enabled == true && com_stud.Enabled == true)
            {
                if (com_group.SelectedValue != null)
                    tech_lect_id = Convert.ToInt32(com_group.SelectedValue);
                stud_id = Convert.ToInt32(com_stud.SelectedValue);
                var temp = con.TBL_SEND_STUD_LECT.Where(w => w.LECT_ID == lect_id && w.TECH_LECT_ID == tech_lect_id && w.STUD_ID == stud_id).ToList();
                // _Lect.DataSource=con.TBL_SEND_STUD_LECT.Where(w=>w.id)
                if (temp.Count > 0)
                {
                    _Lect.DataSource = temp;
                    _Lect.DataMember = "";
                    _Lect.ShowPreview();
                    //_Lect.ShowRibbonPreview();
                }
                else
                {
                    NotifictionUser notif = new NotifictionUser("    لايوجد طلاب مسددين  في هذه الدوره ", THAGBAN_INST.Properties.Resources.icons8_Notification_128px);
                    notif.StartPosition = FormStartPosition.CenterScreen;
                    notif.Show();
                }
            }

            else if (com_lect.Enabled == true && com_group.Enabled == false && com_stud.Enabled == true)
            {
                if (com_group.SelectedValue != null)
                    tech_lect_id = Convert.ToInt32(com_group.SelectedValue);
                stud_id = Convert.ToInt32(com_stud.SelectedValue);
                var temp = con.TBL_SEND_STUD_LECT.Where(w => w.LECT_ID == lect_id && w.STUD_ID == stud_id).ToList();
                // _Lect.DataSource=con.TBL_SEND_STUD_LECT.Where(w=>w.id)
                if (temp.Count > 0)
                {
                    _Lect.DataSource = temp;
                    _Lect.DataMember = "";
                    _Lect.ShowPreview();
                    //_Lect.ShowRibbonPreview();
                }
                else
                {
                    NotifictionUser notif = new NotifictionUser("    لايوجد طلاب مسددين  في هذه الدوره ", THAGBAN_INST.Properties.Resources.icons8_Notification_128px);
                    notif.StartPosition = FormStartPosition.CenterScreen;
                    notif.Show();
                }
            }

            else if (com_stud.Enabled == true && com_lect.Enabled == false && com_group.Enabled == false)
            {
                if (com_stud.SelectedValue != null)
                    stud_id = Convert.ToInt32(com_stud.SelectedValue);
                var temp1 = con.TBL_SEND_STUD_LECT.Where(w => w.STUD_ID == stud_id).ToList();
                if (temp1.Count > 0)
                {
                    _Lect.DataSource = temp1;
                    _Lect.DataMember = "";
                    _Lect.ShowPreview();
                    // _Lect.ShowRibbonPreview();
                }
                else
                {
                    NotifictionUser notif = new NotifictionUser(" الطالب  غير مسدد    ", THAGBAN_INST.Properties.Resources.icons8_Notification_128px);
                    notif.StartPosition = FormStartPosition.CenterScreen;
                    notif.Show();
                }
            }

            else if (com_stud.Enabled == true && com_lect.Enabled == false && com_group.Enabled == true)
            {
                if (com_stud.SelectedValue != null)
                    stud_id = Convert.ToInt32(com_stud.SelectedValue);
                var temp1 = con.TBL_SEND_STUD_LECT.Where(w => w.STUD_ID == stud_id && w.TECH_LECT_ID == tech_lect_id).ToList();
                if (temp1.Count > 0)
                {
                    _Lect.DataSource = temp1;
                    _Lect.DataMember = "";
                    _Lect.ShowPreview();
                    // _Lect.ShowRibbonPreview();
                }
                else
                {
                    NotifictionUser notif = new NotifictionUser(" الطالب  غير مسدد    ", THAGBAN_INST.Properties.Resources.icons8_Notification_128px);
                    notif.StartPosition = FormStartPosition.CenterScreen;
                    notif.Show();
                }
            }

            else
            {

                //_Lect.DataSource = con.TBL_SEND_STUD_LECT.ToList();

                // _Lect.ShowPreview();
                var temp1 = con.TBL_SEND_STUD_LECT.ToList();
                if (temp1.Count > 0)
                {
                    // _Lect.ShowPreview();

                    _Lect.ShowRibbonPreview();
                }
                else
                {
                    NotifictionUser notif = new NotifictionUser(" لايوجد طلاب مسجيلين في الدورات ", THAGBAN_INST.Properties.Resources.icons8_Notification_128px);
                    notif.StartPosition = FormStartPosition.CenterScreen;
                    notif.Show();
                }
                // _Lect.DataSource=con.TBL_SEND_STUD_LECT.Where(w=>w.id)

            }



        }
      
        void print_studnts_name()
        {
            report_lect_studns_ttend _Lect = new report_lect_studns_ttend();

            if (com_lect.Enabled == true && com_group.Enabled == false && com_stud.Enabled == false)
            {
                if (com_lect.SelectedValue != null)
                    lect_id = Convert.ToInt32(com_lect.SelectedValue);
                var temp_lec = con.TBL_STUD_LECT.Where(w => w.LECT_ID == lect_id).ToList();

                // _Lect.DataSource=con.TBL_SEND_STUD_LECT.Where(w=>w.id)
                if (temp_lec.Count > 0)
                {

                    _Lect.DataSource = temp_lec.ToList();

                    
                    int ints_id = THAGBAN_INST.Properties.Settings.Default.inst_id;
                    _Lect.lbl_inst_name.Text = con.TBL_INST.Find(ints_id).INST_NAME.ToString();
                    adl.method method = new adl.method();
                    method.data = con.TBL_INST.Find(ints_id).INST_LOGO;
                    _Lect.inst_logo.Image = Image.FromStream(method.convert_image());
                    _Lect.Watermark.Image = Image.FromStream(method.convert_image());
                    _Lect.lbl_inst_desc.Text = con.TBL_INST.Find(ints_id).INST_DESC;
                    _Lect.lbl_inst_locationn.Text = con.TBL_INST.Find(ints_id).INST_LOCATION;


                    _Lect.DataMember = "";
                    _Lect.ShowPreview();
                    // _Lect.ShowRibbonPreview();

                }
                else
                {
                    NotifictionUser notif = new NotifictionUser("    لايوجد طلاب   في هذه الدوره ", THAGBAN_INST.Properties.Resources.icons8_Notification_128px);
                    notif.StartPosition = FormStartPosition.CenterScreen;
                    notif.Show();
                }
            }


            else if (com_lect.Enabled == true && com_group.Enabled == true && com_stud.Enabled == false)
            {
                if (com_group.SelectedValue != null)
                    tech_lect_id = Convert.ToInt32(com_group.SelectedValue);
                var temp_tech = con.TBL_STUD_LECT.Where(w => w.LECT_ID == lect_id && w.LECT_TECH_ID == tech_lect_id).ToList();
                // _Lect.DataSource=con.TBL_SEND_STUD_LECT.Where(w=>w.id)
                if (temp_tech.Count > 0)
                {
                    _Lect.DataSource = temp_tech;
                    _Lect.DataMember = "";

                    int ints_id = THAGBAN_INST.Properties.Settings.Default.inst_id;
                    _Lect.lbl_inst_name.Text = con.TBL_INST.Find(ints_id).INST_NAME.ToString();
                    adl.method method = new adl.method();
                    method.data = con.TBL_INST.Find(ints_id).INST_LOGO;
                    _Lect.inst_logo.Image = Image.FromStream(method.convert_image());
                    _Lect.Watermark.Image = Image.FromStream(method.convert_image());
                    _Lect.lbl_inst_desc.Text = con.TBL_INST.Find(ints_id).INST_DESC;
                    _Lect.lbl_inst_locationn.Text = con.TBL_INST.Find(ints_id).INST_LOCATION;
                    _Lect.ShowPreview();
                    //_Lect.ShowRibbonPreview();
                }
                else
                {
                    NotifictionUser notif = new NotifictionUser("    لايوجد طلاب   في هذه الدوره ", THAGBAN_INST.Properties.Resources.icons8_Notification_128px);
                    notif.StartPosition = FormStartPosition.CenterScreen;
                    notif.Show();
                }
            }

            else if (com_lect.Enabled == true && com_group.Enabled == true && com_stud.Enabled == true)
            {
                if (com_group.SelectedValue != null)
                    tech_lect_id = Convert.ToInt32(com_group.SelectedValue);
                stud_id = Convert.ToInt32(com_stud.SelectedValue);
                var temp = con.TBL_STUD_LECT.Where(w => w.LECT_ID == lect_id && w.LECT_TECH_ID == tech_lect_id && w.STUD_ID == stud_id).ToList();
                // _Lect.DataSource=con.TBL_SEND_STUD_LECT.Where(w=>w.id)
                if (temp.Count > 0)
                {
                    _Lect.DataSource = temp;
                    _Lect.DataMember = "";

                    int ints_id = THAGBAN_INST.Properties.Settings.Default.inst_id;
                    _Lect.lbl_inst_name.Text = con.TBL_INST.Find(ints_id).INST_NAME.ToString();
                    adl.method method = new adl.method();
                    method.data = con.TBL_INST.Find(ints_id).INST_LOGO;
                    _Lect.inst_logo.Image = Image.FromStream(method.convert_image());
                    _Lect.Watermark.Image = Image.FromStream(method.convert_image());
                    _Lect.lbl_inst_desc.Text = con.TBL_INST.Find(ints_id).INST_DESC;
                    _Lect.lbl_inst_locationn.Text = con.TBL_INST.Find(ints_id).INST_LOCATION;
                    _Lect.ShowPreview();
                    //_Lect.ShowRibbonPreview();
                }
                else
                {
                    NotifictionUser notif = new NotifictionUser("      الطالب غير مسجل بهذه الدوره  في هذه الدوره ", THAGBAN_INST.Properties.Resources.icons8_Notification_128px);
                    notif.StartPosition = FormStartPosition.CenterScreen;
                    notif.Show();
                }
            }

            else if (com_lect.Enabled == true && com_group.Enabled == false && com_stud.Enabled == true)
            {
                if (com_group.SelectedValue != null)
                    tech_lect_id = Convert.ToInt32(com_group.SelectedValue);
                stud_id = Convert.ToInt32(com_stud.SelectedValue);
                var temp = con.TBL_STUD_LECT.Where(w => w.LECT_ID == lect_id && w.STUD_ID == stud_id).ToList();
                // _Lect.DataSource=con.TBL_SEND_STUD_LECT.Where(w=>w.id)
                if (temp.Count > 0)
                {
                    _Lect.DataSource = temp;
                    _Lect.DataMember = "";

                    int ints_id = THAGBAN_INST.Properties.Settings.Default.inst_id;
                    _Lect.lbl_inst_name.Text = con.TBL_INST.Find(ints_id).INST_NAME.ToString();
                    adl.method method = new adl.method();
                    method.data = con.TBL_INST.Find(ints_id).INST_LOGO;
                    _Lect.inst_logo.Image = Image.FromStream(method.convert_image());
                    _Lect.Watermark.Image = Image.FromStream(method.convert_image());
                    _Lect.lbl_inst_desc.Text = con.TBL_INST.Find(ints_id).INST_DESC;
                    _Lect.lbl_inst_locationn.Text = con.TBL_INST.Find(ints_id).INST_LOCATION;
                    _Lect.ShowPreview();
                    //_Lect.ShowRibbonPreview();
                }
                else
                {
                    NotifictionUser notif = new NotifictionUser("    لايوجد طلاب   في هذه الدوره ", THAGBAN_INST.Properties.Resources.icons8_Notification_128px);
                    notif.StartPosition = FormStartPosition.CenterScreen;
                    notif.Show();
                }
            }

            else if (com_stud.Enabled == true && com_lect.Enabled == false && com_group.Enabled == false)
            {
                if (com_stud.SelectedValue != null)
                    stud_id = Convert.ToInt32(com_stud.SelectedValue);
                var temp1 = con.TBL_STUD_LECT.Where(w => w.STUD_ID == stud_id).ToList();
                if (temp1.Count > 0)
                {
                    _Lect.DataSource = temp1;
                    _Lect.DataMember = "";
                    int ints_id = THAGBAN_INST.Properties.Settings.Default.inst_id;
                    _Lect.lbl_inst_name.Text = con.TBL_INST.Find(ints_id).INST_NAME.ToString();
                    adl.method method = new adl.method();
                    method.data = con.TBL_INST.Find(ints_id).INST_LOGO;
                    _Lect.inst_logo.Image = Image.FromStream(method.convert_image());
                    _Lect.Watermark.Image = Image.FromStream(method.convert_image());
                    _Lect.lbl_inst_desc.Text = con.TBL_INST.Find(ints_id).INST_DESC;
                    _Lect.lbl_inst_locationn.Text = con.TBL_INST.Find(ints_id).INST_LOCATION;
                    _Lect.ShowPreview();
                    // _Lect.ShowRibbonPreview();
                }
                else
                {
                    NotifictionUser notif = new NotifictionUser(" الطالب   غير مسجل باي دوره     ", THAGBAN_INST.Properties.Resources.icons8_Notification_128px);
                    notif.StartPosition = FormStartPosition.CenterScreen;
                    notif.Show();
                }
            }

            else if (com_stud.Enabled == true && com_lect.Enabled == false && com_group.Enabled == true)
            {
                if (com_stud.SelectedValue != null)
                    stud_id = Convert.ToInt32(com_stud.SelectedValue);
                var temp1 = con.TBL_STUD_LECT.Where(w => w.STUD_ID == stud_id && w.LECT_TECH_ID == tech_lect_id).ToList();
                if (temp1.Count > 0)
                {
                    _Lect.DataSource = temp1;
                    _Lect.DataMember = "";
                    int ints_id = THAGBAN_INST.Properties.Settings.Default.inst_id;
                    _Lect.lbl_inst_name.Text = con.TBL_INST.Find(ints_id).INST_NAME.ToString();
                    adl.method method = new adl.method();
                    method.data = con.TBL_INST.Find(ints_id).INST_LOGO;
                    _Lect.inst_logo.Image = Image.FromStream(method.convert_image());
                    _Lect.Watermark.Image = Image.FromStream(method.convert_image());
                    _Lect.lbl_inst_desc.Text = con.TBL_INST.Find(ints_id).INST_DESC;
                    _Lect.lbl_inst_locationn.Text = con.TBL_INST.Find(ints_id).INST_LOCATION;
                    _Lect.ShowPreview();
                    // _Lect.ShowRibbonPreview();
                }
                else
                {
                    NotifictionUser notif = new NotifictionUser(" الطالب   غير مسجل  في هذه الدفعه    ", THAGBAN_INST.Properties.Resources.icons8_Notification_128px);
                    notif.StartPosition = FormStartPosition.CenterScreen;
                    notif.Show();
                }
            }

            else
            {

                //_Lect.DataSource = con.TBL_SEND_STUD_LECT.ToList();

                // _Lect.ShowPreview();
                var temp1 = con.TBL_STUD_LECT.ToList();
                if (temp1.Count > 0)
                {
                    // _Lect.ShowPreview();
                    int ints_id = THAGBAN_INST.Properties.Settings.Default.inst_id;
                    _Lect.lbl_inst_name.Text = con.TBL_INST.Find(ints_id).INST_NAME.ToString();
                    adl.method method = new adl.method();
                    method.data = con.TBL_INST.Find(ints_id).INST_LOGO;
                    _Lect.inst_logo.Image = Image.FromStream(method.convert_image());
                    _Lect.Watermark.Image = Image.FromStream(method.convert_image());
                    _Lect.lbl_inst_desc.Text = con.TBL_INST.Find(ints_id).INST_DESC;
                    _Lect.lbl_inst_locationn.Text = con.TBL_INST.Find(ints_id).INST_LOCATION;

                    _Lect.ShowRibbonPreview();
                }
                else
                {
                    NotifictionUser notif = new NotifictionUser(" لايوجد طلاب مسجيلين في الدورات ", THAGBAN_INST.Properties.Resources.icons8_Notification_128px);
                    notif.StartPosition = FormStartPosition.CenterScreen;
                    notif.Show();
                }
                // _Lect.DataSource=con.TBL_SEND_STUD_LECT.Where(w=>w.id)

            }

        }
        private void com_stud_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (com_stud.SelectedValue != null)
                {
                    stud_id = Convert.ToInt32(com_stud.SelectedValue);
                    simpleButton2.Enabled = true;
                }
                else
                { 
                  simpleButton2.Enabled=false;
                }


            }
            catch(Exception ex)
            {

            }
        }

        private void ch_lect_CheckedChanged(object sender, EventArgs e)
        {
            cheack_change();
        }
        void cheack_change()
        {

            if (ch_lect.Checked)
            {
                groupBox1.Enabled = true;
                com_lect.Enabled = true;
            }
            else
            {
                com_lect.Enabled = false;
            }
            if (ch_grou.Checked)
            {
                com_group.Enabled = true;

            }
            else
            {
                //groupBox1.Enabled = false;
                //groupBox1.Visible = false;
                com_group.Enabled = false;
            }
            if (ch_stud.Checked)
            {
                com_stud.Enabled = true;
            }
            else
            {
                com_stud.Enabled = false;
            }
            Get_piad();
        }

        private void ch_grou_CheckedChanged(object sender, EventArgs e)
        {

            cheack_change();
            
        }

        private void lbl_mal_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            cheack_change();
            print_studnts_name();
        }
    }

}
