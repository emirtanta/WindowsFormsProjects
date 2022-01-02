
namespace HastahaneYonetimSistemi
{
    partial class frmDoctor
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
            this.txtDoktorId = new System.Windows.Forms.TextBox();
            this.txtDoktorAdi = new System.Windows.Forms.TextBox();
            this.txtUzmanlikYili = new System.Windows.Forms.TextBox();
            this.txtDoktorSifre = new System.Windows.Forms.TextBox();
            this.DoktorGV = new System.Windows.Forms.DataGridView();
            this.btnDoktorEkle = new System.Windows.Forms.Button();
            this.btnDoktorGuncelle = new System.Windows.Forms.Button();
            this.btnDoktorSil = new System.Windows.Forms.Button();
            this.btnDoktorAnasayfa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoktorGV)).BeginInit();
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
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(440, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "DOKTOR";
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
            // txtDoktorId
            // 
            this.txtDoktorId.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDoktorId.Location = new System.Drawing.Point(44, 157);
            this.txtDoktorId.Name = "txtDoktorId";
            this.txtDoktorId.Size = new System.Drawing.Size(180, 20);
            this.txtDoktorId.TabIndex = 1;
            this.txtDoktorId.Text = "DoktorId";
            // 
            // txtDoktorAdi
            // 
            this.txtDoktorAdi.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDoktorAdi.Location = new System.Drawing.Point(44, 183);
            this.txtDoktorAdi.Name = "txtDoktorAdi";
            this.txtDoktorAdi.Size = new System.Drawing.Size(180, 20);
            this.txtDoktorAdi.TabIndex = 1;
            this.txtDoktorAdi.Text = "Doktor Adı";
            // 
            // txtUzmanlikYili
            // 
            this.txtUzmanlikYili.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUzmanlikYili.Location = new System.Drawing.Point(44, 209);
            this.txtUzmanlikYili.Name = "txtUzmanlikYili";
            this.txtUzmanlikYili.Size = new System.Drawing.Size(180, 20);
            this.txtUzmanlikYili.TabIndex = 1;
            this.txtUzmanlikYili.Text = "Uzmanlık Yılı";
            // 
            // txtDoktorSifre
            // 
            this.txtDoktorSifre.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDoktorSifre.Location = new System.Drawing.Point(44, 235);
            this.txtDoktorSifre.Name = "txtDoktorSifre";
            this.txtDoktorSifre.Size = new System.Drawing.Size(180, 20);
            this.txtDoktorSifre.TabIndex = 1;
            this.txtDoktorSifre.Text = "Şifre";
            // 
            // DoktorGV
            // 
            this.DoktorGV.BackgroundColor = System.Drawing.Color.White;
            this.DoktorGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoktorGV.Location = new System.Drawing.Point(357, 157);
            this.DoktorGV.Name = "DoktorGV";
            this.DoktorGV.Size = new System.Drawing.Size(499, 187);
            this.DoktorGV.TabIndex = 2;
            this.DoktorGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoktorGV_CellContentClick);
            // 
            // btnDoktorEkle
            // 
            this.btnDoktorEkle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDoktorEkle.FlatAppearance.BorderSize = 0;
            this.btnDoktorEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktorEkle.ForeColor = System.Drawing.Color.White;
            this.btnDoktorEkle.Location = new System.Drawing.Point(44, 279);
            this.btnDoktorEkle.Name = "btnDoktorEkle";
            this.btnDoktorEkle.Size = new System.Drawing.Size(75, 23);
            this.btnDoktorEkle.TabIndex = 3;
            this.btnDoktorEkle.Text = "Ekle";
            this.btnDoktorEkle.UseVisualStyleBackColor = false;
            this.btnDoktorEkle.Click += new System.EventHandler(this.btnDoktorEkle_Click);
            // 
            // btnDoktorGuncelle
            // 
            this.btnDoktorGuncelle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDoktorGuncelle.FlatAppearance.BorderSize = 0;
            this.btnDoktorGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktorGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnDoktorGuncelle.Location = new System.Drawing.Point(125, 279);
            this.btnDoktorGuncelle.Name = "btnDoktorGuncelle";
            this.btnDoktorGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnDoktorGuncelle.TabIndex = 3;
            this.btnDoktorGuncelle.Text = "Güncelle";
            this.btnDoktorGuncelle.UseVisualStyleBackColor = false;
            this.btnDoktorGuncelle.Click += new System.EventHandler(this.btnDoktorGuncelle_Click);
            // 
            // btnDoktorSil
            // 
            this.btnDoktorSil.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDoktorSil.FlatAppearance.BorderSize = 0;
            this.btnDoktorSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktorSil.ForeColor = System.Drawing.Color.White;
            this.btnDoktorSil.Location = new System.Drawing.Point(206, 279);
            this.btnDoktorSil.Name = "btnDoktorSil";
            this.btnDoktorSil.Size = new System.Drawing.Size(75, 23);
            this.btnDoktorSil.TabIndex = 3;
            this.btnDoktorSil.Text = "Sil";
            this.btnDoktorSil.UseVisualStyleBackColor = false;
            this.btnDoktorSil.Click += new System.EventHandler(this.btnDoktorSil_Click);
            // 
            // btnDoktorAnasayfa
            // 
            this.btnDoktorAnasayfa.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDoktorAnasayfa.FlatAppearance.BorderSize = 0;
            this.btnDoktorAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktorAnasayfa.ForeColor = System.Drawing.Color.White;
            this.btnDoktorAnasayfa.Location = new System.Drawing.Point(125, 321);
            this.btnDoktorAnasayfa.Name = "btnDoktorAnasayfa";
            this.btnDoktorAnasayfa.Size = new System.Drawing.Size(75, 23);
            this.btnDoktorAnasayfa.TabIndex = 3;
            this.btnDoktorAnasayfa.Text = "Anasayfa";
            this.btnDoktorAnasayfa.UseVisualStyleBackColor = false;
            this.btnDoktorAnasayfa.Click += new System.EventHandler(this.btnDoktorAnasayfa_Click);
            // 
            // frmDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(856, 675);
            this.Controls.Add(this.btnDoktorAnasayfa);
            this.Controls.Add(this.btnDoktorSil);
            this.Controls.Add(this.btnDoktorGuncelle);
            this.Controls.Add(this.btnDoktorEkle);
            this.Controls.Add(this.DoktorGV);
            this.Controls.Add(this.txtDoktorSifre);
            this.Controls.Add(this.txtUzmanlikYili);
            this.Controls.Add(this.txtDoktorAdi);
            this.Controls.Add(this.txtDoktorId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoctor";
            this.Load += new System.EventHandler(this.frmDoctor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoktorGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDoktorId;
        private System.Windows.Forms.TextBox txtDoktorAdi;
        private System.Windows.Forms.TextBox txtUzmanlikYili;
        private System.Windows.Forms.TextBox txtDoktorSifre;
        private System.Windows.Forms.DataGridView DoktorGV;
        private System.Windows.Forms.Button btnDoktorEkle;
        private System.Windows.Forms.Button btnDoktorGuncelle;
        private System.Windows.Forms.Button btnDoktorSil;
        private System.Windows.Forms.Button btnDoktorAnasayfa;
    }
}