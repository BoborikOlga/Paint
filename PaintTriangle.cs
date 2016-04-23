using System.Drawing;
using System.Drawing.Drawing2D;

namespace paint
{
    class PaintTriangle : Painter<Triangle>
    {
        public override void Draw(Graphics g, Pen pen, Triangle tr)
        {
                       
            g.DrawLine(pen, tr.X, tr.Y, tr.X_end, tr.Y_end);
            g.DrawLine(pen, tr.X_end, tr.Y_end, tr.X_3, tr.Y_3);
            g.DrawLine(pen, tr.X_3, tr.Y_3, tr.X, tr.Y);
            
        }
    }
}
