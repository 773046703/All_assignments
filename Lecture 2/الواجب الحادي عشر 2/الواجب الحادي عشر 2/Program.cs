using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace الواجب_الحادي_عشر_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;

            Console.Write("Input the number of terms: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("The odd numbers are: ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(2 * i - 1 + " ");
                sum += 2 * i - 1;
            }
            Console.Write("\nThe Sum of odd Natural Number upto {0} terms is = {1} ", n, sum);
            Console.ReadLine();
        }
    }
}
