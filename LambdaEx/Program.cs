using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaEx
{
     class Program
    {
        delegate int deleg(int i);
        static void Main(string[] args)
        {

            deleg Mydeleg = a => a * a;
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Mydeleg(x));
            Console.WriteLine(Mydeleg(x));
        }
    }
}
