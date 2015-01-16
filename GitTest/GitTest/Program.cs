using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello 1111!");
            var t = new TestClass(5, 10).Sum();
            Console.WriteLine(t);
            Console.ReadKey();
        }
    }
}
