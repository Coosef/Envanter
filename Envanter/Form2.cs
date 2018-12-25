using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Envanter
{
    public partial class Form2 : Form
    {
        
       
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DestroyHandle();
        }
        private DialogResult cikis;
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            cikis = MessageBox.Show("Çıkış Yapmak İstediğinize Eminmisiniz?","ÇIKIŞ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (cikis==DialogResult.Yes)
            {
                DestroyHandle();
            }
            else
            {
                MessageBox.Show("Çıkış İşlemi İptal Edildi!","İPTAL",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            
        }

        private void tbnHakkimda_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

    


        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text == "" || txtSoyadi.Text == "" || txtAdet.Text == "" || txtUrun.Text == "" || dtTarih.Text == "")
            {
                MessageBox.Show("Lütfen Zorunlu Alanları Doldurunuz!", "Eksik Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                
                cmd.CommandText = "insert into kayitlar (adi,soyadi,urun,adet,tarih,kimden,aciklama) values (@adi,@soyadi,@urun,@adet,@tarih,@kimden,@aciklama)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("adi", txtAdi.Text);
                cmd.Parameters.AddWithValue("soyadi", txtSoyadi.Text);
                cmd.Parameters.AddWithValue("urun", txtUrun.Text);
                cmd.Parameters.AddWithValue("adet", Convert.ToInt32(txtAdet.Text));
                cmd.Parameters.AddWithValue("tarih", Convert.ToDateTime(dtTarih.Text));
                cmd.Parameters.AddWithValue("kimden", txtKimden.Text);
                cmd.Parameters.AddWithValue("aciklama", rtAciklama.Text);
                
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Kayıt Eklendi!", "İşlem Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kayitGetir();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Icon = SystemIcons.Exclamation;
                notifyIcon1.BalloonTipTitle = "Envanter Programı";
                notifyIcon1.BalloonTipText = "Simge Durumuna Alınmıştır Kapanmamıştır!";
                notifyIcon1.ShowBalloonTip(1000);
            }
        }
        OleDbConnection baglanti;
        OleDbCommand cmd;
        OleDbDataAdapter adp;

        public void kayitGetir()
        {
            cmd.CommandText = "select * from kayitlar";
            adp = new OleDbDataAdapter();
            adp.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgKayitlar.DataSource = dt;
         

            dgKayitlar.Columns[0].HeaderText = "Kayıt No";
            dgKayitlar.Columns[1].HeaderText = "Adı";
            dgKayitlar.Columns[2].HeaderText = "Soyadı";
            dgKayitlar.Columns[3].HeaderText = "Cihaz";
            dgKayitlar.Columns[4].HeaderText = "Adet";
            dgKayitlar.Columns[5].HeaderText = "Tarih";
            dgKayitlar.Columns[6].HeaderText = "Kimden Alındı";
            dgKayitlar.Columns[7].HeaderText = "Açıklama";

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0; Data Source=" + Application.StartupPath + "/stok.accdb");
            baglanti.Open();

            cmd = new OleDbCommand();
            cmd.Connection = baglanti;
            kayitGetir();
        }

        private void dgKayitlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKayitId.Text = dgKayitlar.CurrentRow.Cells[0].Value.ToString();
            txtAdi.Text = dgKayitlar.CurrentRow.Cells[1].Value.ToString();
            txtSoyadi.Text = dgKayitlar.CurrentRow.Cells[2].Value.ToString();
            txtUrun.Text = dgKayitlar.CurrentRow.Cells[3].Value.ToString();
            txtAdet.Text = dgKayitlar.CurrentRow.Cells[4].Value.ToString();
            dtTarih.Text = dgKayitlar.CurrentRow.Cells[5].Value.ToString();
            txtKimden.Text = dgKayitlar.CurrentRow.Cells[6].Value.ToString();
            rtAciklama.Text = dgKayitlar.CurrentRow.Cells[7].Value.ToString();
        }
        
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
           

            if (txtKayitId.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz!", "Kayıt Seç!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Kayıt Düzenlenecektir Onaylıyor Musunuz!", "İşlem Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.No)
            {
                return;
            }
            cmd.CommandText = "update kayitlar set adi=@adi, soyadi=@soyadi, urun=@urun, adet=@adet, tarih=@tarih, kimden=@kimde, aciklama=@aciklama where kayitId= " + Convert.ToInt32(txtKayitId.Text);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("adi", txtAdi.Text);
            cmd.Parameters.AddWithValue("soyadi", txtSoyadi.Text);
            cmd.Parameters.AddWithValue("urun", txtUrun.Text);
            cmd.Parameters.AddWithValue("adet", Convert.ToInt32(txtAdet.Text));
            cmd.Parameters.AddWithValue("tarih", Convert.ToDateTime(dtTarih.Text));
            cmd.Parameters.AddWithValue("kimden", txtKimden.Text);
            cmd.Parameters.AddWithValue("aciklama", rtAciklama.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Kayıt Güncellendi!", "İşlem Tamam", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            kayitGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtKayitId.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz!", "Kayıt Seç!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Kayıt Silinecektir Onaylıyor Musunuz!", "İşlem Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            cmd.CommandText = "delete from kayitlar where kayitId=" + Convert.ToInt32(txtKayitId.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Kayıt Silindi!", "İşlem Tamam", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            kayitGetir();

        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar==8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
