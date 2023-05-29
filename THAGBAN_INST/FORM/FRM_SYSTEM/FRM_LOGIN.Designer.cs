namespace THAGBAN_INST.FORM.FRM_SYSTEM
{
    partial class FRM_LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_LOGIN));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_login = new DevExpress.XtraEditors.SimpleButton();
            this.txt_user = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txt_pass = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 49);
            this.panel1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(38, 45);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "تسجيل الدخول ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_login);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 77);
            this.panel2.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btn_login.Appearance.Options.UseFont = true;
            this.btn_login.Appearance.Options.UseTextOptions = true;
            this.btn_login.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btn_login.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisPath;
            this.btn_login.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.btn_login.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btn_login.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btn_login.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_login.ImageOptions.Image")));
            this.btn_login.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_login.Location = new System.Drawing.Point(125, 11);
            this.btn_login.Name = "btn_login";
            this.btn_login.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_login.Size = new System.Drawing.Size(102, 50);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "تسجيل الدخول";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_user
            // 
            this.txt_user.AcceptsReturn = false;
            this.txt_user.AcceptsTab = false;
            this.txt_user.AnimationSpeed = 200;
            this.txt_user.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_user.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_user.AutoSize = true;
            this.txt_user.BackColor = System.Drawing.Color.White;
            this.txt_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_user.BackgroundImage")));
            this.txt_user.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_user.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_user.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_user.BorderColorIdle = System.Drawing.Color.Black;
            this.txt_user.BorderRadius = 30;
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_user.BorderThickness = 3;
            this.txt_user.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_user.DefaultText = "";
            this.txt_user.FillColor = System.Drawing.Color.White;
            this.txt_user.HideSelection = false;
            this.txt_user.IconLeft = null;
            this.txt_user.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user.IconPadding = 10;
            this.txt_user.IconRight = global::THAGBAN_INST.Properties.Resources.icons8_select_users_32px_1;
            this.txt_user.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user.Lines = new string[0];
            this.txt_user.Location = new System.Drawing.Point(28, 179);
            this.txt_user.MaxLength = 32767;
            this.txt_user.MinimumSize = new System.Drawing.Size(2, 2);
            this.txt_user.Modified = false;
            this.txt_user.Multiline = false;
            this.txt_user.Name = "txt_user";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_user.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_user.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_user.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Black;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_user.OnIdleState = stateProperties4;
            this.txt_user.Padding = new System.Windows.Forms.Padding(3);
            this.txt_user.PasswordChar = '\0';
            this.txt_user.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_user.PlaceholderText = "اسم المستخدم";
            this.txt_user.ReadOnly = false;
            this.txt_user.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_user.SelectedText = "";
            this.txt_user.SelectionLength = 0;
            this.txt_user.SelectionStart = 0;
            this.txt_user.ShortcutsEnabled = true;
            this.txt_user.Size = new System.Drawing.Size(308, 56);
            this.txt_user.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_user.TabIndex = 100;
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_user.TextMarginBottom = 0;
            this.txt_user.TextMarginLeft = 3;
            this.txt_user.TextMarginTop = 2;
            this.txt_user.TextPlaceholder = "اسم المستخدم";
            this.txt_user.UseSystemPasswordChar = false;
            this.txt_user.WordWrap = true;
            this.txt_user.TextChange += new System.EventHandler(this.txt_user_TextChange);
            this.txt_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_user_KeyPress);
            this.txt_user.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_user_KeyUp);
            // 
            // txt_pass
            // 
            this.txt_pass.AcceptsReturn = false;
            this.txt_pass.AcceptsTab = false;
            this.txt_pass.AnimationSpeed = 200;
            this.txt_pass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_pass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_pass.AutoSize = true;
            this.txt_pass.BackColor = System.Drawing.Color.White;
            this.txt_pass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_pass.BackgroundImage")));
            this.txt_pass.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_pass.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_pass.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_pass.BorderColorIdle = System.Drawing.Color.Black;
            this.txt_pass.BorderRadius = 30;
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pass.BorderThickness = 3;
            this.txt_pass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_pass.DefaultText = "";
            this.txt_pass.FillColor = System.Drawing.Color.White;
            this.txt_pass.HideSelection = false;
            this.txt_pass.IconLeft = global::THAGBAN_INST.Properties.Resources.EAYS;
            this.txt_pass.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.IconPadding = 10;
            this.txt_pass.IconRight = global::THAGBAN_INST.Properties.Resources.PASS;
            this.txt_pass.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.Lines = new string[0];
            this.txt_pass.Location = new System.Drawing.Point(28, 258);
            this.txt_pass.MaxLength = 32767;
            this.txt_pass.MinimumSize = new System.Drawing.Size(2, 2);
            this.txt_pass.Modified = false;
            this.txt_pass.Multiline = false;
            this.txt_pass.Name = "txt_pass";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_pass.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_pass.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_pass.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Black;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_pass.OnIdleState = stateProperties8;
            this.txt_pass.Padding = new System.Windows.Forms.Padding(3);
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_pass.PlaceholderText = "كلمة المرور ";
            this.txt_pass.ReadOnly = false;
            this.txt_pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_pass.SelectedText = "";
            this.txt_pass.SelectionLength = 0;
            this.txt_pass.SelectionStart = 0;
            this.txt_pass.ShortcutsEnabled = true;
            this.txt_pass.Size = new System.Drawing.Size(308, 55);
            this.txt_pass.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_pass.TabIndex = 101;
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pass.TextMarginBottom = 0;
            this.txt_pass.TextMarginLeft = 3;
            this.txt_pass.TextMarginTop = 2;
            this.txt_pass.TextPlaceholder = "كلمة المرور ";
            this.txt_pass.UseSystemPasswordChar = false;
            this.txt_pass.WordWrap = true;
            this.txt_pass.TextChange += new System.EventHandler(this.txt_pass_TextChange);
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            this.txt_pass.OnIconLeftClick += new System.EventHandler(this.txt_pass_OnIconLeftClick);
            this.txt_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pass_KeyPress);
            this.txt_pass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_pass_KeyUp);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::THAGBAN_INST.Properties.Resources.login;
            this.pictureEdit1.Location = new System.Drawing.Point(112, 55);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(143, 118);
            this.pictureEdit1.TabIndex = 102;
            // 
            // FRM_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 421);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_LOGIN";
            this.Load += new System.EventHandler(this.FRM_LOGIN_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FRM_LOGIN_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.UI.WinForms.BunifuTextBox txt_user;
        public Bunifu.UI.WinForms.BunifuTextBox txt_pass;
        private DevExpress.XtraEditors.SimpleButton btn_login;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}