using System.Drawing;

namespace paint
{
    class Rectangle : Shape
    {
        public int X_end, Y_end;

        public Rectangle( int X1, int Y1, int endX, int endY)
        {

            X = X1;
            Y = Y1;
            X_end = endX;
            Y_end = endY;
        }
    }
}
