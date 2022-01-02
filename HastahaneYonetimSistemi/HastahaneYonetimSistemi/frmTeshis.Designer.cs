
namespace HastahaneYonetimSistemi
{
    partial class frmTeshis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeshis));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeshisId = new System.Windows.Forms.TextBox();
            this.cmbTeshisHastaId = new System.Windows.Forms.ComboBox();
            this.txtTeshisHastaAd = new System.Windows.Forms.TextBox();
            this.txtTeshisSemptom = new System.Windows.Forms.TextBox();
            this.txtTeshisler = new System.Windows.Forms.TextBox();
            this.txtIlaclar = new System.Windows.Forms.TextBox();
            this.btnTeshisAnasayfa = new System.Windows.Forms.Button();
            this.btnTeshisSil = new System.Windows.Forms.Button();
            this.btnTeshisGuncelle = new System.Windows.Forms.Button();
            this.btnTeshisEkle = new System.Windows.Forms.Button();
            this.TeshisGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTeshisOzet = new System.Windows.Forms.Panel();
            this.lblTeshis = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblIlac = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSemptom = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblTeshisOzet = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnTeshisYazdir = new System.Windows.Forms.Button();
            this.lblKapat = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeshisGV)).BeginInit();
            this.panelTeshisOzet.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.lblKapat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 100);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(440, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "TEŞHİSLER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(362, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "HASTANE YÖNETİM SİSTEMİ";
            // 
            // txtTeshisId
            // 
            this.txtTeshisId.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTeshisId.Location = new System.Drawing.Point(0, 194);
            this.txtTeshisId.Name = "txtTeshisId";
            this.txtTeshisId.Size = new System.Drawing.Size(180, 20);
            this.txtTeshisId.TabIndex = 3;
            this.txtTeshisId.Text = "TeşhisId";
            // 
            // cmbTeshisHastaId
            // 
            this.cmbTeshisHastaId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTeshisHastaId.FormattingEnabled = true;
            this.cmbTeshisHastaId.Location = new System.Drawing.Point(0, 220);
            this.cmbTeshisHastaId.Name = "cmbTeshisHastaId";
            this.cmbTeshisHastaId.Size = new System.Drawing.Size(180, 25);
            this.cmbTeshisHastaId.TabIndex = 4;
            this.cmbTeshisHastaId.Text = "HastaId";
            this.cmbTeshisHastaId.SelectionChangeCommitted += new System.EventHandler(this.cmbTeshisHastaId_SelectionChangeCommitted);
            // 
            // txtTeshisHastaAd
            // 
            this.txtTeshisHastaAd.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTeshisHastaAd.Enabled = false;
            this.txtTeshisHastaAd.Location = new System.Drawing.Point(0, 251);
            this.txtTeshisHastaAd.Name = "txtTeshisHastaAd";
            this.txtTeshisHastaAd.Size = new System.Drawing.Size(180, 20);
            this.txtTeshisHastaAd.TabIndex = 3;
            this.txtTeshisHastaAd.Text = "Hasta Adı";
            // 
            // txtTeshisSemptom
            // 
            this.txtTeshisSemptom.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTeshisSemptom.Location = new System.Drawing.Point(214, 194);
            this.txtTeshisSemptom.Name = "txtTeshisSemptom";
            this.txtTeshisSemptom.Size = new System.Drawing.Size(180, 20);
            this.txtTeshisSemptom.TabIndex = 3;
            this.txtTeshisSemptom.Text = "Semptomlar";
            // 
            // txtTeshisler
            // 
            this.txtTeshisler.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTeshisler.Location = new System.Drawing.Point(214, 225);
            this.txtTeshisler.Name = "txtTeshisler";
            this.txtTeshisler.Size = new System.Drawing.Size(180, 20);
            this.txtTeshisler.TabIndex = 3;
            this.txtTeshisler.Text = "Teşhisler";
            // 
            // txtIlaclar
            // 
            this.txtIlaclar.BackColor = System.Drawing.Color.Gainsboro;
            this.txtIlaclar.Location = new System.Drawing.Point(214, 251);
            this.txtIlaclar.Name = "txtIlaclar";
            this.txtIlaclar.Size = new System.Drawing.Size(180, 20);
            this.txtIlaclar.TabIndex = 3;
            this.txtIlaclar.Text = "İlaçlar";
            // 
            // btnTeshisAnasayfa
            // 
            this.btnTeshisAnasayfa.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTeshisAnasayfa.FlatAppearance.BorderSize = 0;
            this.btnTeshisAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeshisAnasayfa.ForeColor = System.Drawing.Color.White;
            this.btnTeshisAnasayfa.Location = new System.Drawing.Point(243, 292);
            this.btnTeshisAnasayfa.Name = "btnTeshisAnasayfa";
            this.btnTeshisAnasayfa.Size = new System.Drawing.Size(75, 23);
            this.btnTeshisAnasayfa.TabIndex = 9;
            this.btnTeshisAnasayfa.Text = "Anasayfa";
            this.btnTeshisAnasayfa.UseVisualStyleBackColor = false;
            this.btnTeshisAnasayfa.Click += new System.EventHandler(this.btnTeshisAnasayfa_Click);
            // 
            // btnTeshisSil
            // 
            this.btnTeshisSil.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTeshisSil.FlatAppearance.BorderSize = 0;
            this.btnTeshisSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeshisSil.ForeColor = System.Drawing.Color.White;
            this.btnTeshisSil.Location = new System.Drawing.Point(162, 292);
            this.btnTeshisSil.Name = "btnTeshisSil";
            this.btnTeshisSil.Size = new System.Drawing.Size(75, 23);
            this.btnTeshisSil.TabIndex = 10;
            this.btnTeshisSil.Text = "Sil";
            this.btnTeshisSil.UseVisualStyleBackColor = false;
            this.btnTeshisSil.Click += new System.EventHandler(this.btnTeshisSil_Click);
            // 
            // btnTeshisGuncelle
            // 
            this.btnTeshisGuncelle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTeshisGuncelle.FlatAppearance.BorderSize = 0;
            this.btnTeshisGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeshisGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnTeshisGuncelle.Location = new System.Drawing.Point(81, 292);
            this.btnTeshisGuncelle.Name = "btnTeshisGuncelle";
            this.btnTeshisGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnTeshisGuncelle.TabIndex = 11;
            this.btnTeshisGuncelle.Text = "Güncelle";
            this.btnTeshisGuncelle.UseVisualStyleBackColor = false;
            this.btnTeshisGuncelle.Click += new System.EventHandler(this.btnTeshisGuncelle_Click);
            // 
            // btnTeshisEkle
            // 
            this.btnTeshisEkle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTeshisEkle.FlatAppearance.BorderSize = 0;
            this.btnTeshisEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeshisEkle.ForeColor = System.Drawing.Color.White;
            this.btnTeshisEkle.Location = new System.Drawing.Point(0, 292);
            this.btnTeshisEkle.Name = "btnTeshisEkle";
            this.btnTeshisEkle.Size = new System.Drawing.Size(75, 23);
            this.btnTeshisEkle.TabIndex = 12;
            this.btnTeshisEkle.Text = "Ekle";
            this.btnTeshisEkle.UseVisualStyleBackColor = false;
            this.btnTeshisEkle.Click += new System.EventHandler(this.btnTeshisEkle_Click);
            // 
            // TeshisGV
            // 
            this.TeshisGV.BackgroundColor = System.Drawing.Color.White;
            this.TeshisGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeshisGV.Location = new System.Drawing.Point(0, 388);
            this.TeshisGV.Name = "TeshisGV";
            this.TeshisGV.Size = new System.Drawing.Size(499, 285);
            this.TeshisGV.TabIndex = 13;
            this.TeshisGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeshisGV_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(390, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "HASTA LİSTESİ";
            // 
            // panelTeshisOzet
            // 
            this.panelTeshisOzet.Controls.Add(this.lblTeshis);
            this.panelTeshisOzet.Controls.Add(this.label9);
            this.panelTeshisOzet.Controls.Add(this.lblIlac);
            this.panelTeshisOzet.Controls.Add(this.label11);
            this.panelTeshisOzet.Controls.Add(this.label10);
            this.panelTeshisOzet.Controls.Add(this.lblSemptom);
            this.panelTeshisOzet.Controls.Add(this.lblPatientName);
            this.panelTeshisOzet.Controls.Add(this.lblTeshisOzet);
            this.panelTeshisOzet.Location = new System.Drawing.Point(458, 106);
            this.panelTeshisOzet.Name = "panelTeshisOzet";
            this.panelTeshisOzet.Size = new System.Drawing.Size(398, 209);
            this.panelTeshisOzet.TabIndex = 15;
            // 
            // lblTeshis
            // 
            this.lblTeshis.AutoSize = true;
            this.lblTeshis.BackColor = System.Drawing.Color.Transparent;
            this.lblTeshis.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeshis.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTeshis.Location = new System.Drawing.Point(258, 50);
            this.lblTeshis.Name = "lblTeshis";
            this.lblTeshis.Size = new System.Drawing.Size(63, 16);
            this.lblTeshis.TabIndex = 1;
            this.lblTeshis.Text = "Teşhisler";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(353, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tarih";
            // 
            // lblIlac
            // 
            this.lblIlac.AutoSize = true;
            this.lblIlac.BackColor = System.Drawing.Color.Transparent;
            this.lblIlac.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlac.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblIlac.Location = new System.Drawing.Point(258, 88);
            this.lblIlac.Name = "lblIlac";
            this.lblIlac.Size = new System.Drawing.Size(51, 16);
            this.lblIlac.TabIndex = 1;
            this.lblIlac.Text = "İlaçlar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(168, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Emir Tanta ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(113, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Hastahane Yönetim Sistemi";
            // 
            // lblSemptom
            // 
            this.lblSemptom.AutoSize = true;
            this.lblSemptom.BackColor = System.Drawing.Color.Transparent;
            this.lblSemptom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSemptom.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSemptom.Location = new System.Drawing.Point(72, 88);
            this.lblSemptom.Name = "lblSemptom";
            this.lblSemptom.Size = new System.Drawing.Size(86, 16);
            this.lblSemptom.TabIndex = 1;
            this.lblSemptom.Text = "Semptomlar";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.BackColor = System.Drawing.Color.Transparent;
            this.lblPatientName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPatientName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPatientName.Location = new System.Drawing.Point(73, 50);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(71, 16);
            this.lblPatientName.TabIndex = 1;
            this.lblPatientName.Text = "Hasta Adı";
            // 
            // lblTeshisOzet
            // 
            this.lblTeshisOzet.AutoSize = true;
            this.lblTeshisOzet.BackColor = System.Drawing.Color.Transparent;
            this.lblTeshisOzet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeshisOzet.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTeshisOzet.Location = new System.Drawing.Point(155, 5);
            this.lblTeshisOzet.Name = "lblTeshisOzet";
            this.lblTeshisOzet.Size = new System.Drawing.Size(108, 16);
            this.lblTeshisOzet.TabIndex = 1;
            this.lblTeshisOzet.Text = "TEŞHİSLER ÖZETİ";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnTeshisYazdir
            // 
            this.btnTeshisYazdir.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTeshisYazdir.FlatAppearance.BorderSize = 0;
            this.btnTeshisYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeshisYazdir.ForeColor = System.Drawing.Color.White;
            this.btnTeshisYazdir.Location = new System.Drawing.Point(309, 359);
            this.btnTeshisYazdir.Name = "btnTeshisYazdir";
            this.btnTeshisYazdir.Size = new System.Drawing.Size(75, 23);
            this.btnTeshisYazdir.TabIndex = 16;
            this.btnTeshisYazdir.Text = "Yazdır";
            this.btnTeshisYazdir.UseVisualStyleBackColor = false;
            this.btnTeshisYazdir.Click += new System.EventHandler(this.btnTeshisYazdir_Click);
            // 
            // lblKapat
            // 
            this.lblKapat.AutoSize = true;
            this.lblKapat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKapat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblKapat.Location = new System.Drawing.Point(831, 6);
            this.lblKapat.Name = "lblKapat";
            this.lblKapat.Size = new System.Drawing.Size(20, 19);
            this.lblKapat.TabIndex = 1;
            this.lblKapat.Text = "X";
            this.lblKapat.Click += new System.EventHandler(this.lblKapat_Click);
            // 
            // frmTeshis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(856, 675);
            this.Controls.Add(this.btnTeshisYazdir);
            this.Controls.Add(this.panelTeshisOzet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TeshisGV);
            this.Controls.Add(this.btnTeshisAnasayfa);
            this.Controls.Add(this.btnTeshisSil);
            this.Controls.Add(this.btnTeshisGuncelle);
            this.Controls.Add(this.btnTeshisEkle);
            this.Controls.Add(this.cmbTeshisHastaId);
            this.Controls.Add(this.txtIlaclar);
            this.Controls.Add(this.txtTeshisler);
            this.Controls.Add(this.txtTeshisSemptom);
            this.Controls.Add(this.txtTeshisHastaAd);
            this.Controls.Add(this.txtTeshisId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTeshis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTeshis";
            this.Load += new System.EventHandler(this.frmTeshis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeshisGV)).EndInit();
            this.panelTeshisOzet.ResumeLayout(false);
            this.panelTeshisOzet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeshisId;
        private System.Windows.Forms.ComboBox cmbTeshisHastaId;
        private System.Windows.Forms.TextBox txtTeshisHastaAd;
        private System.Windows.Forms.TextBox txtTeshisSemptom;
        private System.Windows.Forms.TextBox txtTeshisler;
        private System.Windows.Forms.TextBox txtIlaclar;
        private System.Windows.Forms.Button btnTeshisAnasayfa;
        private System.Windows.Forms.Button btnTeshisSil;
        private System.Windows.Forms.Button btnTeshisGuncelle;
        private System.Windows.Forms.Button btnTeshisEkle;
        private System.Windows.Forms.DataGridView TeshisGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelTeshisOzet;
        private System.Windows.Forms.Label lblTeshis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblIlac;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSemptom;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblTeshisOzet;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnTeshisYazdir;
        private System.Windows.Forms.Label lblKapat;
    }
}