﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.Data.ODataLinq.Helpers;
using DevExpress.Data.WcfLinq.Helpers;
using System.Text.RegularExpressions;

namespace YazilimSinamaProje
{
    public partial class SatınAlmaForm : Form
    {

        Regex regex = new Regex("^[0-9]*$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        int zimmetSirasi;
        int depoID = 1;
        SqlConnection con;
        SqlCommand cmd;

        public SatınAlmaForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.CenterToScreen();
        }

        public void guncelle()
        {
            this.tblZimmetTableAdapter.Dispose();
            this.tblZimmetTableAdapter.Fill(this.stok_yonetim_sistemiDataSet2.tblZimmet);
        }

        private void SatınAlmaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stok_yonetim_sistemiDataSet4.sp_Raporlama' table. You can move, or remove it, as needed.
            this.sp_RaporlamaTableAdapter.Fill(this.stok_yonetim_sistemiDataSet4.sp_Raporlama);
            // TODO: This line of code loads data into the 'stok_yonetim_sistemiDataSet3.tblFirma' table. You can move, or remove it, as needed.
            this.tblFirmaTableAdapter.Fill(this.stok_yonetim_sistemiDataSet3.tblFirma);
            // TODO: This line of code loads data into the 'stok_yonetim_sistemiDataSet2.tblZimmet' table. You can move, or remove it, as needed.
            this.tblZimmetTableAdapter.Fill(this.stok_yonetim_sistemiDataSet2.tblZimmet);
            // TODO: This line of code loads data into the 'stok_yonetim_sistemiDataSet1.tblUrun' table. You can move, or remove it, as needed.
            this.tblUrunTableAdapter.Fill(this.stok_yonetim_sistemiDataSet1.tblUrun);
            // TODO: This line of code loads data into the 'stok_yonetim_sistemiDataSet.tblCalisanlar' table. You can move, or remove it, as needed.
            this.tblCalisanlarTableAdapter.Fill(this.stok_yonetim_sistemiDataSet.tblCalisanlar);
            con = new SqlConnection("Data Source=JUDASTHEUG;Initial Catalog=stok_yonetim_sistemi;Integrated Security=True");
            con.Open();
        }

        private void btnZimmet_Click(object sender, EventArgs e)
        {

            tblZimmet zimmet = new tblZimmet();
            zimmetArttir();
            zimmet.calisanID = Convert.ToInt32(cmbCalisanZimmet.Text);
            zimmet.urunID = Convert.ToInt32(cmbUrunZimmet.Text);
            zimmet.yetkiliID = 0;
            zimmetSirasi++;
            zimmet.zimmetID = zimmetSirasi;
            

            using (stok_yonetim_sistemiEntities3 db = new stok_yonetim_sistemiEntities3())
            {
                db.tblZimmet.Add(zimmet);
                db.SaveChanges();
            }
            MessageBox.Show("Ürün Çalışana Zimmetlendi");
            guncelle();
        }

        private void btnZimmetKaldır_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("DELETE from tblZimmet where zimmetID=@id", con);
            cmd.Parameters.AddWithValue("@id", cmbZimmetKaldir.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Zimmet Kaldırıldı");
            guncelle();
        }

        private void SatınAlma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (txtUrunadi.Text == null || txtUrunTipi.Text == null || txtFiyati.Text == null || txtAdet.Text == null || txtMarka.Text == null)
            {
                MessageBox.Show("Ürün bilgisi alanları boş bırakılamaz");
            }
            else if (txtUrunadi.Text == ""|| txtUrunTipi.Text == "" || txtFiyati.Text == "" || txtAdet.Text == "" || txtMarka.Text == "")
            {
                MessageBox.Show("Ürün bilgisi alanları boş bırakılamaz");
            }
            else if (txtUrunadi.Text.Contains(" ") || txtUrunTipi.Text.Contains(" ") || txtFiyati.Text.Contains(" ") || txtAdet.Text.Contains(" ") || txtMarka.Text.Contains(" "))
                MessageBox.Show("Ürün bilgisi alanlarında boşluk karakteri kullanılamaz");
            else if (txtUrunadi.Text.Length > 50 || txtUrunTipi.Text.Length > 20 || txtMarka.Text.Length > 20)
            {
                MessageBox.Show("Geçersiz Karakter uzunluğu!");
            }
            else if (!(regex.IsMatch(txtAdet.Text)) || !(regex.IsMatch(txtFiyati.Text)) || Convert.ToInt32(txtAdet.Text) < 1 || Convert.ToInt32(txtFiyati.Text) < 1)
            {
                MessageBox.Show("Ürün adeti ve fiyatına pozitif bir sayı girilmelidir başka karakter girilemez");
            }
            else
            {
                tblUrun u = new tblUrun();
                u.urunAdi = txtUrunadi.Text;
                u.urunTipi = txtUrunTipi.Text;
                u.marka = txtMarka.Text;
                u.firmaID = Convert.ToInt32(cmbFirmaID.Text);
                u.fiyat = Convert.ToDecimal(txtFiyati.Text);
                tblDepo d = new tblDepo();
                d.depoID = this.depoID;
                d.adet = Convert.ToInt32(txtAdet.Text);
                d.satinAlmaTarihi = DateTime.Now;

                using (stok_yonetim_sistemiEntities3 db = new stok_yonetim_sistemiEntities3())
                {
                    db.tblUrun.Add(u);
                    db.SaveChanges();
                    db.tblDepo.Add(d);
                    d.urunID = u.urunID;
                    db.SaveChanges();
                }
                MessageBox.Show("Ürün Stoğa Eklendi");
            }
        }

        public void zimmetArttir()
        {

            SqlCommand newcmd2 = new SqlCommand("SELECT zimmetID FROM tblZimmet where zimmetID=(select max(zimmetID) from tblZimmet)", con);
            zimmetSirasi = (Int32)newcmd2.ExecuteScalar();
            if (zimmetSirasi == 0)
            {
                zimmetSirasi = 1;
            }
        }

        private void gcRaporla_Click(object sender, EventArgs e)
        {
            gcRapor.ShowRibbonPrintPreview();
        }
    }
}
