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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        //en alttaki picturebox
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 h = new Form1();

            h.Show();
        }

        private void pictureBoxDoktor_Click(object sender, EventArgs e)
        {
            frmDoctor form = new frmDoctor();
            form.Show();

            this.Hide();
        }

        private void pictureBoxHasta_Click(object sender, EventArgs e)
        {
            frmHasta form = new frmHasta();
            form.Show();

            this.Hide();
        }

        private void pictureBoxTeshis_Click(object sender, EventArgs e)
        {
            frmTeshis form = new frmTeshis();
            form.Show();

            this.Hide();
        }
    }
}
