
namespace login
{
    partial class login
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.loginpanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pwforget = new System.Windows.Forms.Label();
            this.login_button = new Guna.UI2.WinForms.Guna2Button();
            this.pwlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pwbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.idbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginpanel
            // 
            this.loginpanel.BackColor = System.Drawing.Color.Transparent;
            this.loginpanel.Controls.Add(this.pwforget);
            this.loginpanel.Controls.Add(this.login_button);
            this.loginpanel.Controls.Add(this.pwlabel);
            this.loginpanel.Controls.Add(this.label1);
            this.loginpanel.Controls.Add(this.pwbox);
            this.loginpanel.Controls.Add(this.login_label);
            this.loginpanel.Controls.Add(this.idbox);
            this.loginpanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.loginpanel.Location = new System.Drawing.Point(18, 11);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Radius = 10;
            this.loginpanel.ShadowColor = System.Drawing.Color.Black;
            this.loginpanel.Size = new System.Drawing.Size(767, 426);
            this.loginpanel.TabIndex = 0;
            // 
            // pwforget
            // 
            this.pwforget.AutoSize = true;
            this.pwforget.Font = new System.Drawing.Font("배달의민족 도현", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pwforget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(102)))), ((int)(((byte)(182)))));
            this.pwforget.Location = new System.Drawing.Point(409, 241);
            this.pwforget.Name = "pwforget";
            this.pwforget.Size = new System.Drawing.Size(114, 15);
            this.pwforget.TabIndex = 6;
            this.pwforget.Text = "Forgot Passworld";
            this.pwforget.Click += new System.EventHandler(this.pwforget_Click);
            // 
            // login_button
            // 
            this.login_button.BorderRadius = 8;
            this.login_button.CheckedState.Parent = this.login_button;
            this.login_button.CustomImages.Parent = this.login_button;
            this.login_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_button.DisabledState.Parent = this.login_button;
            this.login_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(102)))), ((int)(((byte)(182)))));
            this.login_button.Font = new System.Drawing.Font("배달의민족 도현", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.HoverState.Parent = this.login_button;
            this.login_button.Location = new System.Drawing.Point(226, 280);
            this.login_button.Name = "login_button";
            this.login_button.ShadowDecoration.Parent = this.login_button;
            this.login_button.Size = new System.Drawing.Size(276, 45);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Login";
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            this.login_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_button_KeyDown);
            // 
            // pwlabel
            // 
            this.pwlabel.AutoSize = true;
            this.pwlabel.Font = new System.Drawing.Font("배달의민족 도현", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pwlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(164)))), ((int)(((byte)(160)))));
            this.pwlabel.Location = new System.Drawing.Point(212, 170);
            this.pwlabel.Name = "pwlabel";
            this.pwlabel.Size = new System.Drawing.Size(67, 15);
            this.pwlabel.TabIndex = 4;
            this.pwlabel.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("배달의민족 도현", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(164)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(212, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // pwbox
            // 
            this.pwbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(102)))), ((int)(((byte)(182)))));
            this.pwbox.BorderRadius = 5;
            this.pwbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pwbox.DefaultText = "";
            this.pwbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pwbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pwbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pwbox.DisabledState.Parent = this.pwbox;
            this.pwbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pwbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.pwbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pwbox.FocusedState.Parent = this.pwbox;
            this.pwbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pwbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pwbox.HoverState.Parent = this.pwbox;
            this.pwbox.Location = new System.Drawing.Point(208, 190);
            this.pwbox.Name = "pwbox";
            this.pwbox.PasswordChar = '*';
            this.pwbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(102)))), ((int)(((byte)(182)))));
            this.pwbox.PlaceholderText = "";
            this.pwbox.SelectedText = "";
            this.pwbox.ShadowDecoration.Parent = this.pwbox;
            this.pwbox.Size = new System.Drawing.Size(317, 44);
            this.pwbox.TabIndex = 2;
            this.pwbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_button_KeyDown);
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("배달의민족 도현", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.login_label.ForeColor = System.Drawing.Color.White;
            this.login_label.Location = new System.Drawing.Point(319, 33);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(85, 29);
            this.login_label.TabIndex = 1;
            this.login_label.Text = "Login";
            // 
            // idbox
            // 
            this.idbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(102)))), ((int)(((byte)(182)))));
            this.idbox.BorderRadius = 5;
            this.idbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idbox.DefaultText = "";
            this.idbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idbox.DisabledState.Parent = this.idbox;
            this.idbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.idbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idbox.FocusedState.Parent = this.idbox;
            this.idbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.idbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idbox.HoverState.Parent = this.idbox;
            this.idbox.Location = new System.Drawing.Point(208, 105);
            this.idbox.Name = "idbox";
            this.idbox.PasswordChar = '\0';
            this.idbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(102)))), ((int)(((byte)(182)))));
            this.idbox.PlaceholderText = "";
            this.idbox.SelectedText = "";
            this.idbox.ShadowDecoration.Parent = this.idbox;
            this.idbox.Size = new System.Drawing.Size(317, 44);
            this.idbox.TabIndex = 0;
            this.idbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_button_KeyDown);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginpanel);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel loginpanel;
        private System.Windows.Forms.Label login_label;
        private Guna.UI2.WinForms.Guna2TextBox idbox;
        private System.Windows.Forms.Label pwlabel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox pwbox;
        private Guna.UI2.WinForms.Guna2Button login_button;
        private System.Windows.Forms.Label pwforget;
    }
}

