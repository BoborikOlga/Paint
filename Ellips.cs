
using System.Drawing;

namespace paint
{
    class Ellips : Shape
    {

        public int X_end, Y_end; 

        public Ellips( int X1, int Y1, int endX, int endY)
        {   
            X = X1;
            Y = Y1;
            X_end = endX;
            Y_end = endY;
        }
    }
}
