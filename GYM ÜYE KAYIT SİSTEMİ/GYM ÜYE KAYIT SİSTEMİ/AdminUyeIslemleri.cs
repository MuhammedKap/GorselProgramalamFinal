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
using MySql.Data.MySqlClient;

namespace GYM_ÜYE_KAYIT_SİSTEMİ
{
    public partial class AdminUyeIslemleri : UserControl
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=gymkayit;Uid=root;Pwd=Eral5334");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        void UyeleriListele()
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM uyekayit";
                adapter = new MySqlDataAdapter(sql, conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dtg_uyeislemleri.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                conn.Close();
            }
        }
        
        public AdminUyeIslemleri()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ekleuyid_Click(object sender, EventArgs e)
        {

        }

        private void AdminUyeIslemleri_Load(object sender, EventArgs e)
        {
            UyeleriListele();
            txt_ekleuyeid.ReadOnly = true;
            
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "INSERT INTO uyekayit (isim, soyisim, mail, telefon_no, cinsiyet, uyelik_paketi, dogum_tarihi, baslama_tarihi, bitis_tarihi,odeme_durumu) " +
                             "VALUES (@isim, @soyisim, @mail, @telefon, @cinsiyet, @paket, @dogum, @baslama, @bitis,@odeme_durumu)";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@isim", txt_ekleisim.Text);
                cmd.Parameters.AddWithValue("@soyisim", txt_eklesoyisim.Text);
                cmd.Parameters.AddWithValue("@mail", txt_eklemailadres.Text);
                cmd.Parameters.AddWithValue("@telefon", txt_ekletelno.Text);
                cmd.Parameters.AddWithValue("@cinsiyet", cmb_eklecinsiyet.Text);
                cmd.Parameters.AddWithValue("@paket", cmb_eklepaket.Text);
                cmd.Parameters.AddWithValue("@dogum", dt_ekledogumtarihi.Value.Date);
                cmd.Parameters.AddWithValue("@baslama", dt_ekleabonebaslangic.Value.Date);
                cmd.Parameters.AddWithValue("@bitis", dt_ekleabonebitis.Value.Date);
                cmd.Parameters.AddWithValue("@odeme_durumu", cmb_odemedurumu.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Kayıt eklendi.");
                UyeleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                conn.Close();
            }
        }

        private void dtg_uyeislemleri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM uyekayit where uye_id=@uye_id";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@uye_id", txt_ekleuyeid.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Veriler Silindi");
            UyeleriListele();
        }

        private void dtg_uyeislemleri_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txt_ekleuyeid.Text = dtg_uyeislemleri.CurrentRow.Cells[0].Value.ToString();
                txt_ekleisim.Text = dtg_uyeislemleri.CurrentRow.Cells[1].Value.ToString();
                txt_eklesoyisim.Text = dtg_uyeislemleri.CurrentRow.Cells[2].Value.ToString();
                txt_eklemailadres.Text = dtg_uyeislemleri.CurrentRow.Cells[3].Value.ToString();
                txt_ekletelno.Text = dtg_uyeislemleri.CurrentRow.Cells[4].Value.ToString();
                cmb_eklecinsiyet.Text = dtg_uyeislemleri.CurrentRow.Cells[5].Value.ToString();                
                cmb_eklepaket.Text = dtg_uyeislemleri.CurrentRow.Cells[6].Value.ToString();
                dt_ekledogumtarihi.Text = dtg_uyeislemleri.CurrentRow.Cells[7].Value.ToString();
                dt_ekleabonebaslangic.Value = Convert.ToDateTime(dtg_uyeislemleri.CurrentRow.Cells[8].Value);
                dt_ekleabonebitis.Value = Convert.ToDateTime(dtg_uyeislemleri.CurrentRow.Cells[9].Value);
                cmb_odemedurumu.Text = dtg_uyeislemleri.CurrentRow.Cells[10].Value.ToString();
            }
            catch
            {

            }


        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE uyekayit SET uye_id=@uye_id, isim=@isim, soyisim=@soyisim, mail=@mail, telefon_no=@telefon_no, cinsiyet=@cinsiyet, uyelik_paketi=@uyelik_paketi, dogum_tarihi=@dogum_tarihi , baslama_tarihi = @baslama_tarihi , bitis_tarihi = @bitis_tarihi , odeme_durumu = @odeme_durumu WHERE uye_id=@uye_id";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@isim", txt_ekleisim.Text);
            cmd.Parameters.AddWithValue("@soyisim", txt_eklesoyisim.Text);
            cmd.Parameters.AddWithValue("@mail", txt_eklemailadres.Text);
            cmd.Parameters.AddWithValue("@telefon_no", txt_ekletelno.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", cmb_eklecinsiyet.Text);
            cmd.Parameters.AddWithValue("@uyelik_paketi", cmb_eklepaket.Text);
            cmd.Parameters.AddWithValue("@dogum_tarihi", dt_ekledogumtarihi.Value);
            cmd.Parameters.AddWithValue("@baslama_tarihi", dt_ekleabonebaslangic.Value);
            cmd.Parameters.AddWithValue("@bitis_tarihi", dt_ekleabonebitis.Value);
            cmd.Parameters.AddWithValue("@odeme_durumu", cmb_odemedurumu.Text);
            cmd.Parameters.AddWithValue("@uye_id", txt_ekleuyeid.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt Güncellendi");
            UyeleriListele();
        }

        private void Temizle()
        {
            txt_ekleisim.Clear();
            txt_eklesoyisim.Clear();
            cmb_eklecinsiyet.SelectedIndex = -1;
            cmb_odemedurumu.SelectedIndex = -1;
            txt_eklemailadres.Clear();
            txt_ekletelno.Clear();
            cmb_eklepaket.SelectedIndex = -1;
            dt_ekledogumtarihi.Value = DateTime.Now;
            dt_ekleabonebaslangic.Value = DateTime.Now;
            dt_ekleabonebitis.Value = DateTime.Now;
            txt_ekleuyeid.Clear();

        }
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void txt_isimegoreara_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "isim LIKE '" + txt_isimegoreara.Text + "%'";
        }
    }
    }

