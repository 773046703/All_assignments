using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace الواجب_الثاني_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int z,f=1;
            z = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<= z;i++)
            {
                f *= i;
            }
            Console.WriteLine("The factonial : " + f);
        }
    }
}
