using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisTakip
{
    public partial class SiparisForm : Form
    {
        public SiparisForm()
        {
            InitializeComponent();
        }
         DhSoftDBEntities2 db= new DhSoftDBEntities2();
        void MusterileriGetir() 
        {
            dataGridView1.DataSource = db.MusteriBilgi();
        }
        private void SiparisForm_Load(object sender, EventArgs e)
        {
            MusterileriGetir();
        }

        private void FiltreBtn_Click(object sender, EventArgs e)
        {
            string searchText = FiltreTxt.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(searchText))
            {
                // Veritabanından arama 
                var filteredData = db.MusteriBilgi()
                    .Where(m => m.Ad_Soyad.ToLower().Contains(searchText) ||
                                m.TC_Kimlik.ToString().Contains(searchText) ||
                                m.Ürün_Adı.ToString().Contains(searchText))
                    .ToList();

                dataGridView1.DataSource = filteredData;
            }
            else
            {
                // TextBox boş ise tüm verileri göster
                MusterileriGetir();
            }
        }
    }
}
