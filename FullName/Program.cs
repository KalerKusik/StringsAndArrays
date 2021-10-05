using System;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm võrdleb sisestatud andmeid omavahel
            //programm kuvab konsoolis, kumb on pikem - eesnimi või perekonnanimi

            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();

            if (firstName.Length < lastName.Length)
            {
                Console.WriteLine("Last name is longer");
            }
            else if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("First name is longer");
            }

            else
            {
                Console.WriteLine("They are the same length");
            }

            }    
        }
    }