using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_ÜYE_KAYIT_SİSTEMİ
{
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_cikisyapx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullaniciadi, sifre = "";

            kullaniciadi = txt_kullaniciadi.Text;
            sifre = txt_sifre.Text;

            if (kullaniciadi == "" || sifre == "")
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş bırakılamaz", "Hatalı giriş denemsi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {


                if (kullaniciadi == "1" && sifre == "1")
                {


                    AdminSayfasi adminForm = new AdminSayfasi();

                    adminForm.Show();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
    
}
