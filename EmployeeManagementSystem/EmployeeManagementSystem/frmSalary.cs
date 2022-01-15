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

namespace EmployeeManagementSystem
{
    public partial class frmSalary : Form
    {
        public frmSalary()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("data source=DESKTOP-QVN1TMN;initial catalog=WinformEmployeeManagementDB;integrated security=true;");

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();



            this.Hide();
        }

        private void btnCalisanGetir_Click(object sender, EventArgs e)
        {
            FetchData();
        }

        private void FetchData()
        {

            if (txtCalisanId.Text=="")
            {
                MessageBox.Show("Lütfen Çalışan Id değeri girin");
            }

            else
            {
                con.Open();

                string query = "select * from Employees where EmployeId='" + txtCalisanId.Text + "'";

                SqlCommand cmd = new SqlCommand(query, con);

                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    txtCalisanAd.Text = dr["EmployeeName"].ToString();
                    txtCalisanPozisyon.Text = dr["EmployeePosition"].ToString();

                }

                con.Close();
            }
            
        }

        int dailybase,total;

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("==== Maaş Dökümanı ===", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(180));//başlık ortalama ayarı

            e.Graphics.DrawString("Çalışan Id: " + txtCalisanId.Text , new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(20, 100));
            e.Graphics.DrawString("Çalışan Adres: " + txtCalisanPozisyon.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(20, 140));
            e.Graphics.DrawString("Çalışılan Gün: " + txtCalisanGun.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(20, 180));
            e.Graphics.DrawString("Günlük Ödeme: " + dailybase , new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(20, 220));
            e.Graphics.DrawString("Toplam Ödeme: " + total , new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(20, 260));

            e.Graphics.DrawString("==== Çalışan Yönetim Sistemi ===", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(180, 300));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalisanGoster_Click(object sender, EventArgs e)
        {
            if (txtCalisanPozisyon.Text=="")
            {
                MessageBox.Show("Bir çalışan seçin");
            }

            else if(txtCalisanGun.Text=="" || Convert.ToInt32(txtCalisanGun.Text)>28)
            {
                MessageBox.Show("Enter A valid number of days");
            }

            else
            {
                if (txtCalisanPozisyon.Text=="Manager")
                {
                    dailybase = 1200;
                }

                else if (txtCalisanPozisyon.Text=="Senior Developper")
                {
                    dailybase = 1000;
                }

                else if (txtCalisanPozisyon.Text== "Junior Develooper")
                {
                    dailybase = 950;
                }

                else
                {
                    dailybase = 850;
                }

                total = dailybase * Convert.ToInt32(txtCalisanGun.Text);

                rchTxtDetay.Text = "Numara: "+txtCalisanId.Text + "\n"+"Çalışan Adı: " + txtCalisanAd.Text + "\n"+"Pozisyon: " + txtCalisanPozisyon.Text + "\n"+"Günlük Çalışma: " + txtCalisanGun.Text+"\n"+"Günlük Maaş Rs: "+dailybase+"\n"+"Toplam Tutar Rs: "+total;


            }
        }
    }
}
