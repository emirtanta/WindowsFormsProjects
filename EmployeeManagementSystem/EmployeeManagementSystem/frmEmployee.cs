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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("data source=DESKTOP-QVN1TMN;initial catalog=WinformEmployeeManagementDB;integrated security=true;");

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        //Çalışan Ekle Butonu
        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            if (txtCalisanId.Text=="" || txtCalisanAd.Text=="" || txtCalisanTelefon.Text=="" || txtCalisanAdres.Text=="")
            {
                MessageBox.Show("Lütfen bilgi girin");
            }

            else
            {
                try
                {
                    con.Open();

                    string query = "insert into Employees values('"+txtCalisanId.Text+"','"+txtCalisanAd.Text+"','"+txtCalisanAdres.Text+"','"+cmbCalisanPozisyon.SelectedItem.ToString()+"','"+dtpCalisanDogumTarihi.Value.Date+"','"+txtCalisanTelefon.Text+"','"+cmbCalisanEgitim.SelectedItem.ToString()+"','"+cmbCalisanCinsiyet.SelectedItem.ToString()+"')";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Çalışan kaydedildi");

                    con.Close();

                    GetEmployeList();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Çalışan Düzenle Butonu
        private void btnCalisanDuzenle_Click(object sender, EventArgs e)
        {
            if (txtCalisanId.Text == "" || txtCalisanAd.Text == "" || txtCalisanTelefon.Text == "" || txtCalisanAdres.Text == "")
            {
                MessageBox.Show("Lütfen bilgi giriniz");
            }

            else
            {
                try
                {
                    con.Open();

                    string query = "update Employees set EmployeeName='" + txtCalisanAd.Text + "',EmployeeAddress='"+txtCalisanAdres.Text+ "',EmployeePosition='"+cmbCalisanPozisyon.SelectedItem.ToString()+ "',EmployeeBirtDate='"+dtpCalisanDogumTarihi.Value.Date.ToShortDateString()+ "',EmployeePhone='"+txtCalisanTelefon.Text+ "',EmployeeEducation='"+cmbCalisanEgitim.SelectedItem.ToString()+ "',EmployeeGender='"+cmbCalisanCinsiyet.SelectedItem.ToString()+"' where EmployeId='" + txtCalisanId.Text + "'";


                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Çalışan güncellendi");

                    con.Close();

                    GetEmployeList();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Çalışan Sil Butonu
        private void btnCalisanSil_Click(object sender, EventArgs e)
        {
            if (txtCalisanId.Text=="")
            {
                MessageBox.Show("Çalışan Id Değeri Giriniz!");
            }

            else
            {
                try
                {
                    con.Open();

                    string query = "delete from Employees where EmployeId='" + txtCalisanId.Text + "';";

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Çalışan silindi!");

                    con.Close();

                    GetEmployeList();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GetEmployeList()
        {
            con.Open();

            string query = "select * from Employees";

            SqlDataAdapter sda = new SqlDataAdapter(query,con);

            SqlCommandBuilder builder = new SqlCommandBuilder(sda);

            var ds = new DataSet();

            sda.Fill(ds);
            employeeDGV.DataSource = ds.Tables[0]; //datagridview içerisine veriler yazdırılır

            con.Close();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            //satır rengini değiştirir
            employeeDGV.RowsDefaultCellStyle.BackColor = Color.White;

            //ayrıca satır rengi değiştikten sonra alttaki beyaz yerdeki satır rengini değiştirir
            employeeDGV.AlternatingRowsDefaultCellStyle.BackColor = Color.OrangeRed;



            //employeeDGV.CurrentRow.HeaderCell.Style.BackColor = Color.Magenta;


            //employeeDGV.Columns[0].HeaderCell.Style.ForeColor = Color.Yellow;

            GetEmployeList();
        }

        private void employeeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCalisanId.Text= employeeDGV.CurrentRow.Cells[0].Value.ToString();
            txtCalisanAd.Text= employeeDGV.CurrentRow.Cells[1].Value.ToString();
            txtCalisanAdres.Text= employeeDGV.CurrentRow.Cells[2].Value.ToString();
            cmbCalisanEgitim.Text = employeeDGV.CurrentRow.Cells[6].Value.ToString();
            cmbCalisanPozisyon.Text = employeeDGV.CurrentRow.Cells[3].Value.ToString();
            txtCalisanTelefon.Text= employeeDGV.CurrentRow.Cells[5].Value.ToString();
            cmbCalisanCinsiyet.Text = employeeDGV.CurrentRow.Cells[7].Value.ToString();
        }

        //Ana sayfa butonu
        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
