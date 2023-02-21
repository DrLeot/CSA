using System;

namespace VL1
{
    class HelloWorld
    {
        public static void PrintMessage(string msg, bool upperCase)
        {
            if (upperCase)
            {
                //TODO msg auf Grossbuchstaben ändern
                Console.WriteLine(msg.ToUpper());
            }
            Console.WriteLine(msg);
        }
    }
}
