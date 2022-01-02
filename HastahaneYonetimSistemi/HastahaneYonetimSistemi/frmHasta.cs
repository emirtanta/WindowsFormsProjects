using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastahaneYonetimSistemi
{
    public partial class frmHasta : Form
    {
        public frmHasta()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("data source=DESKTOP-QVN1TMN;initial catalog=WinFormsHospitalManagementDB;integrated security=true;");

        private void btnHastaAnaSayfa_Click(object sender, EventArgs e)
        {
            frmHome h = new frmHome();
            h.Show();

            this.Hide();
        }

        //hastaları listeleyen fonksiyon
        void populate()
        {
            con.Open();

            string query = "select * from Patients";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            var ds = new DataSet();
            da.Fill(ds);
            HastaGV.DataSource = ds.Tables[0];

            con.Close();

        }

        //Hasta Ekle formu
        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            if (txtHastaId.Text == "" || txtHastaAd.Text == "" || txtHastaAdres.Text == "" || txtHastaTelefon.Text == "" || txtHastaYas.Text=="" || txtHastaBuyukHastalik.Text=="")
            {
                MessageBox.Show("Alanları doldurun");
            }

            else
            {
                con.Open();

                string query = "insert into Patients values(" + txtHastaId.Text + ",'" + txtHastaAd.Text + "','" + txtHastaAdres.Text + "','" + txtHastaTelefon.Text + "','"+txtHastaYas.Text+"','"+cmbHastaCinsiyet.SelectedItem.ToString()+"','"+cmbHastaKanGrubu.SelectedItem.ToString()+"','"+txtHastaBuyukHastalik.Text+"')";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Hasta kaydedildi");

                con.Close();

                populate();
            }
        }

        private void frmHasta_Load(object sender, EventArgs e)
        {
            populate();
        }

        //Hasta Sil butonu
        private void btnHastaSil_Click(object sender, EventArgs e)
        {
            if (txtHastaId.Text == "")
            {
                MessageBox.Show("Hasta Id değerini girin");
            }

            else
            {
                con.Open();

                string query = "delete from Patients where PatientId=" + txtHastaId.Text + "";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Hasta silindi");

                con.Close();

                populate();
            }
        }

        private void HastaGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtHastaId.Text = HastaGV.CurrentRow.Cells[0].Value.ToString();
            txtHastaAd.Text = HastaGV.CurrentRow.Cells[1].Value.ToString();
            txtHastaAdres.Text = HastaGV.CurrentRow.Cells[2].Value.ToString();
            txtHastaTelefon.Text = HastaGV.CurrentRow.Cells[3].Value.ToString();
            txtHastaYas.Text = HastaGV.CurrentRow.Cells[4].Value.ToString();
            //cmbHastaCinsiyet.SelectedItem = HastaGV.CurrentRow.Cells[5].Value.ToString();
            //cmbHastaKanGrubu.SelectedItem = HastaGV.CurrentRow.Cells[6].Value.ToString();
            txtHastaBuyukHastalik.Text = HastaGV.CurrentRow.Cells[7].Value.ToString();
        }

        //Hasta Güncelle butonu
        private void btnHastaGuncelle_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = "update Patients set PatientName='" + txtHastaAd.Text + "',PatientAddress='" + txtHastaAdres.Text + "',PatientPhone='" + txtHastaTelefon.Text + "',PatientAge='"+txtHastaYas.Text+ "',PatientGender='"+cmbHastaCinsiyet.SelectedItem.ToString()+"',PatientBlood='"+cmbHastaKanGrubu.SelectedItem.ToString()+ "',PatientDisease='" + txtHastaBuyukHastalik.Text+"' where PatientId=" + txtHastaId.Text + "";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Hasta güncellendi");


            con.Close();

            populate();
        }
    }
}
