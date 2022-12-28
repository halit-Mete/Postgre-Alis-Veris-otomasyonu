namespace PostgreAlisVerisProje
{
    partial class FrmKurye
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtKurye = new System.Windows.Forms.TextBox();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtArac = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnKargo = new System.Windows.Forms.Button();
            this.CBKargaFNo = new System.Windows.Forms.ComboBox();
            this.BtnKuryeKargo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtKurye
            // 
            this.TxtKurye.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKurye.Location = new System.Drawing.Point(858, 23);
            this.TxtKurye.Margin = new System.Windows.Forms.Padding(2);
            this.TxtKurye.Name = "TxtKurye";
            this.TxtKurye.Size = new System.Drawing.Size(161, 38);
            this.TxtKurye.TabIndex = 39;
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnGüncelle.Location = new System.Drawing.Point(872, 355);
            this.BtnGüncelle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(166, 49);
            this.BtnGüncelle.TabIndex = 36;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnSil.Location = new System.Drawing.Point(872, 302);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(165, 49);
            this.BtnSil.TabIndex = 35;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnEkle.Location = new System.Drawing.Point(873, 253);
            this.BtnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(164, 45);
            this.BtnEkle.TabIndex = 34;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnListele.Location = new System.Drawing.Point(875, 200);
            this.BtnListele.Margin = new System.Windows.Forms.Padding(2);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(163, 49);
            this.BtnListele.TabIndex = 33;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(10, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(669, 395);
            this.dataGridView1.TabIndex = 32;
            // 
            // TxtArac
            // 
            this.TxtArac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtArac.Location = new System.Drawing.Point(857, 109);
            this.TxtArac.Margin = new System.Windows.Forms.Padding(2);
            this.TxtArac.Name = "TxtArac";
            this.TxtArac.Size = new System.Drawing.Size(161, 38);
            this.TxtArac.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.label3.Location = new System.Drawing.Point(776, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 32);
            this.label3.TabIndex = 41;
            this.label3.Text = "Araç:";
            // 
            // BtnView
            // 
            this.BtnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnView.Location = new System.Drawing.Point(719, 259);
            this.BtnView.Margin = new System.Windows.Forms.Padding(2);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(149, 71);
            this.BtnView.TabIndex = 43;
            this.BtnView.Text = "Atanmış Kuryeler";
            this.BtnView.UseVisualStyleBackColor = true;
            this.BtnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.label1.Location = new System.Drawing.Point(731, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 37;
            this.label1.Text = "Kurye No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.label2.Location = new System.Drawing.Point(697, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 32);
            this.label2.TabIndex = 38;
            this.label2.Text = "Kargo F. No:";
            // 
            // BtnKargo
            // 
            this.BtnKargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnKargo.Location = new System.Drawing.Point(719, 335);
            this.BtnKargo.Name = "BtnKargo";
            this.BtnKargo.Size = new System.Drawing.Size(149, 69);
            this.BtnKargo.TabIndex = 44;
            this.BtnKargo.Text = "Kargo Firmaları";
            this.BtnKargo.UseVisualStyleBackColor = true;
            this.BtnKargo.Click += new System.EventHandler(this.BtnKargo_Click);
            // 
            // CBKargaFNo
            // 
            this.CBKargaFNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBKargaFNo.FormattingEnabled = true;
            this.CBKargaFNo.Location = new System.Drawing.Point(857, 66);
            this.CBKargaFNo.Name = "CBKargaFNo";
            this.CBKargaFNo.Size = new System.Drawing.Size(162, 33);
            this.CBKargaFNo.TabIndex = 45;
            // 
            // BtnKuryeKargo
            // 
            this.BtnKuryeKargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnKuryeKargo.Location = new System.Drawing.Point(719, 200);
            this.BtnKuryeKargo.Name = "BtnKuryeKargo";
            this.BtnKuryeKargo.Size = new System.Drawing.Size(149, 51);
            this.BtnKuryeKargo.TabIndex = 46;
            this.BtnKuryeKargo.Text = "Görüntüle";
            this.BtnKuryeKargo.UseVisualStyleBackColor = true;
            this.BtnKuryeKargo.Click += new System.EventHandler(this.BtnKuryeKargo_Click);
            // 
            // FrmKurye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 419);
            this.Controls.Add(this.BtnKuryeKargo);
            this.Controls.Add(this.CBKargaFNo);
            this.Controls.Add(this.BtnKargo);
            this.Controls.Add(this.BtnView);
            this.Controls.Add(this.TxtArac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtKurye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmKurye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKurye";
            this.Load += new System.EventHandler(this.FrmKurye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtKurye;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtArac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnKargo;
        private System.Windows.Forms.ComboBox CBKargaFNo;
        private System.Windows.Forms.Button BtnKuryeKargo;
    }
}