namespace A033_CalculatorWithFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(45, 23);
            Console.WriteLine(  result);
        }

        private static int Add(int i, int j)
        {
            return i + j;
        }
    }
}
