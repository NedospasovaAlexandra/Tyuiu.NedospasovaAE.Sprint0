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
            Console.WriteLine(DataService.Addition(1, 5));
            Console.WriteLine(DataService.Subtraction(6, 2));
            Console.WriteLine(DataService.Multiplication(2, 3));
            Console.WriteLine(DataService.Division(6, 3));
            Console.ReadKey();
        }
    }
}
