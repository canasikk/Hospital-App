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
    public partial class HastaOlusturEkrani : Form
    {
        public HastaOlusturEkrani()
        {
            InitializeComponent();
        }
        Yonetim y = new Yonetim();
        private void olusturBtn_Click(object sender, EventArgs e)
        {
            if (y.dbCheck() == true)
            {
                if (y.hastaEkle(tcTxt.Text,
                    adTxt.Text,
                    soyadTxt.Text,
                    cinsiyetCmb.SelectedItem.ToString(),
                    dogumCmb.SelectedItem.ToString(),
                    hastaDogumDtp.Value.ToShortDateString(),
                    kanCmb.SelectedItem.ToString(),
                    cepTxt.Text,
                    mailTxt.Text) == true)
                {
                    y.msg05();
                    this.Close();
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

        private void HastaOlusturEkrani_Load(object sender, EventArgs e)
        {
            cinsiyetCmb.SelectedIndex = 0;
            dogumCmb.SelectedIndex = 0;
            kanCmb.SelectedIndex = 0;
             

        }
    }
}
