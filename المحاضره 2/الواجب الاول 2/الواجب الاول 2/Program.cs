using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace الواجب_الاول_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            for(int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    Console.WriteLine(i);
                    x += i;
                }
            }
            Console.WriteLine("the number = " + x);
        }
    }
}
