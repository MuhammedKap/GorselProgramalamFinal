namespace GYM_ÜYE_KAYIT_SİSTEMİ
{
    partial class AdminSayfasi
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
            this.pnl_adminust = new System.Windows.Forms.Panel();
            this.lbl_admincikis = new System.Windows.Forms.Label();
            this.lbl_adminustisim = new System.Windows.Forms.Label();
            this.pnl_adminsol = new System.Windows.Forms.Panel();
            this.lbl_duzcizgi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cikisyap = new System.Windows.Forms.Button();
            this.btn_anaekranodemeler = new System.Windows.Forms.Button();
            this.btn_anaekranuyeler = new System.Windows.Forms.Button();
            this.btn_anaekransporkoclari = new System.Windows.Forms.Button();
            this.btn_anaekrangostergepaneli = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.odemeler1 = new GYM_ÜYE_KAYIT_SİSTEMİ.Odemeler();
            this.adminSporKoclari1 = new GYM_ÜYE_KAYIT_SİSTEMİ.AdminSporKoclari();
            this.adminUyeIslemleri1 = new GYM_ÜYE_KAYIT_SİSTEMİ.AdminUyeIslemleri();
            this.adminDashboard1 = new GYM_ÜYE_KAYIT_SİSTEMİ.AdminDashboard();
            this.pnl_adminust.SuspendLayout();
            this.pnl_adminsol.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_adminust
            // 
            this.pnl_adminust.BackColor = System.Drawing.Color.White;
            this.pnl_adminust.Controls.Add(this.lbl_admincikis);
            this.pnl_adminust.Controls.Add(this.lbl_adminustisim);
            this.pnl_adminust.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_adminust.Location = new System.Drawing.Point(0, 0);
            this.pnl_adminust.Name = "pnl_adminust";
            this.pnl_adminust.Size = new System.Drawing.Size(1273, 39);
            this.pnl_adminust.TabIndex = 0;
            // 
            // lbl_admincikis
            // 
            this.lbl_admincikis.AutoSize = true;
            this.lbl_admincikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_admincikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_admincikis.Location = new System.Drawing.Point(1237, 9);
            this.lbl_admincikis.Name = "lbl_admincikis";
            this.lbl_admincikis.Size = new System.Drawing.Size(24, 24);
            this.lbl_admincikis.TabIndex = 1;
            this.lbl_admincikis.Text = "X";
            this.lbl_admincikis.Click += new System.EventHandler(this.lbl_admincikis_Click);
            // 
            // lbl_adminustisim
            // 
            this.lbl_adminustisim.AutoSize = true;
            this.lbl_adminustisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adminustisim.Location = new System.Drawing.Point(12, 9);
            this.lbl_adminustisim.Name = "lbl_adminustisim";
            this.lbl_adminustisim.Size = new System.Drawing.Size(240, 22);
            this.lbl_adminustisim.TabIndex = 0;
            this.lbl_adminustisim.Text = "Spor Salonu Üyelik Programı";
            // 
            // pnl_adminsol
            // 
            this.pnl_adminsol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.pnl_adminsol.Controls.Add(this.lbl_duzcizgi);
            this.pnl_adminsol.Controls.Add(this.btn_cikisyap);
            this.pnl_adminsol.Controls.Add(this.btn_anaekranodemeler);
            this.pnl_adminsol.Controls.Add(this.btn_anaekranuyeler);
            this.pnl_adminsol.Controls.Add(this.btn_anaekransporkoclari);
            this.pnl_adminsol.Controls.Add(this.btn_anaekrangostergepaneli);
            this.pnl_adminsol.Controls.Add(this.label1);
            this.pnl_adminsol.Controls.Add(this.pictureBox1);
            this.pnl_adminsol.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_adminsol.Location = new System.Drawing.Point(0, 39);
            this.pnl_adminsol.Name = "pnl_adminsol";
            this.pnl_adminsol.Size = new System.Drawing.Size(266, 756);
            this.pnl_adminsol.TabIndex = 1;
            // 
            // lbl_duzcizgi
            // 
            this.lbl_duzcizgi.AutoSize = true;
            this.lbl_duzcizgi.ForeColor = System.Drawing.Color.White;
            this.lbl_duzcizgi.Location = new System.Drawing.Point(-3, 178);
            this.lbl_duzcizgi.Name = "lbl_duzcizgi";
            this.lbl_duzcizgi.Size = new System.Drawing.Size(271, 16);
            this.lbl_duzcizgi.TabIndex = 3;
            this.lbl_duzcizgi.Text = "------------------------------------------------------------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hoş Geldiniz...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.odemeler1);
            this.panel1.Controls.Add(this.adminSporKoclari1);
            this.panel1.Controls.Add(this.adminUyeIslemleri1);
            this.panel1.Controls.Add(this.adminDashboard1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(266, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 756);
            this.panel1.TabIndex = 2;
            // 
            // btn_cikisyap
            // 
            this.btn_cikisyap.BackColor = System.Drawing.Color.Firebrick;
            this.btn_cikisyap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikisyap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikisyap.ForeColor = System.Drawing.Color.White;
            this.btn_cikisyap.Image = global::GYM_ÜYE_KAYIT_SİSTEMİ.Properties.Resources.Logouut;
            this.btn_cikisyap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cikisyap.Location = new System.Drawing.Point(16, 698);
            this.btn_cikisyap.Name = "btn_cikisyap";
            this.btn_cikisyap.Size = new System.Drawing.Size(230, 37);
            this.btn_cikisyap.TabIndex = 4;
            this.btn_cikisyap.Text = "Çıkış Yap";
            this.btn_cikisyap.UseVisualStyleBackColor = false;
            this.btn_cikisyap.Click += new System.EventHandler(this.btn_cikisyap_Click);
            // 
            // btn_anaekranodemeler
            // 
            this.btn_anaekranodemeler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_anaekranodemeler.FlatAppearance.BorderSize = 0;
            this.btn_anaekranodemeler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anaekranodemeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_anaekranodemeler.ForeColor = System.Drawing.Color.White;
            this.btn_anaekranodemeler.Image = global::GYM_ÜYE_KAYIT_SİSTEMİ.Properties.Resources.Card_Payment;
            this.btn_anaekranodemeler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_anaekranodemeler.Location = new System.Drawing.Point(16, 398);
            this.btn_anaekranodemeler.Name = "btn_anaekranodemeler";
            this.btn_anaekranodemeler.Size = new System.Drawing.Size(230, 37);
            this.btn_anaekranodemeler.TabIndex = 3;
            this.btn_anaekranodemeler.Text = "Ödemeler";
            this.btn_anaekranodemeler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_anaekranodemeler.UseVisualStyleBackColor = false;
            this.btn_anaekranodemeler.Click += new System.EventHandler(this.btn_anaekranodemeler_Click);
            // 
            // btn_anaekranuyeler
            // 
            this.btn_anaekranuyeler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_anaekranuyeler.FlatAppearance.BorderSize = 0;
            this.btn_anaekranuyeler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anaekranuyeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_anaekranuyeler.ForeColor = System.Drawing.Color.White;
            this.btn_anaekranuyeler.Image = global::GYM_ÜYE_KAYIT_SİSTEMİ.Properties.Resources.Add_Male_User_Group;
            this.btn_anaekranuyeler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_anaekranuyeler.Location = new System.Drawing.Point(16, 335);
            this.btn_anaekranuyeler.Name = "btn_anaekranuyeler";
            this.btn_anaekranuyeler.Size = new System.Drawing.Size(230, 37);
            this.btn_anaekranuyeler.TabIndex = 2;
            this.btn_anaekranuyeler.Text = "Üye İşlemleri";
            this.btn_anaekranuyeler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_anaekranuyeler.UseVisualStyleBackColor = false;
            this.btn_anaekranuyeler.Click += new System.EventHandler(this.btn_anaekranuyeler_Click);
            // 
            // btn_anaekransporkoclari
            // 
            this.btn_anaekransporkoclari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_anaekransporkoclari.FlatAppearance.BorderSize = 0;
            this.btn_anaekransporkoclari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anaekransporkoclari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_anaekransporkoclari.ForeColor = System.Drawing.Color.White;
            this.btn_anaekransporkoclari.Image = global::GYM_ÜYE_KAYIT_SİSTEMİ.Properties.Resources.Personal_Trainerr;
            this.btn_anaekransporkoclari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_anaekransporkoclari.Location = new System.Drawing.Point(16, 277);
            this.btn_anaekransporkoclari.Name = "btn_anaekransporkoclari";
            this.btn_anaekransporkoclari.Size = new System.Drawing.Size(230, 37);
            this.btn_anaekransporkoclari.TabIndex = 1;
            this.btn_anaekransporkoclari.Text = "Spor Koçları";
            this.btn_anaekransporkoclari.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_anaekransporkoclari.UseVisualStyleBackColor = false;
            this.btn_anaekransporkoclari.Click += new System.EventHandler(this.btn_anaekransporkoclari_Click);
            // 
            // btn_anaekrangostergepaneli
            // 
            this.btn_anaekrangostergepaneli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.btn_anaekrangostergepaneli.FlatAppearance.BorderSize = 0;
            this.btn_anaekrangostergepaneli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anaekrangostergepaneli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_anaekrangostergepaneli.ForeColor = System.Drawing.Color.White;
            this.btn_anaekrangostergepaneli.Image = global::GYM_ÜYE_KAYIT_SİSTEMİ.Properties.Resources.Dashboard_Gaugge1;
            this.btn_anaekrangostergepaneli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_anaekrangostergepaneli.Location = new System.Drawing.Point(16, 216);
            this.btn_anaekrangostergepaneli.Name = "btn_anaekrangostergepaneli";
            this.btn_anaekrangostergepaneli.Size = new System.Drawing.Size(230, 37);
            this.btn_anaekrangostergepaneli.TabIndex = 0;
            this.btn_anaekrangostergepaneli.Text = "Gösterge Paneli";
            this.btn_anaekrangostergepaneli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_anaekrangostergepaneli.UseVisualStyleBackColor = false;
            this.btn_anaekrangostergepaneli.Click += new System.EventHandler(this.btn_anaekrangostergepaneli_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GYM_ÜYE_KAYIT_SİSTEMİ.Properties.Resources.Protein_Supplement1;
            this.pictureBox1.Location = new System.Drawing.Point(79, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // odemeler1
            // 
            this.odemeler1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.odemeler1.Location = new System.Drawing.Point(0, 0);
            this.odemeler1.Name = "odemeler1";
            this.odemeler1.Size = new System.Drawing.Size(1007, 756);
            this.odemeler1.TabIndex = 3;
            // 
            // adminSporKoclari1
            // 
            this.adminSporKoclari1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminSporKoclari1.Location = new System.Drawing.Point(0, 0);
            this.adminSporKoclari1.Name = "adminSporKoclari1";
            this.adminSporKoclari1.Size = new System.Drawing.Size(1007, 756);
            this.adminSporKoclari1.TabIndex = 2;
            // 
            // adminUyeIslemleri1
            // 
            this.adminUyeIslemleri1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminUyeIslemleri1.Location = new System.Drawing.Point(0, 0);
            this.adminUyeIslemleri1.Name = "adminUyeIslemleri1";
            this.adminUyeIslemleri1.Size = new System.Drawing.Size(1007, 756);
            this.adminUyeIslemleri1.TabIndex = 1;
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminDashboard1.Location = new System.Drawing.Point(0, 0);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(1007, 756);
            this.adminDashboard1.TabIndex = 0;
            this.adminDashboard1.Load += new System.EventHandler(this.adminDashboard1_Load);
            // 
            // AdminSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 795);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_adminsol);
            this.Controls.Add(this.pnl_adminust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminSayfasi";
            this.pnl_adminust.ResumeLayout(false);
            this.pnl_adminust.PerformLayout();
            this.pnl_adminsol.ResumeLayout(false);
            this.pnl_adminsol.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_adminust;
        private System.Windows.Forms.Panel pnl_adminsol;
        private System.Windows.Forms.Label lbl_adminustisim;
        private System.Windows.Forms.Label lbl_admincikis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_anaekrangostergepaneli;
        private System.Windows.Forms.Label lbl_duzcizgi;
        private System.Windows.Forms.Button btn_anaekranodemeler;
        private System.Windows.Forms.Button btn_anaekranuyeler;
        private System.Windows.Forms.Button btn_anaekransporkoclari;
        private System.Windows.Forms.Button btn_cikisyap;
        private System.Windows.Forms.Panel panel1;
        private AdminDashboard adminDashboard1;
        private AdminUyeIslemleri adminUyeIslemleri1;
        private AdminSporKoclari adminSporKoclari1;
        private Odemeler odemeler1;
    }
}