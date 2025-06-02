using MySql.Data.MySqlClient;
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
    public partial class AdminDashboard : UserControl
    {
        private readonly Dictionary<string, decimal> paketFiyatlari = new Dictionary<string, decimal>
        {
           { "1 ay", 800 },
           { "3 ay", 2000 },
           { "6 ay", 4200 },
           { "yıllık", 8200 }
        };

        public void SayilariGuncelle()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection("Server=localhost;Database=gymkayit;Uid=root;Pwd=Eral5334");
                conn.Open();

                MySqlCommand cmdUye = new MySqlCommand("SELECT COUNT(*) FROM uyekayit", conn);
                int uyeSayisi = Convert.ToInt32(cmdUye.ExecuteScalar());
                lbl_uyeSayisi.Text = uyeSayisi.ToString();

                MySqlCommand cmdKoc = new MySqlCommand("SELECT COUNT(*) FROM sporkoclari", conn);
                int kocSayisi = Convert.ToInt32(cmdKoc.ExecuteScalar());
                lbl_kocSayisi.Text = kocSayisi.ToString();

               
                MySqlCommand cmdOdeme = new MySqlCommand("SELECT uyelik_paketi FROM uyekayit WHERE odeme_durumu = 'ödendi'", conn);
                MySqlDataReader reader = cmdOdeme.ExecuteReader();

                decimal toplamGelir = 0;
                while (reader.Read())
                {
                    string paket = reader.GetString("uyelik_paketi");
                    if (paketFiyatlari.ContainsKey(paket))
                    {
                        toplamGelir += paketFiyatlari[paket];
                    }
                }
                reader.Close();

                lbl_totalsayac.Text = toplamGelir.ToString("N0") + " ₺";


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sayılarda hata: " + ex.Message);
            }
        }

        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void lbl_uyesayac_Click(object sender, EventArgs e)
        {
           
        }

        private void lbl_kocsayac_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_totalsayac_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            SayilariGuncelle();
        }

        private void salesChart_Click(object sender, EventArgs e)
        {
            
        }
    }
}
