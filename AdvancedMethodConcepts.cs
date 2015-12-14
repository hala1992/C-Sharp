using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace _3_FoodOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Choose one of the items number (20,23,25,31) \n Or \n Choose one of the following items description (Enchilada, Burrito, Taco, Tostada) \n >> ");
            string inputString = ReadLine();
            int inputInt;
            if (int.TryParse(inputString, out inputInt))
            {
                GetDetails(inputInt);
            }
            GetDetails(inputString, inputInt);
           
        }
        private static void GetDetails(int inputI)
        {
            if(inputI ==20)
            {
                WriteLine("The item discrption is Enchilada and the price is $2.95");
            }
            if (inputI == 23)
            {
                WriteLine("The item discrption is Burrito and the price is $1.95");
            }
            if (inputI == 25)
            {
                WriteLine("The item discrption is Taco and the price is $2.25");
            }
            if (inputI == 31)
            {
                WriteLine("The item discrption is Tostada and the price is $3.10");
            }
            if((inputI != 20) && (inputI != 23) && (inputI != 25) && (inputI != 31))
            {
                WriteLine("Item was not found");
            }
        }
        private static void GetDetails(string inputS, int inputI)
        {
            if (!int.TryParse(inputS, out inputI))
            {

          
                  if (inputS == "Tostada")
            {
                WriteLine("The item number is 31 and price is $3.10");
            }
                  if (inputS == "Enchilada")
            {
                WriteLine("The item number is 20 and price is $2.95");
            }
                  if (inputS == "Burrito")
            {
                WriteLine("The item number is 23 and price is $1.95");
            }
                  if (inputS == "Taco")
            {
                WriteLine("The item number is 25 and price is $2.25");
            }
            if((inputS != "Tostada") && (inputS != "Enchilada") && (inputS != "Burrito") && (inputS != "Taco"))
            {
                WriteLine("Item was not found");
            }
            }
        }
    }
}
