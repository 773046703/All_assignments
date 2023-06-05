using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace الوجب_الثلاث
{
    class Program
    {
        static void Main(string[] args)
        /* {
             double number;
             Console.Write("Enter Your number  : ");
             number = Convert.ToDouble(Console.ReadLine());
             if (number == 1)
             {
                 Console.Write(" Saturday  \n");
             }
             else if (number == 2)
             {
                 Console.Write(" Sunday  \n");
             }
             else if (number == 3)
             {
                 Console.Write(" Monday  \n");
             }
             else if (number == 4)
             {
                 Console.Write(" Tuesday  \n");
             }
             else if (number == 5)
             {
                 Console.Write(" Wednesday  \n");
             }
             else if (number == 6)
             {
                 Console.Write(" Thursday  \n");
             }
             else if (number == 7)
             {
                 Console.Write(" Friday  \n");
             }
             else if (number > 7)
             {
                 Console.Write(" Not Day  \n");
             }
         }*/
        {
            Console.WriteLine("Enter a day number: ");
            int dayNumber = int.Parse(Console.ReadLine());

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("  Saturday");
                    break;
                case 2:
                    Console.WriteLine("  Sunday");
                    break;
                case 3:
                    Console.WriteLine("  Monday");
                    break;
                case 4:
                    Console.WriteLine("  Tuesday");
                    break;
                case 5:
                    Console.WriteLine("  Wednesday");
                    break;
                case 6:
                    Console.WriteLine("  Thursday");
                    break;
                case 7:
                    Console.WriteLine("  Friday");
                    break;
                default:
                    Console.WriteLine("  Not Day ");
                    break;
            }
        }
           
    }
}
