using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VL1
{
    public class Starter
    {
        static void Main(string[] args)
        {
            HelloWorld.PrintMessage("Hello World", false);
            HelloWorld.PrintMessage("Hello World", true);

            ClassA A = new ClassA("A");
            ClassB B0 = new ClassB();
            ClassB B1 = new ClassB("B1");
            ClassB B2 = new ClassB("B2", 2);

            Console.Read();

            Test test = new Test();

        }

    }
}
