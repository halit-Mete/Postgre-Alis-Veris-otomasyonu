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
    public partial class FrmTeslimat : Form
    {
        public FrmTeslimat()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=alisveris; user ID=postgres; password=7993");
        private void BtnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from public.teslimatadres order by teslimatno asc";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into public.teslimatadres (teslimatno, ilno) values (@p1,@p2)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(TxtNo.Text));
            komut1.Parameters.AddWithValue("@p2", int.Parse(CBilNo.SelectedValue.ToString()));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Teslimat Adresi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from public.teslimatadres where teslimatno=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(TxtNo.Text));
            komut2.ExecuteNonQuery(); // değişiklikleri veri tabanına yanısıtıyor
            baglanti.Close();
            MessageBox.Show("Teslimat Adresi silme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update public.teslimatadres set ilno=@p1 where teslimatno=@p2", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(CBilNo.SelectedValue.ToString()));
            komut3.Parameters.AddWithValue("@p2", int.Parse(TxtNo.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Teslimat Adresi başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut4 = new NpgsqlCommand("select * from teslimatnoktasi", baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut4);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void FrmTeslimat_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter da11 = new NpgsqlDataAdapter("select * from il", baglanti);
            DataTable dt11 = new DataTable();
            da11.Fill(dt11);
            CBilNo.DisplayMember = "ilad"; // biz adı seçeceğiz
            CBilNo.ValueMember = "il_plakano"; // o arkada id sini seçmiş olacak
            CBilNo.DataSource = dt11;
            baglanti.Close();
        }
    }
}
