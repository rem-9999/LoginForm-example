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
    public partial class main : Form
    {
        static public string ID;
        static public string PW;
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            banner.Hide();
            WebClient client = new WebClient();
            try
            {
                using (Stream data = client.OpenRead("http://127.0.0.1/v1/login/info/" + ID + "/" + PW))
                {
                    using (StreamReader reader = new StreamReader(data))
                    {
                        String s = reader.ReadToEnd();

                        this.Text = s;

                        try
                        {
                            using (Stream ff = client.OpenRead("https://remapi.xyz:2/discord/users/" + s))
                            {
                                using (StreamReader read = new StreamReader(ff))
                                {
                                    String str = read.ReadToEnd();
                                    JObject obj = JObject.Parse(str);

                                    if(obj["banner"].ToString() != "null")
                                    {
                                        Banner.username = obj["username"].ToString();
                                        Banner.banner = obj["banner"].ToString();
                                        banner.Show();
                                    }

                                    if (obj["banner"].ToString() == "null")
                                    {
                                        banner.Hide();
                                    }

                                    this.Text = obj["username"].ToString() + obj["discriminator"].ToString();
                                    profile.ImageLocation = obj["avatar"].ToString();
                                    profile.SizeMode = PictureBoxSizeMode.Zoom;
                                    message.Text = "Welcome " + obj["username"].ToString() + "!";
                                    name.Text = obj["username"].ToString() + "#" + obj["discriminator"].ToString();
                                    userid.Text = obj["id"].ToString();
                                    created.Text = obj["creation_date"].ToString();
                                }
                            }
                        }
                        catch (Exception er)
                        {
                            MessageBox.Show("디스코드 API와의 통신에 실패했습니다.\n" + er, "Login Manager");
                        }

                        reader.Close();
                        data.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("서버와 통신중 오류가 발생했습니다.\n" + ex, "Login Manager");
            }
        }

        public void Delay(int ms)
        {
            DateTime dateTimeNow = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, ms);
            DateTime dateTimeAdd = dateTimeNow.Add(duration);
            while (dateTimeAdd >= dateTimeNow)
            {
                System.Windows.Forms.Application.DoEvents();
                dateTimeNow = DateTime.Now;
            }
            return;
        }

        private void banner_Click(object sender, EventArgs e)
        {
            new Banner().Show();
        }
    }
}
