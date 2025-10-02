using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp31
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point startpoint = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startpoint = e.Location;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                button1.Left += e.X - startpoint.X;
                button1.Top += e.Y - startpoint.Y;
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
