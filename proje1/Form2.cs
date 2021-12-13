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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string dosyaadresi = @"C:\Users\90534\Desktop\Deneme.txt";
            string okunanmetin = "";
            if (File.Exists(dosyaadresi))
            {
                okunanmetin = File.ReadAllText(dosyaadresi);
                Kullanıcı_Bılgı.Text = okunanmetin;
            }
            else
            {
                MessageBox.Show(dosyaadresi + " Dosyası bulunamadı");
            }
        }
    }
}
