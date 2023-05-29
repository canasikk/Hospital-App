using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DopemaHastanesi
{
    public partial class SplashEkrani : Form
    {
        Yonetim ms = new Yonetim();
        Boolean checkDb = false;
        int selectDataRandom;
        public SplashEkrani()
        {
            InitializeComponent();
        }
        private void SplashEkrani_Load(object sender, EventArgs e)
        {
            
            Random timerRandom = new Random();
            int selectTimerRandom = timerRandom.Next(1, 50);
            Random dataRandom = new Random();
            selectDataRandom = dataRandom.Next(40, 65);
            timer1.Interval = selectTimerRandom;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            islemProgress.Value++;
            if (islemProgress.Value == selectDataRandom)
            {
                if (ms.dbCheck() == true)
                {
                    checkDb = true;
                    veritabaniTxt.Text = "Bağlandı!";
                }
                else
                {
                    checkDb = false;
                    veritabaniTxt.Text = "Başarısız!";
                }
            }
            else
            {
                if (islemProgress.Value == 100)
                {
                    timer1.Stop();
                    if (checkDb == false)
                    {
                        ms.msg01();
                        Application.Exit();
                    }
                    if (checkDb == true)
                    {
                        OturumEkrani oe = new OturumEkrani();
                        oe.Show();
                        this.Hide();
                    }
                }
            }
        }
        private void güvenliÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
