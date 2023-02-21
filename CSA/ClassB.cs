using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VL1
{
    public class ClassB
    {

        public ClassB(string msg, int count)
        {
            Console.Write("B:" + msg);
            for (int i = 0; i < count; i++)
            {
                Console.Write(".");
            }
            Console.Write(" ");
        }

        public ClassB(string msg) : this(msg, 0) { }

        public ClassB() : this("B0", 0) { }

    }
}
