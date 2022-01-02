using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastahaneYonetimSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("data source=DESKTOP-QVN1TMN;initial catalog=WinFormsHospitalManagementDB;integrated security=true;");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text=="" || txtKullaniciSifre.Text=="")
            {
                MessageBox.Show("Kullanıcı adı ve şifresini girin");
            }

            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from Doctors where DoctorName='" + txtKullaniciAdi.Text+ "' and DoctorPassword='"+txtKullaniciSifre.Text+"'",con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString()=="1")
                {
                    frmHome h = new frmHome();
                    h.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Yanlış kullanıcı adı ya da şifre girdiniz");
                }

                con.Close();
                
            }

            
        }

        //Temizle labeli
        private void lblTemizle_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.Text = "";
            txtKullaniciSifre.Text = "";
        }
    }
}
