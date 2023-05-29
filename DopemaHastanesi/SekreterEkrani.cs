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
namespace DopemaHastanesi
{
    public partial class SekreterEkrani : Form
    {
        public SekreterEkrani()
        {
            InitializeComponent();
        }
        Yonetim y = new Yonetim(); 
        MySqlConnection conn = new MySqlConnection("Server=localhost;database=dopeca;uid=root;pwd=;");
        private void SekreterEkrani_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = Properties.Settings.Default.loginAdi;
            saatCmb.SelectedIndex = 0;
            BransCek();
            HastaCek();
            RandevuCek();
            DataGridViewColumn col = randevuDataGrid.Columns[0];
            col.Visible = false; 
            saat.Text = DateTime.Now.ToLongTimeString();
            tarih.Text = DateTime.Now.ToShortDateString();
            tarihDate.MinDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        }
        void BransCek()
        {
            y.bransListele();
            foreach (string eleman in y._BransListele)
            {
                bransCmb.Items.Add(eleman);
            }
            bransCmb.SelectedIndex = 0;
        }
        void HastaCek()
        {
            y.hastaListeleFonk();
            foreach (string eleman in y._HastaListele)
            {
                hastaCmb.Items.Add(eleman);
            }
            hastaCmb.SelectedIndex = 0;
        }
        void RandevuCek()
        {
            y._sekreterRandevuTablosu.Clear();
            y.sekreterRandevuGetir();
            randevuDataGrid.DataSource = y._sekreterRandevuTablosu;
        }
        private void bransCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            doktorCmb.Items.Clear();
            y.bransaGoreDoktorAra(bransCmb.SelectedItem.ToString());
            for (int i = 0; i < y._BransDoktorListele.Count; i++)
            {
                doktorCmb.Items.Add(y._BransDoktorListele[i]);
            }
        }
        private void btnRandevu_Click(object sender, EventArgs e)
        {
           
             
            if (doktorCmb.SelectedIndex >= 0)
            {
                int result = DateTime.Compare(Convert.ToDateTime(saatCmb.SelectedItem.ToString()), Convert.ToDateTime(DateTime.Now.ToShortTimeString()));
                if (result == 1)
                {
                    try
                    {
                        conn.Close();
                        conn.Open();
                        MySqlCommand komut = new MySqlCommand("Select * From date Where doktorTc = '" + doktorCmb.SelectedItem.ToString().Substring(0, 11) + "' && brans = '" + bransCmb.SelectedItem.ToString() + "' && randevuTarihi = '" + tarihDate.Value.ToShortDateString() + "' && randevuSaati = '" + saatCmb.SelectedItem.ToString() + "' &&  islemDurumu = 'Bekleniyor...'", conn);
                        MySqlDataReader okuyucu = komut.ExecuteReader();
                        if (okuyucu.Read())
                        {
                            if (doktorCmb.SelectedItem.ToString().Substring(0, 11) == okuyucu["doktorTc"].ToString() && bransCmb.SelectedItem.ToString() == okuyucu["brans"].ToString() && tarihDate.Value.ToShortDateString() == okuyucu["randevuTarihi"].ToString() && saatCmb.SelectedItem.ToString() == okuyucu["randevuSaati"].ToString())
                            {
                                MessageBox.Show("Bu randevu saati dolu lütfen başka seçiniz.");
                            }
                        }
                        else
                        {
                            if (y.randevuEkle(hastaCmb.SelectedItem.ToString().Substring(0, 11),
                          hastaCmb.SelectedItem.ToString().Substring(14),
                          doktorCmb.SelectedItem.ToString().Substring(0, 11),
                          bransCmb.SelectedItem.ToString(),
                          tarihDate.Value.ToShortDateString(),
                          saatCmb.SelectedItem.ToString(),
                          sikayetTxt.Text,
                          "Bekleniyor...") == true)
                            {
                                y.hastTcGoreMailAra(hastaCmb.SelectedItem.ToString().Substring(0, 11));
                                y.mesajGonderA(y._hastaMail, "Randevu Hatırlatma!", bransCmb.SelectedItem.ToString() + " / " + doktorCmb.SelectedItem.ToString() + " / " + tarihDate.Value.ToShortDateString() + " / " + saatCmb.SelectedItem.ToString() + " / " + "Randevu İşleminiz Alınmıştır. Lütfen 15 Dakika önceden hazır olunuz.");
                                y.msg05();

                                hastaCmb.SelectedIndex = 0;
                                bransCmb.SelectedIndex = 0;
                                saatCmb.SelectedIndex = 0;
                                sikayetTxt.Text = "";
                                RandevuCek();
                            }
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("İleriye yönelik saat seçiniz!!");
                }
            }    
        }
        private void randevuİptalEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Güncellemek istiyor musunuz?", "Oops!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (y.randevuGuncelle(randevuDataGrid.CurrentRow.Cells[0].Value.ToString(),"İptal Edildi!") == true)
                    {
                        RandevuCek();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandevuCek();
        }
        private void randevuDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(randevuDataGrid.CurrentRow.Cells[7].Value.ToString(),"Şikayet Açıklaması!");
        }
        private void hastaÜyeOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
            HastaOlusturEkrani hoe = new HastaOlusturEkrani();
            hoe.ShowDialog();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            saat.Text = DateTime.Now.ToLongTimeString();
            tarih.Text = DateTime.Now.ToShortDateString();

        }
        private void SekreterEkrani_Activated(object sender, EventArgs e)
        {
            hastaCmb.Items.Clear();
            HastaCek();
        }
        private void SekreterEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void hastaCmb_SelectedValueChanged(object sender, EventArgs e)
        {
            y.hastTcGoreMailAra(hastaCmb.SelectedItem.ToString().Substring(0, 11));
        }
        private void tekHastayaDuyuruGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekliDuyuruEkrani tde = new TekliDuyuruEkrani();
            tde.ShowDialog();
        }
    }
}
