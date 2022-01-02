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
    public partial class frmTeshis : Form
    {
        public frmTeshis()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("data source=DESKTOP-QVN1TMN;initial catalog=WinFormsHospitalManagementDB;integrated security=true;");


        //TeşhisHata combobox'unu hasta Id değeri ile dolduran fonksiyon
        void populatecombo()
        {
            string sql = "select * from Patients";

            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader rdr;

            try
            {
                con.Open();


                DataTable dt = new DataTable();
                dt.Columns.Add("PatientId", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                cmbTeshisHastaId.ValueMember = "PatientId";
                cmbTeshisHastaId.DataSource = dt;

                con.Close();
            }
            catch 
            {

               
            }
        }


        string patientname;

        //TeşhisHataId combobox değerinden seçilen Id değerinin Hasta adını hasta textbox'ına yazar
        void FetchPatientName()
        {
            con.Open();

            string mysql = "select * from Patients where PatientId=" + cmbTeshisHastaId.SelectedValue.ToString() + "";

            SqlCommand cmd = new SqlCommand(mysql,con);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                patientname = dr["PatientName"].ToString();
                txtTeshisHastaAd.Text = patientname;
            }


            con.Close();
        }

        //hastaları listeleyen fonksiyon
        void populate()
        {
            con.Open();

            string query = "select * from Diagnosises";

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            var ds = new DataSet();
            da.Fill(ds);
            TeshisGV.DataSource = ds.Tables[0];

            con.Close();

        }

        private void btnTeshisAnasayfa_Click(object sender, EventArgs e)
        {
            frmHome h = new frmHome();
            h.Show();

            this.Hide();
        }
        
        //Teşhis Ekle butonu
        private void btnTeshisEkle_Click(object sender, EventArgs e)
        {
            if (txtTeshisId.Text == "" || txtTeshisSemptom.Text == "" || txtTeshisHastaAd.Text == "" || txtTeshisler.Text == "" || txtIlaclar.Text == "" )
            {
                MessageBox.Show("Alanları doldurun");
            }

            else
            {
                con.Open();

                string query = "insert into Diagnosises values(" + txtTeshisId.Text + ",'" + cmbTeshisHastaId.SelectedValue.ToString() + "','" + txtTeshisHastaAd.Text + "','" + txtTeshisSemptom.Text + "','" + txtTeshisler.Text + "','" + txtIlaclar.Text + "')";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Teşhis kaydedildi");

                con.Close();

                populate();
            }
        }

        private void frmTeshis_Load(object sender, EventArgs e)
        {
            populatecombo();

            populate();

        }

        private void cmbTeshisHastaId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchPatientName();
        }

        //Teşhis Güncelle butonu
        private void btnTeshisGuncelle_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = "update Diagnosises set PatientId='" + cmbTeshisHastaId.SelectedValue.ToString() + "',PatientName='" + txtTeshisHastaAd.Text + "',Symptoms='" + txtTeshisSemptom.Text + "',Diagnosis='" + txtTeshisler.Text + "',Medicines='" + txtIlaclar.Text + "' where DiagnosisId=" + txtTeshisId.Text + "";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Teşhis güncellendi");


            con.Close();

            populate();
        }

        //Teşhis Sil butonu
        private void btnTeshisSil_Click(object sender, EventArgs e)
        {
            if (txtTeshisId.Text == "")
            {
                MessageBox.Show("Teşhis Id değerini girin");
            }

            else
            {
                con.Open();

                string query = "delete from Diagnosises where DiagnosisId=" + txtTeshisId.Text + "";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Teşhis silindi");

                con.Close();

                populate();
            }
        }

        private void TeshisGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTeshisId.Text = TeshisGV.CurrentRow.Cells[0].Value.ToString();
            cmbTeshisHastaId.SelectedItem = TeshisGV.CurrentRow.Cells[1].Value.ToString();
            txtTeshisHastaAd.Text = TeshisGV.CurrentRow.Cells[2].Value.ToString();
            txtTeshisSemptom.Text = TeshisGV.CurrentRow.Cells[3].Value.ToString();
            txtTeshisler.Text = TeshisGV.CurrentRow.Cells[4].Value.ToString();
            txtIlaclar.Text = TeshisGV.CurrentRow.Cells[5].Value.ToString();

            //sağ paneldeki label değerlerine datagridview'den seçilen değerler yazdırılır
            lblPatientName.Text= TeshisGV.CurrentRow.Cells[2].Value.ToString();
            lblSemptom.Text= TeshisGV.CurrentRow.Cells[3].Value.ToString();
            lblTeshis.Text= TeshisGV.CurrentRow.Cells[4].Value.ToString();
            lblIlac.Text= TeshisGV.CurrentRow.Cells[5].Value.ToString();
        }

        //Yazdırma ekranı ayarı
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(lblTeshisOzet.Text, new Font("Centruy Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString(lblTeshisOzet.Text +"\n" +lblPatientName.Text+"\n" + lblSemptom.Text+"\n" + lblTeshis.Text+"\n" + lblIlac.Text, new Font("Centruy Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(130,150));
            e.Graphics.DrawString(label10.Text +"\n\t" +label11.Text+"\n" , new Font("Centruy Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(230,380));
        }

        private void btnTeshisYazdir_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void lblKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
