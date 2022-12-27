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
    public partial class FrmFatura : Form
    {
        public FrmFatura()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=alisveris; user ID=postgres; password=7993");
        private void BtnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from public.fatura order by faturano asc";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into public.fatura (faturano, tutar, tarih, siparisno) values (@p1,@p2,@p3,@p4)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(TxtFaturaNo.Text));
            komut1.Parameters.AddWithValue("@p2", double.Parse(TxtTutar.Text));
            komut1.Parameters.AddWithValue("@p3", TxtTarih.Text);
            komut1.Parameters.AddWithValue("@p4", int.Parse(TxtSiparisNo.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Fatura kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from public.fatura where faturano=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtFaturaNo.Text));
            komut2.ExecuteNonQuery(); // değişiklikleri veri tabanına yanısıtıyor
            baglanti.Close();
            MessageBox.Show("Fatura silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update public.fatura set tutar=@p1, tarih=@p2, siparisno=@p3 where faturano=@p4", baglanti);
            komut3.Parameters.AddWithValue("@p1", double.Parse(TxtTutar.Text));
            komut3.Parameters.AddWithValue("@p2", TxtTarih.Text);
            komut3.Parameters.AddWithValue("@p3", int.Parse(TxtSiparisNo.Text));
            komut3.Parameters.AddWithValue("@p4", int.Parse(TxtFaturaNo.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Fatura kaydı başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnSiparis_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut4 = new NpgsqlCommand("select * from siparislistesi order by siparisno asc", baglanti);
            NpgsqlDataAdapter da4 = new NpgsqlDataAdapter(komut4);
            DataSet ds4 = new DataSet();
            da4.Fill(ds4);
            dataGridView1.DataSource = ds4.Tables[0];
            baglanti.Close();
        }
    }
}
