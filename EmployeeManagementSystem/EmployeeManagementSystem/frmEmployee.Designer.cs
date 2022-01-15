
namespace EmployeeManagementSystem
{
    partial class frmEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCalisanId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCalisanAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCalisanAdres = new System.Windows.Forms.TextBox();
            this.cmbCalisanPozisyon = new System.Windows.Forms.ComboBox();
            this.dtpCalisanDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCalisanTelefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCalisanEgitim = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCalisanCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnCalisanEkle = new System.Windows.Forms.Button();
            this.btnCalisanDuzenle = new System.Windows.Forms.Button();
            this.btnCalisanSil = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.employeeDGV = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Çalışan Yönetim";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.employeeDGV);
            this.panel1.Controls.Add(this.btnAnasayfa);
            this.panel1.Controls.Add(this.btnCalisanSil);
            this.panel1.Controls.Add(this.btnCalisanDuzenle);
            this.panel1.Controls.Add(this.btnCalisanEkle);
            this.panel1.Controls.Add(this.dtpCalisanDogumTarihi);
            this.panel1.Controls.Add(this.cmbCalisanCinsiyet);
            this.panel1.Controls.Add(this.cmbCalisanEgitim);
            this.panel1.Controls.Add(this.cmbCalisanPozisyon);
            this.panel1.Controls.Add(this.txtCalisanAd);
            this.panel1.Controls.Add(this.txtCalisanTelefon);
            this.panel1.Controls.Add(this.txtCalisanAdres);
            this.panel1.Controls.Add(this.txtCalisanId);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 365);
            this.panel1.TabIndex = 4;
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
            // txtCalisanId
            // 
            this.txtCalisanId.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtCalisanId.Location = new System.Drawing.Point(3, 33);
            this.txtCalisanId.Name = "txtCalisanId";
            this.txtCalisanId.Size = new System.Drawing.Size(136, 20);
            this.txtCalisanId.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(161, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Çalışan Adı";
            // 
            // txtCalisanAd
            // 
            this.txtCalisanAd.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtCalisanAd.Location = new System.Drawing.Point(161, 33);
            this.txtCalisanAd.Name = "txtCalisanAd";
            this.txtCalisanAd.Size = new System.Drawing.Size(136, 20);
            this.txtCalisanAd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(3, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(3, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Pozisyon";
            // 
            // txtCalisanAdres
            // 
            this.txtCalisanAdres.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtCalisanAdres.Location = new System.Drawing.Point(3, 97);
            this.txtCalisanAdres.Name = "txtCalisanAdres";
            this.txtCalisanAdres.Size = new System.Drawing.Size(136, 20);
            this.txtCalisanAdres.TabIndex = 2;
            // 
            // cmbCalisanPozisyon
            // 
            this.cmbCalisanPozisyon.ForeColor = System.Drawing.Color.OrangeRed;
            this.cmbCalisanPozisyon.FormattingEnabled = true;
            this.cmbCalisanPozisyon.ItemHeight = 13;
            this.cmbCalisanPozisyon.Items.AddRange(new object[] {
            "Yönetici",
            "Senior Develooper",
            "Junior Develooper",
            "Accountant",
            "Receptionist"});
            this.cmbCalisanPozisyon.Location = new System.Drawing.Point(3, 172);
            this.cmbCalisanPozisyon.Name = "cmbCalisanPozisyon";
            this.cmbCalisanPozisyon.Size = new System.Drawing.Size(121, 21);
            this.cmbCalisanPozisyon.TabIndex = 4;
            // 
            // dtpCalisanDogumTarihi
            // 
            this.dtpCalisanDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpCalisanDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCalisanDogumTarihi.Location = new System.Drawing.Point(165, 172);
            this.dtpCalisanDogumTarihi.Name = "dtpCalisanDogumTarihi";
            this.dtpCalisanDogumTarihi.Size = new System.Drawing.Size(132, 20);
            this.dtpCalisanDogumTarihi.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(3, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Telefon";
            // 
            // txtCalisanTelefon
            // 
            this.txtCalisanTelefon.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtCalisanTelefon.Location = new System.Drawing.Point(3, 266);
            this.txtCalisanTelefon.Name = "txtCalisanTelefon";
            this.txtCalisanTelefon.Size = new System.Drawing.Size(136, 20);
            this.txtCalisanTelefon.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(161, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Eğitim Durumu";
            // 
            // cmbCalisanEgitim
            // 
            this.cmbCalisanEgitim.ForeColor = System.Drawing.Color.OrangeRed;
            this.cmbCalisanEgitim.FormattingEnabled = true;
            this.cmbCalisanEgitim.Items.AddRange(new object[] {
            "BTech",
            "MTech",
            "BBA",
            "BCA",
            "MBA",
            "BCom",
            "MCom"});
            this.cmbCalisanEgitim.Location = new System.Drawing.Point(165, 266);
            this.cmbCalisanEgitim.Name = "cmbCalisanEgitim";
            this.cmbCalisanEgitim.Size = new System.Drawing.Size(121, 21);
            this.cmbCalisanEgitim.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(161, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Doğum Tarihi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(161, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Cinsiyet";
            // 
            // cmbCalisanCinsiyet
            // 
            this.cmbCalisanCinsiyet.ForeColor = System.Drawing.Color.OrangeRed;
            this.cmbCalisanCinsiyet.FormattingEnabled = true;
            this.cmbCalisanCinsiyet.ItemHeight = 13;
            this.cmbCalisanCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCalisanCinsiyet.Location = new System.Drawing.Point(161, 97);
            this.cmbCalisanCinsiyet.Name = "cmbCalisanCinsiyet";
            this.cmbCalisanCinsiyet.Size = new System.Drawing.Size(121, 21);
            this.cmbCalisanCinsiyet.TabIndex = 5;
            // 
            // btnCalisanEkle
            // 
            this.btnCalisanEkle.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCalisanEkle.FlatAppearance.BorderSize = 0;
            this.btnCalisanEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalisanEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisanEkle.ForeColor = System.Drawing.Color.White;
            this.btnCalisanEkle.Location = new System.Drawing.Point(13, 313);
            this.btnCalisanEkle.Name = "btnCalisanEkle";
            this.btnCalisanEkle.Size = new System.Drawing.Size(75, 23);
            this.btnCalisanEkle.TabIndex = 7;
            this.btnCalisanEkle.Text = "Ekle";
            this.btnCalisanEkle.UseVisualStyleBackColor = false;
            this.btnCalisanEkle.Click += new System.EventHandler(this.btnCalisanEkle_Click);
            // 
            // btnCalisanDuzenle
            // 
            this.btnCalisanDuzenle.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCalisanDuzenle.FlatAppearance.BorderSize = 0;
            this.btnCalisanDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalisanDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisanDuzenle.ForeColor = System.Drawing.Color.White;
            this.btnCalisanDuzenle.Location = new System.Drawing.Point(94, 313);
            this.btnCalisanDuzenle.Name = "btnCalisanDuzenle";
            this.btnCalisanDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnCalisanDuzenle.TabIndex = 7;
            this.btnCalisanDuzenle.Text = "Düzenle";
            this.btnCalisanDuzenle.UseVisualStyleBackColor = false;
            this.btnCalisanDuzenle.Click += new System.EventHandler(this.btnCalisanDuzenle_Click);
            // 
            // btnCalisanSil
            // 
            this.btnCalisanSil.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCalisanSil.FlatAppearance.BorderSize = 0;
            this.btnCalisanSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalisanSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalisanSil.ForeColor = System.Drawing.Color.White;
            this.btnCalisanSil.Location = new System.Drawing.Point(175, 313);
            this.btnCalisanSil.Name = "btnCalisanSil";
            this.btnCalisanSil.Size = new System.Drawing.Size(75, 23);
            this.btnCalisanSil.TabIndex = 7;
            this.btnCalisanSil.Text = "Sil";
            this.btnCalisanSil.UseVisualStyleBackColor = false;
            this.btnCalisanSil.Click += new System.EventHandler(this.btnCalisanSil_Click);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAnasayfa.FlatAppearance.BorderSize = 0;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfa.ForeColor = System.Drawing.Color.White;
            this.btnAnasayfa.Location = new System.Drawing.Point(256, 313);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(75, 23);
            this.btnAnasayfa.TabIndex = 7;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // employeeDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Yellow;
            this.employeeDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.employeeDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.employeeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDGV.Location = new System.Drawing.Point(376, 3);
            this.employeeDGV.Name = "employeeDGV";
            this.employeeDGV.Size = new System.Drawing.Size(421, 359);
            this.employeeDGV.TabIndex = 8;
            this.employeeDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDGV_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(701, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Emir Tanta";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(767, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "X";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpCalisanDogumTarihi;
        private System.Windows.Forms.ComboBox cmbCalisanEgitim;
        private System.Windows.Forms.ComboBox cmbCalisanPozisyon;
        private System.Windows.Forms.TextBox txtCalisanAd;
        private System.Windows.Forms.TextBox txtCalisanTelefon;
        private System.Windows.Forms.TextBox txtCalisanAdres;
        private System.Windows.Forms.TextBox txtCalisanId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView employeeDGV;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.Button btnCalisanSil;
        private System.Windows.Forms.Button btnCalisanDuzenle;
        private System.Windows.Forms.Button btnCalisanEkle;
        private System.Windows.Forms.ComboBox cmbCalisanCinsiyet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}