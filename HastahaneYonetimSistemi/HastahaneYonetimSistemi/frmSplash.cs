using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastahaneYonetimSistemi
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        int startpoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {

            startpoint += 1;

            progressBar1.Value = startpoint;

            if (progressBar1.Value==100)
            {
                progressBar1.Value = 0;

                timer1.Stop();

                Form1 login = new Form1();
                login.Show();

                this.Hide();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
