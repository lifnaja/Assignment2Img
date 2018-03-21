using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        private Bitmap f_image = null;
        public Bitmap image;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileImage = new OpenFileDialog();
            OpenFileImage.Filter = "bitmap(*.bmp) | *.bmp";
            OpenFileImage.FilterIndex = 1;
            if (OpenFileImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (f_image != null)
                        f_image.Dispose();
                    f_image =
                    (Bitmap)Bitmap.FromFile(OpenFileImage.FileName, false);

                }
                catch (Exception)
                {
                    MessageBox.Show("Can not open file", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            pictureBox1.Image = f_image;
           
            int[,] colorPic = new int[f_image.Width, f_image.Height];
            // Loop through the images pixels
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    Color PixelColor = f_image.GetPixel(i, j);
                    int C_gray = (int)(PixelColor.R + PixelColor.G +
                    PixelColor.B) / 3;
                    colorPic[i, j] = C_gray;
                }
            }
        }

        public int[,] colorInArray()
        {
            int[,] colorPic = new int[f_image.Width, f_image.Height];
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    Color PixelColor = f_image.GetPixel(i, j);
                    int C_gray = (int)(PixelColor.R + PixelColor.G +
                    PixelColor.B) / 3;
                    colorPic[i, j] = C_gray;
                }
            }
            return colorPic;
        }
        

        private void btn_Max_Click(object sender, EventArgs e)
        {
            image = new Bitmap(f_image.Width, f_image.Height);
            int[,] colorPic = new int[f_image.Width, f_image.Height];
            colorPic = colorInArray();
            int newColor;
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    if (i == 0 || j == 0 || i == f_image.Width-1 || j == f_image.Height - 1)
                    {
                        image.SetPixel(i, j, Color.FromArgb(colorPic[i, j], colorPic[i, j], colorPic[i, j]));
                    }
                    else
                    {
                        /* i - 1, j - 1 ;
                         i - 1, j,
                         i - 1, j + 1
                         i    , j - 1
                         i    , j
                         i    , j + 1
                         i + 1, j - 1
                         i + 1, j 
                         i + 1, j + 1
                         */

                        newColor = Math.Max(colorPic[i-1,j-1], colorPic[i-1,j]);
                        newColor = Math.Max(newColor, colorPic[i - 1, j + 1]);
                        newColor = Math.Max(newColor, colorPic[i, j - 1]);
                        newColor = Math.Max(newColor, colorPic[i, j]);
                        newColor = Math.Max(newColor, colorPic[i, j + 1]);
                        newColor = Math.Max(newColor, colorPic[i + 1, j - 1]);
                        newColor = Math.Max(newColor, colorPic[i + 1, j]);
                        newColor = Math.Max(newColor, colorPic[i + 1, j + 1]);
 
                        image.SetPixel(i, j, Color.FromArgb(newColor, newColor, newColor));
                    }

                        
                }
            }
            pictureBox2.Image = image;
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            image = new Bitmap(f_image.Width, f_image.Height);
            int[,] colorPic = new int[f_image.Width, f_image.Height];
            colorPic = colorInArray();
            int newColor;
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    if (i == 0 || j == 0 || i == f_image.Width - 1 || j == f_image.Height - 1)
                    {
                        image.SetPixel(i, j, Color.FromArgb(colorPic[i, j], colorPic[i, j], colorPic[i, j]));
                    }
                    else
                    {
                        newColor = Math.Min(colorPic[i - 1, j - 1], colorPic[i - 1, j]);
                        newColor = Math.Min(newColor, colorPic[i - 1, j + 1]);
                        newColor = Math.Min(newColor, colorPic[i, j - 1]);
                        newColor = Math.Min(newColor, colorPic[i, j]);
                        newColor = Math.Min(newColor, colorPic[i, j + 1]);
                        newColor = Math.Min(newColor, colorPic[i + 1, j - 1]);
                        newColor = Math.Min(newColor, colorPic[i + 1, j]);
                        newColor = Math.Min(newColor, colorPic[i + 1, j + 1]);

                        image.SetPixel(i, j, Color.FromArgb(newColor, newColor, newColor));
                    }


                }
            }
            pictureBox2.Image = image;
        }

        private void btn_Midpoint_Click(object sender, EventArgs e)
        {
            image = new Bitmap(f_image.Width, f_image.Height);
            int[,] colorPic = new int[f_image.Width, f_image.Height];
            colorPic = colorInArray();
            int minColor,maxColor,newColor;
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    if (i == 0 || j == 0 || i == f_image.Width - 1 || j == f_image.Height - 1)
                    {
                        image.SetPixel(i, j, Color.FromArgb(colorPic[i, j], colorPic[i, j], colorPic[i, j]));
                    }
                    else
                    {
                        minColor = Math.Min(colorPic[i - 1, j - 1], colorPic[i - 1, j]);
                        minColor = Math.Min(minColor, colorPic[i - 1, j + 1]);
                        minColor = Math.Min(minColor, colorPic[i, j - 1]);
                        minColor = Math.Min(minColor, colorPic[i, j]);
                        minColor = Math.Min(minColor, colorPic[i, j + 1]);
                        minColor = Math.Min(minColor, colorPic[i + 1, j - 1]);
                        minColor = Math.Min(minColor, colorPic[i + 1, j]);
                        minColor = Math.Min(minColor, colorPic[i + 1, j + 1]);

                        maxColor = Math.Max(colorPic[i - 1, j - 1], colorPic[i - 1, j]);
                        maxColor = Math.Max(maxColor, colorPic[i - 1, j + 1]);
                        maxColor = Math.Max(maxColor, colorPic[i, j - 1]);
                        maxColor = Math.Max(maxColor, colorPic[i, j]);
                        maxColor = Math.Max(maxColor, colorPic[i, j + 1]);
                        maxColor = Math.Max(maxColor, colorPic[i + 1, j - 1]);
                        maxColor = Math.Max(maxColor, colorPic[i + 1, j]);
                        maxColor = Math.Max(maxColor, colorPic[i + 1, j + 1]);

                        newColor = (minColor + maxColor) / 2;
                        image.SetPixel(i, j, Color.FromArgb(newColor, newColor, newColor));
                    }
                }
            }
            pictureBox2.Image = image;
        }

        private void btn_Alpha_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt16(txt_d.Text);
            image = new Bitmap(f_image.Width, f_image.Height);
            int[,] colorPic = new int[f_image.Width, f_image.Height];
            colorPic = colorInArray();
   
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    if (i == 0 || j == 0 || i == f_image.Width - 1 || j == f_image.Height - 1)
                    {
                        image.SetPixel(i, j, Color.FromArgb(colorPic[i, j], colorPic[i, j], colorPic[i, j]));
                    }
                    else
                    {
                        int[] values = { colorPic[i-1,j-1],colorPic[i-1, j],colorPic[i-1, j+1],
                            colorPic[i, j-1],colorPic[i, j],colorPic[i, j+1],
                            colorPic[i+1, j-1], colorPic[i+1, j], colorPic[i+1, j+1] };

                        Array.Sort(values);
                        int sum = 0;
                        int pop = d / 2;
                        for (int k = pop; k < values.Length - pop; k++)
                        {
                            sum += values[k];
                        }
                        sum = sum / (9-d);
                        image.SetPixel(i, j, Color.FromArgb(sum, sum, sum));
                    }

                }
            }
            pictureBox2.Image = image;
        }

        private void btn_CHMF_Click(object sender, EventArgs e)
        {
           
            int q = Convert.ToInt32(txt_Q.Text);

            image = new Bitmap(f_image.Width, f_image.Height);
            int[,] colorPic = new int[f_image.Width, f_image.Height];
            colorPic = colorInArray();

            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    if (i == 0 || j == 0 || i == f_image.Width - 1 || j == f_image.Height - 1)
                    {
                        image.SetPixel(i, j, Color.FromArgb(colorPic[i, j], colorPic[i, j], colorPic[i, j]));
                    }
                    else
                    {
                        double sumtop = 0, sumbot = 0;
                        int newColor = 0;
                        for (int x = i-1; x <= i; x++)
                        {
                            for (int y = j-1; y <=j; y++)
                            {
                                Color PixelColor = f_image.GetPixel(x, y);
                                int C_gray = (int)(PixelColor.R + PixelColor.G + PixelColor.B) / 3;
                                if (C_gray != 0)
                                {
                                    sumbot += (double)Math.Pow(C_gray, q);
                                    sumtop += (double)Math.Pow(C_gray, q + 1);
                                }
                            }
                        }

                        try
                        {
                            newColor = Convert.ToInt32(Math.Round(sumtop / sumbot));
                            
                        }
                        catch(Exception ex)
                        {
                            newColor = 0;
                        }
 
                        image.SetPixel(i, j, Color.FromArgb(newColor, newColor, newColor));
                    }

                }
            }
            pictureBox2.Image = image;
            
        }
    }
    
}
