using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;

namespace login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (idbox.Text == "" || pwbox.Text == "")
            {
                MessageBox.Show("아이디 또는 비밀번호를 입력해주세요.", "Login Manager");
                return;
            }
            WebClient client = new WebClient();

            try
            {
                using (Stream data = client.OpenRead("http://127.0.0.1/v1/login/" + idbox.Text + "/" + pwbox.Text))
                {
                    using (StreamReader reader = new StreamReader(data))
                    {
                        String s = reader.ReadToEnd();
                        if (s == "로그인 성공.")
                        {
                            this.Hide();
                            main.ID = idbox.Text;
                            main.PW = pwbox.Text;
                            new main().Show();
                            Properties.Settings.Default.id = idbox.Text;
                            Properties.Settings.Default.Save();
                            Properties.Settings.Default.pw = pwbox.Text;
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            MessageBox.Show("올바르지 않은 비밀번호 입니다.", "Login Manager");
                        }

                        reader.Close();
                        data.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("로그인 서버와 통신중 오류가 발생했습니다.\n" + ex, "Login Manager");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            idbox.Text = Properties.Settings.Default.id;
            pwbox.Text = Properties.Settings.Default.pw;
        }

        private void pwforget_Click(object sender, EventArgs e)
        {
            MessageBox.Show("에밀리아 봇을 이용해 비밀번호를 재설정 해주세요.", "Login Manager");
        }

        private void login_button_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                login_button_Click(sender, e);
                login_button.Select();
            }
        }
    }
}
