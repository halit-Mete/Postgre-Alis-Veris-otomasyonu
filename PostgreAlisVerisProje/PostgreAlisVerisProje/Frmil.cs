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
    public partial class Frmil : Form
    {
        public Frmil()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=alisveris; user ID=postgres; password=7993");
        private void BtnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from public.il order by il_plakano asc";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into public.il (il_plakano, ilad) values (@p1,@p2)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(TxtNo.Text));
            komut1.Parameters.AddWithValue("@p2", TxtilAd.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İl kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from public.il where il_plakano=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtNo.Text));
            komut2.ExecuteNonQuery(); // değişiklikleri veri tabanına yanısıtıyor
            baglanti.Close();
            MessageBox.Show("İl silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update public.il set ilad=@p1 where il_plakano=@p2", baglanti);
            komut3.Parameters.AddWithValue("@p1", TxtilAd.Text);
            komut3.Parameters.AddWithValue("@p2", int.Parse(TxtNo.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İl kaydı başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
