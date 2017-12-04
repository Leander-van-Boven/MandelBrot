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

        
        public int MaxIterations;
        public double zoom;
        public double xMidden;
        public double yMidden;

        private Bitmap MandelBit;
        public List<Color> Colors = new List<Color>();

        private double minX = -2.5;
        private double maxX = -2.5;
        private double minY = -2.5;
        private double maxY = 2.5;

        double m_Xmin;
        double m_Xmax;
        double m_Ymin;
        double m_Ymax;
        int it;

        private void AdjustAspect()
        {
            double hgt, wid, mid;

            double want_aspect = (m_Ymax - m_Ymin) / (m_Xmax - m_Xmin);
            double picCanvas_aspect = MandelPic.ClientSize.Height / (double)MandelPic.ClientSize.Width;
            if (want_aspect > picCanvas_aspect)
            {
                // The selected area is too tall and thin.
                wid = (m_Ymax - m_Ymin) / picCanvas_aspect;
                mid = (m_Xmin + m_Xmax) / 2;
                m_Xmin = mid - wid / 2;
                m_Xmax = mid + wid / 2;
            }
            else
            {
                // The selected area is too short and wide.
                hgt = (m_Xmax - m_Xmin) * picCanvas_aspect;
                mid = (m_Ymin + m_Ymax) / 2;
                m_Ymin = mid - hgt / 2;
                m_Ymax = mid + hgt / 2;
            }
        }

        public void Draw_Click(object sender, EventArgs e)
        {
            zoom = double.Parse(ZoomScale.Text);

            Mid_Zoom();
            DrawMandel();
        }

        private void Mid_Zoom()
        {
            xMidden = double.Parse(xMid.Text);
            yMidden = double.Parse(yMid.Text);

            m_Xmin = xMidden - ((1 / zoom) * (maxX - minX)) / 2;
            m_Xmax = xMidden + ((1 / zoom) * (maxX - minX)) / 2;
            m_Ymin = yMidden - ((1 / zoom) * (maxY - minY)) / 2;
            m_Ymax = yMidden + ((1 / zoom) * (maxY - minY)) / 2;

            MiddenPuntStatus.Text = ("MidPoint: (" + xMidden + ";" + yMidden + "), Zoom: " + zoom);
        }

        private void DrawMandel()
        {
            const int maxd = 4;
            MaxIterations = int.Parse(Iterations.Text);

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

            int num_colors = Colors.Count;
            double ReaC = m_Xmin;
            for (int X = 0; X < wid; X++)
            {
                double ImaC = m_Ymin;
                for (int Y = 0; Y < hgt; Y++)
                {
                    double ReaZ = 0;
                    double ImaZ = 0;
                    double ReaZ2 = 0;
                    double ImaZ2 = 0;
                    it = 1;
                    while ((it < MaxIterations) && (ReaZ2 + ImaZ2 < maxd))
                    {
                        // Calculate Z(it).
                        ReaZ2 = ReaZ * ReaZ;
                        ImaZ2 = ImaZ * ImaZ;
                        ImaZ = 2 * ImaZ * ReaZ + ImaC;
                        ReaZ = ReaZ2 - ImaZ2 + ReaC;
                        it++;
                    }

                    if (it >= MaxIterations)
                    {
                        MandelBit.SetPixel(X, Y, Color.Black);
                    }
                    else
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            ReaZ = ReaZ2 - ImaZ2 + ReaC;
                            it++;
                        }
                        double mu = it + 1 - Math.Log(Math.Log(ReaZ)) / Math.Log(2);
                        mu = mu / MaxIterations * Colors.Count;
                        MandelBit.SetPixel(X, Y, MandelColor(mu));
                        //MandelBit.SetPixel(X, Y, Colors[it % Colors.Count]);
                    }

                    ImaC += dImaC;
                }
                ReaC += dReaC;

                if (X % 10 == 0) MandelPic.Refresh();
            }

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            DefaultMandel();
        }

        private void MandelFormLoad(object sender, EventArgs e)
        {
            m_Xmin = minX;
            m_Xmax = maxX;
            m_Ymin = minY;
            m_Ymax = maxY;
            MandelPic.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
            Reset.Location = new Point(this.ClientSize.Width - 30 - Reset.Size.Width, 0);
            Draw.Location = new Point(this.ClientSize.Width - 30 - Reset.Size.Width - 10 - Draw.Size.Width, 0);

            Colors.Add(Color.Red);
            Colors.Add(Color.Yellow);
            Colors.Add(Color.Violet);
            Colors.Add(Color.Orange);
            Colors.Add(Color.LimeGreen);
            Colors.Add(Color.DeepSkyBlue);
            Colors.Add(Color.Gray);
            Colors.Add(Color.Blue);

            DefaultMandel();
            Application.DoEvents();
        }

        private void SizeChange(object sender, EventArgs e)
        {
            MandelPic.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
            Reset.Location = new Point(this.ClientSize.Width - 30 - Reset.Size.Width, 0);
            Draw.Location = new Point(this.ClientSize.Width - 30 - Reset.Size.Width - 10 - Draw.Size.Width, 0);
        }

        private void DefaultMandel()
        {
            xMid.Text = "0";
            yMid.Text = "0";
            ZoomScale.Text = "1";
            Iterations.Text = "100";
            minX = -2.5;
            maxX = 2;
            minY = -1.2;
            maxY = 1.2;
            Mid_Zoom();
            DrawMandel();
            Application.DoEvents();
        }

        private void TextBoxEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                zoom = double.Parse(ZoomScale.Text);

                Mid_Zoom();
                DrawMandel();
            }
        }

        private void XmidLabel_Click(object sender, EventArgs e)
        {

        }

        private void xMiddenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void Redraw_Click(object sender, EventArgs e)
        {
            zoom = double.Parse(ZoomScale.Text);

            Mid_Zoom();
            DrawMandel();
        }

        private Color MandelColor(double mu)
        {       
                int input1 = (int)mu;
                double t2 = mu - input1;
                double t1 = 1 - t2;
                input1 = input1 % Colors.Count;
                int input2 = (input1 + 1) % Colors.Count;
                byte r = (byte)(Colors[input1].R * t1 + Colors[input2].R * t2);
                byte g = (byte)(Colors[input1].G * t1 + Colors[input2].G * t2);
                byte b = (byte)(Colors[input1].B * t1 + Colors[input2].B * t2);

                return Color.FromArgb(255, r, g, b);

        }
        
    }

}
