using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Algorithm
    {
        private int To12h(int h)
        {
            return h > 12 ? h - 12 : h;
        }
        
        public double GetAngle(int h, int min)
        {
            double angle;
            double hDegrees;
            double minDegrees;

            //Assuming that hours represented in 24h format
            h = To12h(h);

            //Calculating angle clockwise from 12h mark to hour and minute hands separately
            hDegrees = h * 30 + min * 0.5;
            minDegrees = min * 6;

            //Finding hour and minute hands' angle difference
            angle = Math.Abs(hDegrees - minDegrees);
            
            //If found a bigger angle - calculate smaller angle and return it
            return angle > 180 ? 360 - angle : angle;
        }
    }
}
