
namespace login
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.profile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.loginpanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.mainpanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.created = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.banner = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            this.loginpanel.SuspendLayout();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // profile
            // 
            this.profile.ImageRotate = 0F;
            this.profile.Location = new System.Drawing.Point(295, 14);
            this.profile.Name = "profile";
            this.profile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.profile.ShadowDecoration.Parent = this.profile;
            this.profile.Size = new System.Drawing.Size(146, 139);
            this.profile.TabIndex = 0;
            this.profile.TabStop = false;
            // 
            // loginpanel
            // 
            this.loginpanel.BackColor = System.Drawing.Color.Transparent;
            this.loginpanel.Controls.Add(this.mainpanel);
            this.loginpanel.Controls.Add(this.message);
            this.loginpanel.Controls.Add(this.profile);
            this.loginpanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.loginpanel.Location = new System.Drawing.Point(17, 12);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Radius = 10;
            this.loginpanel.ShadowColor = System.Drawing.Color.Black;
            this.loginpanel.Size = new System.Drawing.Size(767, 426);
            this.loginpanel.TabIndex = 1;
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.Transparent;
            this.mainpanel.Controls.Add(this.banner);
            this.mainpanel.Controls.Add(this.created);
            this.mainpanel.Controls.Add(this.label2);
            this.mainpanel.Controls.Add(this.userid);
            this.mainpanel.Controls.Add(this.label1);
            this.mainpanel.Controls.Add(this.name);
            this.mainpanel.Controls.Add(this.username);
            this.mainpanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.mainpanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.mainpanel.Location = new System.Drawing.Point(140, 233);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Radius = 10;
            this.mainpanel.ShadowColor = System.Drawing.Color.Black;
            this.mainpanel.Size = new System.Drawing.Size(471, 172);
            this.mainpanel.TabIndex = 2;
            // 
            // created
            // 
            this.created.AutoSize = true;
            this.created.Font = new System.Drawing.Font("배달의민족 도현", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.created.ForeColor = System.Drawing.Color.White;
            this.created.Location = new System.Drawing.Point(156, 74);
            this.created.Name = "created";
            this.created.Size = new System.Drawing.Size(81, 19);
            this.created.TabIndex = 5;
            this.created.Text = "created";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("배달의민족 도현", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Registered On:";
            // 
            // userid
            // 
            this.userid.AutoSize = true;
            this.userid.Font = new System.Drawing.Font("배달의민족 도현", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userid.ForeColor = System.Drawing.Color.White;
            this.userid.Location = new System.Drawing.Point(57, 116);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(27, 19);
            this.userid.TabIndex = 3;
            this.userid.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("배달의민족 도현", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("배달의민족 도현", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(124, 34);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(59, 19);
            this.name.TabIndex = 1;
            this.name.Text = "name";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("배달의민족 도현", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(26, 34);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(98, 19);
            this.username.TabIndex = 0;
            this.username.Text = "Username:";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("배달의민족 도현", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.message.ForeColor = System.Drawing.Color.White;
            this.message.Location = new System.Drawing.Point(235, 181);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 29);
            this.message.TabIndex = 1;
            // 
            // banner
            // 
            this.banner.BackColor = System.Drawing.Color.Transparent;
            this.banner.Font = new System.Drawing.Font("배달의민족 도현", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.banner.ForeColor = System.Drawing.Color.White;
            this.banner.Location = new System.Drawing.Point(363, 15);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(86, 17);
            this.banner.TabIndex = 3;
            this.banner.Text = "Show Banner";
            this.banner.Click += new System.EventHandler(this.banner_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginpanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "Made By REM";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox profile;
        private Guna.UI2.WinForms.Guna2ShadowPanel loginpanel;
        private System.Windows.Forms.Label message;
        private Guna.UI2.WinForms.Guna2ShadowPanel mainpanel;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label userid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label created;
        private Guna.UI2.WinForms.Guna2HtmlLabel banner;
    }
}