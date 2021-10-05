using System;

namespace SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloworld = Console.ReadLine();
            string partToLookFor = "pain";

            bool isThere;

            isThere = helloworld.ToLower().Contains(partToLookFor);

            if(isThere)
            {
                Console.WriteLine($"Leidsin {partToLookFor}");
            }
            else
            {
                Console.WriteLine($"Ei Leidnud {partToLookFor}");
            }
        }
    }
}
