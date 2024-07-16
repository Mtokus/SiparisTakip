namespace SiparisTakip
{
    partial class Form1
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.musteriBtn = new System.Windows.Forms.Button();
            this.urunBtn = new System.Windows.Forms.Button();
            this.siparisBtn = new System.Windows.Forms.Button();
            this.yeniSiparisEkleBtn = new System.Windows.Forms.Button();
            this.anaPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Silver;
            this.menuPanel.Controls.Add(this.musteriBtn);
            this.menuPanel.Controls.Add(this.urunBtn);
            this.menuPanel.Controls.Add(this.siparisBtn);
            this.menuPanel.Controls.Add(this.yeniSiparisEkleBtn);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(167, 450);
            this.menuPanel.TabIndex = 0;
            // 
            // musteriBtn
            // 
            this.musteriBtn.Location = new System.Drawing.Point(20, 27);
            this.musteriBtn.Name = "musteriBtn";
            this.musteriBtn.Size = new System.Drawing.Size(131, 28);
            this.musteriBtn.TabIndex = 0;
            this.musteriBtn.Text = "Müşteriler";
            this.musteriBtn.UseVisualStyleBackColor = true;
            this.musteriBtn.Click += new System.EventHandler(this.musteriBtn_Click);
            // 
            // urunBtn
            // 
            this.urunBtn.Location = new System.Drawing.Point(20, 95);
            this.urunBtn.Name = "urunBtn";
            this.urunBtn.Size = new System.Drawing.Size(131, 28);
            this.urunBtn.TabIndex = 2;
            this.urunBtn.Text = "Ürünler";
            this.urunBtn.UseVisualStyleBackColor = true;
            this.urunBtn.Click += new System.EventHandler(this.urunBtn_Click);
            // 
            // siparisBtn
            // 
            this.siparisBtn.Location = new System.Drawing.Point(20, 61);
            this.siparisBtn.Name = "siparisBtn";
            this.siparisBtn.Size = new System.Drawing.Size(131, 28);
            this.siparisBtn.TabIndex = 1;
            this.siparisBtn.Text = "Siparişler";
            this.siparisBtn.UseVisualStyleBackColor = true;
            this.siparisBtn.Click += new System.EventHandler(this.siparisBtn_Click);
            // 
            // yeniSiparisEkleBtn
            // 
            this.yeniSiparisEkleBtn.Location = new System.Drawing.Point(20, 129);
            this.yeniSiparisEkleBtn.Name = "yeniSiparisEkleBtn";
            this.yeniSiparisEkleBtn.Size = new System.Drawing.Size(131, 28);
            this.yeniSiparisEkleBtn.TabIndex = 3;
            this.yeniSiparisEkleBtn.Text = "Sipariş İşlemleri";
            this.yeniSiparisEkleBtn.UseVisualStyleBackColor = true;
            this.yeniSiparisEkleBtn.Click += new System.EventHandler(this.yeniSiparisEkleBtn_Click);
            // 
            // anaPanel
            // 
            this.anaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.anaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.anaPanel.Location = new System.Drawing.Point(167, 0);
            this.anaPanel.Name = "anaPanel";
            this.anaPanel.Size = new System.Drawing.Size(633, 450);
            this.anaPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.anaPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button yeniSiparisEkleBtn;
        private System.Windows.Forms.Button urunBtn;
        private System.Windows.Forms.Button siparisBtn;
        private System.Windows.Forms.Button musteriBtn;
        private System.Windows.Forms.Panel anaPanel;
    }
}

