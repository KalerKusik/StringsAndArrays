using System;

namespace FullNameReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm kuvab kasutaja eesnime ja perekonnanime tagurpidi
            //*eesnimi ja perekonnanimi kuvatakse eraldi
            //kasutame for-tsüklit

            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();

            for (int i = firstName.Length - 1; i >= 0; i--)
            {
                Console.Write(firstName[i]);
            }
            Console.Write(" ");
            for (int i = lastName.Length - 1; i >= 0; i--)
            {
                Console.Write(lastName[i]);
            }
        }
    }
}
