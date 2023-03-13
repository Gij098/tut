using System;
using System.Drawing;

namespace tut;
class Point
{
    protected int x, y;
    public Point()
    {
        x = 0;
        y = 0;
    }
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public int X
    {
        get { return x; }
        set { x = value; }
    }
    public int Y
    {
        get { return y; }
        set { y = value; }
    }
    public override string ToString()
    {
        string result = $"Координаты x , y =  [{Convert.ToString(x)};{Convert.ToString(y)}]";
        return result;
    }

   

    class ColorPoint : Point
    {
        protected string color;
        public ColorPoint() : base()
        {
            color = "Blue";

        }
        public ColorPoint(string color, int x, int y) : base(x, y)
        {
            this.color = color;
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public override string ToString()
        {
            string result = $"Координаты color;x , y =  [{color};{Convert.ToString(x)};{Convert.ToString(y)}]";
            return result;
        }


        class PointLine
        {
            Point point = new Point();
        }

        class ColorLine : Point
        {
            protected string color;
            public ColorLine() : base()
            {
                color = "Yellow";

            }
            public ColorLine(string color, int x, int y) : base(x, y)
            {
                this.color = color;
            }
            public string Color
            {
                get { return color; }
                set { color = value; }
            }
            public override string ToString()
            {
                string result = $"Координаты color;x , y = [{color};{Convert.ToString(x)};{Convert.ToString(y)}]";
                return result;
            }
            class Program
            {
      static void Main()
    {
        Point point  = new Point(0,1);
    Console.Write(point);

    }

            }
       

        }
    }
}




