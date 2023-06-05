using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace الوجب_الخامس
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("Enter X : ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y : ");
            y = Convert.ToDouble(Console.ReadLine());
           /* (x,y)              Y     
                                 |
                        (-,+)    |    (+,+)
                     -X ________ |________X
                                 |
                        (-,-)    |    (+,-)
                                 |
                                 -Y   
                                 */
            if ((x > 0) && (y > 0))
            {
                Console.WriteLine("First Quarter \n(X = + , Y = + )\n");
            }
            else if ((x < 0) && (y > 0))
            {
                Console.WriteLine("Second Quarter \n(X = - , Y = + )\n");
            }
            if ((x < 0) && (y < 0))
            {
                Console.WriteLine("Third Quarter \n(X = - , Y = - )\n");
            }
            if ((x > 0) && (y < 0))
            {
                Console.WriteLine("Fourth Quarter \n(X = + , Y = - )\n");
            }
            
        }
    }
}
