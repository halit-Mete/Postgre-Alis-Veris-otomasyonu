namespace PostgreAlisVerisProje
{
    partial class Anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnKisiler = new System.Windows.Forms.Button();
            this.BtnMusteriler = new System.Windows.Forms.Button();
            this.BtnMt = new System.Windows.Forms.Button();
            this.BtnKf = new System.Windows.Forms.Button();
            this.BtnTf = new System.Windows.Forms.Button();
            this.Btnil = new System.Windows.Forms.Button();
            this.BtnSiparis = new System.Windows.Forms.Button();
            this.BtnTa = new System.Windows.Forms.Button();
            this.BrnKurye = new System.Windows.Forms.Button();
            this.BtnMarka = new System.Windows.Forms.Button();
            this.BtnKategori = new System.Windows.Forms.Button();
            this.BtnUrun = new System.Windows.Forms.Button();
            this.BtnMagaza = new System.Windows.Forms.Button();
            this.BtnFatura = new System.Windows.Forms.Button();
            this.Btnilce = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnToplam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnKisiler
            // 
            this.BtnKisiler.Location = new System.Drawing.Point(250, 59);
            this.BtnKisiler.Name = "BtnKisiler";
            this.BtnKisiler.Size = new System.Drawing.Size(144, 56);
            this.BtnKisiler.TabIndex = 0;
            this.BtnKisiler.Text = "Kişiler";
            this.BtnKisiler.UseVisualStyleBackColor = true;
            this.BtnKisiler.Click += new System.EventHandler(this.BtnKisiler_Click);
            // 
            // BtnMusteriler
            // 
            this.BtnMusteriler.Location = new System.Drawing.Point(23, 133);
            this.BtnMusteriler.Name = "BtnMusteriler";
            this.BtnMusteriler.Size = new System.Drawing.Size(127, 52);
            this.BtnMusteriler.TabIndex = 1;
            this.BtnMusteriler.Text = "Müşteriler";
            this.BtnMusteriler.UseVisualStyleBackColor = true;
            this.BtnMusteriler.Click += new System.EventHandler(this.BtnMusteriler_Click);
            // 
            // BtnMt
            // 
            this.BtnMt.Location = new System.Drawing.Point(177, 133);
            this.BtnMt.Name = "BtnMt";
            this.BtnMt.Size = new System.Drawing.Size(127, 52);
            this.BtnMt.TabIndex = 2;
            this.BtnMt.Text = "Müşteri Temsilcisi";
            this.BtnMt.UseVisualStyleBackColor = true;
            this.BtnMt.Click += new System.EventHandler(this.BtnMt_Click);
            // 
            // BtnKf
            // 
            this.BtnKf.Location = new System.Drawing.Point(330, 133);
            this.BtnKf.Name = "BtnKf";
            this.BtnKf.Size = new System.Drawing.Size(127, 52);
            this.BtnKf.TabIndex = 3;
            this.BtnKf.Text = "Kargo Firması";
            this.BtnKf.UseVisualStyleBackColor = true;
            this.BtnKf.Click += new System.EventHandler(this.BtnKf_Click);
            // 
            // BtnTf
            // 
            this.BtnTf.Location = new System.Drawing.Point(485, 133);
            this.BtnTf.Name = "BtnTf";
            this.BtnTf.Size = new System.Drawing.Size(127, 52);
            this.BtnTf.TabIndex = 4;
            this.BtnTf.Text = "Tedarikçi Firması";
            this.BtnTf.UseVisualStyleBackColor = true;
            this.BtnTf.Click += new System.EventHandler(this.BtnTf_Click);
            // 
            // Btnil
            // 
            this.Btnil.Location = new System.Drawing.Point(136, 279);
            this.Btnil.Name = "Btnil";
            this.Btnil.Size = new System.Drawing.Size(74, 52);
            this.Btnil.TabIndex = 5;
            this.Btnil.Text = "İller";
            this.Btnil.UseVisualStyleBackColor = true;
            this.Btnil.Click += new System.EventHandler(this.Btnil_Click);
            // 
            // BtnSiparis
            // 
            this.BtnSiparis.Location = new System.Drawing.Point(23, 205);
            this.BtnSiparis.Name = "BtnSiparis";
            this.BtnSiparis.Size = new System.Drawing.Size(127, 52);
            this.BtnSiparis.TabIndex = 10;
            this.BtnSiparis.Text = "Sipariş";
            this.BtnSiparis.UseVisualStyleBackColor = true;
            this.BtnSiparis.Click += new System.EventHandler(this.BtnSiparis_Click);
            // 
            // BtnTa
            // 
            this.BtnTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.BtnTa.Location = new System.Drawing.Point(23, 278);
            this.BtnTa.Name = "BtnTa";
            this.BtnTa.Size = new System.Drawing.Size(107, 53);
            this.BtnTa.TabIndex = 11;
            this.BtnTa.Text = "Teslimat Adresi";
            this.BtnTa.UseVisualStyleBackColor = true;
            this.BtnTa.Click += new System.EventHandler(this.BtnTa_Click);
            // 
            // BrnKurye
            // 
            this.BrnKurye.Location = new System.Drawing.Point(330, 205);
            this.BrnKurye.Name = "BrnKurye";
            this.BrnKurye.Size = new System.Drawing.Size(127, 52);
            this.BrnKurye.TabIndex = 12;
            this.BrnKurye.Text = "Kurye";
            this.BrnKurye.UseVisualStyleBackColor = true;
            this.BrnKurye.Click += new System.EventHandler(this.BrnKurye_Click);
            // 
            // BtnMarka
            // 
            this.BtnMarka.Location = new System.Drawing.Point(339, 278);
            this.BtnMarka.Name = "BtnMarka";
            this.BtnMarka.Size = new System.Drawing.Size(87, 52);
            this.BtnMarka.TabIndex = 13;
            this.BtnMarka.Text = "Marka";
            this.BtnMarka.UseVisualStyleBackColor = true;
            this.BtnMarka.Click += new System.EventHandler(this.BtnMarka_Click);
            // 
            // BtnKategori
            // 
            this.BtnKategori.Location = new System.Drawing.Point(432, 278);
            this.BtnKategori.Name = "BtnKategori";
            this.BtnKategori.Size = new System.Drawing.Size(91, 52);
            this.BtnKategori.TabIndex = 14;
            this.BtnKategori.Text = "Kategori";
            this.BtnKategori.UseVisualStyleBackColor = true;
            this.BtnKategori.Click += new System.EventHandler(this.BtnKategori_Click);
            // 
            // BtnUrun
            // 
            this.BtnUrun.Location = new System.Drawing.Point(529, 278);
            this.BtnUrun.Name = "BtnUrun";
            this.BtnUrun.Size = new System.Drawing.Size(83, 52);
            this.BtnUrun.TabIndex = 15;
            this.BtnUrun.Text = "Ürün";
            this.BtnUrun.UseVisualStyleBackColor = true;
            this.BtnUrun.Click += new System.EventHandler(this.BtnUrun_Click);
            // 
            // BtnMagaza
            // 
            this.BtnMagaza.Location = new System.Drawing.Point(485, 205);
            this.BtnMagaza.Name = "BtnMagaza";
            this.BtnMagaza.Size = new System.Drawing.Size(127, 52);
            this.BtnMagaza.TabIndex = 16;
            this.BtnMagaza.Text = "Mağaza";
            this.BtnMagaza.UseVisualStyleBackColor = true;
            this.BtnMagaza.Click += new System.EventHandler(this.BtnMagaza_Click);
            // 
            // BtnFatura
            // 
            this.BtnFatura.Location = new System.Drawing.Point(177, 205);
            this.BtnFatura.Name = "BtnFatura";
            this.BtnFatura.Size = new System.Drawing.Size(127, 52);
            this.BtnFatura.TabIndex = 17;
            this.BtnFatura.Text = "Fatura";
            this.BtnFatura.UseVisualStyleBackColor = true;
            this.BtnFatura.Click += new System.EventHandler(this.BtnFatura_Click);
            // 
            // Btnilce
            // 
            this.Btnilce.Location = new System.Drawing.Point(216, 279);
            this.Btnilce.Name = "Btnilce";
            this.Btnilce.Size = new System.Drawing.Size(74, 52);
            this.Btnilce.TabIndex = 18;
            this.Btnilce.Text = "İlçeler";
            this.Btnilce.UseVisualStyleBackColor = true;
            this.Btnilce.Click += new System.EventHandler(this.Btnilce_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 38;
            this.label1.Text = "Anasayfa";
            // 
            // BtnToplam
            // 
            this.BtnToplam.Location = new System.Drawing.Point(468, 26);
            this.BtnToplam.Name = "BtnToplam";
            this.BtnToplam.Size = new System.Drawing.Size(144, 56);
            this.BtnToplam.TabIndex = 39;
            this.BtnToplam.Text = "Toplam Sayılar";
            this.BtnToplam.UseVisualStyleBackColor = true;
            this.BtnToplam.Click += new System.EventHandler(this.BtnToplam_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 357);
            this.Controls.Add(this.BtnToplam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btnilce);
            this.Controls.Add(this.BtnFatura);
            this.Controls.Add(this.BtnMagaza);
            this.Controls.Add(this.BtnUrun);
            this.Controls.Add(this.BtnKategori);
            this.Controls.Add(this.BtnMarka);
            this.Controls.Add(this.BrnKurye);
            this.Controls.Add(this.BtnTa);
            this.Controls.Add(this.BtnSiparis);
            this.Controls.Add(this.Btnil);
            this.Controls.Add(this.BtnTf);
            this.Controls.Add(this.BtnKf);
            this.Controls.Add(this.BtnMt);
            this.Controls.Add(this.BtnMusteriler);
            this.Controls.Add(this.BtnKisiler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKisiler;
        private System.Windows.Forms.Button BtnMusteriler;
        private System.Windows.Forms.Button BtnMt;
        private System.Windows.Forms.Button BtnKf;
        private System.Windows.Forms.Button BtnTf;
        private System.Windows.Forms.Button Btnil;
        private System.Windows.Forms.Button BtnSiparis;
        private System.Windows.Forms.Button BtnTa;
        private System.Windows.Forms.Button BrnKurye;
        private System.Windows.Forms.Button BtnMarka;
        private System.Windows.Forms.Button BtnKategori;
        private System.Windows.Forms.Button BtnUrun;
        private System.Windows.Forms.Button BtnMagaza;
        private System.Windows.Forms.Button BtnFatura;
        private System.Windows.Forms.Button Btnilce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnToplam;
    }
}

