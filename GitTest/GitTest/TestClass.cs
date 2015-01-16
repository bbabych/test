using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    public class TestClass
    {
        public int X { get; set; }
        public int Y { get; set; }  
        public TestClass(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int Sum()
        {
            return X + Y;
        }
    }
}
