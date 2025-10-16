using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DorduncuHafta2
{
    public partial class Form1 : Form
    {
        private Label lblPuan;
        private Button btnOyun;
        private Timer timer;
        private Random random;
        private int puan = 0;

        // Kırmızı alan koordinatları (form ortasında bir bölge)
        private Rectangle kirmiziBolge;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            // Form ayarları
            this.Text = "Rastgele Buton Oyunu";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            random = new Random();

            // Kırmızı bölgeyi tanımla (form ortasında 300x300 piksel alan)
            kirmiziBolge = new Rectangle(
                (this.ClientSize.Width - 300) / 2,
                (this.ClientSize.Height - 300) / 2,
                300,
                300
            );

            // Puan Label'ı oluştur
            lblPuan = new Label();
            lblPuan.Text = "Puan: 0";
            lblPuan.Font = new Font("Arial", 16, FontStyle.Bold);
            lblPuan.AutoSize = true;
            lblPuan.Location = new Point(20, 20);
            this.Controls.Add(lblPuan);

            // Oyun Butonu oluştur
            btnOyun = new Button();
            btnOyun.Size = new Size(80, 80);
            btnOyun.Font = new Font("Arial", 20, FontStyle.Bold);
            btnOyun.Click += BtnOyun_Click;
            this.Controls.Add(btnOyun);

            // Timer oluştur 
            timer = new Timer();
            timer.Interval = 800;
            timer.Tick += Timer_Tick;
            timer.Start();

            // İlk konumu ayarla
            YeniKonumAyarla();

            // Kırmızı bölge gizli - sadece buton rengi ile belli olacak
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            YeniKonumAyarla();
        }

        private void YeniKonumAyarla()
        {
            // Rastgele rakam (1-9 arası)
            int rastgeleSayi = random.Next(1, 10);
            btnOyun.Text = rastgeleSayi.ToString();

            // Rastgele konum (butonun form içinde kalmasını sağla)
            int maxX = this.ClientSize.Width - btnOyun.Width - 20;
            int maxY = this.ClientSize.Height - btnOyun.Height - 20;

            int x = random.Next(20, maxX);
            int y = random.Next(60, maxY); // 60'dan başla ki puan label'ı ile çakışmasın

            btnOyun.Location = new Point(x, y);

            // Butonun kırmızı bölgede olup olmadığını kontrol et
            if (KirmiziBolgede(btnOyun.Location))
            {
                btnOyun.ForeColor = Color.Red;
            }
            else
            {
                btnOyun.ForeColor = Color.Black;
            }
        }

        private bool KirmiziBolgede(Point butonKonum)
        {
            // Butonun merkez noktasını al
            Point merkezNokta = new Point(
                butonKonum.X + btnOyun.Width / 2,
                butonKonum.Y + btnOyun.Height / 2
            );

            return kirmiziBolge.Contains(merkezNokta);
        }

        private void BtnOyun_Click(object sender, EventArgs e)
        {
            int butonSayisi = int.Parse(btnOyun.Text);

            // Kırmızı bölgedeyse puan ekle, değilse puan azalt
            if (btnOyun.ForeColor == Color.Red)
            {
                puan += butonSayisi;
            }
            else
            {
                puan -= butonSayisi;
            }

            // Puan label'ını güncelle
            lblPuan.Text = "Puan: " + puan;

            // Puan 100'e ulaştıysa oyunu durdur ve mesaj göster
            if (puan >= 100)
            {
                timer.Stop();
                MessageBox.Show("Tebrikler! Başardınız!", "Kazandınız", MessageBoxButtons.OK, MessageBoxIcon.Information);
                puan = 0;
                lblPuan.Text = "Puan: " + puan;
                timer.Start();
            }

            // Hemen yeni konuma geç
            YeniKonumAyarla();
        }
    }
}