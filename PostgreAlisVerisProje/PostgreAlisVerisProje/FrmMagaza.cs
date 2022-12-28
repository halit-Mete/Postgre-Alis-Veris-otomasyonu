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
    public partial class FrmMagaza : Form
    {
        public FrmMagaza()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=alisveris; user ID=postgres; password=7993");
        private void BtnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from public.magaza order by magazano asc";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into public.magaza (magazano, magazaad, magazaadres, magazatel, tfirmano) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(TxtMagazaNo.Text));
            komut1.Parameters.AddWithValue("@p2", TxtMagazaAd.Text);
            komut1.Parameters.AddWithValue("@p3", TxtMagazaAdres.Text);
            komut1.Parameters.AddWithValue("@p4", TxtMagazaTel.Text);
            komut1.Parameters.AddWithValue("@p5", int.Parse(CBTedarikNo.SelectedValue.ToString()));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mağaza kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from public.magaza where magazano=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtMagazaNo.Text));
            komut2.ExecuteNonQuery(); // değişiklikleri veri tabanına yanısıtıyor
            baglanti.Close();
            MessageBox.Show("Mağaza silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update public.magaza set magazaad=@p1, magazaadres=@p2, magazatel=@p3, tfirmano=@p4 where magazano=@p5", baglanti);
            komut3.Parameters.AddWithValue("@p1", TxtMagazaAd.Text);
            komut3.Parameters.AddWithValue("@p2", TxtMagazaAdres.Text);
            komut3.Parameters.AddWithValue("@p3", TxtMagazaTel.Text);
            komut3.Parameters.AddWithValue("@p2", int.Parse(CBTedarikNo.SelectedValue.ToString()));
            komut3.Parameters.AddWithValue("@p5", int.Parse(TxtMagazaNo.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mağaza kaydı başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FrmMagaza_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter("select * from kisi.tedarikfirma", baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            CBTedarikNo.DisplayMember = "tfirmaad"; // biz adı seçeceğiz
            CBTedarikNo.ValueMember = "kisino"; // o arkada id sini seçmiş olacak
            CBTedarikNo.DataSource = dt1;
            baglanti.Close();
        }
    }
}
