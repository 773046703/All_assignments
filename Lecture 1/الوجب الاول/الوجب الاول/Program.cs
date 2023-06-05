using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace الوجب_الاول
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, height;
            Console.Write("Enter base : ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height : ");
            height = Convert.ToDouble(Console.ReadLine());

            double result = 0.5 * b * height;
            Console.WriteLine("the result is " + result);
        }
    }
}
