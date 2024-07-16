namespace SiparisTakip
{
    partial class UrunForm
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
            this.urunEkleBtn = new System.Windows.Forms.Button();
            this.urunGuncelleBtn = new System.Windows.Forms.Button();
            this.urunSilBtn = new System.Windows.Forms.Button();
            this.urunAd = new System.Windows.Forms.TextBox();
            this.barkodNo = new System.Windows.Forms.TextBox();
            this.stokAdet = new System.Windows.Forms.TextBox();
            this.urunFiyat = new System.Windows.Forms.TextBox();
            this.urunID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Barkod No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok Adeti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ürün ID";
            // 
            // urunEkleBtn
            // 
            this.urunEkleBtn.Location = new System.Drawing.Point(475, 33);
            this.urunEkleBtn.Name = "urunEkleBtn";
            this.urunEkleBtn.Size = new System.Drawing.Size(102, 28);
            this.urunEkleBtn.TabIndex = 4;
            this.urunEkleBtn.Text = "Ürün ekle";
            this.urunEkleBtn.UseVisualStyleBackColor = true;
            this.urunEkleBtn.Click += new System.EventHandler(this.urunEkleBtn_Click);
            // 
            // urunGuncelleBtn
            // 
            this.urunGuncelleBtn.Location = new System.Drawing.Point(475, 64);
            this.urunGuncelleBtn.Name = "urunGuncelleBtn";
            this.urunGuncelleBtn.Size = new System.Drawing.Size(102, 28);
            this.urunGuncelleBtn.TabIndex = 4;
            this.urunGuncelleBtn.Text = "Güncelle";
            this.urunGuncelleBtn.UseVisualStyleBackColor = true;
            this.urunGuncelleBtn.Click += new System.EventHandler(this.urunGuncelleBtn_Click);
            // 
            // urunSilBtn
            // 
            this.urunSilBtn.Location = new System.Drawing.Point(475, 98);
            this.urunSilBtn.Name = "urunSilBtn";
            this.urunSilBtn.Size = new System.Drawing.Size(102, 28);
            this.urunSilBtn.TabIndex = 4;
            this.urunSilBtn.Text = "Sil";
            this.urunSilBtn.UseVisualStyleBackColor = true;
            this.urunSilBtn.Click += new System.EventHandler(this.urunSilBtn_Click);
            // 
            // urunAd
            // 
            this.urunAd.Location = new System.Drawing.Point(106, 38);
            this.urunAd.Name = "urunAd";
            this.urunAd.Size = new System.Drawing.Size(105, 20);
            this.urunAd.TabIndex = 5;
            // 
            // barkodNo
            // 
            this.barkodNo.Location = new System.Drawing.Point(106, 67);
            this.barkodNo.Name = "barkodNo";
            this.barkodNo.Size = new System.Drawing.Size(105, 20);
            this.barkodNo.TabIndex = 5;
            // 
            // stokAdet
            // 
            this.stokAdet.Location = new System.Drawing.Point(106, 97);
            this.stokAdet.Name = "stokAdet";
            this.stokAdet.Size = new System.Drawing.Size(105, 20);
            this.stokAdet.TabIndex = 5;
            // 
            // urunFiyat
            // 
            this.urunFiyat.Location = new System.Drawing.Point(106, 127);
            this.urunFiyat.Name = "urunFiyat";
            this.urunFiyat.Size = new System.Drawing.Size(105, 20);
            this.urunFiyat.TabIndex = 5;
            // 
            // urunID
            // 
            this.urunID.Location = new System.Drawing.Point(310, 38);
            this.urunID.Name = "urunID";
            this.urunID.Size = new System.Drawing.Size(105, 20);
            this.urunID.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ürünler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(534, 103);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // UrunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 407);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.urunID);
            this.Controls.Add(this.urunFiyat);
            this.Controls.Add(this.stokAdet);
            this.Controls.Add(this.barkodNo);
            this.Controls.Add(this.urunAd);
            this.Controls.Add(this.urunSilBtn);
            this.Controls.Add(this.urunGuncelleBtn);
            this.Controls.Add(this.urunEkleBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UrunForm";
            this.Text = "UrunForm";
            this.Load += new System.EventHandler(this.UrunForm_Load);
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
        private System.Windows.Forms.Button urunEkleBtn;
        private System.Windows.Forms.Button urunGuncelleBtn;
        private System.Windows.Forms.Button urunSilBtn;
        private System.Windows.Forms.TextBox urunAd;
        private System.Windows.Forms.TextBox barkodNo;
        private System.Windows.Forms.TextBox stokAdet;
        private System.Windows.Forms.TextBox urunFiyat;
        private System.Windows.Forms.TextBox urunID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}