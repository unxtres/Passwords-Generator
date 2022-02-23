using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorHasel
{
    internal class Generator
    {
        private string lowercase = "abcdefghijklmnoprstuvwqxyz";
        private string uppercase = "ABCDEFGHIJKLMNOPRSTUVWQXYZ";
        private string numbers = "1234567890";
        private string specials = "!@#$%^&*()-_=+:;<>,./}{[]";
        private string characters = "";
        public void Start()
        {
            int PassLength;
            Console.Write("Podaj długość hasła jakie ma zostać wygenerowane: ");
            string PassLengthEntered = Console.ReadLine();
            PassLength = int.Parse(PassLengthEntered);

            Console.WriteLine(Gen(UserChoice(), PassLength));
        }

        public string UserChoice()
        {
            string lowerC, upperC, numberC, specialC;
            Console.Write("Czy używać małych liter [T/N]: ");
            do
            {
                lowerC = Console.ReadLine().ToUpper();
                if (lowerC == "T")
                {
                    characters += lowercase;
                    break;
                }
                if (lowerC == "N")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Zły wybór");
                    Console.WriteLine();
                }
            } while (lowerC != "T" || lowerC != "N");

            Console.Write("Czy używać dużych liter [T/N]: ");
            do
            {
                upperC = Console.ReadLine().ToUpper();
                if (upperC == "T")
                {
                    characters += uppercase;
                    break;
                }
                if (upperC == "N")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Zły wybór");
                    Console.WriteLine();
                }
            } while (upperC != "T" || upperC != "N");

            Console.Write("Czy używać liczb [T/N]: ");
            do
            {
                numberC = Console.ReadLine().ToUpper();
                if (numberC == "T")
                {
                    characters += numbers;
                    break;
                }
                if (numberC == "N")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Zły wybór");
                    Console.WriteLine();
                }
            } while (numberC != "T" || numberC != "N");

            Console.Write("Czy używać znaków specjalnych [T/N]: ");
            do
            {
                specialC = Console.ReadLine().ToUpper();
                if (specialC == "T")
                {
                    characters += specials;
                    break;
                }
                if (specialC == "N")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Zły wybór");
                    Console.WriteLine();
                }
            } while (specialC != "T" || specialC != "N");
            return characters;
        }

        private string Gen(string characters, int dlugosc)
        {
            Random rand = new Random();
            char[] pass = new char[dlugosc];

            for (int i = 0; i < dlugosc; i++)
            {
                pass[i] = characters[rand.Next(characters.Length -1)];
            }
            return String.Join("", pass);
        }
    }
}
