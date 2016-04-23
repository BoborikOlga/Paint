using System.Drawing;

namespace paint
{
    class Line : Shape
    {
        public int X_end, Y_end; 

        public Line( int X1, int Y1, int endX, int endY)
        {

            X = X1;
            Y = Y1;
            X_end = endX;
            Y_end = endY;
        }

       
    }
}
