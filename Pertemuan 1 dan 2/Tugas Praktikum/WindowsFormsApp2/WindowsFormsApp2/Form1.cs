using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int[] histogramValue = new int[256];
        int max = 0, histogramValueMaxIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void brigtness_TextChanged(object sender, EventArgs e)
        {

        }
        Bitmap bmpAsli, bmpHasil;      
        private void button1_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt16(textBoxBrigthness.Text);
            int i, j;
            int nilaiR, nilaiG, nilaiB;
            bmpAsli = (Bitmap)PictureBoxAsli.Image;
            int baris = bmpAsli.Width;
            int kolom = bmpAsli.Height;
            bmpHasil = new Bitmap(baris, kolom);
           
            for(i=0;i<baris; i++)
                for (j = 0; j < kolom; j++)
                {
                    nilaiR = bmpAsli.GetPixel(i, j).R + k;
                    nilaiG = bmpAsli.GetPixel(i, j).G + k;
                    nilaiB = bmpAsli.GetPixel(i, j).B + k;
                    if (nilaiR > 255) nilaiR = 255;
                    if (nilaiG > 255) nilaiG = 255;
                    if (nilaiB > 255) nilaiB = 255;
                    if (nilaiR < 0) nilaiR = 0;
                    if (nilaiG < 0) nilaiG = 0;
                    if (nilaiB < 0) nilaiB = 0;
                    bmpHasil.SetPixel(i, j, Color.FromArgb(nilaiR, nilaiG, nilaiB));

                }

            PictureBoxHasil.Image = bmpHasil;
            Cursor = Cursors.Default;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i, j;
            int nilaiR2, nilaiG2, nilaiB2, nilaiA2;
            bmpAsli = (Bitmap)PictureBoxAsli.Image;
            int baris = bmpAsli.Width;
            int kolom = bmpAsli.Height;
            bmpHasil = new Bitmap(baris, kolom);
            Cursor = Cursors.WaitCursor;
            Color p;
            //grayscale
            for (j = 0; j < kolom; j++)
            {
                for (i = 0; i < baris; i++)
                {
                    p = bmpAsli.GetPixel(i, j);
                    nilaiA2 = 255 - p.A;
                    nilaiR2 = 255 - p.R;
                    nilaiG2 = 255 - p.G;
                    nilaiB2 = 255 - p.B;                
                    bmpAsli.SetPixel(i, j, Color.FromArgb(nilaiA2, nilaiR2, nilaiG2, nilaiB2));
                }
                PictureBoxHasil.Image = bmpAsli;
                
                Cursor = Cursors.Default;
            }
        }

        private void PictureBoxAsli_Click(object sender, EventArgs e)
        {

        }

        private void PictureBoxHasil_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt16(textBoxTreshold.Text);
            int i, j;
            int nilaiR2, nilaiG2, nilaiB2;
            bmpAsli = (Bitmap)PictureBoxAsli.Image;
            int baris = bmpAsli.Width;
            int kolom = bmpAsli.Height;
            Color p;
            bmpHasil = new Bitmap(baris, kolom);
            Cursor = Cursors.WaitCursor;

            for (j = 0; j < kolom; j++)
            {
                for (i = 0; i < baris; i++)
                {
                    p = bmpAsli.GetPixel(i, j);
                    nilaiR2 = p.R;
                    nilaiG2 = p.G;
                    nilaiB2 = p.B;
                    if (nilaiB2 < t && nilaiG2 < t && nilaiR2 < t)
                    {
                        nilaiR2 = 0;
                        nilaiG2 = 0;
                        nilaiB2 = 0;
                    }
                    else
                    {
                        nilaiR2 = 255;
                        nilaiG2 = 255;
                        nilaiB2 = 255;
                    }
                    bmpAsli.SetPixel(i, j, Color.FromArgb(nilaiR2, nilaiG2, nilaiB2));


                }
                PictureBoxHasil.Image = bmpHasil;
                bmpHasil = bmpAsli;
                Cursor = Cursors.Default;
            }
        }

        private void textBoxTreshold_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.bmp)|*.jpg; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                PictureBoxAsli.Image = new Bitmap(open.FileName);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        Bitmap bmp;
        private void button7_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(textBoxX.Text);
            int y = Convert.ToInt16(textBoxY.Text);
            bmp = (Bitmap)PictureBoxAsli.Image;
            int r = bmp.GetPixel(x, y).R;
            int g = bmp.GetPixel(x, y).G;
            int b = bmp.GetPixel(x, y).B;
            textBoxR.Text = r.ToString();
            textBoxG.Text = g.ToString();
            textBoxB.Text = b.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int i, j;
            int convert;
            double avg;
            int nilaiR2, nilaiG2, nilaiB2, nilaiA2;
            bmpAsli = (Bitmap)PictureBoxAsli.Image;
            int baris = bmpAsli.Width;
            int kolom = bmpAsli.Height;
            bmpHasil = new Bitmap(baris, kolom);
            Cursor = Cursors.WaitCursor;
            Color p;
            //grayscale
            for (j = 0; j < kolom; j++)
            {
                for (i = 0; i < baris; i++)
                {
                    p = bmpAsli.GetPixel(i, j);
                  
                    nilaiR2 = p.R;
                    nilaiG2 = p.G;
                    nilaiB2 = p.B;

                    avg = ( 0.2126 * nilaiR2 + nilaiG2 * 0.7152 + 0.0722 * nilaiB2);

                    convert = Convert.ToInt16(avg);

                    bmpAsli.SetPixel(i, j, Color.FromArgb(convert, convert, convert));

                }
                pembobotan.Image = bmpAsli;

                Cursor = Cursors.Default;
            }
        }

        private void pembobotan_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            bmpAsli = (Bitmap)PictureBoxHasil.Image;

            int baris = bmpAsli.Width;
            int kolom = bmpAsli.Height;
            bmpHasil = new Bitmap(baris, kolom);

            float sum = 0;
            int grayscale;
            float[] lut = new float[256];
            float scaleFactor = max / (bmpAsli.Height * bmpAsli.Width);

            for (int i = 0; i < histogramValue.Length; i++)
            {
                sum += histogramValue[i];
                lut[i] = sum * 255 / (bmpAsli.Height * bmpAsli.Width);

               
                
            }

            for (int i = 0; i < bmpAsli.Width; i++)
            {
                for (int j = 0; j < bmpAsli.Height; j++)
                {
                    grayscale = bmpAsli.GetPixel(i, j).R;
                    int resultPixel = (int)lut[grayscale];
                    if (resultPixel > 255)
                        resultPixel = 255;
                    else if (resultPixel < 0)
                        resultPixel = 0;

                    bmpHasil.SetPixel(i, j, Color.FromArgb(resultPixel, resultPixel, resultPixel));

                }
            }
                     
            pictureBoxEqualization.Image = bmpHasil;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void PictureBoxHasil_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxX3.Text = textBoxX2.Text;
            kotakR2.Text = kotakR.Text;
            kotakG2.Text = kotakG.Text;
            kotakB2.Text = kotakB.Text;
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void PictureBoxHasil_MouseMove(object sender, MouseEventArgs e)
        {
            bool isPictureBoxHasilNullOrEmpty = PictureBoxHasil == null || PictureBoxHasil.Image == null;
            if (!isPictureBoxHasilNullOrEmpty)
            {
                textBoxX2.Text = e.X.ToString() + ", " + e.Y.ToString();

                bmpHasil = (Bitmap)PictureBoxHasil.Image;
                int r = bmpHasil.GetPixel(e.X, e.Y).R;
                int g = bmpHasil.GetPixel(e.X, e.Y).G;
                int b = bmpHasil.GetPixel(e.X, e.Y).B;
                kotakR.Text = r.ToString();
                kotakG.Text = g.ToString();
                kotakB.Text = b.ToString();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i, j;
            bmpAsli = (Bitmap)PictureBoxAsli.Image;
           
            int baris = bmpAsli.Width;
            int kolom = bmpAsli.Height;
            bmpHasil = new Bitmap(baris, kolom);
            int grayscale;
            Cursor = Cursors.WaitCursor;
            for (j = 0; j < kolom; j++)
            {
                for (i = 0; i < baris; i++)
                {
                    grayscale = (
                        bmpAsli.GetPixel(i, j).R +
                        bmpAsli.GetPixel(i, j).G +
                        bmpAsli.GetPixel(i, j).B
                        ) / 3;
                    bmpHasil.SetPixel(i, j, Color.FromArgb(grayscale, grayscale, grayscale));


                    histogramValue[grayscale]++;
                    if (max < histogramValue[grayscale])
                    {
                        max = histogramValue[grayscale];
                        histogramValueMaxIndex = grayscale;
                    }
                }
                PictureBoxHasil.Image = bmpHasil;

                Cursor = Cursors.Default;
            }
            int histHeight = 236;
            Bitmap data = new Bitmap(256, histHeight + 10);
            float pct;

            using (Graphics g = Graphics.FromImage(data))
            {
                for (int v = 0; v < 256; v++)
                {
                    pct = (histogramValue[v] * histHeight) / max;   // What percentage of the max is this value
                    g.DrawLine(Pens.Black,
                        new Point(v, histHeight),
                        new Point(v, histHeight - (int)Math.Round(pct))  // Use that percentage of the height
                        );
                }
            }
            pictureBoxHistogram.Image = data;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int i, j;
            int nilaiR2, nilaiG2, nilaiB2, nilaiA2;
            bmpAsli = (Bitmap)PictureBoxAsli.Image;
            int baris = bmpAsli.Width;
            int kolom = bmpAsli.Height;
            bmpHasil = new Bitmap(baris, kolom);
            Cursor = Cursors.WaitCursor;
            Color p;
            //grayscale
            for (j = 0; j < kolom; j++)
            {
                for (i = 0; i < baris; i++)
                {
                    p = bmpAsli.GetPixel(i, j);
                    nilaiA2 = p.A;
                    nilaiR2 = p.R;
                    nilaiG2 = p.G;
                    nilaiB2 = p.B;

                    int avg = (nilaiR2 + nilaiG2 + nilaiB2) / 3;

                    bmpAsli.SetPixel(i, j, Color.FromArgb(nilaiA2, avg, avg, avg));

                }
                PictureBoxHasil.Image = bmpAsli;
                
                Cursor = Cursors.Default;
            }
        }
    }
}
