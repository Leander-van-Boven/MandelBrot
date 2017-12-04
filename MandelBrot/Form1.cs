using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MandelBrot
{
    public partial class Mandelform : Form
    {
        public Mandelform()
        {
            InitializeComponent();

        }

        //private double startX, startY, curX, curY;
        private double m_Xmin, m_Xmax, m_Ymin, m_Ymax;

        public int MaxHerhalingen;
        public int zoom;
        //public double Zr, Zim, Z2r, Z2im;

        private Bitmap MandelBit;

        private const double minX = -2.2;
        private const double maxX = 1;
        private const double minY = -1.2;
        private const double maxY = 1.2;

        private void AdjustAspect()
        {
            double hgt, wid, mid;

            double want_aspect = (m_Ymax - m_Ymin) / (m_Xmax - m_Xmin);
            double picCanvas_aspect = MandelPic.ClientSize.Height / (double)MandelPic.ClientSize.Width;
            if (want_aspect > picCanvas_aspect)
            {
                // The selected area is too tall and thin.
                // Make it wider.
                wid = (m_Ymax - m_Ymin) / picCanvas_aspect;
                mid = (m_Xmin + m_Xmax) / 2;
                m_Xmin = mid - wid / 2;
                m_Xmax = mid + wid / 2;
            }
            else
            {
                // The selected area is too short and wide.
                // Make it taller.
                hgt = (m_Xmax - m_Xmin) * picCanvas_aspect;
                mid = (m_Ymin + m_Ymax) / 2;
                m_Ymin = mid - hgt / 2;
                m_Ymax = mid + hgt / 2;
            }
        }

        public void OK_Click(object sender, EventArgs e)
        {
            MaxHerhalingen = int.Parse(Herhalingen.Text);
            zoom = int.Parse(Zoom.Text);
            DrawMandel();
        }

        private void DrawMandel()
        {
            const int maxd = 4;
            MandelBit = new Bitmap(MandelPic.Width, MandelPic.Height);
            Graphics gr = Graphics.FromImage(MandelBit);

            gr.Clear(MandelPic.BackColor);
            MandelPic.Image = MandelBit;
            Application.DoEvents();

            AdjustAspect();
           
            int wid = MandelPic.Width;
            int hgt = MandelPic.Height;
            double dReaC = (m_Xmax - m_Xmin) / (wid - 1);
            double dImaC = (m_Ymax - m_Ymin) / (hgt - 1);

            //int num_colors = Colors.Count;
            double ReaC = m_Xmin;
            for (int X = 0; X < wid; X++)
            {
                double ImaC = m_Ymin;
                for (int Y = 0; Y < hgt; Y++)
                {
                    double ReaZ = 0; //Zr;
                    double ImaZ = 0; //Zim;
                    double ReaZ2 = 0; //Z2r;
                    double ImaZ2 = 0; //Z2im;
                    int it = 1;
                    do
                    {
                        // Calculate Z(clr).
                        ReaZ2 = ReaZ * ReaZ;
                        ImaZ2 = ImaZ * ImaZ;
                        ImaZ = 2 * ImaZ * ReaZ + ImaC;
                        ReaZ = ReaZ2 - ImaZ2 + ReaC;
                        it++;
                    } while ((it < MaxHerhalingen) && (ReaZ2 + ImaZ2 < maxd));
                    //Console.WriteLine(ImaZ + "+" + ReaZ);
                    // Set the pixel's value.
                    if (it < MaxHerhalingen)
                        if (it % 2 != 0)
                            MandelBit.SetPixel(X, Y, Color.Black);
                        else
                            MandelBit.SetPixel(X, Y, Color.White);
                    else
                        MandelBit.SetPixel(X, Y, Color.Blue);

                    ImaC += dImaC;
                }
                ReaC += dReaC;

                if (X % 10 == 0) MandelPic.Refresh();
            }

        }


    }
}
