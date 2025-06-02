using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GYM_ÜYE_KAYIT_SİSTEMİ
{
    public partial class Odemeler : UserControl
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=gymkayit;Uid=root;Pwd=Eral5334");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        private readonly Dictionary<string, decimal> paketFiyatlari = new Dictionary<string, decimal>
        {
           { "1 ay", 800 },
           { "3 ay", 2000 },
           { "6 ay", 4200 },
           { "yıllık", 8200 }
        };


        private void HesaplaParaUstu()
        {
            if (decimal.TryParse(lbl_odemetoplam.Text.Replace(" TL", ""), out decimal toplamTutar) &&
                decimal.TryParse(txt_odemeodenen.Text, out decimal odenenTutar))
            {
                decimal paraUstu = odenenTutar - toplamTutar;
                if (paraUstu < 0)
                {
                    lbl_odemeparaustu.Text = "Eksik ödeme: " + Math.Abs(paraUstu).ToString("F1") + " TL";
                    lbl_odemeparaustu.ForeColor = Color.Red;
                }
                else
                {
                    lbl_odemeparaustu.Text = "Para üstü: " + paraUstu.ToString("F1") + " TL";
                    lbl_odemeparaustu.ForeColor = Color.Green;
                }
            }
            else
            {
                lbl_odemeparaustu.Text = "";
            }
        }

        private void UyeOdemeListesiGetir()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=gymkayit;Uid=root;Pwd=Eral5334"))
                {
                    string sql = "SELECT uye_id, isim, soyisim, baslama_tarihi, bitis_tarihi, uyelik_paketi, odeme_durumu FROM uyekayit";
                    adapter = new MySqlDataAdapter(sql, conn);
                    dt = new DataTable(); 
                    adapter.Fill(dt);
                    dtg_odemedatagrid.DataSource = dt;
                    dtg_odemedatagrid.Columns["uye_id"].HeaderText = "Üye ID";
                    dtg_odemedatagrid.Columns["isim"].HeaderText = "İsim";
                    dtg_odemedatagrid.Columns["soyisim"].HeaderText = "Soyisim";
                    dtg_odemedatagrid.Columns["baslama_tarihi"].HeaderText = "Başlangıç Tarihi";
                    dtg_odemedatagrid.Columns["bitis_tarihi"].HeaderText = "Bitiş Tarihi";
                    dtg_odemedatagrid.Columns["uyelik_paketi"].HeaderText = "Üyelik Paketi";
                    dtg_odemedatagrid.Columns["odeme_durumu"].HeaderText = "Ödeme Durumu";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        public Odemeler()
        {
            InitializeComponent();
        }

        private void odemepaneli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Odemeler_Load(object sender, EventArgs e)
        {
            UyeOdemeListesiGetir();
            txt_odemeuyeid.ReadOnly = true;
        }

        private void dtg_odemedatagrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txt_odemeuyeid.Text = dtg_odemedatagrid.CurrentRow.Cells[0].Value.ToString();
                txt_odemeisim.Text = dtg_odemedatagrid.CurrentRow.Cells[1].Value.ToString();
                txt_odemesoyisim.Text = dtg_odemedatagrid.CurrentRow.Cells[2].Value.ToString();

                string uyelikPaketi = dtg_odemedatagrid.CurrentRow.Cells["uyelik_paketi"].Value.ToString();
                if (paketFiyatlari.ContainsKey(uyelikPaketi))
                {
                    decimal toplamTutar = paketFiyatlari[uyelikPaketi];
                    lbl_odemetoplam.Text = "" + toplamTutar.ToString("F1") + " TL";
                }
                else
                {
                    lbl_odemetoplam.Text = "0";
                }
            }
            catch
            {

            }
        }

        private void dtg_odemedatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_odemeal_Click(object sender, EventArgs e)
        {
            string odemeDurumu = dtg_odemedatagrid.CurrentRow.Cells["odeme_durumu"].Value.ToString();
            if (odemeDurumu == "ödendi")
            {
                MessageBox.Show("Bu üye zaten ödeme yapmış.");
                return;
            }
            try
            {
                
                if (string.IsNullOrWhiteSpace(txt_odemeuyeid.Text))
                {
                    MessageBox.Show("Lütfen bir üye seçin.");
                    return;
                }

                if (!decimal.TryParse(lbl_odemetoplam.Text.Replace(" TL", ""), out decimal toplamTutar) ||
                    !decimal.TryParse(txt_odemeodenen.Text, out decimal odenenTutar))
                {
                    MessageBox.Show("Geçerli bir ödeme giriniz.");
                    return;
                }

                if (odenenTutar < toplamTutar)
                {
                    MessageBox.Show("Ödeme yetersiz. Lütfen tam tutarı girin.");
                    return;
                }

               
                string uyeID = txt_odemeuyeid.Text;

                
                using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=gymkayit;Uid=root;Pwd=Eral5334"))
                {
                    conn.Open();
                    string updateQuery = "UPDATE uyekayit SET odeme_durumu = 'ödendi' WHERE uye_id = @uye_id";
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@uye_id", uyeID);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Ödeme başarıyla alındı.");

              
                UyeOdemeListesiGetir();

               
                txt_odemeuyeid.Clear();
                txt_odemeisim.Clear();
                txt_odemesoyisim.Clear();
                txt_odemeodenen.Clear();
                lbl_odemetoplam.Text = "";
                txt_odemeodenen.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void txt_odemeodenen_TextChanged(object sender, EventArgs e)
        {
            HesaplaParaUstu();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_odemelerisimegoreara_Click(object sender, EventArgs e)
        {

        }

        private void txt_odemeisimegoreara_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "isim LIKE '" + txt_odemeisimegoreara.Text + "%'";
        }
    }
}
