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
    public partial class FaturaGoster : Form
    {
        public FaturaGoster()
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
            dataGridViewSatisListesi.DataSource = ds.Tables[0];

            con.Close();
        }

        private void FaturaGoster_Load(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Fatura obj = new Fatura();

            obj.Show();

            this.Hide();
        }
    }
}
