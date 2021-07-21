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
                    io.Input(ref h, ref min);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Time is invalid or not in 24h format");
                    Console.WriteLine("\"e\" to end program, \"r\" to repeat: ");
                    string e = Console.ReadLine();
                    if (e == "e")
                    {
                        return;
                    }
                    else if (e == "r")
                    {
                        continue;
                    }
                }
                break;
            }
            
            angle = algo.GetAngle(h, min);
            io.Output(angle);
        }

        static void Main(string[] args)
        {
            new Program();
        }             
    }
}
