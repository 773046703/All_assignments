using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace الواجب_1
{
    class Point
    {
        /* (x,y)              Y     
                              |
                     (-,+)    |    (+,+)
                  -X ________ |________X
                              |
                     (-,-)    |    (+,-)
                              |
                              -Y   
       */
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move()
        {
            x -= 5;
            y += 5;
        }

        public int Quadrant()
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else if (x > 0 && y < 0)
            {
                return 4;
            }
            else
            {
                return -1; // point is on an axis
            }
        }

        public void Print()
        {
            Console.WriteLine("({0}, {1})", x, y);
        }
    }
}