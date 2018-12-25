using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Envanter
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKadi.Text=="" || txtKsifre.Text=="")
            {
                MessageBox.Show("Bütün Alanları Doldurunuz!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }else 
            
            if (txtKadi.Text == "SİBER" || txtKsifre.Text =="KURT")
            {
               
               
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
             
            }
            else 
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DestroyHandle();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://siberkurt.com/");
        }
    }
}
