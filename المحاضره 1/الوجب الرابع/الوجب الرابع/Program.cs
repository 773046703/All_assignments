using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace الوجب_الرابع
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double height;
                Console.Write("Enter Your height  : ");
                height = Convert.ToDouble(Console.ReadLine());
                if (height < 150)
                {
                    Console.Write(" Short  \n");
                }
                else if ((height >= 150) && (height < 165))
                {
                    Console.Write(" Average  \n");
                }
                else if ((height >= 165) && (height <= 195))
                {
                    Console.Write(" Tall  \n");
                }
                else if (height > 195)
                {
                    Console.Write(" Giant  \n");
                }
            }
        }
    }
}
