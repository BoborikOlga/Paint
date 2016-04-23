using System.Drawing;

namespace paint
{
    class PaintRectangle : Painter<Rectangle>
    {

        public override void Draw(Graphics g, Pen pen, Rectangle rect)
        {
            g.DrawRectangle(pen, rect.X, rect.Y, rect.X_end, rect.Y_end);
        }      
    }
}
