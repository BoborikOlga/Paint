using System.Drawing;

namespace paint
{
    class Triangle : Shape
    {
        public int X_end, Y_end, X_3, Y_3;

        public Triangle(int X1, int Y1, int endX, int endY, int X3, int Y3)
        {

            X = X1;
            Y = Y1;
            X_end = endX;
            Y_end = endY;
            X_3 = X3;
            Y_3 = Y3;
        }
    }
}
