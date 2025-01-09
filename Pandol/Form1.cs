namespace Pandol
{

    public partial class Form1 : Form
    {
        private int x = 200;
        private int y = 200;
        private int radius = 100;
        private int centerX = 200;
        private int centerY = 50;
        private bool flag = true;
        public Form1()
        {
            InitializeComponent();
        }





        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillEllipse(Brushes.Black, centerX - 5, centerY - 5, 10, 10);
            Pen pen = new Pen(Color.Black, 2);
            g.DrawLine(pen, centerX, centerY, x, y);
            g.FillEllipse(Brushes.Black, x - 10, y - 10, 20, 20);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (flag)
            {
                x += 5;
                if (x >= centerX + radius)
                {
                    flag = false;
                }
            }
            else
            {
                x -= 5;
                if (x <= centerX - radius)
                {
                    flag = true;
                }
            }

            y = centerY + (int)Math.Sqrt(radius * radius - (x - centerX) * (x - centerX));
            Invalidate();
        }
    }
}
