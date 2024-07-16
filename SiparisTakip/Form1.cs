using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.anaPanel.Controls.Count > 0)
                this.anaPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.anaPanel.Controls.Add(f);
            this.anaPanel.Tag = f;
            f.Show();

        }

       

        private void musteriBtn_Click(object sender, EventArgs e)
        {
            loadform(new MusteriPanel());
        }

        private void siparisBtn_Click(object sender, EventArgs e)
        {
            loadform(new SiparisForm());
        }

        private void urunBtn_Click(object sender, EventArgs e)
        {
            loadform(new UrunForm());
        }

        private void yeniSiparisEkleBtn_Click(object sender, EventArgs e)
        {
            loadform(new YeniSiparisForm());
        }

   
    }
}
