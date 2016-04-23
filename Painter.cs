using System.Drawing;


namespace paint
{
    public abstract class Painter<T> 
    {
        public abstract void Draw(Graphics g, Pen pen, T shape);
    }
}
