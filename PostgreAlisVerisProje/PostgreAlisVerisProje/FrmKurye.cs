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
    public partial class FrmKurye : Form
    {
        public FrmKurye()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=alisveris; user ID=postgres; password=7993");
        private void BtnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from public.kurye order by kuryeno asc";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into public.kurye (kuryeno, kfirmano, arac) values (@p1,@p2,@p3)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(TxtKurye.Text));
            komut1.Parameters.AddWithValue("@p2", int.Parse(CBKargaFNo.SelectedValue.ToString()));
            komut1.Parameters.AddWithValue("@p3", TxtArac.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kurye kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from public.kurye where kuryeno=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtKurye.Text));
            komut2.ExecuteNonQuery(); // değişiklikleri veri tabanına yanısıtıyor
            baglanti.Close();
            MessageBox.Show("Kurye silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update public.kurye set kfirmano=@p1, arac=@p2 where kuryeno=@p3", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(CBKargaFNo.SelectedValue.ToString()));
            komut3.Parameters.AddWithValue("@p2", TxtArac.Text);
            komut3.Parameters.AddWithValue("@p3", int.Parse(TxtKurye.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kurye kaydı başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut4 = new NpgsqlCommand("select * from kuryekontrol", baglanti);
            NpgsqlDataAdapter da3 = new NpgsqlDataAdapter(komut4);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3);
            dataGridView1.DataSource = ds3.Tables[0];
            baglanti.Close();
        }

        private void BtnKargo_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from kisi.kargofirma order by kisino asc";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            dataGridView1.DataSource = ds2.Tables[0];
            baglanti.Close();
        }

        private void FrmKurye_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from kisi.kargofirma", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CBKargaFNo.DisplayMember = "kfirmaad"; // biz adı seçeceğiz
            CBKargaFNo.ValueMember = "kisino"; // o arkada id sini seçmiş olacak
            CBKargaFNo.DataSource = dt;
            baglanti.Close();
        }

        private void BtnKuryeKargo_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut5 = new NpgsqlCommand("select * from kuryekargokontrol", baglanti);
            NpgsqlDataAdapter da5 = new NpgsqlDataAdapter(komut5);
            DataSet ds5 = new DataSet();
            da5.Fill(ds5);
            dataGridView1.DataSource = ds5.Tables[0];
            baglanti.Close();
        }
    }
}
