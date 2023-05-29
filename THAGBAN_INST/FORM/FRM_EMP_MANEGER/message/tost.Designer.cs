namespace THAGBAN_INST.FORM
{
    partial class tost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pic_mess = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_mess = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_mess)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_mess
            // 
            this.pic_mess.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_mess.Image = global::THAGBAN_INST.Properties.Resources.panel_picture_frame_bg_pressed_blue_9;
            this.pic_mess.Location = new System.Drawing.Point(0, 0);
            this.pic_mess.Name = "pic_mess";
            this.pic_mess.Size = new System.Drawing.Size(100, 73);
            this.pic_mess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_mess.TabIndex = 0;
            this.pic_mess.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(379, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(21, 73);
            this.panel1.TabIndex = 1;
            // 
            // lbl_mess
            // 
            this.lbl_mess.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mess.Appearance.Options.UseFont = true;
            this.lbl_mess.Appearance.Options.UseTextOptions = true;
            this.lbl_mess.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbl_mess.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_mess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_mess.Location = new System.Drawing.Point(100, 0);
            this.lbl_mess.Name = "lbl_mess";
            this.lbl_mess.Size = new System.Drawing.Size(279, 73);
            this.lbl_mess.TabIndex = 44;
            this.lbl_mess.Text = "الرساله";
            this.lbl_mess.Click += new System.EventHandler(this.lbl_mess_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 73);
            this.Controls.Add(this.lbl_mess);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_mess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tost";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "tost";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pic_mess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox pic_mess;
        public DevExpress.XtraEditors.LabelControl lbl_mess;
    }
}