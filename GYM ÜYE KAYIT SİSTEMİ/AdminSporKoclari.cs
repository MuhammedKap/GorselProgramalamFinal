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
    public partial class AdminSporKoclari : UserControl
    {

        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=gymkayit;Uid=root;Pwd=Eral5334");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        void KocUyeleriListele()
        {

            try
            {
                dtg_sporkoclariislemleri.DataSource = null;
                dtg_sporkoclariislemleri.AllowUserToAddRows = false;

                conn.Open();
                string sql = "SELECT * FROM sporkoclari";
                adapter = new MySqlDataAdapter(sql, conn);
                DataTable yeniDt = new DataTable(); 
                adapter.Fill(yeniDt);
                dtg_sporkoclariislemleri.DataSource = yeniDt;
                dt = yeniDt; 
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        public AdminSporKoclari()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (dt != null && dt.Columns.Contains("isim"))
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = "isim LIKE '" + txt_kocekleisimegoreara.Text + "%'";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AdminSporKoclari_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            KocUyeleriListele();
            txt_kocekleid.ReadOnly = true;
            dtg_sporkoclariislemleri.AllowUserToAddRows = false;
        }

        private void btn_kocekle_Click(object sender, EventArgs e)
        {


            try
            {
                conn.Open();
                string sql = "INSERT INTO sporkoclari (isim, soyisim, mail, cinsiyet, tecrube,telefon_no) " +
                             "VALUES (@isim, @soyisim, @mail, @cinsiyet,@tecrube,@telefon_no)";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@isim", txt_kocekleisim.Text);
                cmd.Parameters.AddWithValue("@soyisim", txt_koceklesoyisim.Text);
                cmd.Parameters.AddWithValue("@mail", txt_koceklemailadres.Text);
                cmd.Parameters.AddWithValue("@cinsiyet", cmb_koceklecinsiyet.Text);
                cmd.Parameters.AddWithValue("@tecrube", cmb_kocekletecrube.Text);
                cmd.Parameters.AddWithValue("@telefon_no", txt_kocekletelno.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Kayıt başarıyla eklendi.");
                KocUyeleriListele();

                MessageBox.Show("Kayıt başarıyla eklendi.");
                KocUyeleriListele();
                dtg_sporkoclariislemleri.Refresh(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                conn.Close();
            }

         
        }

        private void btn_kocsil_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM sporkoclari where koc_id=@koc_id";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@koc_id", txt_kocekleid.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Veriler Silindi");
            KocUyeleriListele();
        }

        private void dtg_sporkoclariislemleri_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtg_sporkoclariislemleri.CurrentRow != null &&
                    dtg_sporkoclariislemleri.CurrentRow.Cells[0].Value != null)
                {
                    txt_kocekleid.Text = dtg_sporkoclariislemleri.CurrentRow.Cells[0].Value.ToString();
                    txt_kocekleisim.Text = dtg_sporkoclariislemleri.CurrentRow.Cells[1].Value?.ToString();
                    txt_koceklesoyisim.Text = dtg_sporkoclariislemleri.CurrentRow.Cells[2].Value?.ToString();
                    txt_koceklemailadres.Text = dtg_sporkoclariislemleri.CurrentRow.Cells[3].Value?.ToString();
                    cmb_koceklecinsiyet.Text = dtg_sporkoclariislemleri.CurrentRow.Cells[4].Value?.ToString();
                    cmb_kocekletecrube.Text = dtg_sporkoclariislemleri.CurrentRow.Cells[5].Value?.ToString();
                    txt_kocekletelno.Text = dtg_sporkoclariislemleri.CurrentRow.Cells[6].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btn_kocgunelle_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE sporkoclari SET koc_id=@koc_id, isim=@isim, soyisim=@soyisim, mail=@mail, telefon_no=@telefon_no, cinsiyet=@cinsiyet, tecrube = @tecrube WHERE koc_id=@koc_id";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@isim", txt_kocekleisim.Text);
            cmd.Parameters.AddWithValue("@soyisim", txt_koceklesoyisim.Text);
            cmd.Parameters.AddWithValue("@mail", txt_koceklemailadres.Text);
            cmd.Parameters.AddWithValue("@telefon_no", txt_kocekletelno.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", cmb_koceklecinsiyet.Text);
            cmd.Parameters.AddWithValue("@tecrube", cmb_kocekletecrube.Text);
            cmd.Parameters.AddWithValue("@koc_id", txt_kocekleid.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt Güncellendi");
            KocUyeleriListele();
        }
        private void KocTemizle()
        {
            txt_kocekleisim.Clear();
            txt_koceklesoyisim.Clear();
            cmb_koceklecinsiyet.SelectedIndex = -1;
            txt_koceklemailadres.Clear();
            txt_kocekletelno.Clear();
            cmb_kocekletecrube.SelectedIndex = -1;
            txt_kocekleid.Clear();

        }
        private void btn_koctemizle_Click(object sender, EventArgs e)
        {
            KocTemizle();
        }

        private void dtg_sporkoclariislemleri_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
