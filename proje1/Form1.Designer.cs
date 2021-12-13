
namespace proje1
{
    partial class Form1
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
            this.Lbl_Kadi = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.txt_kadi = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.Grp_MüsteriGiris = new System.Windows.Forms.GroupBox();
            this.grp_Personelgiris = new System.Windows.Forms.GroupBox();
            this.lbl_personel = new System.Windows.Forms.Label();
            this.btn_Personel = new System.Windows.Forms.Button();
            this.lbl_personelsifre = new System.Windows.Forms.Label();
            this.txt_personelsifre = new System.Windows.Forms.TextBox();
            this.txt_Personelkadi = new System.Windows.Forms.TextBox();
            this.Grp_MüsteriGiris.SuspendLayout();
            this.grp_Personelgiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Kadi
            // 
            this.Lbl_Kadi.AutoSize = true;
            this.Lbl_Kadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Lbl_Kadi.Location = new System.Drawing.Point(6, 36);
            this.Lbl_Kadi.Name = "Lbl_Kadi";
            this.Lbl_Kadi.Size = new System.Drawing.Size(130, 25);
            this.Lbl_Kadi.TabIndex = 0;
            this.Lbl_Kadi.Text = "Kullanıcı Adı :";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_sifre.Location = new System.Drawing.Point(6, 93);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(128, 25);
            this.lbl_sifre.TabIndex = 0;
            this.lbl_sifre.Text = "Şifre              :";
            // 
            // txt_kadi
            // 
            this.txt_kadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_kadi.Location = new System.Drawing.Point(184, 36);
            this.txt_kadi.Name = "txt_kadi";
            this.txt_kadi.Size = new System.Drawing.Size(100, 29);
            this.txt_kadi.TabIndex = 1;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_sifre.Location = new System.Drawing.Point(184, 89);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 29);
            this.txt_sifre.TabIndex = 1;
            // 
            // btn_Giris
            // 
            this.btn_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_Giris.Location = new System.Drawing.Point(96, 181);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(188, 66);
            this.btn_Giris.TabIndex = 2;
            this.btn_Giris.Text = "Giriş";
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // Grp_MüsteriGiris
            // 
            this.Grp_MüsteriGiris.Controls.Add(this.Lbl_Kadi);
            this.Grp_MüsteriGiris.Controls.Add(this.btn_Giris);
            this.Grp_MüsteriGiris.Controls.Add(this.lbl_sifre);
            this.Grp_MüsteriGiris.Controls.Add(this.txt_sifre);
            this.Grp_MüsteriGiris.Controls.Add(this.txt_kadi);
            this.Grp_MüsteriGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Grp_MüsteriGiris.Location = new System.Drawing.Point(43, 51);
            this.Grp_MüsteriGiris.Name = "Grp_MüsteriGiris";
            this.Grp_MüsteriGiris.Size = new System.Drawing.Size(317, 270);
            this.Grp_MüsteriGiris.TabIndex = 3;
            this.Grp_MüsteriGiris.TabStop = false;
            this.Grp_MüsteriGiris.Text = "Müşteri_Girişi";
            // 
            // grp_Personelgiris
            // 
            this.grp_Personelgiris.Controls.Add(this.lbl_personel);
            this.grp_Personelgiris.Controls.Add(this.btn_Personel);
            this.grp_Personelgiris.Controls.Add(this.lbl_personelsifre);
            this.grp_Personelgiris.Controls.Add(this.txt_personelsifre);
            this.grp_Personelgiris.Controls.Add(this.txt_Personelkadi);
            this.grp_Personelgiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grp_Personelgiris.Location = new System.Drawing.Point(478, 51);
            this.grp_Personelgiris.Name = "grp_Personelgiris";
            this.grp_Personelgiris.Size = new System.Drawing.Size(317, 270);
            this.grp_Personelgiris.TabIndex = 4;
            this.grp_Personelgiris.TabStop = false;
            this.grp_Personelgiris.Text = "PersonelveYetkili_Girişi";
            // 
            // lbl_personel
            // 
            this.lbl_personel.AutoSize = true;
            this.lbl_personel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_personel.Location = new System.Drawing.Point(6, 36);
            this.lbl_personel.Name = "lbl_personel";
            this.lbl_personel.Size = new System.Drawing.Size(134, 25);
            this.lbl_personel.TabIndex = 0;
            this.lbl_personel.Text = "Personel Adı :";
            // 
            // btn_Personel
            // 
            this.btn_Personel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_Personel.Location = new System.Drawing.Point(96, 181);
            this.btn_Personel.Name = "btn_Personel";
            this.btn_Personel.Size = new System.Drawing.Size(188, 66);
            this.btn_Personel.TabIndex = 2;
            this.btn_Personel.Text = "Giriş";
            this.btn_Personel.UseVisualStyleBackColor = true;
            this.btn_Personel.Click += new System.EventHandler(this.btn_Personel_Click);
            // 
            // lbl_personelsifre
            // 
            this.lbl_personelsifre.AutoSize = true;
            this.lbl_personelsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_personelsifre.Location = new System.Drawing.Point(6, 93);
            this.lbl_personelsifre.Name = "lbl_personelsifre";
            this.lbl_personelsifre.Size = new System.Drawing.Size(128, 25);
            this.lbl_personelsifre.TabIndex = 0;
            this.lbl_personelsifre.Text = "Şifre              :";
            // 
            // txt_personelsifre
            // 
            this.txt_personelsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_personelsifre.Location = new System.Drawing.Point(184, 89);
            this.txt_personelsifre.Name = "txt_personelsifre";
            this.txt_personelsifre.Size = new System.Drawing.Size(100, 29);
            this.txt_personelsifre.TabIndex = 1;
            // 
            // txt_Personelkadi
            // 
            this.txt_Personelkadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_Personelkadi.Location = new System.Drawing.Point(184, 36);
            this.txt_Personelkadi.Name = "txt_Personelkadi";
            this.txt_Personelkadi.Size = new System.Drawing.Size(100, 29);
            this.txt_Personelkadi.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 532);
            this.Controls.Add(this.grp_Personelgiris);
            this.Controls.Add(this.Grp_MüsteriGiris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Grp_MüsteriGiris.ResumeLayout(false);
            this.Grp_MüsteriGiris.PerformLayout();
            this.grp_Personelgiris.ResumeLayout(false);
            this.grp_Personelgiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Kadi;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txt_kadi;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.GroupBox Grp_MüsteriGiris;
        private System.Windows.Forms.GroupBox grp_Personelgiris;
        private System.Windows.Forms.Label lbl_personel;
        private System.Windows.Forms.Button btn_Personel;
        private System.Windows.Forms.Label lbl_personelsifre;
        private System.Windows.Forms.TextBox txt_personelsifre;
        private System.Windows.Forms.TextBox txt_Personelkadi;
    }
}

