using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectByAlice
{
    internal class Point
    {
        private int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        internal void SetX(int a)
        {
            if (this.x < 0 || this.x > MyCanvas.maxWidth)
                Console.WriteLine("this value isnt within screen limitations");
            else
                this.x = x;
        }

        internal void SetY(int a)
        {
            if (this.y < 0 || this.y > MyCanvas.maxHeight)
                Console.WriteLine("this value isnt within screen limitations");
            else
                this.y = y;
        }

        internal int GetX()
        {
            return this.x;
        }

        internal int GetY()
        {
            return this.y;
        }

        public override string ToString()
        {
            return $"x is: {this.x}, y is: {this.y}";
        }
    }
}
