using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DopemaHastanesi
{
    public partial class DoktorEkrani : Form
    {
        public DoktorEkrani()
        {
            InitializeComponent();
        }
        Yonetim y = new Yonetim();
        private void DoktorEkrani_Load(object sender, EventArgs e)
        {
            RandevuCek();
            TumRandevuCek();
            ReceteCek();
            randevuDataGrid.Columns[0].Visible = false;
            randevuDataGrid.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            randevuDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue;

            tumGrid.Columns[0].Visible = false;
            tumGrid.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            tumGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue;

            ilacGrid.Columns[0].Visible = false;
            ilacGrid.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            ilacGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue;
        }
        void RandevuCek()
        {
            y._doktorRandevuTablosu.Clear();
            y.doktorRandevuGetir(Properties.Settings.Default.loginTc);
            randevuDataGrid.DataSource = y._doktorRandevuTablosu;
        }
        void TumRandevuCek()
        {
            y._doktorTumRandevuTablosu.Clear();
            y.doktorTumRandevuGetir(Properties.Settings.Default.loginTc);
            tumGrid.DataSource = y._doktorTumRandevuTablosu;
        }
        void ReceteCek()
        {
            y._receteTablosu.Clear();
            y.receteGetir(Properties.Settings.Default.loginTc);
            ilacGrid.DataSource = y._receteTablosu;
        }
        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandevuCek(); TumRandevuCek(); ReceteCek();
        }

        private void randevuTamamlandıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Güncellemek istiyor musunuz?", "Oops!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    if (y.randevuGuncelle(randevuDataGrid.CurrentRow.Cells[0].Value.ToString(), "Tamamlandı!") == true)
                    {
                        RandevuCek();
                        TumRandevuCek();
                        ReceteCek();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void randevuİptalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Güncellemek istiyor musunuz?", "Oops!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    if (y.randevuGuncelle(randevuDataGrid.CurrentRow.Cells[0].Value.ToString(), "İptal Edildi!") == true)
                    {
                        RandevuCek();
                        TumRandevuCek();
                        ReceteCek();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void randevuDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(randevuDataGrid.CurrentRow.Cells[7].Value.ToString(), "Şikayet Açıklaması!");
        }

        private void ilaçYazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceteYaz ry = new ReceteYaz();
            ry.textBox1.Text = randevuDataGrid.CurrentRow.Cells[1].Value.ToString();
            ry.textBox3.Text = Properties.Settings.Default.loginTc;
            ry.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
            y._hastaAraTablosu.Clear();
            y.doktorTumRandevuGetir(Properties.Settings.Default.loginTc);
            y.hastaAra(textBox1.Text);

            tumGrid.DataSource = y._hastaAraTablosu.Tables[0];

            if (textBox1.Text == "")
            {
                TumRandevuCek();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TumRandevuCek();
            ReceteCek();
        }

        private void DoktorEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
