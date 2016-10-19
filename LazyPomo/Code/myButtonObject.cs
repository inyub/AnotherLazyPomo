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
    public partial class myButtonObject : UserControl
    {
        // Draw the new button. 
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            // Draw the button in the form of a circle
            graphics.DrawEllipse(myPen, 0, 0, 52, 52);
            myPen.Dispose();
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        }
    }
}
