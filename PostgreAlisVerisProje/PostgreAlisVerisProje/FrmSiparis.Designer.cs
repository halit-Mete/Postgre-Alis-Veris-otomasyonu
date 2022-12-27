namespace PostgreAlisVerisProje
{
    partial class FrmSiparis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtKurye = new System.Windows.Forms.TextBox();
            this.TxtSiparis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnUrun = new System.Windows.Forms.Button();
            this.CBMusteriNo = new System.Windows.Forms.ComboBox();
            this.CBMusTem = new System.Windows.Forms.ComboBox();
            this.CBTeslimatNo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CBUrunNo = new System.Windows.Forms.ComboBox();
            this.BtnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtKurye
            // 
            this.TxtKurye.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKurye.Location = new System.Drawing.Point(1193, 273);
            this.TxtKurye.Name = "TxtKurye";
            this.TxtKurye.Size = new System.Drawing.Size(149, 38);
            this.TxtKurye.TabIndex = 33;
            // 
            // TxtSiparis
            // 
            this.TxtSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSiparis.Location = new System.Drawing.Point(1193, 28);
            this.TxtSiparis.Name = "TxtSiparis";
            this.TxtSiparis.Size = new System.Drawing.Size(149, 38);
            this.TxtSiparis.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1037, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 32);
            this.label3.TabIndex = 28;
            this.label3.Text = "Müş. T. No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1053, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 32);
            this.label5.TabIndex = 27;
            this.label5.Text = "Kurye No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1022, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 32);
            this.label4.TabIndex = 26;
            this.label4.Text = "Teslimat No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1034, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 25;
            this.label2.Text = "Müşteri No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1034, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Sipariş No:";
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnGüncelle.Location = new System.Drawing.Point(1193, 542);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(149, 51);
            this.BtnGüncelle.TabIndex = 23;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnSil.Location = new System.Drawing.Point(1193, 483);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(149, 53);
            this.BtnSil.TabIndex = 22;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnEkle.Location = new System.Drawing.Point(1193, 429);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(149, 48);
            this.BtnEkle.TabIndex = 21;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnListele.Location = new System.Drawing.Point(1193, 374);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(149, 49);
            this.BtnListele.TabIndex = 20;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(978, 578);
            this.dataGridView1.TabIndex = 19;
            // 
            // BtnView
            // 
            this.BtnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnView.Location = new System.Drawing.Point(1028, 374);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(144, 51);
            this.BtnView.TabIndex = 34;
            this.BtnView.Text = "Görüntüle";
            this.BtnView.UseVisualStyleBackColor = true;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // BtnUrun
            // 
            this.BtnUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnUrun.Location = new System.Drawing.Point(1028, 519);
            this.BtnUrun.Name = "BtnUrun";
            this.BtnUrun.Size = new System.Drawing.Size(144, 71);
            this.BtnUrun.TabIndex = 35;
            this.BtnUrun.Text = "Ürün İnceleme";
            this.BtnUrun.UseVisualStyleBackColor = true;
            this.BtnUrun.Click += new System.EventHandler(this.BtnUrun_Click);
            // 
            // CBMusteriNo
            // 
            this.CBMusteriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBMusteriNo.FormattingEnabled = true;
            this.CBMusteriNo.Location = new System.Drawing.Point(1193, 90);
            this.CBMusteriNo.Name = "CBMusteriNo";
            this.CBMusteriNo.Size = new System.Drawing.Size(149, 33);
            this.CBMusteriNo.TabIndex = 39;
            // 
            // CBMusTem
            // 
            this.CBMusTem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBMusTem.FormattingEnabled = true;
            this.CBMusTem.Location = new System.Drawing.Point(1193, 144);
            this.CBMusTem.Name = "CBMusTem";
            this.CBMusTem.Size = new System.Drawing.Size(149, 33);
            this.CBMusTem.TabIndex = 40;
            // 
            // CBTeslimatNo
            // 
            this.CBTeslimatNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBTeslimatNo.FormattingEnabled = true;
            this.CBTeslimatNo.Location = new System.Drawing.Point(1193, 209);
            this.CBTeslimatNo.Name = "CBTeslimatNo";
            this.CBTeslimatNo.Size = new System.Drawing.Size(149, 33);
            this.CBTeslimatNo.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1061, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 32);
            this.label6.TabIndex = 42;
            this.label6.Text = "Ürün No:";
            // 
            // CBUrunNo
            // 
            this.CBUrunNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBUrunNo.FormattingEnabled = true;
            this.CBUrunNo.Location = new System.Drawing.Point(1193, 329);
            this.CBUrunNo.Name = "CBUrunNo";
            this.CBUrunNo.Size = new System.Drawing.Size(149, 33);
            this.CBUrunNo.TabIndex = 44;
            // 
            // BtnAra
            // 
            this.BtnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnAra.Location = new System.Drawing.Point(1028, 440);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(144, 67);
            this.BtnAra.TabIndex = 45;
            this.BtnAra.Text = "Numara ile Ara";
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // FrmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 612);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.CBUrunNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBTeslimatNo);
            this.Controls.Add(this.CBMusTem);
            this.Controls.Add(this.CBMusteriNo);
            this.Controls.Add(this.BtnUrun);
            this.Controls.Add(this.BtnView);
            this.Controls.Add(this.TxtKurye);
            this.Controls.Add(this.TxtSiparis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmSiparis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSiparis";
            this.Load += new System.EventHandler(this.FrmSiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtKurye;
        private System.Windows.Forms.TextBox TxtSiparis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Button BtnUrun;
        private System.Windows.Forms.ComboBox CBMusteriNo;
        private System.Windows.Forms.ComboBox CBMusTem;
        private System.Windows.Forms.ComboBox CBTeslimatNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBUrunNo;
        private System.Windows.Forms.Button BtnAra;
    }
}