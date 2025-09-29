using System;
using System.Drawing;
using System.Windows.Forms;

namespace KronometreOrnek
{
    public partial class Form1 : Form
    {
        int saat = 0, dakika = 0, saniye = 0, salise = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10; // 10 ms -> 0-99 salise
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            salise++;
            if (salise == 100)
            {
                salise = 0;
                saniye++;
            }
            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }
            if (dakika == 60)
            {
                dakika = 0;
                saat++;
            }

            // Label’lara yaz
            lblSaat.Text = saat.ToString("00");
            lblDakika.Text = dakika.ToString("00");
            lblSaniye.Text = saniye.ToString("00");
            lblSalise.Text = salise.ToString("00");

            // Sistem saatine denk geldiyse
            var now = DateTime.Now;
            if (saat == now.Hour && dakika == now.Minute && saniye == now.Second)
            {
                btnBasla.BackColor = Color.Green;
                timer1.Stop();
            }
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            saat = dakika = saniye = salise = 0;
            lblSaat.Text = "00";
            lblDakika.Text = "00";
            lblSaniye.Text = "00";
            lblSalise.Text = "00";
            btnBasla.BackColor = SystemColors.Control; // normal rengine dönsün
            timer1.Start();
        }
    }
}