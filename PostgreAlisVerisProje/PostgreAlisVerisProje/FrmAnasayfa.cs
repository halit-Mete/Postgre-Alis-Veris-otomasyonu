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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void BtnKisiler_Click(object sender, EventArgs e)
        {
            FrmKisi fk = new FrmKisi();
            fk.Show();

        }

        private void BtnMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteri fm = new FrmMusteri();
            fm.Show();
        }

        private void BtnMt_Click(object sender, EventArgs e)
        {
            FrmMusteriTem fmt = new FrmMusteriTem();
            fmt.Show();
        }

        private void BtnKf_Click(object sender, EventArgs e)
        {
            FrmKargo fkf = new FrmKargo();
            fkf.Show();
        }

        private void BtnTf_Click(object sender, EventArgs e)
        {
            FrmTedarik ftf = new FrmTedarik();
            ftf.Show();
        }

        private void Btnil_Click(object sender, EventArgs e)
        {
            Frmil fil = new Frmil();
            fil.Show();
        }


        private void BtnSiparis_Click(object sender, EventArgs e)
        {
            FrmSiparis fs = new FrmSiparis();
            fs.Show();
        }

        private void BtnTa_Click(object sender, EventArgs e)
        {
            FrmTeslimat fta = new FrmTeslimat();
            fta.Show();
        }

        private void BrnKurye_Click(object sender, EventArgs e)
        {
            FrmKurye fkurye = new FrmKurye();
            fkurye.Show();
        }
        private void BtnMarka_Click(object sender, EventArgs e)
        {
            FrmMarka fmarka = new FrmMarka();
            fmarka.Show();
        }

        private void BtnKategori_Click(object sender, EventArgs e)
        {
            FrmKategori fkategori = new FrmKategori();
            fkategori.Show();
        }

        private void BtnUrun_Click(object sender, EventArgs e)
        {
            FrmUrun furun = new FrmUrun();
            furun.Show();
        }

        private void BtnMagaza_Click(object sender, EventArgs e)
        {
            FrmMagaza fmagaza = new FrmMagaza();
            fmagaza.Show();
        }

        private void BtnFatura_Click(object sender, EventArgs e)
        {
            FrmFatura ffatura = new FrmFatura();
            ffatura.Show();
        }

        private void Btnilce_Click(object sender, EventArgs e)
        {
            Frmilce filce = new Frmilce();
            filce.Show();
        }

        private void BtnToplam_Click(object sender, EventArgs e)
        {
            FrmToplam ftoplam = new FrmToplam();
            ftoplam.Show();
        }
    }
}
