using System;

namespace Task1
{
    class Program
    {
        int h;
        int min;
        double angle; //Angle measured in degrees

        Program()
        {
            InOut io = new InOut();
            Algorithm algo = new Algorithm();

            while (true)
            {
                try
                {
                    io.TimeInput(ref h, ref min);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Time is invalid or not in 24h format");
                    Console.WriteLine("\"e\" to end program, any ohter input to repeat: ");
                    string e = Console.ReadLine();
                    if (e == "e")
                    {
                        return;
                    }
                    else
                    {
                        continue;
                    }
                }
                break;
            }
            
            angle = algo.GetAngle(h, min);
            io.AngleOutput(angle);
        }

        static void Main(string[] args)
        {
            new Program();
        }             
    }
}
