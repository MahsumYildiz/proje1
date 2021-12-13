
namespace proje1
{
    partial class Form3
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
            this.lbl_urun = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_urun = new System.Windows.Forms.ComboBox();
            this.btn_tkp = new System.Windows.Forms.Button();
            this.btn_gnc = new System.Windows.Forms.Button();
            this.btn_cıkar = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.lbl_adet = new System.Windows.Forms.Label();
            this.Personel_Bılgı = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_urun
            // 
            this.lbl_urun.AutoSize = true;
            this.lbl_urun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_urun.Location = new System.Drawing.Point(36, 30);
            this.lbl_urun.Name = "lbl_urun";
            this.lbl_urun.Size = new System.Drawing.Size(71, 20);
            this.lbl_urun.TabIndex = 2;
            this.lbl_urun.Text = "Ürün Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_urun);
            this.groupBox1.Controls.Add(this.btn_tkp);
            this.groupBox1.Controls.Add(this.btn_gnc);
            this.groupBox1.Controls.Add(this.btn_cıkar);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.txt_adet);
            this.groupBox1.Controls.Add(this.lbl_adet);
            this.groupBox1.Controls.Add(this.lbl_urun);
            this.groupBox1.Location = new System.Drawing.Point(30, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 205);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cmb_urun
            // 
            this.cmb_urun.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_urun.FormattingEnabled = true;
            this.cmb_urun.Items.AddRange(new object[] {
            "Eşorfman",
            "T-shirt",
            "Pantalon"});
            this.cmb_urun.Location = new System.Drawing.Point(16, 67);
            this.cmb_urun.Name = "cmb_urun";
            this.cmb_urun.Size = new System.Drawing.Size(114, 21);
            this.cmb_urun.TabIndex = 5;
            this.cmb_urun.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_tkp
            // 
            this.btn_tkp.Location = new System.Drawing.Point(259, 127);
            this.btn_tkp.Name = "btn_tkp";
            this.btn_tkp.Size = new System.Drawing.Size(75, 47);
            this.btn_tkp.TabIndex = 4;
            this.btn_tkp.Text = "Müşteri Takip";
            this.btn_tkp.UseVisualStyleBackColor = true;
            // 
            // btn_gnc
            // 
            this.btn_gnc.Location = new System.Drawing.Point(178, 127);
            this.btn_gnc.Name = "btn_gnc";
            this.btn_gnc.Size = new System.Drawing.Size(75, 47);
            this.btn_gnc.TabIndex = 4;
            this.btn_gnc.Text = "Güncelle";
            this.btn_gnc.UseVisualStyleBackColor = true;
            this.btn_gnc.Click += new System.EventHandler(this.btn_gnc_Click);
            // 
            // btn_cıkar
            // 
            this.btn_cıkar.Location = new System.Drawing.Point(97, 127);
            this.btn_cıkar.Name = "btn_cıkar";
            this.btn_cıkar.Size = new System.Drawing.Size(75, 47);
            this.btn_cıkar.TabIndex = 4;
            this.btn_cıkar.Text = "Ürün Çıkar";
            this.btn_cıkar.UseVisualStyleBackColor = true;
            this.btn_cıkar.Click += new System.EventHandler(this.btn_cıkar_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(16, 127);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 47);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "Ürün Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(182, 68);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(101, 20);
            this.txt_adet.TabIndex = 3;
            this.txt_adet.TextChanged += new System.EventHandler(this.txt_adet_TextChanged);
            // 
            // lbl_adet
            // 
            this.lbl_adet.AutoSize = true;
            this.lbl_adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_adet.Location = new System.Drawing.Point(197, 30);
            this.lbl_adet.Name = "lbl_adet";
            this.lbl_adet.Size = new System.Drawing.Size(43, 20);
            this.lbl_adet.TabIndex = 2;
            this.lbl_adet.Text = "Adet";
            // 
            // Personel_Bılgı
            // 
            this.Personel_Bılgı.Location = new System.Drawing.Point(446, 52);
            this.Personel_Bılgı.Multiline = true;
            this.Personel_Bılgı.Name = "Personel_Bılgı";
            this.Personel_Bılgı.Size = new System.Drawing.Size(342, 302);
            this.Personel_Bılgı.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Personel_Bılgı);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_urun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_tkp;
        private System.Windows.Forms.Button btn_gnc;
        private System.Windows.Forms.Button btn_cıkar;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_adet;
        private System.Windows.Forms.Label lbl_adet;
        private System.Windows.Forms.ComboBox cmb_urun;
        private System.Windows.Forms.TextBox Personel_Bılgı;
    }
}