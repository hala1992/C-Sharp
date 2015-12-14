using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace _9_RelativeBirthday2
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------Array------------------------------------
            Relative[] relArray = new Relative[2];
            string name;
            string relationShip;
            int month;
            int day;
            int year;
            int i;

            for (i = 0; i < relArray.Length; i++)
            {
                relArray[i] = new Relative();

                Write("Enter the relative name>> ");
                    name = ReadLine();
                Write("Enter the relative relationship>> ");
                    relationShip = ReadLine();
                Write("Enter the date of birth day only >> ");
                    day = Convert.ToInt32(ReadLine());
                Write("Enter the date of birth month only >> ");
                    month = Convert.ToInt32(ReadLine());
                Write("Enter the date of birth year only >> ");
                    year = Convert.ToInt32(ReadLine());

                relArray[i].Name = name;
                relArray[i].RelationShip = relationShip;
                relArray[i].Month = month;
                relArray[i].Day = day;
                relArray[i].Year = year;
            }
            // ---------------------------------------Sort-----------------------------------
            Array.Sort(relArray);
            for (i = 0; i < relArray.Length; i++)
            {
                WriteLine("Relative name: {0}", relArray[i].Name);
                WriteLine("Relative relationship: {0}", relArray[i].RelationShip);
                WriteLine("Relative date of birth: {0}-{1}-{2}",
                    relArray[i].Month, relArray[i].Day, relArray[i].Year);
            }
            WriteLine("---------------------");
            Write("Enter relative name: ");
            // ----------------------------------add new object--------------------------------*********
            Relative nameSearch = new Relative();
                nameSearch.Name = ReadLine();

            int x;
            x = Array.BinarySearch(relArray, nameSearch);
            if (x >= 0)
            {
                WriteLine("Relationship {0}, Birthday {1}-{2}-{3}", relArray[x].RelationShip, relArray[x].Month, relArray[x].Day, relArray[x].Year);
            }
            else
            {
                WriteLine("The name was not found");
            }
        }
        class Relative : IComparable
        {
            // ----------------------------------Auto Implemented-------------------------------------
            public string Name { get; set; }
            public string RelationShip { get; set; }
            public int Month { get; set; }
            public int Day { get; set; }
            public int Year { get; set; }

            // ------------------------------ICombarebale method help sorting------------------------- 
            int IComparable.CompareTo(object o)
            {
                int returnVal;
                Relative temp = (Relative)o;
                returnVal = Name.CompareTo(temp.Name);
                return returnVal;
            }
        }
    }
}
