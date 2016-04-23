using System.Drawing;
using System.Windows.Input;
using System.Windows.Forms;
using System.Collections.Generic;

using System;
using System.Drawing.Drawing2D;




namespace paint
{

    public partial class FMain : Form
    {

        public FMain()
        {
            InitializeComponent();
        }

        private List<Point> cord = new List<Point>();
        private Action drawMethod;
        private int lastCordCount = 0, count = 0;
        private bool buttonCheck = false;
        

        Pen pen = new Pen(Color.Black);
        

        private void bColor_Click(object sender, System.EventArgs e)
        {
            ColorDialog colors = new ColorDialog();
            colors.ShowDialog();
            pen.Color = colors.Color;
        }

        private void ChekCord(int count)
        {
            if (cord.Count - lastCordCount == count)
            {
                drawMethod();
                lastCordCount = cord.Count;
            }
        }

        private void Circle()
        {
            Graphics g = PBPaintField.CreateGraphics();         
            Ellips ellips = new Ellips(cord[cord.Count - 2].X, cord[cord.Count - 2].Y, cord[cord.Count - 1].X, cord[cord.Count - 1].Y);
            PaintEllips elCr = new PaintEllips();
            elCr.Draw(g, pen, ellips);
        }

        private void bCircle_Click(object sender, System.EventArgs e)
        {
            buttonCheck = true;
            drawMethod = Circle;
            count = 2;      
        }

        private void Rectangle()
        {
            Graphics g = PBPaintField.CreateGraphics();
            Rectangle rect = new Rectangle(cord[cord.Count - 2].X, cord[cord.Count - 2].Y, cord[cord.Count - 1].X, cord[cord.Count - 1].Y);
            PaintRectangle recCr = new PaintRectangle();
            recCr.Draw(g, pen, rect);
        }
        

        private void bRectangle_Click(object sender, System.EventArgs e)
        {
            buttonCheck = true;
            drawMethod = Rectangle;
            count = 2;     
        }

        private void Line()
        {
            Graphics g = PBPaintField.CreateGraphics();
            Line line = new Line(cord[cord.Count - 2].X, cord[cord.Count - 2].Y, cord[cord.Count - 1].X, cord[cord.Count - 1].Y);
            PaintLine lCr = new PaintLine();
            lCr.Draw(g, pen, line);
        }


        private void bLine_Click(object sender, System.EventArgs e)
        {
            buttonCheck = true;
            drawMethod = Line;
            count = 2;
            
        }

        private void Dot()
        {
            Graphics g = PBPaintField.CreateGraphics();
            Dot dot = new Dot(cord[cord.Count - 1].X, cord[cord.Count - 1].Y);
            PaintDot dCr = new PaintDot();
            dCr.Draw(g, pen, dot);
        }

        private void bDot_Click(object sender, System.EventArgs e)
        {
            buttonCheck = true;
            drawMethod = Dot;
            count = 1;
        }

        private void Triangle()
        {
            Graphics g = PBPaintField.CreateGraphics();
            Triangle tr = new Triangle(cord[cord.Count - 3].X, cord[cord.Count - 3].Y, cord[cord.Count - 2].X, cord[cord.Count - 2].Y, cord[cord.Count - 1].X, cord[cord.Count - 1].Y);
            PaintTriangle trCr = new PaintTriangle();
            trCr.Draw(g, pen, tr);
        }

        private void bTriangle_Click(object sender, System.EventArgs e)
        {
            buttonCheck = true;
            drawMethod = Triangle;
            count = 3;          
        }

        private void Star()
        {
            Graphics g = PBPaintField.CreateGraphics();
            Star star = new Star(cord[cord.Count - 5].X, cord[cord.Count - 5].Y, cord[cord.Count - 4].X, cord[cord.Count - 4].Y, cord[cord.Count - 3].X, cord[cord.Count - 3].Y, cord[cord.Count - 2].X, cord[cord.Count - 2].Y, cord[cord.Count - 1].X, cord[cord.Count - 1].Y);
            PaintStar stCr = new PaintStar();
            stCr.Draw(g, pen, star);
        }

        private void bStar_Click(object sender, System.EventArgs e)
        {
            buttonCheck = true;
            drawMethod = Star;
            count = 5;
        }

         
        private void PBPaintField_MouseDown(object sender, MouseEventArgs e)
        {
            Point curCord = new Point();
            if (buttonCheck)
            {
                curCord.X = e.X;
                curCord.Y = e.Y;
                cord.Add(curCord);
                ChekCord(count);
            }
        }

        private void FMain_Load(object sender, System.EventArgs e)
        {
            pen.Width = Convert.ToInt32(tbWidth.Text);
        }

        private void tbWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b') return;
            else
            {
                e.Handled = true;
            }    

        }

        private void tbWidth_TextChanged(object sender, EventArgs e)
        {
            if ((String.Equals(tbWidth.Text,"")) == false)
            pen.Width = Convert.ToInt32(tbWidth.Text);
        }
       
    }

}
   
        
    

