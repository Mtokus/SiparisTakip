namespace SiparisTakip
{
    partial class SiparisForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FiltreBtn = new System.Windows.Forms.Button();
            this.FiltreTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(493, 168);
            this.dataGridView1.TabIndex = 0;
            // 
            // FiltreBtn
            // 
            this.FiltreBtn.Location = new System.Drawing.Point(458, 137);
            this.FiltreBtn.Name = "FiltreBtn";
            this.FiltreBtn.Size = new System.Drawing.Size(89, 20);
            this.FiltreBtn.TabIndex = 1;
            this.FiltreBtn.Text = "Ara";
            this.FiltreBtn.UseVisualStyleBackColor = true;
            this.FiltreBtn.Click += new System.EventHandler(this.FiltreBtn_Click);
            // 
            // FiltreTxt
            // 
            this.FiltreTxt.Location = new System.Drawing.Point(377, 138);
            this.FiltreTxt.Name = "FiltreTxt";
            this.FiltreTxt.Size = new System.Drawing.Size(75, 20);
            this.FiltreTxt.TabIndex = 2;
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 418);
            this.Controls.Add(this.FiltreTxt);
            this.Controls.Add(this.FiltreBtn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SiparisForm";
            this.Text = "SiparisForm";
            this.Load += new System.EventHandler(this.SiparisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button FiltreBtn;
        private System.Windows.Forms.TextBox FiltreTxt;
    }
}