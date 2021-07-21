using System;

namespace Task1
{
    class InOut
    {
        public void Input(ref int h, ref int min)
        {
            Console.WriteLine("Enter time in 24h format");
            Console.WriteLine("Hours: ");
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Minutes: ");
            min = Convert.ToInt32(Console.ReadLine());

            if (h < 0 || h > 23 || min < 0 || min > 59)
            {
                throw new ArgumentOutOfRangeException("Time is invalid or not in 24h format");
            }
        }
        public void Output(double angle)
        {
            Console.WriteLine($"Angle is: {angle} degrees");
        }
    }
}
