namespace A35_MethodOverloadingHello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strHello = Hello();
            Console.WriteLine(strHello);

            strHello = Hello("Rithin");

            Console.WriteLine(strHello);

            strHello = Hello("Megha", "Kochi");
            Console.WriteLine(strHello);

        }

        internal static string Hello()
        {
            return "Hello Aswin";
        }
        internal static string Hello(string name)
        {
            return $"Hello {name}";
        }
        internal static string Hello(string name, string location)
        {
            return $"Hello {name}, located at {location}";
        }
    }
}