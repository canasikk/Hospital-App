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
    public partial class OturumEkrani : Form
    {
        public OturumEkrani()
        {
            InitializeComponent();
        }
        Yonetim y = new Yonetim();
        

        private void OturumEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       

        private void OturumEkrani_Load(object sender, EventArgs e)
        {
            versiyonLbl.Text = "Versiyon : " + y._version;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (y.dbCheck() == true)
            {
                if (y.hesapGirisi(tcTxt.Text, pwTxt.Text) == true)
                {
                    if(Properties.Settings.Default.rutbe == "0")
                    {
                        AdminEkrani ae = new AdminEkrani();
                        ae.Show();
                        this.Hide();
                    }
                    if(Properties.Settings.Default.rutbe == "1") {

                        DoktorEkrani de = new DoktorEkrani();
                        de.Show();
                        this.Hide();
                    }
                    if(Properties.Settings.Default.rutbe == "2") {
                        SekreterEkrani se = new SekreterEkrani();
                        se.Show();
                        this.Hide();
                    }
                }
                else
                {
                    y.msg03();
                }
            }
            else
            {
                y.msg01();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginGrup.Visible = true;
            label7.Visible = false;
            linkLabel1.Visible = false;
        }
    }
}
