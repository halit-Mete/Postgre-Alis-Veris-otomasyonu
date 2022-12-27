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
    public partial class Frmilce : Form
    {
        public Frmilce()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=alisveris; user ID=postgres; password=7993");
        private void BtnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from public.ilce order by ilceno asc";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into public.ilce (ilno,ilceno,ilcead, acikadres) values (@p1,@p2,@p3,@p4)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(CBilNo.SelectedValue.ToString()));
            komut1.Parameters.AddWithValue("@p2", int.Parse(TxtilceNo.Text));
            komut1.Parameters.AddWithValue("@p3", TxtilceAd.Text);
            komut1.Parameters.AddWithValue("@p4", TxtAdres.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İlçe kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from public.ilce where ilceno=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtilceNo.Text));
            komut2.ExecuteNonQuery(); // değişiklikleri veri tabanına yanısıtıyor
            baglanti.Close();
            MessageBox.Show("İlçe silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update public.ilce set ilno=@p1, ilcead=@p2, acikadres=@p3 where ilceno=@p4", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(CBilNo.SelectedValue.ToString()));
            komut3.Parameters.AddWithValue("@p2", TxtilceAd.Text);
            komut3.Parameters.AddWithValue("@p3", TxtAdres.Text);
            komut3.Parameters.AddWithValue("@p4", int.Parse(TxtilceNo.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İlçe kaydı başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Frmilce_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from il", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CBilNo.DisplayMember = "ilad"; // biz adı seçeceğiz
            CBilNo.ValueMember = "il_plakano"; // o arkada id sini seçmiş olacak
            CBilNo.DataSource = dt;
            baglanti.Close();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut4 = new NpgsqlCommand("select * from ilcelistesi", baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut4);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
