using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace الواجب_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the rows = ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the cols = ");
            int cols = int.Parse(Console.ReadLine());

            Matrix m1 = new Matrix(rows, cols);

            m1.ReadMatrix();

            m1.Print();

            m1.Transpose();

            m1.Print();

        }
    }
}
