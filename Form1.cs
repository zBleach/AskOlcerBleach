using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AskOlcerBleach
{
    public partial class AskOlcer : Form
    {
        public AskOlcer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ask1tbox_TextChanged(object sender, EventArgs e)
        {
            ask1lbl.Text = ask1tbox.Text;
        }

        private void ask2tbox_TextChanged(object sender, EventArgs e)
        {
            ask2lbl.Text = ask2tbox.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hesaplabtn_Click(object sender, EventArgs e)
        {
            int Sayi;
            Random sayirandom = new Random();
            Sayi = sayirandom.Next(101);
            askyuzdelbl.Text = Sayi.ToString();

            if (Sayi <= 30)
            {
                sozlbl.Text = "Sizin Aşkınızı Düşünmek İstemiyorum.";
            }
            else
            {
                sozlbl.Text = "Aşkınızın Ederi var.";
            }
            if (Sayi >= 80)
            {
                sozlbl.Text = "Siz gerçek bir aşıksınız hemen evlenin.";
            }
            if (Sayi == 100)
            {
                sozlbl.Text = "OMGGGGGGGG EN GÜZELLL ÇİFTT <<<333";
            }

        }
    }
}
