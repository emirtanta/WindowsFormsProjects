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
    public partial class frmDoctor : Form
    {
        public frmDoctor()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("data source=DESKTOP-QVN1TMN;initial catalog=WinFormsHospitalManagementDB;integrated security=true;Connect Timeout=30");

        //Doktor Ekle
        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {

            if (txtDoktorId.Text=="" || txtDoktorAdi.Text=="" || txtUzmanlikYili.Text=="" || txtDoktorSifre.Text=="")
            {
                MessageBox.Show("Alanları doldurun");
            }

            else
            {
                con.Open();

                string query = "insert into Doctors values(" + txtDoktorId.Text + ",'" + txtDoktorAdi.Text + "','" + txtUzmanlikYili.Text + "','" + txtDoktorSifre.Text + "')";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Doktor kaydedildi");

               

                con.Close();

                populate();
            }

            
        }

        private void btnDoktorAnasayfa_Click(object sender, EventArgs e)
        {
            frmHome h = new frmHome();
            h.Show();

            this.Hide();
        }

        #region fonsiyon bölümü

        //doktorları listeleyen fonksiyon
        void populate()
        {
            con.Open();

            string query = "select * from Doctors";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            var ds = new DataSet();
            da.Fill(ds);
            DoktorGV.DataSource = ds.Tables[0];

            con.Close();

        }

        #endregion

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            populate();
        }

        //Doktor silme butonu
        private void btnDoktorSil_Click(object sender, EventArgs e)
        {
            if (txtDoktorId.Text=="")
            {
                MessageBox.Show("Doktor Id değerini girin");
            }

            else
            {
                con.Open();

                string query = "delete from Doctors where DoctorId=" + txtDoktorId.Text + "";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Doktor silindi");

                con.Close();

                populate();
            }
        }

        private void DoktorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDoktorId.Text = DoktorGV.SelectedRows[0].Cells[0].Value.ToString();
            txtDoktorAdi.Text = DoktorGV.SelectedRows[0].Cells[1].Value.ToString();
            txtUzmanlikYili.Text = DoktorGV.SelectedRows[0].Cells[2].Value.ToString();
            txtDoktorSifre.Text = DoktorGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        //Doktor Güncelle butonu
        private void btnDoktorGuncelle_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = "update Doctors set DoctorName='" + txtDoktorAdi.Text + "',DoctorExperience='" + txtUzmanlikYili.Text + "',DoctorPassword='" + txtDoktorSifre.Text + "' where DoctorId="+txtDoktorId.Text+"";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Doktor güncellendi");


            con.Close();

            populate();

        }
    }
}
