using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proje1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void Urunulisteleme()
        {
            StreamReader sr = new StreamReader("C:\\Users\\90534\\Desktop\\Deneme2.txt");
            Personel_Bılgı.Text=sr.ReadToEnd(); 
            sr.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

            Urunulisteleme();
        }

        private void Personel_Bılgı_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SirketSahibi sirketSahibi = new SirketSahibi();
            sirketSahibi.Urunadi = cmb_urun.Text;
            sirketSahibi.UrunSayisi = Convert.ToInt32( txt_adet.Text);
            sirketSahibi.Urunekle();
            MessageBox.Show("Ürün ekleme başarılı günceleleyip görebilirsiniz");


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void txt_adet_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_gnc_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\Users\\90534\\Desktop\\Deneme2.txt");
            SirketSahibi sirketSahibi = new SirketSahibi();
            



            sr.Close();


            Urunulisteleme();


        }

        private void btn_cıkar_Click(object sender, EventArgs e)
        {
            SirketSahibi sirketSahibi = new SirketSahibi();
            sirketSahibi.Urunadi = cmb_urun.Text;
            sirketSahibi.UrunSayisi = Convert.ToInt32(txt_adet.Text);
            sirketSahibi.UrunCikar();
        }
    }
}
