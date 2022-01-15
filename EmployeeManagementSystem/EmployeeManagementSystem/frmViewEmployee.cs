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
    public partial class frmViewEmployee : Form
    {
        public frmViewEmployee()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("data source=DESKTOP-QVN1TMN;initial catalog=WinformEmployeeManagementDB;integrated security=true;");

        private void FetchData()
        {
            con.Open();

            string query = "select * from Employees where EmployeId='" + txtCalisanAra.Text + "'";

            SqlCommand cmd = new SqlCommand(query, con);

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                lblCalisanId.Text = dr["EmployeId"].ToString();
                lblCalisanAd.Text = dr["EmployeeName"].ToString();
                lblCalisanAdres.Text = dr["EmployeeAddress"].ToString();
                lblCalisanCinsiyet.Text = dr["EmployeeGender"].ToString();
                lblCalisanPozisyon.Text = dr["EmployeePosition"].ToString();
                lblCalisanDogumTarihi.Text = dr["EmployeeBirtDate"].ToString();
                lblCalisanTelefon.Text = dr["EmployeePhone"].ToString();
                lblCalisanEgitim.Text = dr["EmployeeEducation"].ToString();

                lblCalisanId.Visible = true;
                lblCalisanAd.Visible = true;
                lblCalisanAdres.Visible = true;
                lblCalisanCinsiyet.Visible = true;
                lblCalisanPozisyon.Visible = true;
                lblCalisanDogumTarihi.Visible = true;
                lblCalisanTelefon.Visible = true;
                lblCalisanEgitim.Visible = true;

            }

            con.Close();
        }

        private void frmViewEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            FetchData();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();

            this.Hide();
        }

        //Yazdır butonu
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("==== Çalışan Özeti ===", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(180));//başlık ortalama ayarı

            e.Graphics.DrawString("Çalışan Id: " + lblCalisanId.Text+"\tÇalışan Adı: "+lblCalisanAd.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10,100));
            e.Graphics.DrawString("Çalışan Adres: " + lblCalisanAdres.Text+"\tÇalışan Cinsiyet: "+lblCalisanCinsiyet.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10,140));
            e.Graphics.DrawString("Çalışan Pozisyon: " + lblCalisanPozisyon.Text+"\tÇalışan Doğum Tarihi: "+lblCalisanDogumTarihi.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10,180));
            e.Graphics.DrawString("Eğitim Durumu: " + lblCalisanEgitim.Text+"\tTelefon: "+lblCalisanTelefon.Text, new Font("Century Gothic", 18, FontStyle.Regular), Brushes.Blue, new Point(10,220));

            e.Graphics.DrawString("==== Çalışan Yönetim Sistemi ===", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(180,280));
        }
    }
}
