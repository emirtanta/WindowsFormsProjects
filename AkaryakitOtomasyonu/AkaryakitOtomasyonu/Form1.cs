using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkaryakitOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //D=>depodaki yakıt miktarını tutan değişkeni simgeler
        double D_benzin95 = 0, D_benzin97 = 0, D_dizel = 0, D_eurodizel = 0, D_lpg = 0;

        //E=> depoya eklenen benzin miktarıları
        double E_benzin95 = 0, E_benzin97 = 0, E_dizel = 0, E_eurodizel = 0, E_lpg = 0;

        //F=> benzin fiyatını simgeler
        double F_benzin95 = 0, F_benzin97 = 0, F_dizel = 0, F_eurodizel = 0, F_lpg = 0;

        



        //S=> satılan benzin  miktarları
        double S_benzin95 = 0, S_benzin97 = 0, S_dizel = 0, S_eurodizel = 0, S_lpg = 0;

        



        //fiyat.txt ve depo.txt dosyalarının içerisindeki bilgileri altta tanımlanan dizilere aktarmak için tanımladık
        string[] depo_bilgileri;
        string[] fiyat_bilgileri;

        //depo.txt dosyasındaki verileri okuyup D ile başlayan değişkenlerin içerisine atmak için tanımlandı
        private void txt_depo_oku()
        {
            //bin klasörünün debug içerisindeki dosya
            depo_bilgileri = System.IO.File.ReadAllLines(Application.StartupPath+"\\depo.txt");
            D_benzin95 = Convert.ToDouble(depo_bilgileri[0]);
            D_benzin97 = Convert.ToDouble(depo_bilgileri[1]);
            D_dizel = Convert.ToDouble(depo_bilgileri[2]);
            D_eurodizel = Convert.ToDouble(depo_bilgileri[3]);
            D_lpg = Convert.ToDouble(depo_bilgileri[4]);
        }

        //depodaki bilgileri label nesnesine yazdırır
        private void txt_depo_yaz()
        {
            //N=>virgülden sonraki basamak sayısını 2 olarak ayarlar
            label6.Text = D_benzin95.ToString("N");
            label7.Text = D_benzin97.ToString("N");
            label8.Text = D_dizel.ToString("N");
            label9.Text = D_eurodizel.ToString("N");
            label10.Text = D_lpg.ToString("N");
        }

        //fiyat.txt dosyasındaki verileri okuyup F ile başlayan değişkenlerin içerisine atmak için tanımlandı
        private void txt_fiyat_oku()
        {
            fiyat_bilgileri = System.IO.File.ReadAllLines(Application.StartupPath + "\\fiyat.txt");
            F_benzin95 = Convert.ToDouble(fiyat_bilgileri[0]);
            F_benzin97 = Convert.ToDouble(fiyat_bilgileri[1]);
            F_dizel = Convert.ToDouble(fiyat_bilgileri[2]);
            F_eurodizel = Convert.ToDouble(fiyat_bilgileri[3]);
            F_lpg = Convert.ToDouble(fiyat_bilgileri[4]);
        }

        //fiyat bilgilerini label nesnesine yazdırır
        private void txt_fiyat_yaz()
        {
            //N=>virgülden sonraki basamak sayısını 2 olarak ayarlar
            label11.Text = F_benzin95.ToString("N");
            label12.Text = F_benzin97.ToString("N");
            label13.Text = F_dizel.ToString("N");
            label14.Text = F_eurodizel.ToString("N");
            label15.Text = F_lpg.ToString("N");
        }

        //progress bar nesnesini güncellenmesini sağlar
        private void progressBar_guncelle()
        {
            progressBar1.Value = Convert.ToInt16(D_benzin95);
            progressBar2.Value = Convert.ToInt16(D_benzin97);
            progressBar3.Value = Convert.ToInt16(D_dizel);
            progressBar4.Value = Convert.ToInt16(D_eurodizel);
            progressBar5.Value = Convert.ToInt16(D_lpg);
        }

        //numericUpDown değerinin depoda kalan değere kadar arttırmayı sağladık
        private void numericupdown_value()
        {
            numericUpDown1.Maximum = decimal.Parse(D_benzin95.ToString());
            numericUpDown2.Maximum = decimal.Parse(D_benzin97.ToString());
            numericUpDown3.Maximum = decimal.Parse(D_dizel.ToString());
            numericUpDown4.Maximum = decimal.Parse(D_eurodizel.ToString());
            numericUpDown5.Maximum = decimal.Parse(D_lpg.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Text = "Akaryakıt Otomasyonu"; //Formun Yazısını ayarladık

            //progressbar nesnesini kaç eşit parçaya bölüneceği belirlendi
            progressBar1.Maximum = 1000;
            progressBar2.Maximum = 1000;
            progressBar3.Maximum = 1000;
            progressBar4.Maximum = 1000;
            progressBar5.Maximum = 1000;

            txt_depo_oku();
            txt_depo_yaz();

            txt_fiyat_oku();
            txt_fiyat_yaz();
            progressBar_guncelle();

            

            numericupdown_value();

            //satış yap bölümündeki combobox işlemleri
            string[] yakit_turleri = { "Benzin (95)", "Benzin (97)", "Dizel", "Euro Dizel", "LPG" };
            comboBox1.Items.AddRange(yakit_turleri);

            //numericUpDown nesnelerini pasif hale getirdik
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;
            numericUpDown4.Enabled = false;
            numericUpDown5.Enabled = false;

            //numericUpDown sayı değerlerinin virgülden sonraki basamak değeri
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown4.DecimalPlaces = 2;
            numericUpDown5.DecimalPlaces = 2;

            //numericUpDown tuşuna basılınca artış ve azalış değeri ayarı
            numericUpDown1.Increment = 0.1M;
            numericUpDown2.Increment = 0.1M;
            numericUpDown3.Increment = 0.1M;
            numericUpDown4.Increment = 0.1M;
            numericUpDown5.Increment = 0.1M;

            //numericUpDown nesnesine dışarıdan veri girişini kapama ayarı
            numericUpDown1.ReadOnly = true;
            numericUpDown2.ReadOnly = true;
            numericUpDown3.ReadOnly = true;
            numericUpDown4.ReadOnly = true;
            numericUpDown5.ReadOnly = true;
        }

        //Depo Bilgilerini güncelle butonu bölümü
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                E_benzin95 = Convert.ToDouble(textBox1.Text);

                if (1000<D_benzin95+E_benzin95 || E_benzin95<=0)
                {
                    textBox1.Text = "Hata!";
                }

                else
                {
                    depo_bilgileri[0] = Convert.ToString(D_benzin95 + E_benzin95);
                }
            }
            catch (Exception)
            {

                textBox1.Text = "Hata!";
            }

            try
            {
                E_benzin97 = Convert.ToDouble(textBox2.Text);

                if (1000 < D_benzin97 + E_benzin97 || E_benzin97 <= 0)
                {
                    textBox2.Text = "Hata!";
                }

                else
                {
                    depo_bilgileri[1] = Convert.ToString(D_benzin97 + E_benzin97);
                }
            }
            catch (Exception)
            {

                textBox2.Text = "Hata!";
            }

            try
            {
                E_dizel = Convert.ToDouble(textBox3.Text);

                if (1000 < D_dizel + E_dizel || E_dizel <= 0)
                {
                    textBox3.Text = "Hata!";
                }

                else
                {
                    depo_bilgileri[2] = Convert.ToString(D_dizel + E_dizel);
                }
            }
            catch (Exception)
            {

                textBox3.Text = "Hata!";
            }

            try
            {
                E_eurodizel = Convert.ToDouble(textBox4.Text);

                if (1000 < D_eurodizel + E_eurodizel || E_eurodizel <= 0)
                {
                    textBox4.Text = "Hata!";
                }

                else
                {
                    depo_bilgileri[3] = Convert.ToString(D_eurodizel + E_eurodizel);
                }
            }
            catch (Exception)
            {

                textBox4.Text = "Hata!";
            }

            try
            {
                E_lpg = Convert.ToDouble(textBox5.Text);

                if (1000 < D_lpg + E_lpg || E_lpg <= 0)
                {
                    textBox5.Text = "Hata!";
                }

                else
                {
                    depo_bilgileri[4] = Convert.ToString(D_lpg + E_lpg);
                }
            }
            catch (Exception)
            {

                textBox5.Text = "Hata!";
            }

            //txt dosyasına yapılan değişikleri aktarma işlemi yaptık
            System.IO.File.WriteAllLines(Application.StartupPath + "\\depo.txt", depo_bilgileri);

            txt_depo_oku();

            txt_depo_yaz(); //label değerlerine bilgileri yazan metot

            progressBar_guncelle();

            numericupdown_value();
        }

        //fiyatları güncelle butonu bölümü
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //benzin95 değerine textboxt6'ya girilen değer kadar yüzde değerini alarak ekler
                F_benzin95 = F_benzin95 + (F_benzin95 * Convert.ToDouble(textBox6.Text) / 100);

                fiyat_bilgileri[0] = Convert.ToString(F_benzin95);
            }
            catch (Exception)
            {

                textBox6.Text="Hata!";
            }

            try
            {
                //benzin97 değerine textboxt6'ya girilen değer kadar yüzde değerini alarak ekler
                F_benzin97 = F_benzin97 + (F_benzin97 * Convert.ToDouble(textBox7.Text) / 100);

                fiyat_bilgileri[1] = Convert.ToString(F_benzin97);
            }
            catch (Exception)
            {

                textBox7.Text = "Hata!";
            }

            try
            {
                //dizel değerine textboxt8'ya girilen değer kadar yüzde değerini alarak ekler
                F_dizel = F_dizel + (F_dizel * Convert.ToDouble(textBox8.Text) / 100);

                fiyat_bilgileri[2] = Convert.ToString(F_dizel);
            }
            catch (Exception)
            {

                textBox8.Text = "Hata!";
            }

            try
            {
                //eurodizel değerine textboxt9'ya girilen değer kadar yüzde değerini alarak ekler
                F_eurodizel = F_eurodizel + (F_eurodizel * Convert.ToDouble(textBox9.Text) / 100);

                fiyat_bilgileri[3] = Convert.ToString(F_eurodizel);
            }
            catch (Exception)
            {

                textBox9.Text = "Hata!";
            }

            try
            {
                //lpg değerine textboxt10'ya girilen değer kadar yüzde değerini alarak ekler
                F_lpg = F_lpg + (F_lpg * Convert.ToDouble(textBox10.Text) / 100);

                fiyat_bilgileri[4] = Convert.ToString(F_lpg);
            }
            catch (Exception)
            {

                textBox10.Text = "Hata!";
            }

            //fiyat.txt dosyasına değişikleri yazdırır
            System.IO.File.WriteAllLines(Application.StartupPath + "\\fiyat.txt", fiyat_bilgileri);

            txt_fiyat_oku();

            txt_fiyat_yaz();


        }

        //Satış yap butonu bölümü
        private void button3_Click(object sender, EventArgs e)
        {
            S_benzin95 = double.Parse(numericUpDown1.Value.ToString());
            S_benzin97 = double.Parse(numericUpDown2.Value.ToString());
            S_dizel = double.Parse(numericUpDown3.Value.ToString());
            S_eurodizel = double.Parse(numericUpDown4.Value.ToString());
            S_lpg = double.Parse(numericUpDown5.Value.ToString());

            //benzin 95 için numeric up down seçili ise
            if (numericUpDown1.Enabled==true)
            {
                D_benzin95 = D_benzin95 - S_benzin95;

                label29.Text = Convert.ToString(S_benzin95 * F_benzin95);
                
            }

            //benzin 97 için numeric up down seçili ise
            else if (numericUpDown2.Enabled == true)
            {
                D_benzin97 = D_benzin97 - S_benzin97;

                label29.Text = Convert.ToString(S_benzin97 * F_benzin97);

            }

            //dizel için numeric up down seçili ise
            else if (numericUpDown3.Enabled == true)
            {
                D_dizel = D_dizel - S_dizel;

                label29.Text = Convert.ToString(S_dizel * F_dizel);

            }

            //euro dizel için numeric up down seçili ise
            else if (numericUpDown4.Enabled == true)
            {
                D_eurodizel = D_eurodizel - S_eurodizel;

                label29.Text = Convert.ToString(S_eurodizel * F_eurodizel);

            }

            //lpg için numeric up down seçili ise
            else if (numericUpDown5.Enabled == true)
            {
                D_lpg = D_lpg - S_lpg;

                label29.Text = Convert.ToString(S_lpg * F_lpg);

            }

            //dizinin elemanlarını güncelledik
            depo_bilgileri[0] = Convert.ToString(D_benzin95);
            depo_bilgileri[1] = Convert.ToString(D_benzin97);
            depo_bilgileri[2] = Convert.ToString(D_dizel);
            depo_bilgileri[3] = Convert.ToString(D_eurodizel);
            depo_bilgileri[4] = Convert.ToString(D_lpg);

            //depo.txt dosyamızı yeni bilgiler ile güncelledik
            System.IO.File.WriteAllLines(Application.StartupPath + "\\depo.txt", depo_bilgileri);

            txt_depo_oku();
            txt_depo_yaz();

            progressBar_guncelle();

            numericupdown_value();

            //Satış yapıldıktan sonra numeric up down 0'landı
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Benzin (95)")
            {
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }

            else if (comboBox1.Text == "Benzin (97)")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = true;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }

            else if (comboBox1.Text == "Dizel")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = true;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = false;
            }

            else if (comboBox1.Text == "Euro Dizel")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = true;
                numericUpDown5.Enabled = false;
            }

            else if (comboBox1.Text == "LPG")
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown3.Enabled = false;
                numericUpDown4.Enabled = false;
                numericUpDown5.Enabled = true;
            }

            //combobox içerisinden seçilen değere göre diğer numericup down değerleri 0 sayısına eşitlenir.
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;

            label29.Text = "_________";
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
