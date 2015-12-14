using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Array;
namespace ArrayDemo_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            int[] demo = new int[8] {22,26,28,30,40,46,50,66};

            WriteLine("This list order from first to last ");
            for (int x = 0; x < demo.Length; ++x)
            {
                Write("{0,4}",demo[x]);
            }
            WriteLine("\n-------------------------------------");
            WriteLine("This list order from last to first ");

            Reverse(demo);
            for (int x = 0; x < demo.Length; ++x)
            {
                Write("{0,4}", demo[x]);
            }
            WriteLine("\n-------------------------------------");

            Write("Enter a number to view it's value ");
            userInput = Convert.ToInt32(ReadLine());
            Reverse(demo);

            while (userInput != 666)
            {
                WriteLine("Position {0} has a value of {1}.",userInput,demo[userInput]);

                Write("Enter a number to view it's value ");
                userInput = Convert.ToInt32(ReadLine());
            }
            

        }

    }
}
