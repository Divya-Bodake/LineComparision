namespace LineComparisonComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparision Computation Program");
            Comparison comparison = new Comparison();
            comparison.value(2, 4, 6, 8);
            comparison.calculate();
        }
    }
}