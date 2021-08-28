using System;

namespace HelloWorldTesting20212
{
    class Program
    {
        static void Main(string[] args)
        {
            var utils = new StringUtilities();
            string texto = Console.ReadLine();

            bool esPalindrome = utils.EsPalindrome(texto);

            if(esPalindrome)
                Console.WriteLine("Si Es");
            else
                Console.WriteLine("No Es");

        }
    }
}
