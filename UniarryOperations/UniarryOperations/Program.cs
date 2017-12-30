using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniarryOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 7;
            int myVar2 = 2;
            int myVar3 = 5;

            int temp1 = ++myVar3;
            int temp2 = myVar1 / ++myVar2;

            Console.WriteLine("{0}\n {1}", temp1, temp2);
            Console.ReadKey();
        }
    }
}
