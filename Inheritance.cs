using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace OrderDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------Array-----------------------------
            double total = 0;
            int orderNumber;
            Order[] arrayList = new Order[5] ;
            for (int i = 0; i < arrayList.Length; i++)
            {
                Write("Enter order number: ");
                    orderNumber =Convert.ToInt32 (ReadLine());
                Write("Enter customer name: ");
                    string customerName = ReadLine();
                Write("Enter order quantity: ");
                    int quantityOrder = Convert.ToInt32(ReadLine());

                arrayList[i] = new Order(orderNumber, customerName, quantityOrder);
                // --------------- if same order number u have to change it---x----------------
                if (i > 0)
                {
                    for (int x = i-1; x >= 0; x--)
                    {
                        while(arrayList[i].OrderNumber == arrayList[x].OrderNumber)
                        {
                            WriteLine("Enter a different order number: ");
                            orderNumber = Convert.ToInt32(ReadLine());
                            arrayList[i].OrderNumber = orderNumber;
                        }
                    }
                }

                total += arrayList[i].TotalPrice;

            }
            for (int i = 0; i < arrayList.Length; i++)
            {
                WriteLine(arrayList[i].ToString());
            }
            WriteLine("The price total for all orders is: {0}", total.ToString("c"));
        }
    }
    class Order
    {
        //--------------------------------------------------Field-----------------------------------------------------
        private int orderNumber;
        private string custumerName;
        private int quantityOrdered;
        private double totalPrice;
        //------------------------------------------------Property-----------------------------------------------------
        public int OrderNumber
        {
            get { return this.orderNumber; }
            set { this.orderNumber = value; }
        }
        public string CustomerName
        {
            get { return this.custumerName; }
            set { this.custumerName = value; }
        }
        public int QuantityOrder
        {
            get { return this.quantityOrdered; }
            set { this.quantityOrdered = value; }
        }
        public double TotalPrice
        {
            get { return this.totalPrice; }

        }

        //------------------------------------------------Constructors-------------------------------------------------
        public Order(int orderNum, string customerN, int quantityO)
        {
            orderNumber = orderNum;
            custumerName = customerN;
            quantityOrdered = quantityO;
            totalPrice = quantityO * 19.95;
        }
        public Order()
            {

            }

        //--------------------------------------------------Equals-----------------------------------------------------
        public override bool Equals(object obj)
        {
            bool x = true;
            if (this.GetType() != obj.GetType())
                x = false;
            else
            {
                Order temp = (Order)obj;
                if (orderNumber == temp.orderNumber)
                    x = true;
                else
                {
                    x = false;
                }
            }
            return x;
        }

        // ------------------------------------test the equal methodes------------------------------------------------
        public static void TestEqual(Order ord1, Order ord2)
        {
            if (ord1.Equals(ord2))
                WriteLine("The orders number are equal");
            else
            {
                WriteLine("The orders number are not equal");
            }
        }
        //--------------------------------------------------GetHashCode------------------------------------------------
        public override int GetHashCode()
        {
            return OrderNumber;
        }
        //---------------------------------------------------ToString--------------------------------------------------
        public override string ToString()
        {
            return ("Order# " + GetHashCode() + " Name: " + CustomerName + ". For: " + QuantityOrder + " Items, Total price is: " + TotalPrice.ToString("c"));
        }
    }
}
