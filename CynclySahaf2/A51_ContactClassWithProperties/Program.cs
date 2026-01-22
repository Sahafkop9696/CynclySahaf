namespace A51_ContactClassWithProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact();
            contact.Name = "Sahaf";
            contact.Address = "Kozhikode";
            Console.WriteLine($"Hello {contact.Name} You are from {contact.Address}");
        }
    }
}
