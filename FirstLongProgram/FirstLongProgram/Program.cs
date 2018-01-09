using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLongProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string myFirstname,  myLastname;
            double myTax,myRec, total = 0.0;
            int mySal ,TaxRate, myPer;
            Console.WriteLine("\nPlease Enter Your First Name\n");
            myFirstname = Console.ReadLine();
            Console.WriteLine("\nPlease Enter Your Last Name\n");
            myLastname = Console.ReadLine();
            Console.WriteLine("\nPlease Enter Your Salary\n");
            mySal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPlease Enter Your TaxRate\n");
            TaxRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPlease Enter Your period in months\n");
            myPer = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i <=myPer; i++)
            {
            total +=mySal;
            }
            myTax = total * TaxRate / 100;
                myRec = total - myTax;
            Console.WriteLine($"My First Name is {myFirstname}\nMy Last Name is {myLastname}\nMy Salary for {myPer} months is {total}$\nMy Total Tax for 12 months is {myTax}$\nMy Total Amount Received for 12 months is {myRec}$");
            Console.ReadKey();
            }
    }
}
