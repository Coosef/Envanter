namespace Envanter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtKadi = new MetroFramework.Controls.MetroTextBox();
            this.txtKsifre = new MetroFramework.Controls.MetroTextBox();
            this.btnGiris = new MetroFramework.Controls.MetroButton();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtKadi
            // 
            // 
            // 
            // 
            this.txtKadi.CustomButton.Image = null;
            this.txtKadi.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.txtKadi.CustomButton.Name = "";
            this.txtKadi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKadi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKadi.CustomButton.TabIndex = 1;
            this.txtKadi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKadi.CustomButton.UseSelectable = true;
            this.txtKadi.CustomButton.Visible = false;
            this.txtKadi.Lines = new string[0];
            this.txtKadi.Location = new System.Drawing.Point(175, 227);
            this.txtKadi.MaxLength = 32767;
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.PasswordChar = '\0';
            this.txtKadi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKadi.SelectedText = "";
            this.txtKadi.SelectionLength = 0;
            this.txtKadi.SelectionStart = 0;
            this.txtKadi.ShortcutsEnabled = true;
            this.txtKadi.Size = new System.Drawing.Size(115, 23);
            this.txtKadi.TabIndex = 1;
            this.txtKadi.UseSelectable = true;
            this.txtKadi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKadi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtKsifre
            // 
            // 
            // 
            // 
            this.txtKsifre.CustomButton.Image = null;
            this.txtKsifre.CustomButton.Location = new System.Drawing.Point(93, 1);
            this.txtKsifre.CustomButton.Name = "";
            this.txtKsifre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKsifre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKsifre.CustomButton.TabIndex = 1;
            this.txtKsifre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKsifre.CustomButton.UseSelectable = true;
            this.txtKsifre.CustomButton.Visible = false;
            this.txtKsifre.Lines = new string[0];
            this.txtKsifre.Location = new System.Drawing.Point(175, 268);
            this.txtKsifre.MaxLength = 32767;
            this.txtKsifre.Name = "txtKsifre";
            this.txtKsifre.PasswordChar = '*';
            this.txtKsifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKsifre.SelectedText = "";
            this.txtKsifre.SelectionLength = 0;
            this.txtKsifre.SelectionStart = 0;
            this.txtKsifre.ShortcutsEnabled = true;
            this.txtKsifre.Size = new System.Drawing.Size(115, 23);
            this.txtKsifre.TabIndex = 2;
            this.txtKsifre.UseSelectable = true;
            this.txtKsifre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKsifre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(126, 330);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(135, 55);
            this.btnGiris.TabIndex = 5;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseSelectable = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(0, 5);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(399, 477);
            this.metroProgressSpinner1.Speed = 0.5F;
            this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroProgressSpinner1.TabIndex = 6;
            this.metroProgressSpinner1.UseSelectable = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(364, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kullanıcı Şifre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 481);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtKsifre);
            this.Controls.Add(this.txtKadi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroProgressSpinner1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox txtKadi;
        private MetroFramework.Controls.MetroTextBox txtKsifre;
        private MetroFramework.Controls.MetroButton btnGiris;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

