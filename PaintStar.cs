using System.Drawing;

namespace paint
{
    class PaintStar : Painter<Star>
    {


        public override void Draw(Graphics g, Pen pen, Star star)
        {
            g.DrawPolygon(pen, star.StarCord);
        }
    }
}
