
namespace EmployeeManagementSystem
{
    partial class frmViewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewEmployee));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCalisanAra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.lblCalisanId = new System.Windows.Forms.Label();
            this.lblCalisanAdres = new System.Windows.Forms.Label();
            this.lblCalisanPozisyon = new System.Windows.Forms.Label();
            this.lblCalisanTelefon = new System.Windows.Forms.Label();
            this.lblCalisanAd = new System.Windows.Forms.Label();
            this.lblCalisanDogumTarihi = new System.Windows.Forms.Label();
            this.lblCalisanCinsiyet = new System.Windows.Forms.Label();
            this.lblCalisanEgitim = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(767, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Çalışan Detayları";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAnasayfa);
            this.panel1.Controls.Add(this.btnYazdir);
            this.panel1.Controls.Add(this.btnYenile);
            this.panel1.Controls.Add(this.txtCalisanAra);
            this.panel1.Controls.Add(this.lblCalisanEgitim);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblCalisanCinsiyet);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblCalisanTelefon);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblCalisanDogumTarihi);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblCalisanPozisyon);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblCalisanAd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblCalisanAdres);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblCalisanId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 365);
            this.panel1.TabIndex = 10;
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAnasayfa.FlatAppearance.BorderSize = 0;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfa.ForeColor = System.Drawing.Color.White;
            this.btnAnasayfa.Location = new System.Drawing.Point(499, 328);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(75, 23);
            this.btnAnasayfa.TabIndex = 7;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.OrangeRed;
            this.btnYenile.FlatAppearance.BorderSize = 0;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.Color.White;
            this.btnYenile.Location = new System.Drawing.Point(475, 13);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 23);
            this.btnYenile.TabIndex = 7;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(391, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Eğitim Durumu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(391, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Cinsiyet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(69, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Telefon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(391, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Doğum Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(69, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Pozisyon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(391, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Çalışan Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(69, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(69, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Çalışan Id";
            // 
            // txtCalisanAra
            // 
            this.txtCalisanAra.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtCalisanAra.Location = new System.Drawing.Point(332, 15);
            this.txtCalisanAra.Name = "txtCalisanAra";
            this.txtCalisanAra.Size = new System.Drawing.Size(113, 20);
            this.txtCalisanAra.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(237, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Çalışan Id";
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.OrangeRed;
            this.btnYazdir.FlatAppearance.BorderSize = 0;
            this.btnYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.ForeColor = System.Drawing.Color.White;
            this.btnYazdir.Location = new System.Drawing.Point(256, 328);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(75, 23);
            this.btnYazdir.TabIndex = 7;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // lblCalisanId
            // 
            this.lblCalisanId.AutoSize = true;
            this.lblCalisanId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalisanId.ForeColor = System.Drawing.Color.Navy;
            this.lblCalisanId.Location = new System.Drawing.Point(216, 65);
            this.lblCalisanId.Name = "lblCalisanId";
            this.lblCalisanId.Size = new System.Drawing.Size(89, 20);
            this.lblCalisanId.TabIndex = 3;
            this.lblCalisanId.Text = "Çalışan Id";
            this.lblCalisanId.Visible = false;
            // 
            // lblCalisanAdres
            // 
            this.lblCalisanAdres.AutoSize = true;
            this.lblCalisanAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalisanAdres.ForeColor = System.Drawing.Color.Navy;
            this.lblCalisanAdres.Location = new System.Drawing.Point(216, 129);
            this.lblCalisanAdres.Name = "lblCalisanAdres";
            this.lblCalisanAdres.Size = new System.Drawing.Size(56, 20);
            this.lblCalisanAdres.TabIndex = 3;
            this.lblCalisanAdres.Text = "Adres";
            this.lblCalisanAdres.Visible = false;
            // 
            // lblCalisanPozisyon
            // 
            this.lblCalisanPozisyon.AutoSize = true;
            this.lblCalisanPozisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalisanPozisyon.ForeColor = System.Drawing.Color.Navy;
            this.lblCalisanPozisyon.Location = new System.Drawing.Point(216, 204);
            this.lblCalisanPozisyon.Name = "lblCalisanPozisyon";
            this.lblCalisanPozisyon.Size = new System.Drawing.Size(80, 20);
            this.lblCalisanPozisyon.TabIndex = 3;
            this.lblCalisanPozisyon.Text = "Pozisyon";
            this.lblCalisanPozisyon.Visible = false;
            // 
            // lblCalisanTelefon
            // 
            this.lblCalisanTelefon.AutoSize = true;
            this.lblCalisanTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalisanTelefon.ForeColor = System.Drawing.Color.Navy;
            this.lblCalisanTelefon.Location = new System.Drawing.Point(216, 281);
            this.lblCalisanTelefon.Name = "lblCalisanTelefon";
            this.lblCalisanTelefon.Size = new System.Drawing.Size(69, 20);
            this.lblCalisanTelefon.TabIndex = 3;
            this.lblCalisanTelefon.Text = "Telefon";
            this.lblCalisanTelefon.Visible = false;
            // 
            // lblCalisanAd
            // 
            this.lblCalisanAd.AutoSize = true;
            this.lblCalisanAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalisanAd.ForeColor = System.Drawing.Color.Navy;
            this.lblCalisanAd.Location = new System.Drawing.Point(567, 65);
            this.lblCalisanAd.Name = "lblCalisanAd";
            this.lblCalisanAd.Size = new System.Drawing.Size(99, 20);
            this.lblCalisanAd.TabIndex = 3;
            this.lblCalisanAd.Text = "Çalışan Adı";
            this.lblCalisanAd.Visible = false;
            // 
            // lblCalisanDogumTarihi
            // 
            this.lblCalisanDogumTarihi.AutoSize = true;
            this.lblCalisanDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalisanDogumTarihi.ForeColor = System.Drawing.Color.Navy;
            this.lblCalisanDogumTarihi.Location = new System.Drawing.Point(567, 204);
            this.lblCalisanDogumTarihi.Name = "lblCalisanDogumTarihi";
            this.lblCalisanDogumTarihi.Size = new System.Drawing.Size(115, 20);
            this.lblCalisanDogumTarihi.TabIndex = 3;
            this.lblCalisanDogumTarihi.Text = "Doğum Tarihi";
            this.lblCalisanDogumTarihi.Visible = false;
            // 
            // lblCalisanCinsiyet
            // 
            this.lblCalisanCinsiyet.AutoSize = true;
            this.lblCalisanCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalisanCinsiyet.ForeColor = System.Drawing.Color.Navy;
            this.lblCalisanCinsiyet.Location = new System.Drawing.Point(567, 129);
            this.lblCalisanCinsiyet.Name = "lblCalisanCinsiyet";
            this.lblCalisanCinsiyet.Size = new System.Drawing.Size(72, 20);
            this.lblCalisanCinsiyet.TabIndex = 3;
            this.lblCalisanCinsiyet.Text = "Cinsiyet";
            this.lblCalisanCinsiyet.Visible = false;
            // 
            // lblCalisanEgitim
            // 
            this.lblCalisanEgitim.AutoSize = true;
            this.lblCalisanEgitim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalisanEgitim.ForeColor = System.Drawing.Color.Navy;
            this.lblCalisanEgitim.Location = new System.Drawing.Point(567, 281);
            this.lblCalisanEgitim.Name = "lblCalisanEgitim";
            this.lblCalisanEgitim.Size = new System.Drawing.Size(127, 20);
            this.lblCalisanEgitim.TabIndex = 3;
            this.lblCalisanEgitim.Text = "Eğitim Durumu";
            this.lblCalisanEgitim.Visible = false;
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
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewEmployee";
            this.Load += new System.EventHandler(this.frmViewEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.TextBox txtCalisanAra;
        private System.Windows.Forms.Label lblCalisanEgitim;
        private System.Windows.Forms.Label lblCalisanCinsiyet;
        private System.Windows.Forms.Label lblCalisanTelefon;
        private System.Windows.Forms.Label lblCalisanDogumTarihi;
        private System.Windows.Forms.Label lblCalisanPozisyon;
        private System.Windows.Forms.Label lblCalisanAd;
        private System.Windows.Forms.Label lblCalisanAdres;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCalisanId;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}