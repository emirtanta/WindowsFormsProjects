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

namespace JewelleryShopManagement
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();

            populate();
        }

        SqlConnection con = new SqlConnection(@"data source=DESKTOP-QVN1TMN;initial catalog=WinformJewerlyShopDB;integrated security=true;");

        int key = 0; //datagridview'deki kolonlara çift tıklanınca ilgili yerleri textbox,combobox gibi yerlerde gösterebilmek için tanımlandı

        private void lblUrunler_Click(object sender, EventArgs e)
        {
            Items obj = new Items();
            obj.Show();

            this.Hide();
        }

        //Müşteri Kaydet butonu
        private void btnMusteriKaydet_Click(object sender, EventArgs e)
        {
            if (txtMusteriAdi.Text == "" || txtMusteriSoyadi.Text == "")
            {
                MessageBox.Show("Missing ınformation");
            }

            else
            {
                try
                {
                    con.Open();

                    string query = "insert into Customers values('" + txtMusteriAdi.Text + "','" + txtMusteriSoyadi.Text + "')";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Müşteri kaydedildi");



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

            //Müşteri Güncelle butonu
            private void btnMusteriGuncelle_Click(object sender, EventArgs e)
            {
                if (txtMusteriAdi.Text == "" || txtMusteriSoyadi.Text == "" )
                {
                    MessageBox.Show("Missing ınformation");
                }

                else
                {
                    try
                    {
                        con.Open();

                        string query = "update Customers set CustomerName='" + txtMusteriAdi.Text + "',CustomerSurname='" + txtMusteriSoyadi.Text + "' where CustomerId=" + key + "";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Müşteri güncellendi");

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

            //Müşteri Sil butonu
            private void btnMusteriSil_Click(object sender, EventArgs e)
            {
                if (key == 0)
                {
                    MessageBox.Show("Missing ınformation");
                }

                else
                {
                    try
                    {
                        con.Open();

                        string query = "delete from Customers where CustomerId=" + key + "";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Müşteri silindi");

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

            //Müşteri Sıfırla butonu
            private void btnMusteriSifirla_Click(object sender, EventArgs e)
            {
                Reset();
            }

            private void dataGridViewMusteriListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                txtMusteriAdi.Text = dataGridViewMusteriListesi.CurrentRow.Cells[1].Value.ToString();
                txtMusteriSoyadi.Text = dataGridViewMusteriListesi.CurrentRow.Cells[2].Value.ToString();

                if (txtMusteriAdi.Text == "")
                {
                    key = 0;
                }

                else
                {
                    key = Convert.ToInt32(dataGridViewMusteriListesi.CurrentRow.Cells[0].Value.ToString());
                }
            }


            #region Fonksiyonlar bölümü


            private void populate()
            {
                con.Open();

                string query = "select * from Customers";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sqlDataAdapter);

                var ds = new DataSet();
                sqlDataAdapter.Fill(ds); //datagridview içerisine yüklemek için tanımladık
                dataGridViewMusteriListesi.DataSource = ds.Tables[0];

                con.Close();
            }

            //Nesneleri temizleme fonksiyonu
            private void Reset()
            {
                txtMusteriAdi.Text = "";
                txtMusteriSoyadi.Text = "";
                key = 0;
            }




        #endregion

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();

            this.Hide();
        }
    } 
}
