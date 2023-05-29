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
    public partial class ReceteYaz : Form
    {
        public ReceteYaz()
        {
            InitializeComponent();
        }
        Yonetim y = new Yonetim();
        private void button1_Click(object sender, EventArgs e)
        {
            if (y.ilacEkle(textBox1.Text,textBox3.Text,textBox4.Text) == true)
            {
                if(y.mesajGonderA(textBox2.Text,"eReçete",textBox4.Text+" <br> ilaçlarınızı eczaneden temin edebilirsiniz") == true)
                {
                    y.msg05();
                    this.Close();
                }
            }
            else
            {
                y.msg09();
            }
        }

        private void ReceteYaz_Load(object sender, EventArgs e)
        {
            Yonetim y = new Yonetim();
            y.hastTcGoreMailAra((textBox1.Text).Substring(0, 11));
            textBox2.Text = y._hastaMail;
        }
    }
}
