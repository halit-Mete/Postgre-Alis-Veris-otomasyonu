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

namespace PostgreAlisVerisProje
{
    public partial class FrmTedarik : Form
    {
        public FrmTedarik()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=alisveris; user ID=postgres; password=7993");

        private void BtnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from kisi.tedarikfirma order by kisino asc";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into kisi.tedarikfirma (kisino, tfirmaad) values (@p1,@p2)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(TxtNo.Text));
            komut1.Parameters.AddWithValue("@p2", TxtFirmaAd.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Tedarikçi kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from kisi.tedarikfirma where kisino=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtNo.Text));
            komut2.ExecuteNonQuery(); // değişiklikleri veri tabanına yanısıtıyor
            baglanti.Close();
            MessageBox.Show("Tedarikçi Firma silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update kisi.tedarikfirma set tfirmaad=@p1 where kisino=@p2", baglanti);
            komut3.Parameters.AddWithValue("@p1", TxtFirmaAd.Text);
            komut3.Parameters.AddWithValue("@p2", int.Parse(TxtNo.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Tedarikçi Firma kaydı başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnKisiler_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from kisi.kisi order by kisino asc";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
