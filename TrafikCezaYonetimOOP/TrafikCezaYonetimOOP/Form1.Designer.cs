namespace TrafikCezaYonetimOOP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtPlaka = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            label4 = new Label();
            txtTc = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtCezaTuru = new TextBox();
            txtTutar = new TextBox();
            txtAciklama = new TextBox();
            dtpTarih = new DateTimePicker();
            btnEkle = new Button();
            btnAra = new Button();
            txtAraPlaka = new TextBox();
            lstSuruculer = new ListBox();
            btnSil = new Button();
            txtSilTc = new TextBox();
            label9 = new Label();
            label10 = new Label();
            dtpSilTarih = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 58);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "Plaka:";
            label1.Click += label1_Click;
            // 
            // txtPlaka
            // 
            txtPlaka.Location = new Point(111, 58);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(204, 27);
            txtPlaka.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 101);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 2;
            label2.Text = "Ad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 141);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 3;
            label3.Text = "Soyad:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(111, 101);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(204, 27);
            txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(111, 141);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(204, 27);
            txtSoyad.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 180);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 6;
            label4.Text = "TC No:";
            // 
            // txtTc
            // 
            txtTc.Location = new Point(109, 180);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(204, 27);
            txtTc.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 222);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 8;
            label5.Text = "Ceza Türü:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 263);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 9;
            label6.Text = "Tutar:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 294);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 10;
            label7.Text = "Açıklama:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 332);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 11;
            label8.Text = "Tarih:";
            // 
            // txtCezaTuru
            // 
            txtCezaTuru.Location = new Point(113, 222);
            txtCezaTuru.Name = "txtCezaTuru";
            txtCezaTuru.Size = new Size(202, 27);
            txtCezaTuru.TabIndex = 12;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(111, 263);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(204, 27);
            txtTutar.TabIndex = 13;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(109, 296);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(202, 27);
            txtAciklama.TabIndex = 14;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(107, 332);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(204, 27);
            dtpTarih.TabIndex = 15;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(148, 395);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 16;
            btnEkle.Text = "Ceza Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click_1;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(589, 320);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(125, 29);
            btnAra.TabIndex = 17;
            btnAra.Text = "Plaka ile Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click_1;
            // 
            // txtAraPlaka
            // 
            txtAraPlaka.Location = new Point(589, 276);
            txtAraPlaka.Name = "txtAraPlaka";
            txtAraPlaka.Size = new Size(125, 27);
            txtAraPlaka.TabIndex = 18;
            // 
            // lstSuruculer
            // 
            lstSuruculer.FormattingEnabled = true;
            lstSuruculer.Location = new Point(437, 372);
            lstSuruculer.Name = "lstSuruculer";
            lstSuruculer.Size = new Size(543, 204);
            lstSuruculer.TabIndex = 19;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(589, 180);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 20;
            btnSil.Text = "Ceza Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtSilTc
            // 
            txtSilTc.Location = new Point(589, 91);
            txtSilTc.Name = "txtSilTc";
            txtSilTc.Size = new Size(125, 27);
            txtSilTc.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(544, 98);
            label9.Name = "label9";
            label9.Size = new Size(26, 20);
            label9.TabIndex = 22;
            label9.Text = "Tc:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(540, 138);
            label10.Name = "label10";
            label10.Size = new Size(43, 20);
            label10.TabIndex = 23;
            label10.Text = "Tarih:";
            // 
            // dtpSilTarih
            // 
            dtpSilTarih.Location = new Point(589, 138);
            dtpSilTarih.Name = "dtpSilTarih";
            dtpSilTarih.Size = new Size(250, 27);
            dtpSilTarih.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 604);
            Controls.Add(dtpSilTarih);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtSilTc);
            Controls.Add(btnSil);
            Controls.Add(lstSuruculer);
            Controls.Add(txtAraPlaka);
            Controls.Add(btnAra);
            Controls.Add(btnEkle);
            Controls.Add(dtpTarih);
            Controls.Add(txtAciklama);
            Controls.Add(txtTutar);
            Controls.Add(txtCezaTuru);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtTc);
            Controls.Add(label4);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPlaka);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPlaka;
        private Label label2;
        private Label label3;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label label4;
        private TextBox txtTc;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtCezaTuru;
        private TextBox txtTutar;
        private TextBox txtAciklama;
        private DateTimePicker dtpTarih;
        private Button btnEkle;
        private Button btnAra;
        private TextBox txtAraPlaka;
        private ListBox lstSuruculer;
        private Button btnSil;
        private TextBox txtSilTc;
        private Label label9;
        private Label label10;
        private DateTimePicker dtpSilTarih;
    }
}
