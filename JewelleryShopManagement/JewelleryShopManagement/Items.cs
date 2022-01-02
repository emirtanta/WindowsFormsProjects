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

namespace JewelleryShopManagement
{
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();

            populate();
        }

        SqlConnection con = new SqlConnection(@"data source=DESKTOP-QVN1TMN;initial catalog=WinformJewerlyShopDB;integrated security=true;");

        int key = 0; //datagridview'deki kolonlara çift tıklanınca ilgili yerleri textbox,combobox gibi yerlerde gösterebilmek için tanımlandı

        //ürünleri getiren fonksiyon
        private void populate()
        {
            con.Open();

            string query = "select * from Items";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sqlDataAdapter);

            var ds = new DataSet();
            sqlDataAdapter.Fill(ds); //datagridview içerisine yüklemek için tanımladık
            dataGridViewUrunListesi.DataSource = ds.Tables[0];

            con.Close();
        }


        private void KategoriyeGoreFiltrele()
        {
            con.Open();

            string query = "select * from Items where ItemCategory='"+cmbKategoriFiltre.SelectedItem.ToString()+"'";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sqlDataAdapter);

            var ds = new DataSet();
            sqlDataAdapter.Fill(ds); //datagridview içerisine yüklemek için tanımladık
            dataGridViewUrunListesi.DataSource = ds.Tables[0];

            con.Close();
        }

        private void TureGoreFiltrele()
        {
            con.Open();

            string query = "select * from Items where ItemType='" + cmbTurFiltre.SelectedItem.ToString() + "'";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sqlDataAdapter);

            var ds = new DataSet();
            sqlDataAdapter.Fill(ds); //datagridview içerisine yüklemek için tanımladık
            dataGridViewUrunListesi.DataSource = ds.Tables[0];

            con.Close();
        }

        //Kaydet butonu
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtUrunAdi.Text=="" || txtFiyat.Text=="" || txtMiktar.Text=="" || cmbKategori.SelectedIndex==-1 || cmbTur.SelectedIndex==-1)
            {
                MessageBox.Show("Missing ınformation");
            }

            else
            {
                try
                {
                    con.Open();

                    string query = "insert into Items values('" + txtUrunAdi.Text + "','" + cmbKategori.SelectedItem.ToString() + "','" + cmbTur.SelectedItem.ToString() + "','" + txtFiyat.Text + "','" + txtMiktar.Text + "')";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ürün kaydedildi");

                   

                    con.Close();

                    populate();

                    Reset();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }


        //Güncelle butonu
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtUrunAdi.Text == "" || txtFiyat.Text == "" || txtMiktar.Text == "" || cmbKategori.SelectedIndex == -1 || cmbTur.SelectedIndex == -1)
            {
                MessageBox.Show("Missing ınformation");
            }

            else
            {
                try
                {
                    con.Open();

                    string query = "update Items set ItemName='"+txtFiyat.Text+ "',ItemCategory='" + cmbKategori.SelectedItem+ "',ItemType='" + cmbTur.SelectedItem+ "',ItemPrice='" + txtFiyat.Text+ "',ItemQuantity='" + txtMiktar.Text+ "' where ItemId=" + key+"";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ürün güncellendi");

                    con.Close();

                    populate();

                    Reset();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }


        //Sil butonu
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (key==0)
            {
                MessageBox.Show("Missing ınformation");
            }

            else
            {
                try
                {
                    con.Open();

                    string query = "delete from Items where ItemId="+key+"";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Ürün silindi");

                    con.Close();

                    populate();

                    Reset();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Sıfırla butonu
        private void btnSifirla_Click(object sender, EventArgs e)
        {
            Reset();
        }

       

        //datagridview kolonundaki değerlere çift tıklanınca değerlerin textbox,combobox gibi yerlere getirmeyi sağlar
        private void dataGridViewUrunListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunAdi.Text = dataGridViewUrunListesi.CurrentRow.Cells[1].Value.ToString();
            cmbKategori.SelectedItem = dataGridViewUrunListesi.CurrentRow.Cells[2].Value.ToString();
            cmbTur.SelectedItem = dataGridViewUrunListesi.CurrentRow.Cells[3].Value.ToString();
            txtFiyat.Text = dataGridViewUrunListesi.CurrentRow.Cells[4].Value.ToString();
            txtMiktar.Text = dataGridViewUrunListesi.CurrentRow.Cells[5].Value.ToString();

            if (txtUrunAdi.Text=="")
            {
                key = 0;
            }

            else
            {
                key = Convert.ToInt32(dataGridViewUrunListesi.CurrentRow.Cells[0].Value.ToString());
            }
        }

        //Nesneleri temizleme fonksiyonu
        private void Reset()
        {
            txtUrunAdi.Text = "";
            cmbKategori.SelectedIndex = -1;
            cmbTur.SelectedIndex = -1;
            txtFiyat.Text = "";
            txtMiktar.Text = "";
            key = 0;
        }

        private void lblMusteriler_Click(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            obj.Show();

            this.Hide();
        }

        private void cmbKategoriFiltre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            KategoriyeGoreFiltrele();
        }

        private void cmbTurFiltre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            TureGoreFiltrele();
        }

        //türe göre filtrele combobox'unun yanındaki resim
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();

            this.Hide();
        }
    }
}
