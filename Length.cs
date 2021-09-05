using System;

namespace LineComparsion.cs
{
    class LineComparision
    {
        //UC1 for Calculation of length using cartesian system 
        //two points (x1,y1) & (x2,y2)
        static double distance(int x1, int y1, int x2, int y2)
        {
            //math expression Math method() 
            double lineLength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double length = Math.Round(lineLength, 2);
            return length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("line length:" + LineComparision.distance(5, 6, 6, 5));
            Console.ReadLine();
        }
    }
}
