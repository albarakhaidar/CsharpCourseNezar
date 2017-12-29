using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatingPluseMiuse
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 7;
            int myVar2 = 3;

            int temp1 = myVar1 + myVar2;
            int temp2 = myVar1 - myVar2;
            int temp3 = myVar1 * myVar2;
            int temp4 = myVar1 / myVar2;
            int temp5 = myVar1 % myVar2;

            String myString1 = "I am";
            String myString2 = " Smart";
            String myString3 = myString1 + myString2;

            Console.WriteLine("{0} \n{1} \n{2} \n{3} \n{4} \n\n{5}",temp1, temp2, temp3,temp4,temp5,myString3);
            Console.ReadKey();
        }
    }
}
