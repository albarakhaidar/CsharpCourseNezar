using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeCarString
{
    class Program
    {
        static void Main(string[] args)
        {
            int charMin = char.MinValue;
            int charMax = char.MaxValue;

            char myVar = 'G';
            int myVarValue = 'G';

            char myVarValue2 = Convert.ToChar(myVarValue);
            Console.WriteLine(" Char MinValue ={0} Char Max Value = {1} My Char Variable = {2} My Char Value = {3} my Conversioan Value is = {4}", charMin, charMax , myVar, myVarValue, myVarValue2);

            String myString = "this is my variable value";
            Console.WriteLine("\nthis is my stinge {0}", myString);

            bool myBool = true;
            Console.WriteLine("\nMy Boolean Value is {0}", myBool);
            Console.ReadKey();

        }
    }
}
