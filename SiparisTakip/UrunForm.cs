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
    public partial class UrunForm : Form
    {
        public UrunForm()
        {
            InitializeComponent();
        }
        DhSoftDBEntities2 db = new DhSoftDBEntities2();
        void UrunGetir()
        {
            dataGridView1.DataSource = db.UrunTbl.ToList();
            dataGridView1.Columns[5].Visible = false;


        }

        private void UrunForm_Load(object sender, EventArgs e)
        {
            UrunGetir();
        }

        private void urunEkleBtn_Click(object sender, EventArgs e)
        {
            UrunTbl urun=new UrunTbl();
            urun.UrunAdi=urunAd.Text;
            urun.BarkodNO=barkodNo.Text;
            urun.StokAdeti =Convert.ToInt32(stokAdet.Text);
            urun.Fiyati = Convert.ToInt32(urunFiyat.Text);
            db.UrunTbl.Add(urun);
            db.SaveChanges();
            UrunGetir();
            MessageBox.Show("Ürün Eklendi");
        }

       

        private void urunSilBtn_Click(object sender, EventArgs e)
        {
           int id=Convert.ToInt32(urunID.Text);
            var silinecekUrun = db.UrunTbl.Find(id);
            db.UrunTbl.Remove(silinecekUrun);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi");
            UrunGetir();

        }
     

        private void urunGuncelleBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(urunID.Text);
            var guncellenecekUrun = db.UrunTbl.Find(id);
            guncellenecekUrun.UrunAdi = urunAd.Text;
            guncellenecekUrun.BarkodNO = barkodNo.Text;
            guncellenecekUrun.StokAdeti= Convert.ToInt32(stokAdet.Text);
            guncellenecekUrun.Fiyati= Convert.ToInt32(urunFiyat.Text);
            db.SaveChanges();
            UrunGetir();
            MessageBox.Show("Müşteri Güncellendi");
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            urunID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            urunAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            barkodNo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            stokAdet.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            urunFiyat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
