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
    public partial class MusteriPanel : Form
    {
        public MusteriPanel()
        {
            InitializeComponent();
        }
        DhSoftDBEntities2 db = new DhSoftDBEntities2();
        void MusteriGetir()
        {
            dataGridView1.DataSource = db.MusteriTbl.ToList();
            dataGridView1.Columns[6].Visible = false;
        }
        private void MusteriPanel_Load(object sender, EventArgs e)
        {
            MusteriGetir();
            
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            musteriID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            musteriAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            musteriSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            musteriAdres.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            musteriTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            musteriTck.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void musteriEkleBtn_Click(object sender, EventArgs e)
        {
            MusteriTbl musteri=new MusteriTbl();
            musteri.Ad=musteriAd.Text;  
            musteri.Soyad=musteriSoyad.Text;    
            musteri.TelNo=musteriTel.Text;
            musteri.TcKimlikNo = musteriTck.Text;
            musteri.Adres  =    musteriAdres.Text;
            db.MusteriTbl.Add(musteri);
            db.SaveChanges();
            MusteriGetir();
            MessageBox.Show("Müşteri Eklendi");

        }

        private void musteriSilBtn_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(musteriID.Text);
            var silinecekMusteri=db.MusteriTbl.Find(id);
            db.MusteriTbl.Remove(silinecekMusteri);
            db.SaveChanges() ;
            MessageBox.Show("Müşteri Silindi");
            MusteriGetir();
        }

        private void musteriGuncelleBtn_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(musteriID.Text);
            var guncellenecekMusteri = db.MusteriTbl.Find(id);
            guncellenecekMusteri.Ad=musteriAd.Text;
            guncellenecekMusteri.Soyad = musteriSoyad.Text;
            guncellenecekMusteri.TelNo = musteriTel.Text;
            guncellenecekMusteri.TcKimlikNo= musteriTck.Text;
            guncellenecekMusteri.Adres =   musteriAdres.Text;
            db.SaveChanges();
            MusteriGetir();
            MessageBox.Show("Müşteri Güncellendi");
        }
    }

    internal class DhSoftDBEntities
    {
        public DhSoftDBEntities()
        {
        }
    }
}
