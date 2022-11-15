using System;

namespace LineComparisonComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("welcome to line comparision Problem");
            Comparison compare1 = new Comparison(3, 5, 8, 7);
            double line1 = compare1.calculate();
            Comparison compare2 = new Comparison(3, 5, 8, 7);
            double line2 = compare2.calculate();

            if (line1.CompareTo(line2) == 0)
            {
                Console.WriteLine("line1 and line2 are equal");
            }
            else
            {
                Console.WriteLine("line1 and line2 are not equal");
            }
        }

    }
}