using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LazyPomo.Code
{
    public partial class CircularProgressbar : UserControl
    {
        public CircularProgressbar()
        {
            progress = 0;
            InitializeComponent();
        }

        int progress;
        double divider;
        Color progressbarColor = Color.Red;

        private void CircularProgressbar_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            e.Graphics.RotateTransform(-90);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen obj_pen = new Pen(System.Drawing.Color.LightGray); // Outline
            Rectangle rect1 = new Rectangle(0 - this.Width / 2 + 17, 0 - this.Height / 2 + 17, this.Width - 34, this.Height - 34);
            e.Graphics.DrawPie(obj_pen, rect1, 0, 360);
            e.Graphics.FillPie(new SolidBrush(System.Drawing.Color.LightGray), rect1, 0, 360);


            obj_pen = new Pen(System.Drawing.Color.Silver); // Fill
            rect1 = new Rectangle(0 - this.Width / 2 + 20, 0 - this.Height / 2 + 20, this.Width - 40, this.Height - 40);
            e.Graphics.DrawPie(obj_pen, rect1, 0, 360);
            e.Graphics.FillPie(new SolidBrush(System.Drawing.Color.Silver), rect1, 0, 360);

            obj_pen = new Pen(progressbarColor); // progressbar
             rect1 = new Rectangle(0 - this.Width / 2+20, 0 - this.Height / 2+20, this.Width-40, this.Height-40);
            e.Graphics.DrawPie(obj_pen, rect1, 0, (int)(this.progress* divider)); // 360/25= 14.4
            e.Graphics.FillPie(new SolidBrush(progressbarColor), rect1, 0, (int)(this.progress * divider));


            obj_pen = new Pen(System.Drawing.Color.LightGray); // Inline
            rect1 = new Rectangle(0 - this.Width / 2 + 32, 0 - this.Height / 2 + 32, this.Width - 64, this.Height - 64);
            e.Graphics.DrawPie(obj_pen, rect1, 0, 360);
            e.Graphics.FillPie(new SolidBrush(System.Drawing.Color.LightGray), rect1, 0, 360);

            obj_pen = new Pen(Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232))))));
            rect1 = new Rectangle(0 - this.Width / 2 + 35, 0 - this.Height / 2 + 35, this.Width - 70, this.Height - 70);
            e.Graphics.DrawPie(obj_pen, rect1, 0, 360);
            e.Graphics.FillPie(new SolidBrush(Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))))), rect1, 0, 360);

            
            e.Graphics.RotateTransform(90);
            StringFormat ft = new StringFormat();
            ft.LineAlignment = StringAlignment.Center;
            ft.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(this.progress.ToString() + "..", new Font("Arial", 30), new SolidBrush(Color.Red), rect1, ft);
            
        }

        public void UpdateProgress (int progress, double divider, Color progressbarColor)
        {
            this.progress = progress;
            this.Invalidate();
            this.divider = divider;
            this.progressbarColor = progressbarColor;
        }

    }
}
