using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm kuvab, mitu 'a' tähte kasutaja ees ja perekonnanimes kokku on'

            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName}{lastName}".ToLower();

            int counter = 0;

            foreach(char character in fullName)
            { 
            if(character == 'a')
                {
                    counter++; 
                }
            }

            Console.WriteLine($"Sinu nimes on {counter} a-tähte");
        }
    }
}
