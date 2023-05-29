using System;
using System.Drawing;
using System.Windows.Forms;
using THAGBAN_INST.Properties;

namespace THAGBAN_INST.adl { 
    public partial class NotifictionUser : Form
    {
        public NotifictionUser(string Caption,Image iamg)
        {
            InitializeComponent();
            labelNotifictionCatption.Text = Caption;
            this.pictureBox1.Image= iamg;
            timerhide.Interval = Properties.Settings.Default.NotificationTime;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void labelNotifictionCatption_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
