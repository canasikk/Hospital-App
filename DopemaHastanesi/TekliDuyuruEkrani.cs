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
    public partial class TekliDuyuruEkrani : Form
    {
        public TekliDuyuruEkrani()
        {
            InitializeComponent();
        }
        Yonetim y = new Yonetim();
        private void TekliDuyuruEkrani_Load(object sender, EventArgs e)
        {
            y.hastaListeleFonk();
            foreach (string eleman in y._HastaListele)
            {
                hastaCmb.Items.Add(eleman);
            }
            hastaCmb.SelectedIndex = 0;
            y.hastTcGoreMailAra(hastaCmb.SelectedItem.ToString());
            mailTxt.Text = y._hastaMail;
        }
        private void hastaCmb_SelectedValueChanged(object sender, EventArgs e)
        {
            y.hastTcGoreMailAra((hastaCmb.SelectedItem.ToString()).Substring(0,11));
            mailTxt.Text = y._hastaMail;
        }
        private void GonderBtn_Click(object sender, EventArgs e)
        {
            if(y.mesajGonderA(mailTxt.Text, konuTxt.Text, mesajTxt.Text) == true)
            {
                y.msg05();
            }
            else
            {
                y.msg09();
            }
        }
    }
}
