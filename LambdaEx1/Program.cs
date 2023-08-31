using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 56, 72, 23 };
            double av = numbers.Where(n  => n % 2 == 1).Average();
            Console.WriteLine(av);
        }
    }
}
