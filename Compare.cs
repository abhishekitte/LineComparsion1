using System;

namespace LineComparision.cs
{
    class LineComparision
    {
        //UC3 comparing lengths of two lines
        static double distance(int x1, int y1, int x2, int y2)
        {
            double lineLength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double length = Math.Round(lineLength, 2);
            return length;
        }
        public static void comparingLines(string len1, string len2)
        {
            if (len1.CompareTo(len2) > 0)
            {
                Console.WriteLine("Line1 is greater than line2");
            }
            else if (len1.CompareTo(len2) < 0)
            {
                Console.WriteLine("Line1 is lesser than line2");
            }
            else
            {
                Console.WriteLine("Both lines are equal");
            }
        }
        static void Main(string[] args)
        {
            double line1 = LineComparision.distance(3, 4, 4, 3);
            double line2 = LineComparision.distance(4, 5, 8, 3);

            LineComparision.comparingLines(line1.ToString(), line2.ToString());
            Console.ReadLine();
        }
    }
}