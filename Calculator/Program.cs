// See https://aka.ms/new-console-template for more information
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2;
            string operation;
 
            //asia ma psa :) 
            if ( operation == "dodaj" )
            {
                Console.WriteLine("Wynik: " + (number1 + number2));
            }
            else
            if ( operation == "odejmij")
            {
                Console.WriteLine("Wynik: " + (number1 - number2));
            }
            else
            if (operation == "pomnóż")
            {
                Console.WriteLine("Wynik: " + (number1 * number2));
            }
            else
            if (operation == "podziel")
            {
                Console.WriteLine("Wynik: " + (number1 / number2));
            }
        }

    }
}
