using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace _6_Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter an integer: ");
            int userInputNum = Convert.ToInt32(ReadLine());
            DisplayMultiplicatinTable(userInputNum);
        }
        private static void DisplayMultiplicatinTable(double num)
        {
            for (int x = 2; x <= 10; ++x)
            {
                WriteLine("{0} * {1} = {2}", num, x, num * x);
            }
        }
    }
    
}
