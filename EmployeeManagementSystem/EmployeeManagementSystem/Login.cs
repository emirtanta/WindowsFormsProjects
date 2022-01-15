using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Giriş yap butonu
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text=="" || txtKullaniciSifre.Text=="")
            {
                MessageBox.Show("Kullanıcı adı ve şifresini girin");
            }

            else if(txtKullaniciAdi.Text=="Admin" && txtKullaniciSifre.Text=="Admin123")
            {
                this.Hide();

                Home home = new Home();

                home.Show();
            }

            else
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre girdiniz");
            }
        }
    }
}
