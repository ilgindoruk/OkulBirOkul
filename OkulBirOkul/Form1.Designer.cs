namespace OkulBirOkul
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
            gBSınıflar = new GroupBox();
            listBox1 = new ListBox();
            txtekleme = new TextBox();
            bttnEkle = new Button();
            bttnGuncelle = new Button();
            bttncıkar = new Button();
            bttnGetir = new Button();
            gBSınıflar.SuspendLayout();
            SuspendLayout();
            // 
            // gBSınıflar
            // 
            gBSınıflar.BackColor = Color.Lime;
            gBSınıflar.Controls.Add(listBox1);
            gBSınıflar.Location = new Point(12, 23);
            gBSınıflar.Name = "gBSınıflar";
            gBSınıflar.Size = new Size(200, 253);
            gBSınıflar.TabIndex = 0;
            gBSınıflar.TabStop = false;
            gBSınıflar.Text = "Sınıflar";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Cyan;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(17, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(167, 214);
            listBox1.TabIndex = 0;
            // 
            // txtekleme
            // 
            txtekleme.Location = new Point(12, 282);
            txtekleme.Name = "txtekleme";
            txtekleme.Size = new Size(200, 23);
            txtekleme.TabIndex = 1;
            // 
            // bttnEkle
            // 
            bttnEkle.BackColor = Color.Lime;
            bttnEkle.ForeColor = SystemColors.ActiveCaptionText;
            bttnEkle.Location = new Point(5, 312);
            bttnEkle.Name = "bttnEkle";
            bttnEkle.Size = new Size(65, 52);
            bttnEkle.TabIndex = 2;
            bttnEkle.Text = "Ekle";
            bttnEkle.UseVisualStyleBackColor = false;
            bttnEkle.Click += bttnEkle_Click;
            // 
            // bttnGuncelle
            // 
            bttnGuncelle.BackColor = Color.Fuchsia;
            bttnGuncelle.ForeColor = SystemColors.ActiveCaptionText;
            bttnGuncelle.Location = new Point(76, 312);
            bttnGuncelle.Name = "bttnGuncelle";
            bttnGuncelle.Size = new Size(65, 52);
            bttnGuncelle.TabIndex = 3;
            bttnGuncelle.Text = "Güncelle";
            bttnGuncelle.UseVisualStyleBackColor = false;
            bttnGuncelle.Click += bttnGuncelle_Click;
            // 
            // bttncıkar
            // 
            bttncıkar.BackColor = Color.Yellow;
            bttncıkar.ForeColor = SystemColors.ActiveCaptionText;
            bttncıkar.Location = new Point(147, 312);
            bttncıkar.Name = "bttncıkar";
            bttncıkar.Size = new Size(65, 52);
            bttncıkar.TabIndex = 4;
            bttncıkar.Text = "Sil/Çıkar";
            bttncıkar.UseVisualStyleBackColor = false;
            bttncıkar.Click += bttncıkar_Click;
            // 
            // bttnGetir
            // 
            bttnGetir.BackColor = Color.Cyan;
            bttnGetir.ForeColor = SystemColors.ActiveCaptionText;
            bttnGetir.Location = new Point(5, 370);
            bttnGetir.Name = "bttnGetir";
            bttnGetir.Size = new Size(65, 48);
            bttnGetir.TabIndex = 5;
            bttnGetir.Text = "Getir";
            bttnGetir.UseVisualStyleBackColor = false;
            bttnGetir.Click += bttnGetir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(231, 419);
            Controls.Add(bttnGetir);
            Controls.Add(bttncıkar);
            Controls.Add(bttnGuncelle);
            Controls.Add(bttnEkle);
            Controls.Add(txtekleme);
            Controls.Add(gBSınıflar);
            Name = "Form1";
            Text = "Form1";
            gBSınıflar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gBSınıflar;
        private ListBox listBox1;
        private TextBox txtekleme;
        private Button bttnEkle;
        private Button bttnGuncelle;
        private Button bttncıkar;
        private Button bttnGetir;
    }
}
