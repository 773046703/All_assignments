using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace الواجب_الخامس_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of X : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of N : ");
            int n = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 0; i < n; i++)
            {
                result *= x;
            }

            Console.WriteLine("The result is : {0}", result);
        }
    }
}
