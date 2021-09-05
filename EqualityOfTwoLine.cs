using System;

namespace LineComparsion.cs
{
    class LineComparision
    {
        //UC2 equality of two line
        //Creating distance method to calculate length of a line using two points 
        static double distance(int x1, int y1, int x2, int y2)
        {
            //To evaluate math expression Math method() used 
            double lineLength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //Round method() 
            double length = Math.Round(lineLength, 2);
            return length;
        }
        static void Main(string[] args)
        {
            //Initializing two lines(line1,line2) by calling distance method
            double line1 = LineComparision.distance(5, 6, 6, 5);
            double line2 = LineComparision.distance(2, 3, 4, 7);
            Console.WriteLine("line length1:" + line1);
            Console.WriteLine("line length2:" + line2);
            if (double.Equals(line1, line2))
            {
                Console.WriteLine("{0} is equals to {1}", line1, line2);
            }
            else
            {
                Console.WriteLine("{0} is not equal to {1}", line1, line2);
            }
            Console.ReadLine();
        }
    }
}