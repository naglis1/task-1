using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class InOut
    {
        public void Input(ref int h, ref int min)
        {
            Console.WriteLine("Hours: ");
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Minutes: ");
            min = Convert.ToInt32(Console.ReadLine());
        }
        public void Output(double angle)
        {
            Console.WriteLine($"Angle is: {angle}");
        }
    }
}
