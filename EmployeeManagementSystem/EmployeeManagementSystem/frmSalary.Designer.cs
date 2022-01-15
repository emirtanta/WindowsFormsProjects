
namespace EmployeeManagementSystem
{
    partial class frmSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalary));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rchTxtDetay = new System.Windows.Forms.RichTextBox();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.btnCalisanGetir = new System.Windows.Forms.Button();
            this.btnCalisanGoster = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.txtCalisanAd = new System.Windows.Forms.TextBox();
            this.txtCalisanPozisyon = new System.Windows.Forms.TextBox();
            this.txtCalisanGun = new System.Windows.Forms.TextBox();
            this.txtCalisanId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(831, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Çalışan Maaşları";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rchTxtDetay);
            this.panel1.Controls.Add(this.btnAnasayfa);
            this.panel1.Controls.Add(this.btnCalisanGetir);
            this.panel1.Controls.Add(this.btnCalisanGoster);
            this.panel1.Controls.Add(this.btnYazdir);
            this.panel1.Controls.Add(this.txtCalisanAd);
            this.panel1.Controls.Add(this.txtCalisanPozisyon);
            this.panel1.Controls.Add(this.txtCalisanGun);
            this.panel1.Controls.Add(this.txtCalisanId);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 365);
            this.panel1.TabIndex = 13;
            // 
            // rchTxtDetay
            // 
            this.rchTxtDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchTxtDetay.ForeColor = System.Drawing.Color.Navy;
            this.rchTxtDetay.Location = new System.Drawing.Point(483, 33);
            this.rchTxtDetay.Name = "rchTxtDetay";
            this.rchTxtDetay.Size = new System.Drawing.Size(366, 270);
            this.rchTxtDetay.TabIndex = 9;
            this.rchTxtDetay.Text = "";
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAnasayfa.FlatAppearance.BorderSize = 0;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfa.ForeColor = System.Drawing.Color.White;
            this.btnAnasayfa.Location = new System.Drawing.Point(13, 323);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(75, 23);
            this.btnAnasayfa.TabIndex = 7;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // btnCalisanGetir
            // 
            this.btnCalisanGetir.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCalisanGetir.FlatAppearance.BorderSize = 0;
            this.btnCalisanGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalisanGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisanGetir.ForeColor = System.Drawing.Color.White;
            this.btnCalisanGetir.Location = new System.Drawing.Point(196, 30);
            this.btnCalisanGetir.Name = "btnCalisanGetir";
            this.btnCalisanGetir.Size = new System.Drawing.Size(75, 23);
            this.btnCalisanGetir.TabIndex = 7;
            this.btnCalisanGetir.Text = "Veri Getir";
            this.btnCalisanGetir.UseVisualStyleBackColor = false;
            this.btnCalisanGetir.Click += new System.EventHandler(this.btnCalisanGetir_Click);
            // 
            // btnCalisanGoster
            // 
            this.btnCalisanGoster.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCalisanGoster.FlatAppearance.BorderSize = 0;
            this.btnCalisanGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalisanGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisanGoster.ForeColor = System.Drawing.Color.White;
            this.btnCalisanGoster.Location = new System.Drawing.Point(94, 323);
            this.btnCalisanGoster.Name = "btnCalisanGoster";
            this.btnCalisanGoster.Size = new System.Drawing.Size(75, 23);
            this.btnCalisanGoster.TabIndex = 7;
            this.btnCalisanGoster.Text = "Göster";
            this.btnCalisanGoster.UseVisualStyleBackColor = false;
            this.btnCalisanGoster.Click += new System.EventHandler(this.btnCalisanGoster_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.BackColor = System.Drawing.Color.OrangeRed;
            this.btnYazdir.FlatAppearance.BorderSize = 0;
            this.btnYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazdir.ForeColor = System.Drawing.Color.White;
            this.btnYazdir.Location = new System.Drawing.Point(483, 323);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(75, 23);
            this.btnYazdir.TabIndex = 7;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = false;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // txtCalisanAd
            // 
            this.txtCalisanAd.Enabled = false;
            this.txtCalisanAd.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtCalisanAd.Location = new System.Drawing.Point(4, 96);
            this.txtCalisanAd.Name = "txtCalisanAd";
            this.txtCalisanAd.Size = new System.Drawing.Size(136, 20);
            this.txtCalisanAd.TabIndex = 1;
            // 
            // txtCalisanPozisyon
            // 
            this.txtCalisanPozisyon.Enabled = false;
            this.txtCalisanPozisyon.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtCalisanPozisyon.Location = new System.Drawing.Point(8, 197);
            this.txtCalisanPozisyon.Name = "txtCalisanPozisyon";
            this.txtCalisanPozisyon.Size = new System.Drawing.Size(136, 20);
            this.txtCalisanPozisyon.TabIndex = 6;
            // 
            // txtCalisanGun
            // 
            this.txtCalisanGun.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtCalisanGun.Location = new System.Drawing.Point(8, 283);
            this.txtCalisanGun.Name = "txtCalisanGun";
            this.txtCalisanGun.Size = new System.Drawing.Size(136, 20);
            this.txtCalisanGun.TabIndex = 6;
            // 
            // txtCalisanId
            // 
            this.txtCalisanId.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtCalisanId.Location = new System.Drawing.Point(3, 33);
            this.txtCalisanId.Name = "txtCalisanId";
            this.txtCalisanId.Size = new System.Drawing.Size(136, 20);
            this.txtCalisanId.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(8, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Çalışılan Gün Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(8, 157);
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
            this.label2.Location = new System.Drawing.Point(4, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Çalışan Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Çalışan Id";
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
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // frmSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(864, 635);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSalary";
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
        private System.Windows.Forms.RichTextBox rchTxtDetay;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Button btnCalisanGetir;
        private System.Windows.Forms.Button btnCalisanGoster;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.TextBox txtCalisanAd;
        private System.Windows.Forms.TextBox txtCalisanPozisyon;
        private System.Windows.Forms.TextBox txtCalisanGun;
        private System.Windows.Forms.TextBox txtCalisanId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}