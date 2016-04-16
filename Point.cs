using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIN_lab2
{
    public class Point
    {
        private int x;
        private int y;
        private int colour;

        public Point(int x, int y, int colour)
        {
            this.x = x;
            this.y = y;
            this.colour = colour;
        }

        public int getX() {return x;}
        public int getY() {return y;}
        public int getC() {return colour;}

        public bool setX(int x) 
        { 
            this.x = x;
            return true;
        }
        public bool setY(int y)
        {
            this.y = y;
            return true;
        }
        public bool setC(int c)
        {
            this.colour = c;
            return true;
        }
    }
}
