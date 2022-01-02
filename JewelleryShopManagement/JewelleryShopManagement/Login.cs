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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Giriş butonu
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text=="" || txtKullaniciAdi.Text=="")
            {
                MessageBox.Show("Kullanıcı adı ve şifrenizi giriniz");
            }
            
            //giriş için Admin ve Password değerini kendimiz atadık
            else if(txtKullaniciAdi.Text=="Admin" && txtSifre.Text=="Password")
            {
                Items obj = new Items();

                obj.Show();

                this.Hide();
            }
        }

        private void lblSaticiOlarakDevamEt_Click(object sender, EventArgs e)
        {
            //fatura formundan bir nesne oluşturduk
            Fatura obj = new Fatura();

            obj.Show();

            this.Hide();
        }
    }
}
