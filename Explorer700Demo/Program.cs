using Explorer700Library;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;

namespace Explorer700Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Explorer700 exp = new Explorer700();

            while (true)
            {
                // Toggle LED 1
                exp.Led1.Toggle();

                // Toggle LED 2
                exp.Led2.Toggle();
                
                // Joystick Interaction
                if (!exp.Joystick.Keys.Equals(Keys.NoKey))
                {
                    Console.WriteLine(exp.Joystick.Keys);
                }
                if (exp.Joystick.Keys.Equals(Keys.Up))
                {
                    // Buzzer
                    exp.Buzzer.Beep(500);
                }
                
                // Graphics
                Graphics g = exp.Display.Graphics;
                Pen p = new Pen(Brushes.Aqua);
                g.DrawString("Hello World!", new Font(new FontFamily("arial"), 8, FontStyle.Bold),
                    Brushes.White , new PointF(5, 50));
                exp.Display.Update();
                
                Thread.Sleep(1000);                
            }
        }

    }
}
