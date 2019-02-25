using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace YazilimSinamaProje
{
    public partial class Form1 : Form
    {
        
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        Singleton singleton;
       

        

        Regex rx = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b",RegexOptions.Compiled | RegexOptions.IgnoreCase);

        public Form1()
        {
            singleton = Singleton.getInstance();
            InitializeComponent();
            this.MaximizeBox = false;
            this.CenterToScreen();
        }

        public int TestLogin(string adi, string parola)
        {
            if (adi == null || parola == null)
            {
                MessageBox.Show("Kullanıcı adı ve Şifre Boş bırakılamaz lütfen bir değer giriniz");
            }
            else if (adi == "" || parola == "")
            {
                MessageBox.Show("Kullanıcı adı ve Şifre Boş bırakılamaz lütfen bir değer giriniz");
            }
            else if (adi.Contains(" ") || parola.Contains(" "))
                MessageBox.Show("Kullanıcı adı ve Şifre boşluk içeremez");
            else if (adi.Length > 20 || parola.Length > 20)
            {
                MessageBox.Show("Kullanıcı adı ve Şifre  20 karakterden uzun olamaz lütfen başka bir kullanıcı adı veya şifre giriniz...");
            }
            else
            {
                int oldu = 0;

                con = new SqlConnection("Data Source=JUDASTHEUG;Initial Catalog=stok_yonetim_sistemi;Integrated Security=True");
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM tblYetkililer where kullaniciAdi='"
                    + adi + "' AND sifre='" + parola + "'AND rolID='" + 1 + "'";
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    oldu++;
                    this.Hide();
                    AdminForm ad = new AdminForm();
                    ad.Show();
                }
                con.Close();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM tblYetkililer where kullaniciAdi='"
                    + adi + "' AND sifre='" + parola + "'AND rolID='" + 3 + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    SqlCommand newcmd = new SqlCommand("SELECT calisanID FROM tblYetkililer WHERE kullaniciAdi='" + adi + "'", con);
                    int userID = (Int32)newcmd.ExecuteScalar();

                    singleton.temp = userID;

                    oldu++;
                    this.Hide();
                    YetkiliForm ad = new YetkiliForm();
                    ad.Show();

                }
                else
                {

                    con.Close();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM tblYetkililer where kullaniciAdi='"
                    + adi + "' AND sifre='" + parola + "'AND rolID='" + 2 + "'";
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {

                        oldu++;
                        this.Hide();
                        SatınAlmaForm ad = new SatınAlmaForm();
                        ad.Show();
                    }
                }
                if (oldu == 0)
                    MessageBox.Show("Geçersiz bir giriş yaptınız!!!");
                con.Close();

            }
            return 1;
        }



        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            TestLogin(txtKullaniciAdi.Text, txtSifre.Text);
        }
    }
}
