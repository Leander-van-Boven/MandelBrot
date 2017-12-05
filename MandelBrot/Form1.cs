using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        public List<Color> DefaultColors = new List<Color>();
        int GetColorCode;
        double EC;

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
            zoom = double.Parse(ZoomScale.Text);

            Mid_Zoom();

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
                        // MandelCalculation
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
                        EC = it + 1 - Math.Log(Math.Log(ReaZ)) / Math.Log(2);
                        EC = EC / MaxIterations * Colors.Count;
                        Color Color = GetColor();
                        MandelBit.SetPixel(X, Y, Color);
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
            Reset.Location = new Point(this.ClientSize.Width - 10 - Help_Button.Size.Width - 10 - Reset.Size.Width, 1);
            Draw.Location = new Point(this.ClientSize.Width - 10 - Help_Button.Size.Width - 10 - Reset.Size.Width - 10 - Draw.Size.Width, 1);
            Help_Button.Location = new Point(this.ClientSize.Width - 10 - Help_Button.Size.Width, 1);

            Colors.Add(Color.SeaGreen);
            Colors.Add(Color.Lime);
            Colors.Add(Color.Violet);
            Colors.Add(Color.OrangeRed);
            Colors.Add(Color.SkyBlue);
            Colors.Add(Color.Yellow);
            Colors.Add(Color.Gray);
            Colors.Add(Color.DarkRed);

            DefaultColors.Add(Color.SeaGreen);
            DefaultColors.Add(Color.Lime);
            DefaultColors.Add(Color.Violet);
            DefaultColors.Add(Color.OrangeRed);
            DefaultColors.Add(Color.SkyBlue);
            DefaultColors.Add(Color.Yellow);
            DefaultColors.Add(Color.Gray);
            DefaultColors.Add(Color.DarkRed);

            DefaultMandel();

            Application.DoEvents();

        }

        private void SizeChange(object sender, EventArgs e)
        {
            MandelPic.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
            Reset.Location = new Point(this.ClientSize.Width - 10 - Help_Button.Size.Width - 10 - Reset.Size.Width, 1);
            Draw.Location = new Point(this.ClientSize.Width - 10 - Help_Button.Size.Width - 10 - Reset.Size.Width - 10 - Draw.Size.Width, 1);
            Help_Button.Location = new Point(this.ClientSize.Width - 10 - Help_Button.Size.Width, 1);
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
            DrawMandel();
            Application.DoEvents();
        }

        private void TextBoxKeyDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                string decimalError = "Use the decimal key instead of the dot key as decimal seperator.";
                string decimalErrorCaption = "Incorrect use of dot key!";
                MessageBox.Show(decimalError, decimalErrorCaption, MessageBoxButtons.OK);

            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                DrawMandel();
            }


        }

        private void Redraw_Click(object sender, EventArgs e)
        {
            DrawMandel();
        }

        private void SaveBit_Click(object sender, EventArgs e)
        {
            if (dlgSaveFile.ShowDialog() == DialogResult.OK)
            {
                MandelBit.Save(dlgSaveFile.FileName);
                string filename = dlgSaveFile.FileName;
                string extension = filename.Substring(filename.LastIndexOf("."));
                switch (extension)
                {
                    case ".bmp":
                        MandelBit.Save(filename, ImageFormat.Bmp);
                        break;
                    case ".jpg":
                    case ".jpeg":
                        MandelBit.Save(filename, ImageFormat.Jpeg);
                        break;
                    case ".gif":
                        MandelBit.Save(filename, ImageFormat.Gif);
                        break;
                    case "png":
                        MandelBit.Save(filename, ImageFormat.Png);
                        break;
                    case ".tif":
                    case ".tiff":
                        MandelBit.Save(filename, ImageFormat.Tiff);
                        break;
                }
            }
        }

        private void Help_Button_Click(object sender, EventArgs e)
        {
            string Help_Button_Text = "-Use the File menu to save your most beautiful MandelFigures (ctrl + s), \r\n" +
                "-Use the variables menu to change variables of the figure (type in the textbox and press Enter, " +
                "or dubble-click somewhere on the picture to zoom on that specific point), \r\n" +
                "-Use the Colors menu to change the colors of your MandelFigure. \r\n" +
                "-On the bottom you can see your current Mid_Point and Zoom level.";
            string Help_Button_Header = "Help";
            MessageBox.Show(Help_Button_Text, Help_Button_Header, MessageBoxButtons.OK);
        }

        private Color GetColor()
        {
            Color ColorCode;

            if (GetColorCode == 1)
            {
                ColorCode = DefaultColors[it % DefaultColors.Count];
                return ColorCode;
            }
            if (GetColorCode == 2)
            {
                ColorCode = ExperimentalMandelColor(EC);
                return ColorCode;
            }
            if (GetColorCode == 3)
            {
                if (it % 2 != 0)
                {
                    ColorCode = Color.Black;
                    return ColorCode;
                }
                else
                {
                    ColorCode = Color.White;
                    return ColorCode;
                }
            }
            if (GetColorCode == 4)
            {
                Colors.Clear();
                Colors.Add(Color.MediumVioletRed);
                Colors.Add(Color.Magenta);
                Colors.Add(Color.Violet);
                Colors.Add(Color.DeepPink);
                Colors.Add(Color.PaleVioletRed);
                Colors.Add(Color.Red);
                Colors.Add(Color.DarkRed);
                Colors.Add(Color.RosyBrown);
                ColorCode = Colors[it % Colors.Count];
                return ColorCode;
            }
            if (GetColorCode == 5)
            {
                Colors.Clear();
                Colors.Add(Color.Green);
                Colors.Add(Color.ForestGreen);
                Colors.Add(Color.LawnGreen);
                Colors.Add(Color.LimeGreen);
                Colors.Add(Color.SeaGreen);
                Colors.Add(Color.YellowGreen);
                Colors.Add(Color.DarkGreen);
                Colors.Add(Color.SpringGreen);
                ColorCode = Colors[it % Colors.Count];
                return ColorCode;
            }
            if (GetColorCode == 6)
            {
                Colors.Clear();
                Colors.Add(Color.BlueViolet);
                Colors.Add(Color.DeepSkyBlue);
                Colors.Add(Color.Blue);
                Colors.Add(Color.Turquoise);
                Colors.Add(Color.AliceBlue);
                Colors.Add(Color.MediumBlue);
                Colors.Add(Color.RoyalBlue);
                Colors.Add(Color.DarkViolet);
                ColorCode = Colors[it % Colors.Count];
                return ColorCode;
            }

            else
            {
                ColorCode = DefaultColors[it % DefaultColors.Count];
                return ColorCode;
            }
        }

        private Color ExperimentalMandelColor(double mu)
        {
            if (GetColorCode == 1)
            {
                int input1 = (int)mu;
                double t2 = mu - input1;
                double t1 = 1 - t2;
                input1 = input1 % DefaultColors.Count;
                int input2 = (input1 + 1) % DefaultColors.Count;
                byte r = (byte)(DefaultColors[input1].R * t1 + DefaultColors[input2].R * t2);
                byte g = (byte)(DefaultColors[input1].G * t1 + DefaultColors[input2].G * t2);
                byte b = (byte)(DefaultColors[input1].B * t1 + DefaultColors[input2].B * t2);

                return Color.FromArgb(255, r, g, b);
            }
            else
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

        private void defaultcolorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetColorCode = 1;
            DrawMandel();
        }
        private void experimentalcolorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetColorCode = 2;
            DrawMandel();
        }
        private void blackwhitecolorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetColorCode = 3;
            DrawMandel();
        }
        private void redhueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetColorCode = 4;
            DrawMandel();
        }
        private void greenhueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetColorCode = 5;
            DrawMandel();
        }
        private void bluehueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetColorCode = 6;
            DrawMandel();
        }

        private void pickDefaultColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultColorsBox.Location = new Point(MandelPic.Width / 2 - DefaultColorsBox.Width / 2, MandelPic.Height / 2 - DefaultColorsBox.Height / 2);
            AcceptColors.Location = new Point(MandelPic.Width / 2 - AcceptColors.Width - 5, MandelPic.Height / 2 + DefaultColorsBox.Height / 2 + 10);
            CancelColorsButton.Location = new Point(MandelPic.Width / 2 + 5, MandelPic.Height /2 + DefaultColorsBox.Height / 2 + 10);
            MessageBox.Show("Choose some colors and press 'Accept'.");

            DefaultColorsBox.Visible = true;
            AcceptColors.Visible = true;
            CancelColorsButton.Visible = true;
        }

        private void AcceptColors_Click(object sender, EventArgs e)
        {
            DefaultColors.Clear();
            DefaultColors = DefaultColorsBox.CheckedItems.OfType<Color>().ToList();
            DefaultColorsBox.Visible = false;
            AcceptColors.Visible = false;
            CancelColorsButton.Visible = false;

            Application.DoEvents();
            DrawMandel();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DefaultColorsBox.Visible = false;
            AcceptColors.Visible = false;
            CancelColorsButton.Visible = false;
        }

        private void ResetColors_Click(object sender, EventArgs e)
        {
            DefaultColors.Clear();
            DefaultColors.Add(Color.SeaGreen);
            DefaultColors.Add(Color.Lime);
            DefaultColors.Add(Color.Violet);
            DefaultColors.Add(Color.OrangeRed);
            DefaultColors.Add(Color.SkyBlue);
            DefaultColors.Add(Color.Yellow);
            DefaultColors.Add(Color.Gray);
            DefaultColors.Add(Color.DarkRed);

            foreach(int i in DefaultColorsBox.CheckedIndices)
            {
                DefaultColorsBox.SetItemCheckState(i, CheckState.Unchecked);
            }

            Application.DoEvents();
            DrawMandel();
        }
    }

}
