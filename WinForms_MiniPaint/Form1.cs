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
using System.Globalization;
using System.Threading;

namespace WinForms_MiniPaint
{
    public partial class Form1 : Form
    {
        public bool brushclick = false;
        private bool painting = false;
        private bool ellipse = false;
        private bool rectangle = false;
        private PictureBox prev;
        private KnownColor[] colors;
        private Bitmap drawArea;
        Graphics g, colorbox;
        private Pen pen;
        private Pen dashedPen;
        private int posx, posy;
        private int figurex, figurey;
        private int colorcount = 0;
        private int windowsize_x, windowsize_y;
        private bool isBrushChecked = false;
        private bool isRectChecked = false;
        private bool isEllipseChecked = false;
        public Form1()
        {
            System.Globalization.CultureInfo.CurrentUICulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();
            
            colors = (KnownColor[])Enum.GetValues(typeof(System.Drawing.KnownColor)); //from https://stackoverflow.com/questions/32226355/how-to-use-different-color-for-backcolor-in-textbox
            colors = Array.FindAll(colors, c => c != KnownColor.Transparent);  //from https://stackoverflow.com/questions/32226355/how-to-use-different-color-for-backcolor-in-textbox

            drawArea = new Bitmap(paintingArea.Size.Width, paintingArea.Size.Height);
            paintingArea.Image = drawArea;
            g = Graphics.FromImage(drawArea);
            pen = new Pen(Brushes.Black, 1);
            g.Clear(Color.White);
            windowsize_x = Size.Width;
            windowsize_y = Size.Height;
            foreach(KnownColor c in colors)
            {
                PictureBox color = new PictureBox();
                color.Width = 25;
                color.Height = 25;
                color.BackColor = Color.FromKnownColor(c);
                color.Name = "ColorButton";
                color.Click += Colorbutton_Click;
                ColorPanel.Controls.Add(color);
            }
        }

        private Bitmap ChangeSize(Bitmap bitmap)
        {
            Bitmap newBmp = new Bitmap(paintingArea.Width, paintingArea.Height);
            paintingArea.Image = newBmp;
            g = Graphics.FromImage(newBmp);
            g.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
            paintingArea.Refresh();
            windowsize_x = Size.Width;
            windowsize_y = Size.Height;
            return newBmp;
        }

        private void Colorbutton_Click(object sender, EventArgs e)
        {
            PictureBox b = (PictureBox)sender;
            if(colorcount >= 1)
            {
                Bitmap removeBorder = new Bitmap(25, 25);
                colorbox = Graphics.FromImage(removeBorder);
                colorbox.Clear(prev.BackColor);
                prev.Image = removeBorder;
            }
            pen.Color = b.BackColor;    //from yt https://www.youtube.com/watch?v=xyEG1e5Gnic

            dashedPen = new Pen(Color.FromArgb(b.BackColor.ToArgb() ^ 0xffffff), 2);
            dashedPen.DashPattern = new float[] { 2, 2 };

            Bitmap colorBmp = new Bitmap(25, 25);
            colorbox = Graphics.FromImage(colorBmp);
            colorbox.DrawRectangle(dashedPen, 1, 1, 23, 23);        
            b.Image = colorBmp;

            chosenColor.BackColor = b.BackColor;

            prev = b;
            colorcount++;
        }




        private void paintingArea_MouseMove(object sender, MouseEventArgs e)
        {
            figurex = e.X;
            figurey = e.Y;
            if (painting && brushclick)
            {
                Point p = new Point(posx, posy);      //from yt https://www.youtube.com/watch?v=xyEG1e5Gnic
                g.DrawLine(pen, p.X, p.Y, e.X,e.Y);   //from yt https://www.youtube.com/watch?v=xyEG1e5Gnic
                posx = e.X;
                posy = e.Y;
                paintingArea.Refresh();
            }
            if (painting)
            {
                paintingArea.Refresh();
            }

        }
        private void paintingArea_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            if (painting && ellipse)
            {
                Point p = new Point(posx, posy);
                g.DrawEllipse(pen, p.X, p.Y, figurex - p.X, figurey - p.Y);
            }
            if (painting && rectangle)
            {
                Point p = new Point(posx, posy);
                if (p.X <= figurex && p.Y <= figurey)
                {
                    g.DrawRectangle(pen, p.X, p.Y, figurex - p.X, figurey - p.Y);
                }
                else if (p.X > figurex && p.Y <= figurey)
                {
                    g.DrawRectangle(pen, figurex, p.Y, p.X - figurex, figurey - p.Y);
                }
                else if (p.X <= figurex && p.Y > figurey)
                {
                    g.DrawRectangle(pen, p.X, figurey, figurex - p.X, p.Y - figurey);
                }
                else if (p.X > figurex && p.Y > figurey)
                {
                    g.DrawRectangle(pen, figurex, figurey, p.X - figurex, p.Y - figurey);
                }
            }
        }

        private void paintingArea_MouseDown(object sender, MouseEventArgs e)
        {
            posx = e.X;
            posy = e.Y;
            painting = true;
            if (e.Button == MouseButtons.Right)
            {
                painting = false;
            }
        }

        private void ColorPanel_Scroll(object sender, ScrollEventArgs e)
        {
            ColorPanel.AutoScroll = true;
        }

        private void paintingArea_SizeChanged(object sender, EventArgs e)
        {
            if(drawArea != null)
                drawArea = ChangeSize(drawArea);
        }

        private void chooseThickness_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox cb = (ToolStripComboBox)sender;
            if ((string)cb.SelectedItem == "1")
            {
                pen.Width = 1;
            }
            else if ((string)cb.SelectedItem == "2")
            {
                pen.Width = 2;
            }
            else
            {
                pen.Width = 3;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            paintingArea.Refresh();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = ".jpeg|*.jpeg|.png|*.png|.bmp|*.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.FilterIndex == 1)
                {
                    drawArea.Save(dialog.FileName, ImageFormat.Jpeg);
                }
                if (dialog.FilterIndex == 2)
                {
                    drawArea.Save(dialog.FileName, ImageFormat.Png);
                }
                if (dialog.FilterIndex == 3)
                {
                    drawArea.Save(dialog.FileName, ImageFormat.Bmp);
                }

            }
            dialog.Dispose();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = ".jpeg, .bmp, .png|*.bmp; *.jpeg; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int wndsizex = Size.Width;
                int wndsizey = Size.Height;
                Size = new Size(wndsizex + (Image.FromFile(dialog.FileName).Width - paintingArea.Width)+50, wndsizey + (Image.FromFile(dialog.FileName).Height - paintingArea.Height));
                drawArea = ChangeSize(drawArea);
                g.DrawImage(Image.FromFile(dialog.FileName), 0, 0);
                paintingArea.Refresh();
            }
        }

        private void brushButton_Click(object sender, EventArgs e)
        {
            if (brushclick == false)
            {
                brushclick = true;
                isBrushChecked = true;
            }
            else
            {
                brushclick = false;
                isBrushChecked = false;
            }     
            ellipse = false;
            rectangle = false;
            ellipseButton.Checked = false;
            isRectChecked = false;
            rectangleButton.Checked = false;
            isEllipseChecked = false;
        }

        private void enLang_Click(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo.CurrentUICulture = new System.Globalization.CultureInfo("en");
            this.Controls.Clear();
            InitializeComponent();
            Size = new Size(windowsize_x, windowsize_y);
            paintingArea.Image = drawArea;
            g = Graphics.FromImage(drawArea);
            g.DrawImage(drawArea, 0, 0);
            pen = new Pen(Brushes.Black, 1);
            foreach (KnownColor c in colors)
            {
                PictureBox color = new PictureBox();
                color.Width = 25;
                color.Height = 25;
                color.BackColor = Color.FromKnownColor(c);
                color.Name = "ColorButton";
                color.Click += Colorbutton_Click;
                ColorPanel.Controls.Add(color);
            }
            if (isBrushChecked)
                brushButton.Checked = true;
            if (isEllipseChecked)
                ellipseButton.Checked = true;
            if (isRectChecked)
                rectangleButton.Checked = true;
        }

        private void plLang_Click(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo.CurrentUICulture = new System.Globalization.CultureInfo("pl-PL");
            this.Controls.Clear();
            InitializeComponent();
            Size = new Size(windowsize_x, windowsize_y);
            paintingArea.Image = drawArea;
            g = Graphics.FromImage(drawArea);
            g.DrawImage(drawArea, 0, 0);
            pen = new Pen(Brushes.Black, 1);
            foreach (KnownColor c in colors)
            {
                PictureBox color = new PictureBox();
                color.Width = 25;
                color.Height = 25;
                color.BackColor = Color.FromKnownColor(c);
                color.Name = "ColorButton";
                color.Click += Colorbutton_Click;
                ColorPanel.Controls.Add(color);
            }
            if (isBrushChecked)
                brushButton.Checked = true;
            if (isEllipseChecked)
                ellipseButton.Checked = true;
            if (isRectChecked)
                rectangleButton.Checked = true;
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            if (rectangle == false)
            {
                rectangle = true;
                isRectChecked = true;
            }
            else
            {
                rectangle = false;
                isRectChecked = false;
            }
            brushclick = false;
            ellipse = false;
            ellipseButton.Checked = false;
            isEllipseChecked = false;
            brushButton.Checked = false;
            isBrushChecked = false;
        }



        private void ellipseButton_Click(object sender, EventArgs e)
        {
            if (ellipse == false)
            {
                ellipse = true;
                isEllipseChecked = true;
            }
            else
            {
                ellipse = false;
                isEllipseChecked = false;
            }
            brushclick = false;
            rectangle = false;
            brushButton.Checked = false;
            isBrushChecked = false;
            rectangleButton.Checked = false;
            isRectChecked = false;
        }

        private void paintingArea_MouseUp(object sender, MouseEventArgs e)
        {
            if (painting && ellipse)
            {
                Point p = new Point(posx, posy);
                g.DrawEllipse(pen, p.X, p.Y,e.X - p.X,e.Y - p.Y);
            }
            if (painting && rectangle)
            {
                Point p = new Point(posx, posy);
                if (p.X <= e.X && p.Y <= e.Y)
                {
                    g.DrawRectangle(pen, p.X, p.Y, e.X - p.X, e.Y - p.Y);
                }
                else if (p.X > e.X && p.Y <= e.Y)
                {
                    g.DrawRectangle(pen, e.X, p.Y, p.X - e.X, e.Y - p.Y);
                }
                else if (p.X <= e.X && p.Y > e.Y)
                {
                    g.DrawRectangle(pen, p.X, e.Y, e.X - p.X, p.Y - e.Y);
                }
                else if (p.X > e.X && p.Y > e.Y)
                {
                    g.DrawRectangle(pen, e.X, e.Y, p.X - e.X, p.Y - e.Y);
                }
            }
            painting = false;
        }
    }
}
