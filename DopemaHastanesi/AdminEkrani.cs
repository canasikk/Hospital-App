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
    public partial class AdminEkrani : Form
    {
        public AdminEkrani()
        {
            InitializeComponent();
        }
        Yonetim y = new Yonetim();
        // Foknsiyonlar
        void bransYenile()
        {
            y._bransTablosu.Clear();
            y.bransGetir();
            bransDataGrid.DataSource = y._bransTablosu;
        }
        void sekreterYenile()
        {
            y._sekreterTablosu.Clear();
            y.sekreterGetir();
            sekreterDataGrid.DataSource = y._sekreterTablosu;
        }
        void doktorYenile()
        {
            y._doktorTablosu.Clear();
            y.doktorGetir();
            doktorDataGrid.DataSource = y._doktorTablosu;
        }

        private void AdminEkrani_Load(object sender, EventArgs e)
        {

            bransYenile();
            sekreterDogumCmb.SelectedIndex = 0;

            sekreterYenile();
            doktorDogumCmb.SelectedIndex = 0;

            y.bransListele();
            foreach (string eleman in y._BransListele)
            {
                doktorBransCmb.Items.Add(eleman);
            }
            doktorBransCmb.SelectedIndex = 0;

            doktorYenile();

            bransDataGrid.Columns[0].ReadOnly = true;
            bransDataGrid.Columns[0].Visible = false;
            bransDataGrid.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            bransDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue;

            doktorDataGrid.Columns[0].Visible = false;
            doktorDataGrid.Columns[1].ReadOnly = true;
            doktorDataGrid.Columns[11].ReadOnly = true;

            doktorDataGrid.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            doktorDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue;

            sekreterDataGrid.Columns[0].Visible = false;
            sekreterDataGrid.Columns[1].ReadOnly = true;
            sekreterDataGrid.Columns[7].ReadOnly = true;
            sekreterDataGrid.Columns[11].ReadOnly = true;

            sekreterDataGrid.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            sekreterDataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue;


        }


        //Branş
        private void bransEkleBtn_Click(object sender, EventArgs e)
        {
            if (y.dbCheck() == true)
            {
                if (y.bransEkle(bransTxt.Text) == true)
                {
                    y.msg05();
                    bransYenile();
                    bransTxt.Text = "";
                }
                else
                {
                    y.msg09();
                }
            }
            else
            {
                y.msg01();
            }
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bransYenile();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Silmek istiyor musunuz?", "Oops!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                try
                {
                    if (y.bransSil(bransDataGrid.CurrentRow.Cells[1].Value.ToString()) == true)
                    {
                        bransYenile();
                    }
                    else
                    {
                        y.msg09();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void bransDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Güncellemek istiyor musunuz?", "Oops!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (y.bransGuncelle(Convert.ToInt16(bransDataGrid.CurrentRow.Cells[0].Value), bransDataGrid.CurrentRow.Cells[1].Value.ToString()) == true)
                    {
                        bransYenile();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }
        }

        //Branş Sonu
        //Sekreter Başı

        private void sekreterEkleBtn_Click(object sender, EventArgs e)
        {
            if (y.dbCheck() == true)
            {
                if (y.doktorSekreterEkle(sekreterTcTxt.Text,
                    sekreterAdTxt.Text,
                    sekreterSoyadTxt.Text,
                    sekreterBabaTxt.Text,
                    sekreterDogumCmb.SelectedItem.ToString(),
                    sekreterDogumTarihiDt.Value.ToShortDateString(),
                    "Sekreter",
                    sekreterCepTxt.Text,
                    sekreterMailTxt.Text,
                    sekreterParolaTxt.Text,
                    "2") == true)
                {
                    y.msg05();
                    sekreterYenile();
                    sekreterTcTxt.Text = "";
                    sekreterAdTxt.Text = "";
                    sekreterSoyadTxt.Text = "";
                    sekreterBabaTxt.Text = "";
                    sekreterDogumCmb.SelectedIndex = 0;
                    sekreterCepTxt.Text = "";
                    sekreterMailTxt.Text = "";
                    sekreterParolaTxt.Text = "";
                }
                else
                {
                    y.msg09();
                }
            }
            else
            {
                y.msg01();
            }
        }

        private void sekreterAraTxt_TextChanged(object sender, EventArgs e)
        {

            y._sekreterAraTablosu.Clear();
            y.sekreterGetir();
            y.sekreterAra(sekreterAraTxt.Text);

            sekreterDataGrid.DataSource = y._sekreterAraTablosu.Tables[0];

            if (sekreterAraTxt.Text == "")
            {
                sekreterYenile();
            }
        }

        private void yenileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sekreterYenile();
        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Silmek istiyor musunuz?", "Oops!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                try
                {
                   
                    if (y.doktorSekreterSil(sekreterDataGrid.CurrentRow.Cells[1].Value.ToString()) == true)
                    {
                        sekreterYenile();
                    }
                    else
                    {
                        y.msg09();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void sekreterDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Güncellemek istiyor musunuz?", "Oops!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                   if (y.doktorSekreterGuncelle(
                          sekreterDataGrid.CurrentRow.Cells[1].Value.ToString(),
                            sekreterDataGrid.CurrentRow.Cells[2].Value.ToString(),
                              sekreterDataGrid.CurrentRow.Cells[3].Value.ToString(),
                                sekreterDataGrid.CurrentRow.Cells[4].Value.ToString(),
                                  sekreterDataGrid.CurrentRow.Cells[5].Value.ToString(),
                                    sekreterDataGrid.CurrentRow.Cells[6].Value.ToString(),
                                      "Sekreter",
                                        sekreterDataGrid.CurrentRow.Cells[8].Value.ToString(),
                                          sekreterDataGrid.CurrentRow.Cells[9].Value.ToString(),
                                          sekreterDataGrid.CurrentRow.Cells[10].Value.ToString()
                                              ) == true)
                    {
                        sekreterYenile();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void doktorEkleBtn_Click(object sender, EventArgs e)
        {
            if (y.dbCheck() == true)
            {
                if (y.doktorSekreterEkle(doktorTcTxt.Text,
                    doktorAdTxt.Text,
                    doktorSoyadTxt.Text,
                    doktorBabaTxt.Text,
                    doktorDogumCmb.SelectedItem.ToString(),
                    doktorDogumDtp.Value.ToShortDateString(),
                    doktorBransCmb.SelectedItem.ToString(),
                    doktorCepTxt.Text,
                    doktorMailTxt.Text,
                    doktorParolaTxt.Text,
                    "1") == true)
                {
                    y.msg05();
                    doktorYenile();
                    doktorTcTxt.Text = "";
                    doktorAdTxt.Text = "";
                    doktorSoyadTxt.Text = "";
                    doktorBabaTxt.Text = "";
                    doktorDogumCmb.SelectedIndex = 0;
                    doktorBransCmb.SelectedIndex = 0;
                    doktorCepTxt.Text = "";
                    doktorMailTxt.Text = "";
                    doktorParolaTxt.Text = "";
                }
                else
                {
                    y.msg09();
                }
            }
            else
            {
                y.msg01();
            }
        }

        private void doktorTcAraTxt_TextChanged(object sender, EventArgs e)
        {
            y._doktorAraTablosu.Clear();
            y.doktorGetir();
            y.doktorAra("tckn",doktorTcAraTxt.Text);

            doktorDataGrid.DataSource = y._doktorAraTablosu.Tables[0];

            if (doktorTcAraTxt.Text == "")
            {
                doktorYenile();
            }
        }

        private void doktorBransAraTxt_TextChanged(object sender, EventArgs e)
        {
            y._doktorAraTablosu.Clear();
            y.doktorGetir();
            y.doktorAra("brans",doktorBransAraTxt.Text);

            doktorDataGrid.DataSource = y._doktorAraTablosu.Tables[0];

            if (doktorBransAraTxt.Text == "")
            {
                doktorYenile();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            doktorYenile();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Silmek istiyor musunuz?", "Oops!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                try
                {
                    if (y.doktorSekreterSil(doktorDataGrid.CurrentRow.Cells[1].Value.ToString()) == true)
                    {
                        doktorYenile();
                    }
                    else
                    {
                        y.msg09();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void doktorDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Güncellemek istiyor musunuz?", "Oops!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    if (y.doktorSekreterGuncelle(
                          doktorDataGrid.CurrentRow.Cells[1].Value.ToString(),
                            doktorDataGrid.CurrentRow.Cells[2].Value.ToString(),
                              doktorDataGrid.CurrentRow.Cells[3].Value.ToString(),
                                doktorDataGrid.CurrentRow.Cells[4].Value.ToString(),
                                  doktorDataGrid.CurrentRow.Cells[5].Value.ToString(),
                                    doktorDataGrid.CurrentRow.Cells[6].Value.ToString(),
                                      doktorDataGrid.CurrentRow.Cells[7].Value.ToString(),
                                        doktorDataGrid.CurrentRow.Cells[8].Value.ToString(),
                                          doktorDataGrid.CurrentRow.Cells[9].Value.ToString(),
                                            doktorDataGrid.CurrentRow.Cells[10].Value.ToString()
                                              ) == true)
                    {
                        doktorYenile();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void şuAnkiVerileriExceleAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            y.gonderExcel(bransDataGrid);

        }

        private void şuAnkiVerileriExceleAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            y.gonderExcel(sekreterDataGrid);
        }

        private void şuAnkiVerileriExceleAktarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            y.gonderExcel(doktorDataGrid);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.bransDataGrid.Width, this.bransDataGrid.Height);
            bransDataGrid.DrawToBitmap(bm, new Rectangle(0, 0, this.bransDataGrid.Width, this.bransDataGrid.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void şuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            printDocument1.Print();
        }

        private void şuAnkiVerileriYazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            printDocument2.Print();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.sekreterDataGrid.Width, this.sekreterDataGrid.Height);
            sekreterDataGrid.DrawToBitmap(bm, new Rectangle(0, 0, this.sekreterDataGrid.Width, this.sekreterDataGrid.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.doktorDataGrid.Width, this.doktorDataGrid.Height);
            doktorDataGrid.DrawToBitmap(bm, new Rectangle(0, 0, this.doktorDataGrid.Width, this.doktorDataGrid.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void şuAnkiVerileriYazdırToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            printDocument3.Print();
        }

        private void doktorTcAraTxt_Click(object sender, EventArgs e)
        {
            doktorBransAraTxt.Text = "";
        }

        private void doktorBransAraTxt_Click(object sender, EventArgs e)
        {
            doktorTcAraTxt.Text = "";
        }

        private void AdminEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}