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
    public partial class Fatura : Form
    {
        public Fatura()
        {
            InitializeComponent();

            populate();
            DisplayCustomer();
        }

        SqlConnection con = new SqlConnection(@"data source=DESKTOP-QVN1TMN;initial catalog=WinformJewerlyShopDB;integrated security=true;");

        int key = 0; //datagridview'deki kolonlara çift tıklanınca ilgili yerleri textbox,combobox gibi yerlerde gösterebilmek için tanımlandı
        
        int customerKey = 0;
        int n = 0, genelToplam = 0;
        private void btnFaturayaEkle_Click(object sender, EventArgs e)
        {
            if (txtFaturaUrunMiktar.Text=="" || Convert.ToInt32(txtFaturaUrunMiktar.Text)>stok)
            {
                MessageBox.Show("Stokta yok");
            }

            else
            {
                int total = Convert.ToInt32(txtFaturaUrunMiktar.Text) * Convert.ToInt32(txtFaturaUrunFiyat.Text);

                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridViewFaturaListesi);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = txtFaturaUrunAdi.Text;
                newRow.Cells[2].Value = txtFaturaUrunMiktar.Text;
                newRow.Cells[3].Value = txtFaturaUrunFiyat.Text;
                newRow.Cells[4].Value = total;

                dataGridViewFaturaListesi.Rows.Add(newRow);
                genelToplam = genelToplam + total;
                lblTotal.Text = "₺" + genelToplam;
                n++;

                Update(); //stoktan miktar kadar ürünü düşürür
            }
        }

        int stok = 0;

        private void btnFaturaYazdir_Click(object sender, EventArgs e)
        {
            //fatura datagirdview değerine eklenen değeri fatura tablosuna ekler
            try
            {
                con.Open();

                string query = "insert into Bills values(" + customerKey + ",'" + txtFaturaMusteriAdiSoyadi.Text + "',"+ genelToplam + ")";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Fatura kaydedildi");



                con.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm",285,600);

            if (printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        #region fonksiyonlar bölümü

        //ürünleri getiren fonksiyon
        private void populate()
        {
            con.Open();

            string query = "select * from Items";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sqlDataAdapter);

            var ds = new DataSet();
            sqlDataAdapter.Fill(ds); //datagridview içerisine yüklemek için tanımladık
            dataGridViewFaturaUrunListesi.DataSource = ds.Tables[0];

            con.Close();
        }

       

        private void DisplayCustomer()
        {
            con.Open();

            string query = "select * from Customers";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sqlDataAdapter);

            var ds = new DataSet();
            sqlDataAdapter.Fill(ds); //datagridview içerisine yüklemek için tanımladık
            dataGridViewFaturaMusteriListesi.DataSource = ds.Tables[0];

            con.Close();
        }

        //ürün fatura eklendikten sonra stoktan ürünü eklenen miktar kadar düşürür
        private void Update()
        {
            try
            {
                int newStok = stok - Convert.ToInt32(txtFaturaUrunMiktar.Text);

                con.Open();

                string query = "update Items set ItemQuantity=" + newStok + " where ItemId=" + key + ";";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Ürün güncellendi");

                con.Close();

                populate();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        #endregion

        int urunid, urunmiktar, urunfiyat, uruntotal, pos = 60;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();

            this.Hide();
        }

        private void btnSatisListesi_Click(object sender, EventArgs e)
        {
            FaturaGoster obj = new FaturaGoster();
            obj.Show();

            this.Hide();
        }

        string urunadi;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Jewellery Shop", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));

            //yazdırma sayfasında ürün ile ilgili adları yazdırır
            e.Graphics.DrawString("# Ürün Fiyat Miktar Toplam", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));

            foreach (DataGridViewRow row in dataGridViewFaturaListesi.Rows)
            {
                urunid = Convert.ToInt32(row.Cells["Column1"].Value);
                urunadi = "" + row.Cells["Column2"].Value;
                urunfiyat= Convert.ToInt32(row.Cells["Column3"].Value);
                urunmiktar= Convert.ToInt32(row.Cells["Column4"].Value);
                uruntotal = Convert.ToInt32(row.Cells["Column5"].Value);

                e.Graphics.DrawString("" + urunid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("" + urunadi, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("" + urunfiyat, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("" + urunmiktar, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("" + uruntotal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));

                pos = pos + 20;
            }

            e.Graphics.DrawString("Genel Toplam: ₺" + genelToplam, new Font("Century Gothic", 12, FontStyle.Bold),Brushes.Crimson,new Point(50,pos+50));
            e.Graphics.DrawString("****** Mücevher Mağazası *******", new Font("Century Gothic", 12, FontStyle.Bold),Brushes.Crimson,new Point(11,pos+85));

            dataGridViewFaturaListesi.Rows.Clear();
            dataGridViewFaturaListesi.Refresh();

            pos = 100;
            genelToplam = 0;

            
        }

        private void dataGridViewFaturaUrunListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFaturaUrunAdi.Text = dataGridViewFaturaUrunListesi.CurrentRow.Cells[1].Value.ToString();
            txtFaturaUrunFiyat.Text = dataGridViewFaturaUrunListesi.CurrentRow.Cells[4].Value.ToString();

            if (txtFaturaUrunAdi.Text == "")
            {
                key = 0;
                stok = 0;
            }

            else
            {
                key = Convert.ToInt32(dataGridViewFaturaUrunListesi.CurrentRow.Cells[0].Value.ToString());
                stok = Convert.ToInt32(dataGridViewFaturaUrunListesi.CurrentRow.Cells[5].Value.ToString());
            }
        }

        private void dataGridViewFaturaMusteriListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFaturaMusteriAdiSoyadi.Text = dataGridViewFaturaMusteriListesi.CurrentRow.Cells[1].Value.ToString();

            if (txtFaturaMusteriAdiSoyadi.Text == "")
            {
                customerKey = 0;
            }

            else
            {
                customerKey = Convert.ToInt32(dataGridViewFaturaMusteriListesi.CurrentRow.Cells[0].Value.ToString());
            }
        }
    }
}
