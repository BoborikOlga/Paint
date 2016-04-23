using System.Drawing;

namespace paint
{
    class PaintLine : Painter<Line>
    {
        
        public override void Draw(Graphics g, Pen pen, Line line)
        {
            g.DrawLine(pen, line.X, line.Y, line.X_end, line.Y_end);        
        }
    }
}
