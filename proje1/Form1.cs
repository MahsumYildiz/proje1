using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbEntity2Entities1 db = new DbEntity2Entities1();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
           
           
           
        }

        private void btn_Personel_Click(object sender, EventArgs e)
        {
            if (txt_Personelkadi.Text == "Admin" && txt_personelsifre.Text == "12345")
            {
                MessageBox.Show("Giriş Başarılı");
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("GiriŞ Başarısız");
            }
          
        }
    }
}
