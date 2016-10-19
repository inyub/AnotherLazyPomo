using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


class CirclePanel : Panel
    {
    public CirclePanel()
    {
    }

    protected override void OnPaint(PaintEventArgs e)

    {
        //e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        Graphics g = e.Graphics;
        g.DrawEllipse(Pens.Black, 0, 0, this.Width - 1, this.Height - 1);
        Rectangle rect1 = new Rectangle(0 - this.Width / 2 + 17, 0 - this.Height / 2 + 17, this.Width - 34, this.Height - 34);
        e.Graphics.FillPie(new SolidBrush(System.Drawing.Color.Red), rect1, 0, 360);
        
    }

    protected override void OnResize(EventArgs e)
    {
        using (var path = new GraphicsPath())
        {

            path.AddEllipse(new Rectangle(2, 2, this.Width - 5, this.Height - 5));

            this.BackColor = Color.Transparent;
            this.Region = new Region(path);

        }
        base.OnResize(e);
        /*this.Width = this.Height;
        base.OnResize(e);*/
    }
}

