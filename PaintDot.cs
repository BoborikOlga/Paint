using System.Drawing;

namespace paint
{
    class PaintDot : Painter<Dot>
    {
        public override void Draw(Graphics g, Pen pen, Dot dot) 
        {
             g.DrawLine(pen, dot.X, dot.Y, dot.X, dot.Y);
        }
    }
}
