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
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;


namespace GYM_ÜYE_KAYIT_SİSTEMİ
{
    public partial class AdminSayfasi : Form
    {
       

        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=gymkayit;Uid=root;Pwd=Eral5334");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        AdminDashboard dashboardPanel = new AdminDashboard();
        AdminUyeIslemleri uyeIslemleriPanel = new AdminUyeIslemleri();

        public AdminSayfasi()
        {
            InitializeComponent();
            PanelGoster(dashboardPanel);
            adminDashboard1.Visible = true;
            adminUyeIslemleri1.Visible = false;
            adminSporKoclari1.Visible = false;
            odemeler1.Visible = false;
        }
        private void PanelGoster(UserControl kontrol)
        {
            dashboardPanel.Controls.Clear();
            kontrol.Dock = DockStyle.Fill;
            uyeIslemleriPanel.Controls.Add(kontrol);
        }
       
        private void lbl_admincikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_cikisyap_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();          
            {
                DialogResult cevap = MessageBox.Show("Çıkış Yapmak İstediğinizden Emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (cevap == DialogResult.OK)
                {
                   
                    this.Hide();
                    form1.Show();
                }
                else
                {
                    
                }
            }



        }

        private void adminDashboard1_Load(object sender, EventArgs e)
        {
            PanelGoster(dashboardPanel);
            adminDashboard1.SayilariGuncelle();
            
        }

        private void btn_anaekranuyeler_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible=false;
            adminUyeIslemleri1.Visible=true;
            adminSporKoclari1.Visible = false;
            odemeler1.Visible = false;

        }

        private void btn_anaekrangostergepaneli_Click(object sender, EventArgs e)
        {
            adminDashboard1.Visible = true;
            adminUyeIslemleri1.Visible = false;
            adminSporKoclari1.Visible = false;
            odemeler1.Visible = false;
            adminDashboard1.SayilariGuncelle();
            

        }

        private void btn_anaekransporkoclari_Click(object sender, EventArgs e)
        {
            adminSporKoclari1.Visible=true;
            adminUyeIslemleri1.Visible=false;
            adminDashboard1.Visible=false;
            odemeler1.Visible = false;
        }

        private void btn_anaekranodemeler_Click(object sender, EventArgs e)
        {
            adminSporKoclari1.Visible = false;
            adminUyeIslemleri1.Visible = false;
            adminDashboard1.Visible = false;
            odemeler1.Visible=true;
        }
    }
}
