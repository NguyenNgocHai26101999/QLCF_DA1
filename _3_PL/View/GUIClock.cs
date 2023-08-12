using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PL.View
{
    public class GUIClock
    {
        public static Image ClockImage(int witdh, int height)
        {
            float x = witdh / 100f;
            float y = height / 100f;
            float size2 = (witdh * .78f) / (2);
            float size1 = (height * .9f) / (2), rad = witdh / 2;
            PointF cen = new PointF(witdh / 2, height / 2);
            Image bBackground = new Bitmap(witdh + 1, height + 1);
            Graphics eGraphics = Graphics.FromImage(bBackground);

            Color innnerColor = Color.Peru;
            Color outnnerColor = Color.Tan;
            Color secondhandColor = Color.White;

            int sec = DateTime.Now.Second;
            int min = DateTime.Now.Minute;
            int hour = DateTime.Now.Hour;

            eGraphics.Clear(Color.Transparent);
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, witdh, height);
            PathGradientBrush pgb = new PathGradientBrush(gp);
            pgb.CenterColor = innnerColor;
            pgb.SurroundColors = new Color[] { outnnerColor };
            eGraphics.FillEllipse(pgb, 0, 0, witdh, height);

            eGraphics.DrawEllipse(new Pen(Color.DarkGray, 2f), 0, 0, witdh, height);
            eGraphics.DrawString("       Bug Coffee", new Font("Arial", x * 4), Brushes.Black, x * 22, y * 35);
            eGraphics.DrawString("11", new Font("Impact", x * 8), Brushes.Black, new PointF(x * 22.5f, y * 6.5f));
            eGraphics.DrawString("12", new Font("Impact", x * 8), Brushes.Black, new PointF(x * 44.5f, y * 1.5f));
            eGraphics.DrawString("1", new Font("Impact", x * 8), Brushes.Black, new PointF(x * 66.5f, y * 6.25f));
            eGraphics.DrawString("2", new Font("Impact", x * 8), Brushes.Black, new PointF(x * 82.5f, y * 22.25f));
            eGraphics.DrawString("3", new Font("Impact", x * 8), Brushes.Black, new PointF(x * 90, y * 44f));
            eGraphics.DrawString("4", new Font("Impact", x * 8), Brushes.Black, new PointF(x * 82.75f, y * 64.5f));
            eGraphics.DrawString("5", new Font("Impact", x * 8), Brushes.Black, new PointF(x * 67.25f, y * 80.25f));
            eGraphics.DrawString("6", new Font("Impact", x * 8), Brushes.Black, new PointF(x * 45, y * 85.75f));
            eGraphics.DrawString("7", new Font("Impact", x * 8), Brushes.Black, new PointF(x * 24.75f, y * 79.25f));
            eGraphics.DrawString("8", new Font("Impact", x * 8), Brushes.Black, new PointF(x * 7.75f, y * 64.5f));
            eGraphics.DrawString("9", new Font("Impact", x * 8), Brushes.Black, new PointF(x * 1.5f, y * 44f));
            eGraphics.DrawString("10", new Font("Impact", x * 8), Brushes.Black, new PointF(x * 6.5f, y * 22.25f));

            eGraphics.DrawLine(new Pen(secondhandColor, size1 * .03f),
                cen.X - (float)(Math.Sin((hour * 30 + min / 12 * 6) * Math.PI / 180)) * rad * .1f,
                cen.Y - (float)(-Math.Cos((hour * 30 + min / 12 * 6) * Math.PI / 180)) * rad * .1f,
                (float)(Math.Sin((hour * 30 + min / 12 * 6) * Math.PI / 180)) * rad * .55f + cen.X,
                (float)(-Math.Cos((hour * 30 + min / 12 * 6) * Math.PI / 180)) * rad * .55f + cen.Y);

            eGraphics.DrawLine(new Pen(secondhandColor, size1 * .02f),
                cen.X - (float)(Math.Sin(min * 6 * Math.PI / 180)) * rad * .15f,
                cen.Y - (float)(-Math.Cos(min * 6 * Math.PI / 180)) * rad * .15f,
                (float)(Math.Sin(min * 6 * Math.PI / 180)) * rad * .7f + cen.X,
                (float)(-Math.Cos(min * 6 * Math.PI / 180)) * rad * .7f + cen.Y);


            eGraphics.DrawLine(new Pen(secondhandColor, size1 * .01f),
                cen.X - (float)(Math.Sin(sec * 6 * Math.PI / 180)) * rad * .2f,
                cen.Y - (float)(-Math.Cos(sec * 6 * Math.PI / 180)) * rad * .2f,
                (float)(Math.Sin(sec * 6 * Math.PI / 180)) * rad * .9f + cen.X,
                (float)(-Math.Cos(sec * 6 * Math.PI / 180)) * rad * .9f + cen.Y);

            eGraphics.FillEllipse(new SolidBrush(secondhandColor), cen.X - rad * .03f, cen.Y - rad * .03f, rad * .06f, rad * .06f);
            return bBackground;


        }
    }
}
