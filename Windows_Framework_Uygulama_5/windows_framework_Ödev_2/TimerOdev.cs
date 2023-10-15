using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace windows_framework_Ödev_2
{
    public partial class TimerOdev : Form
    {
        public TimerOdev()
        {
            InitializeComponent();
        }

        int saat, dakika, saniya;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                saniya += 1;
                if (saniya == 60)
                {
                    saniya = 0;
                    dakika += 1;
                }

                if (dakika == 60)
                {
                    dakika = 0;
                    saat += 1;
                }
                Metin_Kutusu.Text = string.Format("{0}:{1}:{2}", saat.ToString().PadLeft(2, '0'), dakika.ToString().PadLeft(2, '0'), saniya.ToString().PadLeft(2, '0'));
            }));
        }

        private void Baslat_Dugmesi_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void Durdur_Dugmesi_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }


        private void Tur_Dugmesi_Click(object sender, EventArgs e)
        {
            string YeniTur = Metin_Kutusu.Text;
            if (!listBox1.Items.Contains(YeniTur))
            {
                listBox1.Items.Add(YeniTur);
            }
            else
            {
                MessageBox.Show("Bu Tur Zaten Mevcut !!!");
            }
        }

        private void Sıfrla_Dugmesi_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            saniya = 0;
            dakika = 0;
            saat = 0;
            Metin_Kutusu.Text = "00:00:00";
            listBox1.Items.Clear();
        }

    }
}
