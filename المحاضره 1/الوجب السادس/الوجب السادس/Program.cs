using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace الوجب_السادس
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                double num1, num2;
                Console.Write("Enter Number 1 : ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Number 2 : ");
                num2 = Convert.ToDouble(Console.ReadLine());
                {
                    Console.Write("Is the First number positive ?\n ");
                    if (num1 > 0)
                    {
                        Console.WriteLine("Yes : The First number positive\n");
                    }
                    else
                    {
                        Console.WriteLine("No : The First number is Not positive\n");
                    }
                }
                {
                    Console.Write("Is the Second number positive ?\n ");
                    if (num2 > 0)
                    {
                        Console.WriteLine("Yes : The Second number positive\n");
                    }
                    else
                    {
                        Console.WriteLine("NO : The Second number is Not positive\n");
                    }
                }
                {
                    Console.Write("Are they both positive ?\n");
                    if ((num1 > 0) && (num2 > 0))
                    {
                        Console.WriteLine("Yes : They are both positive\n");
                    }
                    else
                    {
                        Console.WriteLine("No : They are not both positive\n");
                    }
                }
                {
                        Console.Write("Which one is smaller ?\n");
                    if (num1 < num2)
                    {
                        Console.WriteLine("The Number 1 is smaller\n");
                    }
                    else if (num2 < num1)
                    {
                        Console.WriteLine("The Number 2 is smaller\n");
                    }

                }

            }
        }
    }
}