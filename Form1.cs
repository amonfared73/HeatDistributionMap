using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //RGB Generator
        struct RGB
        {
            public Int32 num;
            public int red;
            public int green;
            public int blue;

            public RGB(Int32 num)
            {
                int[] color = new int[3];
                int i = 2;
                while (num > 0)
                {
                    color[i] = num % 256;
                    num = num - color[i];
                    num = num / 256;
                    i--;
                }
                this.red = color[0];
                this.green = color[1];
                this.blue = color[2];
                this.num = (256 * 256) * color[0] + 256 * color[1] + color[2];
            }
        }
        //2D array initial value
        static void initial_value(double[,] arr, double init)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = init;
                }
            }
        }
        //Copy all elements in a 2D array into another one
        static void Array_Copy(double[,] arr1, double[,] arr2)
        {
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr2[i, j] = arr1[i, j];
                }
            }
        }
        //Find The Highest Element in a 2D Array
        static double TwoDArrayMax(double[,] arr)
        {
            double max = -273;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                double[] arr_each_row = new double[arr.GetLength(1)];
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr_each_row[j] = arr[i, j];
                }
                if (arr_each_row.Max() > max)
                {
                    max = arr_each_row.Max();
                }
            }
            return max;
        }
        //Find The Smallest Element in a 2D Array
        static double TwoDArrayMin(double[,] arr)
        {
            double min = TwoDArrayMax(arr);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                double[] arr_each_row = new double[arr.GetLength(1)];
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr_each_row[j] = arr[i, j];
                }
                if (arr_each_row.Min() < min)
                {
                    min = arr_each_row.Min();
                }
            }
            return min;
        }
        private void Button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X,e.Y);
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/amonfared73");
        }

        private void Button_clear_Click(object sender, EventArgs e)
        {
            textBox_width.Text = "";
            textBox_height.Text = "";
            textBox_Gridpoints.Text = "";
            textBox_initialT.Text = "";
            textBox_topT.Text = "";
            textBox_rightT.Text = "";
            textBox_bottomT.Text = "";
            textBox_leftT.Text = "";
            pictureBox1.Image = null;
            label_min.Text = "";
            label_max.Text = "";
            loops.Text = "";
        }

        private void Button_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_compute_Click(object sender, EventArgs e)
        {
            // Plate and Gridpoints
            double Width = double.Parse(textBox_width.Text);
            double Height = double.Parse(textBox_height.Text);
            int Nx = int.Parse(textBox_Gridpoints.Text) + 2;
            int Ny = Nx;
            double dx = Width / (Convert.ToDouble(Nx) - 2);
            double dy = Height / (Convert.ToDouble(Ny) - 2);

            //Temperatures
            double T_initial = double.Parse(textBox_initialT.Text) + 273;
            double T_top = double.Parse(textBox_topT.Text) + 273;
            double T_right = double.Parse(textBox_rightT.Text) + 273;
            double T_bottom = double.Parse(textBox_bottomT.Text) + 273;
            double T_left = double.Parse(textBox_leftT.Text) + 273;

            //Refrence Temperature array
            double[,] T_old = new double[Nx, Ny];
            initial_value(T_old, T_initial);

            //Boundary Conditions
            for (int b1 = 0; b1 < Ny; b1++)
            {
                T_old[0, b1] = T_top;
            }
            for (int b2 = 0; b2 < Nx; b2++)
            {
                T_old[b2, Ny - 1] = T_right;
            }
            for (int b3 = 0; b3 < Ny; b3++)
            {
                T_old[Nx - 1, b3] = T_bottom;
            }
            for (int b4 = 0; b4 < Nx; b4++)
            {
                T_old[b4, 0] = T_left;
            }

            //Refining Edges
            T_old[0, 0] = (T_top + T_left) / 2;
            T_old[0, Nx - 1] = (T_top + T_right) / 2;
            T_old[Nx - 1, Ny - 1] = (T_right + T_bottom) / 2;
            T_old[Ny - 1, 0] = (T_bottom + T_left) / 2;

            //Temperature Distribution Essentials
            double[,] T_new = new double[Nx, Nx];
            Array_Copy(T_old, T_new);
            double term1, term2;
            double k = 2 * (1 / Math.Pow(dx, 2) + 1 / Math.Pow(dy, 2));
            double error = Math.Pow(10, 8);
            double tol = Math.Pow(10, -4);
            int counter = 0;

            //Calculate Temperature Distribution
            while (error > tol)
            {
                for (int x = 1; x <= Nx - 2; x++)
                {
                    for (int y = 1; y <= Ny - 2; y++)
                    {
                        term1 = (T_old[x - 1, y] + T_old[x + 1, y]) / (k * Math.Pow(dx, 2));
                        term2 = (T_old[x, y + 1] + T_old[x, y - 1]) / (k * Math.Pow(dy, 2));
                        T_new[x, y] = term1 + term2;
                    }
                }
                double[,] T_tol = new double[Nx, Ny];
                for (int m = 0; m < Nx; m++)
                {
                    for (int n = 0; n < Ny; n++)
                    {
                        T_tol[m, n] = Math.Abs(T_old[m, n] - T_new[m, n]);
                    }
                }
                error = TwoDArrayMax(T_tol);
                Array_Copy(T_new, T_old);
                counter++;
            }
            double T_max = TwoDArrayMax(T_new) - 273;
            double T_min = TwoDArrayMin(T_new) - 273;

            //Convert Kelvin to Celecius
            for (int l = 0; l < Nx; l++)
            {
                for (int m = 0; m < Ny; m++)
                {
                    T_new[l, m] = Math.Round(T_new[l, m] - 273, 1);
                }
            }

            //Create Color Array
            Int32 red = 16711680;
            Int32 blue = 255;
            Int32[,] decimalColor = new Int32[Nx, Ny];
            for (int i = 0; i < Nx; i++)
            {
                for (int j = 0; j < Ny; j++)
                {
                    double alpha = (T_new[i, j] - T_min) / (T_max - T_min);
                    double C = alpha * (red - blue);
                    decimalColor[i, j] = Convert.ToInt32(C) + blue;
                }
            }

            //Bitmap Result
            Bitmap bmp = new Bitmap(Nx, Ny);
            for (int i = 0; i < Nx; i++)
            {
                for (int j = 0; j < Ny; j++)
                {
                    RGB rgb = new RGB(decimalColor[i, j]);
                    bmp.SetPixel(i,j,Color.FromArgb(rgb.red,rgb.green,rgb.blue));
                }
            }
            pictureBox1.Image = bmp;

            //Results
            label_min.Text = "Minimum Temperature is " + T_min + " [C]";
            label_max.Text = "Maximum Temperature is " + T_max + " [C]";
            loops.Text = "Calculated by " + counter + " times Gauss Seidel Iterations";

        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            Bitmap final = (Bitmap)pictureBox1.Image;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            final.Save(path + "\\result.png");
        }
    }
}
