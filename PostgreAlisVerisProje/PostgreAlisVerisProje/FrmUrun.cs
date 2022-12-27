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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=alisveris; user ID=postgres; password=7993");
        private void BtnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from public.urun order by urunno asc";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into public.urun (urunno, magazano, urunad, urunfiyat, urunstok, kategorino, markano) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(TxtUrunNo.Text));
            komut1.Parameters.AddWithValue("@p2", int.Parse(CBMagazaNo.SelectedValue.ToString()));
            komut1.Parameters.AddWithValue("@p3", TxtUrunAd.Text);
            komut1.Parameters.AddWithValue("@p4", int.Parse(TxtUrunFiyat.Text));
            komut1.Parameters.AddWithValue("@p5", int.Parse(TxtUrunStok.Text));
            komut1.Parameters.AddWithValue("@p6", int.Parse(CBKategoriNo.SelectedValue.ToString()));
            komut1.Parameters.AddWithValue("@p7", int.Parse(CBMarkaNo.SelectedValue.ToString()));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from public.urun where urunno=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtUrunNo.Text));
            komut2.ExecuteNonQuery(); // değişiklikleri veri tabanına yanısıtıyor
            baglanti.Close();
            MessageBox.Show("Ürün silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update public.urun set magazano=@p1, urunad=@p2, urunfiyat=@p3, urunstok=@p4, kategorino=@p5, markano=@p6 where urunno=@p7", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(CBMagazaNo.SelectedValue.ToString()));
            komut3.Parameters.AddWithValue("@p2", TxtUrunAd.Text);
            komut3.Parameters.AddWithValue("@p3", int.Parse(TxtUrunFiyat.Text));
            komut3.Parameters.AddWithValue("@p4", int.Parse(TxtUrunStok.Text));
            komut3.Parameters.AddWithValue("@p5", int.Parse(CBKategoriNo.SelectedValue.ToString()));
            komut3.Parameters.AddWithValue("@p6", int.Parse(CBMarkaNo.SelectedValue.ToString()));
            komut3.Parameters.AddWithValue("@p7", int.Parse(TxtUrunNo.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün kaydı başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from kategori", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CBKategoriNo.DisplayMember = "kategoriad"; // biz adı seçeceğiz
            CBKategoriNo.ValueMember = "kategorino"; // o arkada id sini seçmiş olacak
            CBKategoriNo.DataSource = dt;


            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select * from marka", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            CBMarkaNo.DisplayMember = "markaad"; // biz adı seçeceğiz
            CBMarkaNo.ValueMember = "markano"; // o arkada id sini seçmiş olacak
            CBMarkaNo.DataSource = dt2;


            NpgsqlDataAdapter da11 = new NpgsqlDataAdapter("select * from public.magaza", baglanti);
            DataTable dt11 = new DataTable();
            da11.Fill(dt11);
            CBMagazaNo.DisplayMember = "magazaad"; // biz adı seçeceğiz
            CBMagazaNo.ValueMember = "magazano"; // o arkada id sini seçmiş olacak
            CBMagazaNo.DataSource = dt11;
            baglanti.Close();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut4 = new NpgsqlCommand("select * from urunkontrol", baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut4);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
