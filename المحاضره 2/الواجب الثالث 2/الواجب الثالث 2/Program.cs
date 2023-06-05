using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace الواجب_الثالث_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Even numbers in descending order :");
            for (int i = num; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
