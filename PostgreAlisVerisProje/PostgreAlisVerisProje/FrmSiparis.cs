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
    public partial class FrmSiparis : Form
    {
        public FrmSiparis()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=alisveris; user ID=postgres; password=7993");
        private void BtnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from public.siparis order by siparisno asc";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into public.siparis (siparisno, musterino, musteritemsilcino, teslimatno, kuryeno, urunno) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(TxtSiparis.Text));
            komut1.Parameters.AddWithValue("@p2", int.Parse(CBMusteriNo.SelectedValue.ToString()));
            komut1.Parameters.AddWithValue("@p3", int.Parse(CBMusTem.SelectedValue.ToString()));
            komut1.Parameters.AddWithValue("@p4", int.Parse(CBTeslimatNo.SelectedValue.ToString()));
            komut1.Parameters.AddWithValue("@p5", int.Parse(TxtKurye.Text));
            komut1.Parameters.AddWithValue("@p6", int.Parse(CBUrunNo.SelectedValue.ToString()));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sipariş kaydı başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from public.siparis where siparisno=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtSiparis.Text));
            komut2.ExecuteNonQuery(); // değişiklikleri veri tabanına yanısıtıyor
            baglanti.Close();
            MessageBox.Show("Sipariş silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update public.siparis set musterino=@p1, musteritemsilcino=@p2, teslimatno=@p3, kuryeno=@p4, urunno=@p5 where siparisno=@p6", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(CBMusteriNo.SelectedValue.ToString()));
            komut3.Parameters.AddWithValue("@p2", int.Parse(CBMusTem.SelectedValue.ToString()));
            komut3.Parameters.AddWithValue("@p3", int.Parse(CBTeslimatNo.SelectedValue.ToString()));
            komut3.Parameters.AddWithValue("@p4", int.Parse(TxtKurye.Text));
            komut3.Parameters.AddWithValue("@p5", int.Parse(CBUrunNo.SelectedValue.ToString()));
            komut3.Parameters.AddWithValue("@p6", int.Parse(TxtSiparis.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sipariş kaydı başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut4 = new NpgsqlCommand("select * from siparislistesi order by siparisno asc", baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut4);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void BtnUrun_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut4 = new NpgsqlCommand("select * from urunkontrol order by urunno asc", baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut4);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void FrmSiparis_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from kisi.kisi where kisitip like 'Müşteri'", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CBMusteriNo.DisplayMember = "kisiad"; // biz adı seçeceğiz
            CBMusteriNo.ValueMember = "kisino"; // o arkada id sini seçmiş olacak
            CBMusteriNo.DataSource = dt;


            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("select * from kisi.kisi where kisitip like 'Müşteri Tem%'", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            CBMusTem.DisplayMember = "kisiad"; // biz adı seçeceğiz
            CBMusTem.ValueMember = "kisino"; // o arkada id sini seçmiş olacak
            CBMusTem.DataSource = dt2;


            NpgsqlDataAdapter da3 = new NpgsqlDataAdapter("select * from public.teslimatadres", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            CBTeslimatNo.DisplayMember = "ilno"; // biz adı seçeceğiz
            CBTeslimatNo.ValueMember = "teslimatno"; // o arkada id sini seçmiş olacak
            CBTeslimatNo.DataSource = dt3;


            NpgsqlDataAdapter da4 = new NpgsqlDataAdapter("select * from public.urun", baglanti);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);
            CBUrunNo.DisplayMember = "urunad"; // biz adı seçeceğiz
            CBUrunNo.ValueMember = "urunno"; // o arkada id sini seçmiş olacak
            CBUrunNo.DataSource = dt4;
            baglanti.Close();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut6 = new NpgsqlCommand("select * from siparisgetirno(@p1)", baglanti);
            komut6.Parameters.AddWithValue("@p1", int.Parse(TxtSiparis.Text));
            komut6.ExecuteNonQuery();
            NpgsqlDataAdapter da6 = new NpgsqlDataAdapter(komut6);
            DataSet ds6 = new DataSet();
            da6.Fill(ds6);
            dataGridView1.DataSource = ds6.Tables[0];
            baglanti.Close();
        }
    }
}
