using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JewelleryShopManagement
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int startpoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;

            progressBar1.Value = startpoint;

            lblPercent.Text = startpoint + "%";

            if (progressBar1.Value==100)
            {
                progressBar1.Value = 0;

                timer1.Stop();

                //login formdan bir nesne oluşturarak login formun açılmasını ve bu formun kapanmasını sağladık
                Login log = new Login();
                log.Show();

                this.Hide();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
