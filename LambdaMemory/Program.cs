using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LambdaMemory
{
     class Program
    {
        delegate bool D1();
        delegate bool D2(int i);
      
        class Test
        {
            D1 del1;
            D2 del2;
            public void testMetod(int input)
            {
                int p = 0;
                del1 = () => { p = 10; return p > input; };
                del2 = (x) => { return x == p; };
                Console.WriteLine("p={0}", p);
                bool boolresult = del1();
                Console.WriteLine("p={0},b={1}", p, boolresult);
            }
            static void Main(string[] args)
            {
                Test test = new Test();
                test.testMetod(9);
                bool res = test.del2(10);
                Console.WriteLine(res);
            }
    }
    
}
}
