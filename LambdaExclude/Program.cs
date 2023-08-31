using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] src = new[] { 1, 2, 3, 4, 6, 7, 8, 12, 45, 2, 4, 9 };
            foreach (var i in src.Where(x =>
            {
                if (x <= 3) return true;
                else if (x >7) return true;
                return false;
            }))


                Console.WriteLine(i);
           
        }
    }
}
