using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace الوجب_الثاني
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.Write("Enter Number : ");
            x = Convert.ToDouble(Console.ReadLine());
            if (x>0)
            {
                Console.Write("Positive ( + )\n");
            }
            else if(x<0)
            {
                Console.Write("Negative ( - )\n");
            }
            else if (x == 0)
            {
                Console.Write("Zero ( = )\n");
            }
        }

    }
}
