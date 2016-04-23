using System.Drawing;

namespace paint
{
    class Star : Shape
    { 
   
        public Point[] StarCord = new Point[5];

        public Star( int X0, int Y0, int X1, int Y1, int X2, int Y2, int X3, int Y3, int X4, int Y4)
        {   
            StarCord[0] = new Point(X0, Y0);
            StarCord[1] = new Point(X1, Y1);
            StarCord[2] = new Point(X2, Y2);
            StarCord[3] = new Point(X3, Y3);
            StarCord[4] = new Point(X4, Y4);
        }
     
    }
}
