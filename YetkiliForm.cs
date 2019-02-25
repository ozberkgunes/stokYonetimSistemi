using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YazilimSinamaProje
{
    public partial class YetkiliForm : Form
    {
        int zimmetSirasi;
        Singleton singleton;

        public YetkiliForm()
        {
            singleton = Singleton.getInstance();
            InitializeComponent();
            this.MaximizeBox = false;
            this.CenterToScreen();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=JUDASTHEUG;Initial Catalog=stok_yonetim_sistemi;Integrated Security=True");

        private void YetkiliForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stok_yonetim_sistemiDataSet6.tblCalisanlar' table. You can move, or remove it, as needed.
            this.tblCalisanlarTableAdapter.Fill(this.stok_yonetim_sistemiDataSet6.tblCalisanlar);
            // TODO: This line of code loads data into the 'stok_yonetim_sistemiDataSet5.tblDepartman' table. You can move, or remove it, as needed.
            this.tblDepartmanTableAdapter.Fill(this.stok_yonetim_sistemiDataSet5.tblDepartman);
            btnListele.PerformClick();
        }

        private void btnRaporla_Click(object sender, EventArgs e)
        {
            cmbCalID.Text = singleton.temp.ToString();
            SqlCommand cmd = new SqlCommand("select * from tblCalisanlar where depatmanID=@id", baglanti);
            cmd.Parameters.AddWithValue("@id", cmbDepartmanID.Text);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dr.Fill(ds, "tblCalisanlar");
            dataGridView1.DataSource = ds.Tables[0];
        }

 
    }
}
