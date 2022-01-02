
namespace HastahaneYonetimSistemi
{
    partial class frmHasta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHastaId = new System.Windows.Forms.TextBox();
            this.txtHastaAd = new System.Windows.Forms.TextBox();
            this.txtHastaAdres = new System.Windows.Forms.TextBox();
            this.txtHastaTelefon = new System.Windows.Forms.TextBox();
            this.txtHastaYas = new System.Windows.Forms.TextBox();
            this.cmbHastaCinsiyet = new System.Windows.Forms.ComboBox();
            this.cmbHastaKanGrubu = new System.Windows.Forms.ComboBox();
            this.txtHastaBuyukHastalik = new System.Windows.Forms.TextBox();
            this.HastaGV = new System.Windows.Forms.DataGridView();
            this.btnHastaAnaSayfa = new System.Windows.Forms.Button();
            this.btnHastaSil = new System.Windows.Forms.Button();
            this.btnHastaGuncelle = new System.Windows.Forms.Button();
            this.btnHastaEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 100);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(440, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "HASTA";
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
            // txtHastaId
            // 
            this.txtHastaId.BackColor = System.Drawing.Color.Gainsboro;
            this.txtHastaId.Location = new System.Drawing.Point(0, 181);
            this.txtHastaId.Name = "txtHastaId";
            this.txtHastaId.Size = new System.Drawing.Size(180, 20);
            this.txtHastaId.TabIndex = 2;
            this.txtHastaId.Text = "HastaId";
            // 
            // txtHastaAd
            // 
            this.txtHastaAd.BackColor = System.Drawing.Color.Gainsboro;
            this.txtHastaAd.Location = new System.Drawing.Point(0, 207);
            this.txtHastaAd.Name = "txtHastaAd";
            this.txtHastaAd.Size = new System.Drawing.Size(180, 20);
            this.txtHastaAd.TabIndex = 2;
            this.txtHastaAd.Text = "Hasta Adı";
            // 
            // txtHastaAdres
            // 
            this.txtHastaAdres.BackColor = System.Drawing.Color.Gainsboro;
            this.txtHastaAdres.Location = new System.Drawing.Point(0, 233);
            this.txtHastaAdres.Name = "txtHastaAdres";
            this.txtHastaAdres.Size = new System.Drawing.Size(180, 20);
            this.txtHastaAdres.TabIndex = 2;
            this.txtHastaAdres.Text = "Hasta Adresi";
            // 
            // txtHastaTelefon
            // 
            this.txtHastaTelefon.BackColor = System.Drawing.Color.Gainsboro;
            this.txtHastaTelefon.Location = new System.Drawing.Point(0, 259);
            this.txtHastaTelefon.Name = "txtHastaTelefon";
            this.txtHastaTelefon.Size = new System.Drawing.Size(180, 20);
            this.txtHastaTelefon.TabIndex = 2;
            this.txtHastaTelefon.Text = "Hasta Telefon";
            // 
            // txtHastaYas
            // 
            this.txtHastaYas.BackColor = System.Drawing.Color.Gainsboro;
            this.txtHastaYas.Location = new System.Drawing.Point(0, 285);
            this.txtHastaYas.Name = "txtHastaYas";
            this.txtHastaYas.Size = new System.Drawing.Size(180, 20);
            this.txtHastaYas.TabIndex = 2;
            this.txtHastaYas.Text = "Hasta Yaş";
            // 
            // cmbHastaCinsiyet
            // 
            this.cmbHastaCinsiyet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHastaCinsiyet.FormattingEnabled = true;
            this.cmbHastaCinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.cmbHastaCinsiyet.Location = new System.Drawing.Point(0, 312);
            this.cmbHastaCinsiyet.Name = "cmbHastaCinsiyet";
            this.cmbHastaCinsiyet.Size = new System.Drawing.Size(180, 25);
            this.cmbHastaCinsiyet.TabIndex = 3;
            this.cmbHastaCinsiyet.Text = "Cinsiyet";
            // 
            // cmbHastaKanGrubu
            // 
            this.cmbHastaKanGrubu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHastaKanGrubu.FormattingEnabled = true;
            this.cmbHastaKanGrubu.Items.AddRange(new object[] {
            "A+",
            "0+",
            "B+",
            "AB+",
            "A-",
            "0-",
            "B-",
            "AB-"});
            this.cmbHastaKanGrubu.Location = new System.Drawing.Point(0, 343);
            this.cmbHastaKanGrubu.Name = "cmbHastaKanGrubu";
            this.cmbHastaKanGrubu.Size = new System.Drawing.Size(180, 25);
            this.cmbHastaKanGrubu.TabIndex = 3;
            this.cmbHastaKanGrubu.Text = "Kan Grubu";
            // 
            // txtHastaBuyukHastalik
            // 
            this.txtHastaBuyukHastalik.BackColor = System.Drawing.Color.Gainsboro;
            this.txtHastaBuyukHastalik.Location = new System.Drawing.Point(0, 374);
            this.txtHastaBuyukHastalik.Name = "txtHastaBuyukHastalik";
            this.txtHastaBuyukHastalik.Size = new System.Drawing.Size(180, 20);
            this.txtHastaBuyukHastalik.TabIndex = 2;
            this.txtHastaBuyukHastalik.Text = "Büyük Hastalık";
            // 
            // HastaGV
            // 
            this.HastaGV.BackgroundColor = System.Drawing.Color.White;
            this.HastaGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HastaGV.Location = new System.Drawing.Point(357, 181);
            this.HastaGV.Name = "HastaGV";
            this.HastaGV.Size = new System.Drawing.Size(499, 213);
            this.HastaGV.TabIndex = 4;
            this.HastaGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HastaGV_CellContentClick);
            // 
            // btnHastaAnaSayfa
            // 
            this.btnHastaAnaSayfa.BackColor = System.Drawing.Color.LimeGreen;
            this.btnHastaAnaSayfa.FlatAppearance.BorderSize = 0;
            this.btnHastaAnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaAnaSayfa.ForeColor = System.Drawing.Color.White;
            this.btnHastaAnaSayfa.Location = new System.Drawing.Point(93, 463);
            this.btnHastaAnaSayfa.Name = "btnHastaAnaSayfa";
            this.btnHastaAnaSayfa.Size = new System.Drawing.Size(75, 23);
            this.btnHastaAnaSayfa.TabIndex = 5;
            this.btnHastaAnaSayfa.Text = "Anasayfa";
            this.btnHastaAnaSayfa.UseVisualStyleBackColor = false;
            this.btnHastaAnaSayfa.Click += new System.EventHandler(this.btnHastaAnaSayfa_Click);
            // 
            // btnHastaSil
            // 
            this.btnHastaSil.BackColor = System.Drawing.Color.LimeGreen;
            this.btnHastaSil.FlatAppearance.BorderSize = 0;
            this.btnHastaSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaSil.ForeColor = System.Drawing.Color.White;
            this.btnHastaSil.Location = new System.Drawing.Point(174, 421);
            this.btnHastaSil.Name = "btnHastaSil";
            this.btnHastaSil.Size = new System.Drawing.Size(75, 23);
            this.btnHastaSil.TabIndex = 6;
            this.btnHastaSil.Text = "Sil";
            this.btnHastaSil.UseVisualStyleBackColor = false;
            this.btnHastaSil.Click += new System.EventHandler(this.btnHastaSil_Click);
            // 
            // btnHastaGuncelle
            // 
            this.btnHastaGuncelle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnHastaGuncelle.FlatAppearance.BorderSize = 0;
            this.btnHastaGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnHastaGuncelle.Location = new System.Drawing.Point(93, 421);
            this.btnHastaGuncelle.Name = "btnHastaGuncelle";
            this.btnHastaGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnHastaGuncelle.TabIndex = 7;
            this.btnHastaGuncelle.Text = "Güncelle";
            this.btnHastaGuncelle.UseVisualStyleBackColor = false;
            this.btnHastaGuncelle.Click += new System.EventHandler(this.btnHastaGuncelle_Click);
            // 
            // btnHastaEkle
            // 
            this.btnHastaEkle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnHastaEkle.FlatAppearance.BorderSize = 0;
            this.btnHastaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaEkle.ForeColor = System.Drawing.Color.White;
            this.btnHastaEkle.Location = new System.Drawing.Point(12, 421);
            this.btnHastaEkle.Name = "btnHastaEkle";
            this.btnHastaEkle.Size = new System.Drawing.Size(75, 23);
            this.btnHastaEkle.TabIndex = 8;
            this.btnHastaEkle.Text = "Ekle";
            this.btnHastaEkle.UseVisualStyleBackColor = false;
            this.btnHastaEkle.Click += new System.EventHandler(this.btnHastaEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(511, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "HASTA LİSTESİ";
            // 
            // frmHasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(856, 675);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHastaAnaSayfa);
            this.Controls.Add(this.btnHastaSil);
            this.Controls.Add(this.btnHastaGuncelle);
            this.Controls.Add(this.btnHastaEkle);
            this.Controls.Add(this.HastaGV);
            this.Controls.Add(this.cmbHastaKanGrubu);
            this.Controls.Add(this.cmbHastaCinsiyet);
            this.Controls.Add(this.txtHastaBuyukHastalik);
            this.Controls.Add(this.txtHastaYas);
            this.Controls.Add(this.txtHastaTelefon);
            this.Controls.Add(this.txtHastaAdres);
            this.Controls.Add(this.txtHastaAd);
            this.Controls.Add(this.txtHastaId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHasta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHasta";
            this.Load += new System.EventHandler(this.frmHasta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHastaId;
        private System.Windows.Forms.TextBox txtHastaAd;
        private System.Windows.Forms.TextBox txtHastaAdres;
        private System.Windows.Forms.TextBox txtHastaTelefon;
        private System.Windows.Forms.TextBox txtHastaYas;
        private System.Windows.Forms.ComboBox cmbHastaCinsiyet;
        private System.Windows.Forms.ComboBox cmbHastaKanGrubu;
        private System.Windows.Forms.TextBox txtHastaBuyukHastalik;
        private System.Windows.Forms.DataGridView HastaGV;
        private System.Windows.Forms.Button btnHastaAnaSayfa;
        private System.Windows.Forms.Button btnHastaSil;
        private System.Windows.Forms.Button btnHastaGuncelle;
        private System.Windows.Forms.Button btnHastaEkle;
        private System.Windows.Forms.Label label3;
    }
}