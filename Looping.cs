using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace WebAddress12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Write("Enter your business name >> ");
            string busniessName = ReadLine();

            busniessName = busniessName.Replace(" ","");
            { 
                WriteLine("www.{0}.com", busniessName);
            }

        }
    }
}
