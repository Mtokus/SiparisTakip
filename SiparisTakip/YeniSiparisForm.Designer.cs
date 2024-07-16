namespace SiparisTakip
{
    partial class YeniSiparisForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.musteriAdiBox = new System.Windows.Forms.ComboBox();
            this.urunAdiBox = new System.Windows.Forms.ComboBox();
            this.urunAdetBox = new System.Windows.Forms.TextBox();
            this.adetFiyatBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.yeniSiparisKayit = new System.Windows.Forms.DateTimePicker();
            this.yeniSiparisTeslim = new System.Windows.Forms.DateTimePicker();
            this.siparisAciklamaBox = new System.Windows.Forms.TextBox();
            this.siparisEkleBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MusteriIDtxt = new System.Windows.Forms.TextBox();
            this.UrunIDtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toplamFiyatBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.urunStokAdettxt = new System.Windows.Forms.TextBox();
            this.siparisSilBtn = new System.Windows.Forms.Button();
            this.SiparisIDtxtBox = new System.Windows.Forms.TextBox();
            this.SiparisGuncelleBtn = new System.Windows.Forms.Button();
            this.formTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Adet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Adet Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sipariş Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sipariş Teslim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sipariş Açıklama";
            // 
            // musteriAdiBox
            // 
            this.musteriAdiBox.FormattingEnabled = true;
            this.musteriAdiBox.Location = new System.Drawing.Point(106, 31);
            this.musteriAdiBox.Name = "musteriAdiBox";
            this.musteriAdiBox.Size = new System.Drawing.Size(103, 21);
            this.musteriAdiBox.TabIndex = 2;
            this.musteriAdiBox.SelectedIndexChanged += new System.EventHandler(this.musteriAdiBox_SelectedIndexChanged);
            // 
            // urunAdiBox
            // 
            this.urunAdiBox.FormattingEnabled = true;
            this.urunAdiBox.Location = new System.Drawing.Point(106, 64);
            this.urunAdiBox.Name = "urunAdiBox";
            this.urunAdiBox.Size = new System.Drawing.Size(103, 21);
            this.urunAdiBox.TabIndex = 2;
            this.urunAdiBox.SelectedIndexChanged += new System.EventHandler(this.urunAdiBox_SelectedIndexChanged);
            // 
            // urunAdetBox
            // 
            this.urunAdetBox.Location = new System.Drawing.Point(106, 99);
            this.urunAdetBox.Name = "urunAdetBox";
            this.urunAdetBox.Size = new System.Drawing.Size(103, 20);
            this.urunAdetBox.TabIndex = 3;
            // 
            // adetFiyatBox
            // 
            this.adetFiyatBox.Location = new System.Drawing.Point(106, 131);
            this.adetFiyatBox.Name = "adetFiyatBox";
            this.adetFiyatBox.Size = new System.Drawing.Size(103, 20);
            this.adetFiyatBox.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(447, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // yeniSiparisKayit
            // 
            this.yeniSiparisKayit.Location = new System.Drawing.Point(447, 32);
            this.yeniSiparisKayit.Name = "yeniSiparisKayit";
            this.yeniSiparisKayit.Size = new System.Drawing.Size(139, 20);
            this.yeniSiparisKayit.TabIndex = 4;
            // 
            // yeniSiparisTeslim
            // 
            this.yeniSiparisTeslim.Location = new System.Drawing.Point(447, 64);
            this.yeniSiparisTeslim.Name = "yeniSiparisTeslim";
            this.yeniSiparisTeslim.Size = new System.Drawing.Size(139, 20);
            this.yeniSiparisTeslim.TabIndex = 4;
            // 
            // siparisAciklamaBox
            // 
            this.siparisAciklamaBox.Location = new System.Drawing.Point(447, 99);
            this.siparisAciklamaBox.Multiline = true;
            this.siparisAciklamaBox.Name = "siparisAciklamaBox";
            this.siparisAciklamaBox.Size = new System.Drawing.Size(139, 52);
            this.siparisAciklamaBox.TabIndex = 3;
            // 
            // siparisEkleBtn
            // 
            this.siparisEkleBtn.Location = new System.Drawing.Point(503, 172);
            this.siparisEkleBtn.Name = "siparisEkleBtn";
            this.siparisEkleBtn.Size = new System.Drawing.Size(83, 29);
            this.siparisEkleBtn.TabIndex = 5;
            this.siparisEkleBtn.Text = "Sipariş Oluştur";
            this.siparisEkleBtn.UseVisualStyleBackColor = true;
            this.siparisEkleBtn.Click += new System.EventHandler(this.siparisEkleBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 110);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // MusteriIDtxt
            // 
            this.MusteriIDtxt.Enabled = false;
            this.MusteriIDtxt.Location = new System.Drawing.Point(242, 31);
            this.MusteriIDtxt.Name = "MusteriIDtxt";
            this.MusteriIDtxt.Size = new System.Drawing.Size(39, 20);
            this.MusteriIDtxt.TabIndex = 7;
            // 
            // UrunIDtxt
            // 
            this.UrunIDtxt.Enabled = false;
            this.UrunIDtxt.Location = new System.Drawing.Point(242, 64);
            this.UrunIDtxt.Name = "UrunIDtxt";
            this.UrunIDtxt.Size = new System.Drawing.Size(39, 20);
            this.UrunIDtxt.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "ID";
            // 
            // toplamFiyatBox
            // 
            this.toplamFiyatBox.Enabled = false;
            this.toplamFiyatBox.Location = new System.Drawing.Point(106, 171);
            this.toplamFiyatBox.Name = "toplamFiyatBox";
            this.toplamFiyatBox.Size = new System.Drawing.Size(103, 20);
            this.toplamFiyatBox.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Toplam Fiyat";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(218, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Ürün Stok";
            // 
            // urunStokAdettxt
            // 
            this.urunStokAdettxt.Enabled = false;
            this.urunStokAdettxt.Location = new System.Drawing.Point(279, 98);
            this.urunStokAdettxt.Name = "urunStokAdettxt";
            this.urunStokAdettxt.Size = new System.Drawing.Size(36, 20);
            this.urunStokAdettxt.TabIndex = 14;
            // 
            // siparisSilBtn
            // 
            this.siparisSilBtn.Location = new System.Drawing.Point(404, 172);
            this.siparisSilBtn.Name = "siparisSilBtn";
            this.siparisSilBtn.Size = new System.Drawing.Size(93, 29);
            this.siparisSilBtn.TabIndex = 15;
            this.siparisSilBtn.Text = "Sipariş Sil";
            this.siparisSilBtn.UseVisualStyleBackColor = true;
            this.siparisSilBtn.Click += new System.EventHandler(this.siparisSilBtn_Click);
            // 
            // SiparisIDtxtBox
            // 
            this.SiparisIDtxtBox.Location = new System.Drawing.Point(493, 230);
            this.SiparisIDtxtBox.Name = "SiparisIDtxtBox";
            this.SiparisIDtxtBox.Size = new System.Drawing.Size(93, 20);
            this.SiparisIDtxtBox.TabIndex = 16;
            // 
            // SiparisGuncelleBtn
            // 
            this.SiparisGuncelleBtn.Location = new System.Drawing.Point(305, 172);
            this.SiparisGuncelleBtn.Name = "SiparisGuncelleBtn";
            this.SiparisGuncelleBtn.Size = new System.Drawing.Size(93, 29);
            this.SiparisGuncelleBtn.TabIndex = 17;
            this.SiparisGuncelleBtn.Text = "Güncelle";
            this.SiparisGuncelleBtn.UseVisualStyleBackColor = true;
            this.SiparisGuncelleBtn.Click += new System.EventHandler(this.SiparisGuncelleBtn_Click);
            // 
            // formTemizle
            // 
            this.formTemizle.Location = new System.Drawing.Point(493, 372);
            this.formTemizle.Name = "formTemizle";
            this.formTemizle.Size = new System.Drawing.Size(92, 21);
            this.formTemizle.TabIndex = 18;
            this.formTemizle.Text = "Formu Temizle";
            this.formTemizle.UseVisualStyleBackColor = true;
            this.formTemizle.Click += new System.EventHandler(this.formTemizle_Click);
            // 
            // YeniSiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 422);
            this.Controls.Add(this.formTemizle);
            this.Controls.Add(this.SiparisGuncelleBtn);
            this.Controls.Add(this.SiparisIDtxtBox);
            this.Controls.Add(this.siparisSilBtn);
            this.Controls.Add(this.urunStokAdettxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.toplamFiyatBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UrunIDtxt);
            this.Controls.Add(this.MusteriIDtxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.siparisEkleBtn);
            this.Controls.Add(this.yeniSiparisKayit);
            this.Controls.Add(this.yeniSiparisTeslim);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.siparisAciklamaBox);
            this.Controls.Add(this.adetFiyatBox);
            this.Controls.Add(this.urunAdetBox);
            this.Controls.Add(this.urunAdiBox);
            this.Controls.Add(this.musteriAdiBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YeniSiparisForm";
            this.Text = "YeniSiparisForm";
            this.Load += new System.EventHandler(this.YeniSiparisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox musteriAdiBox;
        private System.Windows.Forms.ComboBox urunAdiBox;
        private System.Windows.Forms.TextBox urunAdetBox;
        private System.Windows.Forms.TextBox adetFiyatBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker yeniSiparisKayit;
        private System.Windows.Forms.DateTimePicker yeniSiparisTeslim;
        private System.Windows.Forms.TextBox siparisAciklamaBox;
        private System.Windows.Forms.Button siparisEkleBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox MusteriIDtxt;
        private System.Windows.Forms.TextBox UrunIDtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox toplamFiyatBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox urunStokAdettxt;
        private System.Windows.Forms.Button siparisSilBtn;
        private System.Windows.Forms.TextBox SiparisIDtxtBox;
        private System.Windows.Forms.Button SiparisGuncelleBtn;
        private System.Windows.Forms.Button formTemizle;
    }
}