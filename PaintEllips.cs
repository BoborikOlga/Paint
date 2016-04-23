using System.Drawing;

namespace paint
{
    class PaintEllips : Painter<Ellips>
    {
        public override void Draw(Graphics g, Pen pen, Ellips ellips)
        {
            g.DrawEllipse(pen, ellips.X, ellips.Y, ellips.X_end, ellips.Y_end);
        }
    }
}
 