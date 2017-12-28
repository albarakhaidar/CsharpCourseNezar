using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.floatpointType
{
    class Program
    {
        static void Main(string[] args)
        {
            float flMin = float.MinValue;
            float flMax = float.MaxValue;
            Console.WriteLine("float Min Value = {0} float Max Value = {1}", flMin, flMax);

            float flVar = 1F / 3;
            double dlVar = 1D / 3;
            decimal dcVar = 1M / 3;

            Console.WriteLine("\n float Variable Value = {0}\n double Variavle Value ={1}\n decimal Variable Value ={2}", flVar, dlVar, dcVar);
            
            Console.ReadKey();
        }
    }
}
