using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisTakip
{
    public partial class YeniSiparisForm : Form
    {
        public YeniSiparisForm()
        {
            InitializeComponent();
        }
        DhSoftDBEntities2 db = new DhSoftDBEntities2();
        void SiparisGetir()
        {
            dataGridView1.DataSource = db.SiparisFormu();


        }
        private void YeniSiparisForm_Load(object sender, EventArgs e)
        {
            SiparisGetir();

            try
            {
                var musteriler = db.MusteriTbl.ToList();
                musteriAdiBox.DisplayMember = "Ad";
                musteriAdiBox.ValueMember = "MusteriID";
                musteriAdiBox.DataSource = musteriler;

                if (musteriler.Count > 0)
                {
                    MusteriIDtxt.Text = musteriler.First().MusteriID.ToString();
                }

                var urunler = db.UrunTbl.ToList();
                urunAdiBox.DisplayMember = "UrunAdi";
                urunAdiBox.ValueMember = "UrunID";
                urunAdiBox.DataSource = urunler;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void musteriAdiBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (musteriAdiBox.SelectedItem != null)
            {
                var secilenMusteri = (MusteriTbl)musteriAdiBox.SelectedItem;
                MusteriIDtxt.Text = secilenMusteri.MusteriID.ToString();
            }
        }
        private void urunAdiBox_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (urunAdiBox.SelectedItem != null)
            {
                var secilenUrun = (UrunTbl)urunAdiBox.SelectedItem;
                UrunIDtxt.Text = secilenUrun.UrunID.ToString();
                adetFiyatBox.Text = secilenUrun.Fiyati.ToString();
                urunStokAdettxt.Text=secilenUrun.StokAdeti.ToString();
            }
        }
        private void siparisEkleBtn_Click(object sender, EventArgs e)
        {

            try
    {
                // Seçilen ürünün stoğunu kontrol et
                int urunID = Convert.ToInt32(UrunIDtxt.Text);
                var urun = db.UrunTbl.Find(urunID);
                if (urun == null)
                {
                    MessageBox.Show("Geçersiz ürün seçimi.");
                    return;
                }

                int siparisAdet = Convert.ToInt32(urunAdetBox.Text);
                if (urun.StokAdeti < siparisAdet)
                {
                    MessageBox.Show("Stokta yeterli ürün bulunmamaktadır.");
                    return;
                }

                // Yeni sipariş oluştur
                SiparisTbl yeniSiparis = new SiparisTbl();
                yeniSiparis.MusteriID = Convert.ToInt32(MusteriIDtxt.Text);
                yeniSiparis.SiparisKayitTarih = yeniSiparisKayit.Value;
                yeniSiparis.SiparisTeslimTarih = yeniSiparisTeslim.Value;
                yeniSiparis.SiparisAciklama = siparisAciklamaBox.Text;
                db.SiparisTbl.Add(yeniSiparis);
                db.SaveChanges(); // Yeni siparişin ID'sini almak için kaydet

                int yeniSiparisID = yeniSiparis.SiparisID;

                // Yeni sipariş detayı oluştur
                SiparisDetayTbl yeniSiparisDetay = new SiparisDetayTbl();
                yeniSiparisDetay.SiparisID = yeniSiparisID;
                yeniSiparisDetay.UrunID = urunID;
                yeniSiparisDetay.UrunAdet = siparisAdet;
                yeniSiparisDetay.AdetFiyat = Convert.ToInt32(adetFiyatBox.Text);
                yeniSiparisDetay.ToplamFiyat = Convert.ToInt32(toplamFiyatBox.Text) * siparisAdet;
                db.SiparisDetayTbl.Add(yeniSiparisDetay);


                // Ürün stokunu güncelleme
                urun.StokAdeti -= siparisAdet;
                db.Entry(urun).State = EntityState.Modified;

                db.SaveChanges();
                SiparisGetir();
                MessageBox.Show("Sipariş Eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }


        }
        private void siparisSilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(SiparisIDtxtBox.Text);
                var silinecekUrun = db.SiparisTbl.Find(id);
                if (silinecekUrun != null)
                {
                    db.SiparisTbl.Remove(silinecekUrun);
                    db.SaveChanges();
                    MessageBox.Show("Sipariş Silindi");
                    SiparisGetir();
                }
                else
                {
                    MessageBox.Show("Silinecek sipariş bulunamadı.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir Sipariş ID giriniz.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
        private void SiparisGuncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int siparisId = Convert.ToInt32(SiparisIDtxtBox.Text);
                int musteriId = Convert.ToInt32(MusteriIDtxt.Text);
                int urunId = Convert.ToInt32(UrunIDtxt.Text);
                int yeniUrunAdet = Convert.ToInt32(urunAdetBox.Text);
                int adetFiyat = Convert.ToInt32(adetFiyatBox.Text);
                int toplamFiyat = Convert.ToInt32(toplamFiyatBox.Text);

                var guncellenecekSiparis = db.SiparisTbl.FirstOrDefault(s => s.SiparisID == siparisId);
                if (guncellenecekSiparis != null)
                {
                    guncellenecekSiparis.MusteriID = musteriId;
                    guncellenecekSiparis.SiparisKayitTarih = yeniSiparisKayit.Value;
                    guncellenecekSiparis.SiparisTeslimTarih = yeniSiparisTeslim.Value;
                    guncellenecekSiparis.SiparisAciklama = siparisAciklamaBox.Text;

                    db.SaveChanges();

                    var guncellenecekSiparisDetay = db.SiparisDetayTbl
                        .FirstOrDefault(d => d.SiparisID == siparisId && d.UrunID == urunId);
                    if (guncellenecekSiparisDetay != null)
                    {
                        var urun = db.UrunTbl.FirstOrDefault(u => u.UrunID == urunId);
                        if (urun != null)
                        {
                            urun.StokAdeti += guncellenecekSiparisDetay.UrunAdet; // Eski stok iade
                            urun.StokAdeti -= yeniUrunAdet; // Yeni stok çıkar
                            db.Entry(urun).State = EntityState.Modified;
                        }

                        guncellenecekSiparisDetay.UrunAdet = yeniUrunAdet;
                        guncellenecekSiparisDetay.AdetFiyat = adetFiyat;
                        guncellenecekSiparisDetay.ToplamFiyat = toplamFiyat;

                        db.SaveChanges();
                        SiparisGetir();
                        MessageBox.Show("Sipariş Güncellendi");
                    }
                    else
                    {
                        MessageBox.Show("Sipariş detayı bulunamadı.");
                    }
                }
                else
                {
                    MessageBox.Show("Güncellenecek sipariş bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            musteriAdiBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            urunAdiBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            urunAdetBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            adetFiyatBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            toplamFiyatBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            SiparisIDtxtBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            yeniSiparisKayit.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            yeniSiparisTeslim.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            siparisAciklamaBox.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

        }

        private void formTemizle_Click(object sender, EventArgs e)
        {
            musteriAdiBox.Text = "";
            urunAdiBox.Text = "";
            urunAdetBox.Text = "";
            adetFiyatBox.Text = "";
            toplamFiyatBox.Text = "";
            SiparisIDtxtBox.Text = ""; 
            yeniSiparisKayit.Text = "";
            yeniSiparisTeslim.Text = "";
            siparisAciklamaBox.Text = "";
            MusteriIDtxt.Text = "";
            UrunIDtxt.Text = "";
            urunStokAdettxt.Text = "";
        }
    }
}
