using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics_package
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static void multiply(int[,] mat1,
                        int[,] mat2, int[,] res)
        {
            int N = 3;
            int i, j, k;
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    res[i, j] = 0;
                    for (k = 0; k < N; k++)
                        res[i, j] += mat1[i, k]
                                     * mat2[k, j];
                }
            }
        }
        private void ddaPlotPoints(float x, float y)
        {
            var aBrush = Brushes.Yellow;
            var g = panel1.CreateGraphics();

            g.FillRectangle(aBrush, 144 + x, 160 - y, 3, 3);

        }

        void lineDDA(int x0, int y0, int xEnd, int yEnd)

        {
            int xInitial = x0, yInitial = y0, xFinal = xEnd, yFinal = yEnd;
            int dx = xFinal - xInitial, dy = yFinal - yInitial, steps, k, xf, yf;
            float xIncrement, yIncrement, x = xInitial, y = yInitial;

            if (Math.Abs(dx) > Math.Abs(dy)) steps = Math.Abs(dx);
            else steps = Math.Abs(dy);

            xIncrement = dx / (float)steps;
            yIncrement = dy / (float)steps;

            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                xf = (int)x;
                y += yIncrement;
                yf = (int)y;

                try
                {
                    ddaPlotPoints(x, y);

                }
                catch (InvalidOperationException)
                {
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(textBox1.Text);
            int y1 = Convert.ToInt32(textBox2.Text);
            int x2 = Convert.ToInt32(textBox3.Text);
            int y2 = Convert.ToInt32(textBox4.Text);
            this.Refresh();
            label20.Visible = true;
            label21.Visible = true;
            lineDDA(x1, y1, x2, y2);

        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            //   e.Graphics.TranslateTransform(200.0F, 200.0F, MatrixOrder.Append);

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(textBox5.Text);
            int y1 = Convert.ToInt32(textBox6.Text);
            int x2 = Convert.ToInt32(textBox7.Text);
            int y2 = Convert.ToInt32(textBox8.Text);


            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);
            if (dx > dy)
            {
                bresenhamLine(x1, y1, x2, y2, dx, dy, 0);
            }
            else
            {
                bresenhamLine(y1, x1, y2, x2, dx, dy, 1);
            }

        }
        private void BLAPlotPoints(int x, int y)
        {
            var aBrush = Brushes.Yellow;
            var g = panel1.CreateGraphics();


            g.FillRectangle(aBrush, 144 + x, 160 - y, 3, 3);


        }

        private void bresenhamLine(int x1, int y1, int x2, int y2, int dx, int dy, int decide)
        {
            int pk = 2 * dy - dx;
            for (int i = 0; i <= dx - 1; i++)
            {
                if (x1 < x2) x1++;
                else x1--;

                if (pk < 0)
                {
                    if (decide == 0)
                    {
                        BLAPlotPoints(x1, y1);
                        pk = pk + 2 * dy;
                    }
                    else
                    {
                        BLAPlotPoints(y1, x1);
                        pk = pk + 2 * dy;
                    }
                }
                else
                {
                    if (y1 < y2) y1++;
                    else y1--;
                    if (decide == 0)
                    {

                        BLAPlotPoints(x1, y1);
                    }
                    else
                    {
                        BLAPlotPoints(y1, x1);
                    }
                    pk = pk + 2 * dy - 2 * dx;
                }
            }
        }




        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(textBox9.Text);
            int y1 = Convert.ToInt32(textBox10.Text);
            int radiusss = Convert.ToInt32(textBox11.Text);
            this.Refresh();            label20.Visible = true;
            label21.Visible = true;
            circleMidpoint(x1, y1, radiusss);
        }
      

        void circleMidpoint(int xCenter, int yCenter, int radius)
        {
            int x = 0;
            int y = radius;
            int p = 1 - radius;
            circlePlotPoints(xCenter, yCenter, x, y);
            while (x < y)
            {
                x++;
                if (p < 0)
                    p += 2 * x + 1;

                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
                circlePlotPoints(xCenter, yCenter, x, y);
            }
        }
        void circlePlotPoints(int xCenter, int yCenter, int x, int y)
        {
            var aBrush = Brushes.Yellow;
            var g = panel1.CreateGraphics();

            g.FillRectangle(aBrush, 144 + (xCenter + x), 160 - (yCenter + y), 3, 3);
            g.FillRectangle(aBrush, 144 + (xCenter - x), 160 - (yCenter + y), 3, 3);
            g.FillRectangle(aBrush, 144 + (xCenter + x), 160 - (yCenter - y), 3, 3);
            g.FillRectangle(aBrush, 144 + (xCenter - x), 160 - (yCenter - y), 3, 3);
            g.FillRectangle(aBrush, 144 + (xCenter + y), 160 - (yCenter + x), 3, 3);
            g.FillRectangle(aBrush, 144 + (xCenter - y), 160 - (yCenter + x), 3, 3);
            g.FillRectangle(aBrush, 144 + (xCenter + y), 160 - (yCenter - x), 3, 3);
            g.FillRectangle(aBrush, 144 + (xCenter - y), 160 - (yCenter - x), 3, 3);

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int x1 = Convert.ToInt32(textBox12.Text);
            double k = Convert.ToDouble(textBox13.Text);
            double b = Convert.ToDouble(textBox14.Text);
            int x2 = Convert.ToInt32(textBox15.Text);
            int y1, y2;
            y1 = getY(x1, k, b);
            y2 = getY(x2, k, b);
            this.Refresh();
            label20.Visible = true;
            label21.Visible = true;
            lineSPS(x1, y1, x2, y2);
        }

        int getY(int x, double k, double b)
        {
            double y = 0;
            y = k * x + b;
            return (int)y;
        }

        private void spsPlotPoints(float x, float y)
        {
            var aBrush = Brushes.Yellow;
            var g = panel1.CreateGraphics();

            g.FillRectangle(aBrush, 144 + x, 160 - y, 3, 3);

        }

        void lineSPS(int x0, int y0, int xEnd, int yEnd)

        {
            int xInitial = x0, yInitial = y0, xFinal = xEnd, yFinal = yEnd;
            int dx = xFinal - xInitial, dy = yFinal - yInitial, steps, k, xf, yf;
            float xIncrement, yIncrement, x = xInitial, y = yInitial;

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else steps = Math.Abs(dy);

            xIncrement = dx / (float)steps;
            yIncrement = dy / (float)steps;

            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                xf = (int)x;
                y += yIncrement;
                yf = (int)y;

                try
                {
                    spsPlotPoints(x, y);

                }
                catch (InvalidOperationException)
                {
                    return;
                }
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }




        private void button12_Click(object sender, EventArgs e)
        {
            panel1.CreateGraphics().Clear(Color.MediumSlateBlue);
            label20.Visible = false;
            label21.Visible = false;
        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void label19_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

