using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace الواجب_الرابع_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
            }
        }
    }
}
