using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NedospasovaAE.Sprint0.Task4.V0.Lib;

namespace Tyuiu.NedospasovaAE.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A - B = " + DataService.Subtraction(6, 2));
            Console.WriteLine("A * B = " + DataService.Multiplication(2, 3));
            Console.WriteLine("A / B = " + DataService.Division(6, 3));
            Console.ReadKey();
        }
    }
}