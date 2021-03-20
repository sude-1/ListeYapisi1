using System;

namespace ListeYapisi1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> customers = new MyDictionary<string, string>();
            customers.Add("2314", "Sude Karanlık");
            customers.Add("4352", "Mehmet Yıldız");
            customers.Add("6754", "Hande Tatlı");

            Console.WriteLine(customers.Count + " " + "Müşteri var");
            customers.Listing();
        }
    }
}
