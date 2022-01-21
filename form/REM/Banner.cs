using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Banner : Form
    {
        static public string username;
        static public string banner;

        public Banner()
        {
            InitializeComponent();
        }

        private void Banner_Load(object sender, EventArgs e)
        {
            this.Text = username + "'s Profile Banner";
            banner_box.ImageLocation = banner;
            banner_box.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
