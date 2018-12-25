namespace Envanter
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgKayitlar = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIletisim = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSil = new MetroFramework.Controls.MetroButton();
            this.btnDuzenle = new MetroFramework.Controls.MetroButton();
            this.btnEkle = new MetroFramework.Controls.MetroButton();
            this.txtKayitId = new MetroFramework.Controls.MetroTextBox();
            this.txtAdi = new MetroFramework.Controls.MetroTextBox();
            this.txtSoyadi = new MetroFramework.Controls.MetroTextBox();
            this.txtAdet = new MetroFramework.Controls.MetroTextBox();
            this.txtUrun = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtKimden = new MetroFramework.Controls.MetroTextBox();
            this.dtTarih = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.rtAciklama = new System.Windows.Forms.RichTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgKayitlar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgKayitlar
            // 
            this.dgKayitlar.AllowUserToAddRows = false;
            this.dgKayitlar.AllowUserToDeleteRows = false;
            this.dgKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKayitlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgKayitlar.Location = new System.Drawing.Point(0, 249);
            this.dgKayitlar.Name = "dgKayitlar";
            this.dgKayitlar.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgKayitlar.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgKayitlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKayitlar.Size = new System.Drawing.Size(1000, 301);
            this.dgKayitlar.TabIndex = 0;
            this.dgKayitlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKayitlar_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.btnIletisim);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnDuzenle);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 98);
            this.panel1.TabIndex = 1;
            // 
            // btnIletisim
            // 
            this.btnIletisim.BackgroundImage = global::Envanter.Properties.Resources.LOGO;
            this.btnIletisim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIletisim.Location = new System.Drawing.Point(708, 0);
            this.btnIletisim.Name = "btnIletisim";
            this.btnIletisim.Size = new System.Drawing.Size(165, 98);
            this.btnIletisim.TabIndex = 6;
            this.btnIletisim.Text = "İletişim";
            this.btnIletisim.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIletisim.UseSelectable = true;
            this.btnIletisim.Click += new System.EventHandler(this.tbnHakkimda_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Envanter.Properties.Resources.icons8_cancel_64;
            this.pictureBox1.Location = new System.Drawing.Point(966, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(399, 26);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(94, 42);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseSelectable = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(242, 26);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(94, 42);
            this.btnDuzenle.TabIndex = 3;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseSelectable = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(86, 26);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(94, 42);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseSelectable = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtKayitId
            // 
            // 
            // 
            // 
            this.txtKayitId.CustomButton.Image = null;
            this.txtKayitId.CustomButton.Location = new System.Drawing.Point(69, 2);
            this.txtKayitId.CustomButton.Name = "";
            this.txtKayitId.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtKayitId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKayitId.CustomButton.TabIndex = 1;
            this.txtKayitId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKayitId.CustomButton.UseSelectable = true;
            this.txtKayitId.CustomButton.Visible = false;
            this.txtKayitId.Lines = new string[0];
            this.txtKayitId.Location = new System.Drawing.Point(136, 117);
            this.txtKayitId.MaxLength = 32767;
            this.txtKayitId.Name = "txtKayitId";
            this.txtKayitId.PasswordChar = '\0';
            this.txtKayitId.ReadOnly = true;
            this.txtKayitId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKayitId.SelectedText = "";
            this.txtKayitId.SelectionLength = 0;
            this.txtKayitId.SelectionStart = 0;
            this.txtKayitId.ShortcutsEnabled = true;
            this.txtKayitId.Size = new System.Drawing.Size(89, 22);
            this.txtKayitId.TabIndex = 2;
            this.txtKayitId.UseSelectable = true;
            this.txtKayitId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKayitId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAdi
            // 
            this.txtAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtAdi.CustomButton.Image = null;
            this.txtAdi.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.txtAdi.CustomButton.Name = "";
            this.txtAdi.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdi.CustomButton.TabIndex = 1;
            this.txtAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdi.CustomButton.UseSelectable = true;
            this.txtAdi.CustomButton.Visible = false;
            this.txtAdi.Lines = new string[0];
            this.txtAdi.Location = new System.Drawing.Point(136, 149);
            this.txtAdi.MaxLength = 32767;
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.PasswordChar = '\0';
            this.txtAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdi.SelectedText = "";
            this.txtAdi.SelectionLength = 0;
            this.txtAdi.SelectionStart = 0;
            this.txtAdi.ShortcutsEnabled = true;
            this.txtAdi.Size = new System.Drawing.Size(179, 22);
            this.txtAdi.TabIndex = 3;
            this.txtAdi.UseSelectable = true;
            this.txtAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtSoyadi.CustomButton.Image = null;
            this.txtSoyadi.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.txtSoyadi.CustomButton.Name = "";
            this.txtSoyadi.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtSoyadi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSoyadi.CustomButton.TabIndex = 1;
            this.txtSoyadi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSoyadi.CustomButton.UseSelectable = true;
            this.txtSoyadi.CustomButton.Visible = false;
            this.txtSoyadi.Lines = new string[0];
            this.txtSoyadi.Location = new System.Drawing.Point(136, 185);
            this.txtSoyadi.MaxLength = 32767;
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.PasswordChar = '\0';
            this.txtSoyadi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSoyadi.SelectedText = "";
            this.txtSoyadi.SelectionLength = 0;
            this.txtSoyadi.SelectionStart = 0;
            this.txtSoyadi.ShortcutsEnabled = true;
            this.txtSoyadi.Size = new System.Drawing.Size(179, 22);
            this.txtSoyadi.TabIndex = 4;
            this.txtSoyadi.UseSelectable = true;
            this.txtSoyadi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSoyadi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAdet
            // 
            // 
            // 
            // 
            this.txtAdet.CustomButton.Image = null;
            this.txtAdet.CustomButton.Location = new System.Drawing.Point(161, 2);
            this.txtAdet.CustomButton.Name = "";
            this.txtAdet.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtAdet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdet.CustomButton.TabIndex = 1;
            this.txtAdet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdet.CustomButton.UseSelectable = true;
            this.txtAdet.CustomButton.Visible = false;
            this.txtAdet.Lines = new string[0];
            this.txtAdet.Location = new System.Drawing.Point(485, 117);
            this.txtAdet.MaxLength = 32767;
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.PasswordChar = '\0';
            this.txtAdet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdet.SelectedText = "";
            this.txtAdet.SelectionLength = 0;
            this.txtAdet.SelectionStart = 0;
            this.txtAdet.ShortcutsEnabled = true;
            this.txtAdet.Size = new System.Drawing.Size(181, 22);
            this.txtAdet.TabIndex = 5;
            this.txtAdet.UseSelectable = true;
            this.txtAdet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdet_KeyPress);
            // 
            // txtUrun
            // 
            // 
            // 
            // 
            this.txtUrun.CustomButton.Image = null;
            this.txtUrun.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.txtUrun.CustomButton.Name = "";
            this.txtUrun.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtUrun.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUrun.CustomButton.TabIndex = 1;
            this.txtUrun.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUrun.CustomButton.UseSelectable = true;
            this.txtUrun.CustomButton.Visible = false;
            this.txtUrun.Lines = new string[0];
            this.txtUrun.Location = new System.Drawing.Point(137, 219);
            this.txtUrun.MaxLength = 32767;
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.PasswordChar = '\0';
            this.txtUrun.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUrun.SelectedText = "";
            this.txtUrun.SelectionLength = 0;
            this.txtUrun.SelectionStart = 0;
            this.txtUrun.ShortcutsEnabled = true;
            this.txtUrun.Size = new System.Drawing.Size(179, 22);
            this.txtUrun.TabIndex = 6;
            this.txtUrun.UseSelectable = true;
            this.txtUrun.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUrun.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 119);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Kayıt ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 151);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Ekleyen Adı";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(12, 185);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Ekleyen Soyadı";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(12, 222);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(111, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Kayıt Edilen Cihaz";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(347, 117);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(73, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Cihaz Adet";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(347, 152);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(90, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Kimden Alındı";
            // 
            // txtKimden
            // 
            this.txtKimden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtKimden.CustomButton.Image = null;
            this.txtKimden.CustomButton.Location = new System.Drawing.Point(161, 2);
            this.txtKimden.CustomButton.Name = "";
            this.txtKimden.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtKimden.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKimden.CustomButton.TabIndex = 1;
            this.txtKimden.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKimden.CustomButton.UseSelectable = true;
            this.txtKimden.CustomButton.Visible = false;
            this.txtKimden.Lines = new string[0];
            this.txtKimden.Location = new System.Drawing.Point(485, 151);
            this.txtKimden.MaxLength = 32767;
            this.txtKimden.Name = "txtKimden";
            this.txtKimden.PasswordChar = '\0';
            this.txtKimden.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKimden.SelectedText = "";
            this.txtKimden.SelectionLength = 0;
            this.txtKimden.SelectionStart = 0;
            this.txtKimden.ShortcutsEnabled = true;
            this.txtKimden.Size = new System.Drawing.Size(181, 22);
            this.txtKimden.TabIndex = 12;
            this.txtKimden.UseSelectable = true;
            this.txtKimden.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKimden.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(485, 185);
            this.dtTarih.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(181, 29);
            this.dtTarih.TabIndex = 14;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(347, 188);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(114, 19);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Alınış - Kayıt Tarihi";
            // 
            // rtAciklama
            // 
            this.rtAciklama.Location = new System.Drawing.Point(722, 124);
            this.rtAciklama.MaxLength = 200;
            this.rtAciklama.Multiline = false;
            this.rtAciklama.Name = "rtAciklama";
            this.rtAciklama.Size = new System.Drawing.Size(266, 119);
            this.rtAciklama.TabIndex = 16;
            this.rtAciklama.Text = "";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.Location = new System.Drawing.Point(826, 101);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(62, 19);
            this.metroLabel8.TabIndex = 17;
            this.metroLabel8.Text = "Açıklama";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.rtAciklama);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtKimden);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtUrun);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.txtKayitId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgKayitlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgKayitlar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgKayitlar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnSil;
        private MetroFramework.Controls.MetroButton btnDuzenle;
        private MetroFramework.Controls.MetroButton btnEkle;
        private MetroFramework.Controls.MetroTextBox txtKayitId;
        private MetroFramework.Controls.MetroTextBox txtAdi;
        private MetroFramework.Controls.MetroTextBox txtSoyadi;
        private MetroFramework.Controls.MetroTextBox txtAdet;
        private MetroFramework.Controls.MetroTextBox txtUrun;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtKimden;
        private MetroFramework.Controls.MetroDateTime dtTarih;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.RichTextBox rtAciklama;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton btnIletisim;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}