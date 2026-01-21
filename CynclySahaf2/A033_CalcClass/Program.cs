namespace A33_CalculatorFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int i, j, result = 0;

            string @operator = string.Empty;
            Console.Write(" Enter Value 1 : ");
            i = Int32.Parse(Console.ReadLine());

            Console.Write("Enter Value 2 : ");
            j = Int32.Parse(Console.ReadLine());


            Console.Write("Enter operator (+, -, * or /) : ");
            @operator = Console.ReadLine();

            if (@operator == "+")
            {
                result = Add(i, j);

            }

            else if (@operator == "-")
            {
                result = Subtract(i, j);
            }

            else if (@operator == "/")
            {
                result = Divide(i, j);
            }


            else if (@operator == "*")
            {
                result = Multiply(i, j);
            }
            Console.WriteLine(result);


        }

        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static int Subtract(int x, int y)
        {
            return x - y;
        }
        private static int Divide(int x, int y)
        {
            return x / y;
        }
        private static int Multiply(int x, int y)
        {
            return x * y;
        }

    }
}