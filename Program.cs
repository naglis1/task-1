using System;

namespace Task1
{
    class Program
    {
        Program()
        {
            InOut io = new InOut();
            Algorithm algo = new Algorithm();

            io.Input(ref h, ref min);
            angle = algo.GetAngle(h, min);
            io.Output(angle);
        }

        int h;
        int min;
        double angle; //Angle measured in degrees

        static void Main(string[] args)
        {
            new Program();
        }             
    }
}
