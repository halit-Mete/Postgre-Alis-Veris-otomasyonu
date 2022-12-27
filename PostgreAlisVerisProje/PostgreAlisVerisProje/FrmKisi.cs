using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PostgreAlisVerisProje
{
    public partial class FrmKisi : Form
    {
        public FrmKisi()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=alisveris; user ID=postgres; password=7993");
        private void BtnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from kisi.kisi order by kisino asc";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into kisi.kisi (kisino, kisiad, kisisoyad, kisitel, kisitip) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(TxtNo.Text));
            komut1.Parameters.AddWithValue("@p2", TxtAd.Text);
            komut1.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            komut1.Parameters.AddWithValue("@p4", TxtTel.Text);
            komut1.Parameters.AddWithValue("@p5", TxtTip.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from kisi.kisi where kisino=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtNo.Text));
            komut2.ExecuteNonQuery(); // değişiklikleri veri tabanına yanısıtıyor
            baglanti.Close();
            MessageBox.Show("Kişi silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update kisi.kisi set kisiad=@p1, kisisoyad=@p2, kisitel=@p3, kisitip=@p4 where kisino=@p5", baglanti);
            komut3.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut3.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut3.Parameters.AddWithValue("@p3", TxtTel.Text);
            komut3.Parameters.AddWithValue("@p4", TxtTip.Text);
            komut3.Parameters.AddWithValue("@p5", int.Parse(TxtNo.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kişi kaydı başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut5 = new NpgsqlCommand("select * from kisigetirno(@p1)", baglanti);
            komut5.Parameters.AddWithValue("@p1", int.Parse(TxtNo.Text));
            komut5.ExecuteNonQuery();
            NpgsqlDataAdapter da5 = new NpgsqlDataAdapter(komut5);
            DataSet ds5 = new DataSet();
            da5.Fill(ds5);
            dataGridView1.DataSource = ds5.Tables[0];
            baglanti.Close();
        }

        private void BtnAraAdSoyad_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut6 = new NpgsqlCommand("select * from kisigetiradsoyad(@p1,@p2)", baglanti);
            komut6.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut6.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut6.ExecuteNonQuery();
            NpgsqlDataAdapter da6 = new NpgsqlDataAdapter(komut6);
            DataSet ds6 = new DataSet();
            da6.Fill(ds6);
            dataGridView1.DataSource = ds6.Tables[0];
            baglanti.Close();
        }
    }
}
