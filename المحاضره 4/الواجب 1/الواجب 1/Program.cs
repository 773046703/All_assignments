using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace الواجب_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter X = ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter Y = ");
            int y = int.Parse(Console.ReadLine());

           Point p = new Point(x, y);

            p.Move();
            Console.Write("After moving : ");

            p.Print(); 
            Console.Write("Quadrant : ");
            Console.WriteLine(p.Quadrant());
           
        }
    }
}
