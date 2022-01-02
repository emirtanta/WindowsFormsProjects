using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodRestaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongTimeString();

            timer1.Start();
        }

        private void cbxPatatesKizartmasi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPatatesKizartmasi.Checked==true)
            {
                txtPatatesKizartmasi.Enabled = true;
            }

            if (cbxPatatesKizartmasi.Checked==false)
            {
                txtPatatesKizartmasi.Enabled = false;

                txtPatatesKizartmasi.Text = "0";
            }
        }

        private void cbxBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxBurger.Checked == true)
            {
                txtBurger.Enabled = true;
            }

            if (cbxBurger.Checked == false)
            {
                txtBurger.Enabled = false;

                txtBurger.Text = "0";
            }
        }

        private void cbxSalata_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSalata.Checked == true)
            {
                txtSalata.Enabled = true;
            }

            if (cbxSalata.Checked == false)
            {
                txtSalata.Enabled = false;

                txtSalata.Text = "0";
            }
        }

        private void cbxSandvic_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSandvic.Checked == true)
            {
                txtSandvic.Enabled = true;
            }

            if (cbxSandvic.Checked == false)
            {
                txtSandvic.Enabled = false;

                txtSandvic.Text = "0";
            }
        }

        private void cbxTavuk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTavuk.Checked == true)
            {
                txtTavuk.Enabled = true;
            }

            if (cbxTavuk.Checked == false)
            {
                txtTavuk.Enabled = false;

                txtTavuk.Text = "0";
            }
        }

        private void cbxPeynir_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPeynir.Checked == true)
            {
                txtPeynir.Enabled = true;
            }

            if (cbxPeynir.Checked == false)
            {
                txtPeynir.Enabled = false;

                txtPeynir.Text = "0";
            }
        }

        private void cbxCay_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCay.Checked == true)
            {
                txtCay.Enabled = true;
            }

            if (cbxCay.Checked == false)
            {
                txtCay.Enabled = false;

                txtCay.Text = "0";
            }
        }

        private void cbxCola_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCola.Checked == true)
            {
                txtCola.Enabled = true;
            }

            if (cbxCola.Checked == false)
            {
                txtCola.Enabled = false;

                txtCola.Text = "0";
            }
        }

        private void cbxSu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSu.Checked == true)
            {
                txtSu.Enabled = true;
            }

            if (cbxSu.Checked == false)
            {
                txtSu.Enabled = false;

                txtSu.Text = "0";
            }
        }

        private void cbxCikolata_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCikolata.Checked == true)
            {
                txtCikolata.Enabled = true;
            }

            if (cbxCikolata.Checked == false)
            {
                txtCikolata.Enabled = false;

                txtCikolata.Text = "0";
            }
        }

        private void cbxPankek_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPankek.Checked == true)
            {
                txtPankek.Enabled = true;
            }

            if (cbxPankek.Checked == false)
            {
                txtPankek.Enabled = false;

                txtPankek.Text = "0";
            }
        }

        private void cbxMeyve_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMeyve.Checked == true)
            {
                txtMeyve.Enabled = true;
            }

            if (cbxMeyve.Checked == false)
            {
                txtMeyve.Enabled = false;

                txtMeyve.Text = "0";
            }
        }



        //Ekle butonu bölümü

        //her bir yiyecek  birim fiyatı
        double patateskizartmasiup = 50, burgerup = 80, salataup = 100, sandvicup = 75,tavukup=85, peynirup = 80;

        // içeceğin birim fiyatı
        double suup = 15, cayup = 15, colaup = 20, cikolataup = 25, pankekup = 30,meyveup=35;

        //her bir yiyecek ve içeceğin toplam fiyatı
        double patatesitp, burgertp, salatatp, sandvictp,tavuktp, peynirtp, sutp, caytp, colatp, cikolatatp, pankektp, meyvetp;
        double SubTotal = 0,kdv,total;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            patatesitp = patateskizartmasiup * Convert.ToDouble(txtPatatesKizartmasi.Text);
            burgertp = burgerup * Convert.ToDouble(txtBurger.Text);
            salatatp = salataup * Convert.ToDouble(txtSalata.Text);
            sandvictp = sandvicup * Convert.ToDouble(txtSandvic.Text);
            tavuktp = tavukup * Convert.ToDouble(txtTavuk.Text);
            peynirtp = peynirup * Convert.ToDouble(txtPeynir.Text);

            //içecekler için hesaplama
            sutp = suup * Convert.ToDouble(txtSu.Text);
            caytp = cayup * Convert.ToDouble(txtCay.Text);
            colatp = colaup * Convert.ToDouble(txtCola.Text);
            cikolatatp = cikolataup * Convert.ToDouble(txtCikolata.Text);
            pankektp = pankekup * Convert.ToDouble(txtPankek.Text);
            meyvetp = meyveup * Convert.ToDouble(txtMeyve.Text);

            //ürünü fişe ekleme(rich textbox bölümü)
            rchtxtFis.Clear();
            SubTotal = 0;
            total = 0;

            rchtxtFis.AppendText(Environment.NewLine);
            rchtxtFis.AppendText("\t\t\t ABC Restoran \t\t"+lblDate.Text+Environment.NewLine);
            rchtxtFis.AppendText("\t\t\t**************"+Environment.NewLine);

            if (cbxPatatesKizartmasi.Checked==true)
            {
                rchtxtFis.AppendText("\tPatates Kızartması:\t" + patatesitp + "₺" + Environment.NewLine);

                SubTotal = SubTotal + patatesitp;
                lblSubTotal.Text = "" + SubTotal;
            }

            //burger için
            if (cbxBurger.Checked == true)
            {
                rchtxtFis.AppendText("\tBurger:\t" + burgertp + "₺" + Environment.NewLine);

                SubTotal = SubTotal + burgertp;
                lblSubTotal.Text = "" + SubTotal;
            }

            //salata için
            if (cbxSalata.Checked == true)
            {
                rchtxtFis.AppendText("\tSalata:\t" + salatatp + "₺" + Environment.NewLine);

                SubTotal = SubTotal + salatatp;
                lblSubTotal.Text = "" + SubTotal;
            }

            //sandviç için
            if (cbxSandvic.Checked == true)
            {
                rchtxtFis.AppendText("\tSandviç:\t" + sandvictp + "₺" + Environment.NewLine);

                SubTotal = SubTotal + sandvictp;
                lblSubTotal.Text = "" + SubTotal;
            }

            //tavuk için
            if (cbxTavuk.Checked == true)
            {
                rchtxtFis.AppendText("\tTavuk:\t" + tavuktp + "₺" + Environment.NewLine);

                SubTotal = SubTotal + tavuktp;
                lblSubTotal.Text = "" + SubTotal;
            }

            //peynir için
            if (cbxPeynir.Checked == true)
            {
                rchtxtFis.AppendText("\tPeynir:\t" + peynirtp + "₺" + Environment.NewLine);

                SubTotal = SubTotal + peynirtp;
                lblSubTotal.Text = "" + SubTotal;
            }

            //çay için
            if (cbxCay.Checked == true)
            {
                rchtxtFis.AppendText("\tÇay:\t" + caytp + "₺" + Environment.NewLine);

                SubTotal = SubTotal + caytp;
                lblSubTotal.Text = "" + SubTotal;
            }

            //su için
            if (cbxSu.Checked == true)
            {
                rchtxtFis.AppendText("\tSu:\t" + sutp + "₺" + Environment.NewLine);

                SubTotal = SubTotal + sutp;
                lblSubTotal.Text = "" + SubTotal;
            }

            //cola için
            if (cbxCola.Checked == true)
            {
                rchtxtFis.AppendText("\tCoca Cola:\t" + colatp + "₺" + Environment.NewLine);

                SubTotal = SubTotal + colatp;
                lblSubTotal.Text = "" + SubTotal;
            }

            //çikolata
            if (cbxCikolata.Checked == true)
            {
                rchtxtFis.AppendText("\tÇikolata:\t" + cikolatatp + "₺" + Environment.NewLine);

                SubTotal = SubTotal + cikolatatp;
                lblSubTotal.Text = "" + SubTotal;
            }

            //pankek
            if (cbxPankek.Checked == true)
            {
                rchtxtFis.AppendText("\tPankek:\t" + pankektp + "₺" + Environment.NewLine);

                SubTotal = SubTotal + pankektp;
                lblSubTotal.Text = "" + SubTotal;
            }

            //meyve suyu
            if (cbxMeyve.Checked == true)
            {
                rchtxtFis.AppendText("\tMeyve Suyu:\t" + meyvetp + "₺" + Environment.NewLine);

                SubTotal = SubTotal + meyvetp;
                lblSubTotal.Text = "" + SubTotal;
            }

            kdv = SubTotal * 0.18;//%18 kdv değerini ara toplama göre hesaplar
            total = SubTotal + kdv; //toplam tutarı hesaplar

            lblKdv.Text =  kdv+" ₺";
            lblToplam.Text =  total+" ₺";
               

        }

        //Temizle butonu bölümü
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            cbxPatatesKizartmasi.Checked = false;
            cbxBurger.Checked = false;
            cbxSalata.Checked = false;
            cbxSandvic.Checked = false;
            cbxTavuk.Checked = false;
            cbxPeynir.Checked = false;
            cbxCay.Checked = false;
            cbxCola.Checked = false;
            cbxSu.Checked = false;
            cbxCikolata.Checked = false;
            cbxPankek.Checked = false;
            cbxMeyve.Checked = false;
        }

        //Yazdır butonu
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        //Girilen fişi yazdırma için tanımlandı
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rchtxtFis.Text + " Ara toplam: " + lblSubTotal.Text + " Kdv: " + lblKdv.Text + " Toplam fiyat: " + lblToplam.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Blue, new Point(130));
        }

        //X label bölümü
        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
