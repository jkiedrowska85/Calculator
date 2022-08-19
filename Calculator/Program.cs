// See https://aka.ms/new-console-template for more information
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string operation = Console.ReadLine();
                double number1;
                double number2;
                bool resParse1, resParse2;
                resParse1 = double.TryParse(Console.ReadLine(), out number1);
                resParse2 = double.TryParse(Console.ReadLine(), out number2);

                switch (operation)
                {
                    case "dodaj":
                        {
                            Console.WriteLine("Wynik: " + (number1 + number2));
                            break;
                        }
                    case "odejmij":
                        {
                            Console.WriteLine("Wynik: " + (number1 - number2));
                            break;
                        }
                    case "mnóż":
                        {
                            Console.WriteLine("Wynik: " + (number1 * number2));
                            break;
                        }
                    case "dziel":
                        {
                            Console.WriteLine("Wynik: " + (number1 / number2));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Podałeś złą operacje");
                            break;
                        }
                }

                //}
                //if ( operation == "dodaj" )
                //{
                //    Console.WriteLine("Wynik: " + (number1 + number2));
                //}
                //else
                //if ( operation == "odejmij")
                //{
                //    Console.WriteLine("Wynik: " + (number1 - number2));
                //}
                //else
                //if (operation == "pomnóż")
                //{
                //    Console.WriteLine("Wynik: " + (number1 * number2));
                //}
                //else
                //if (operation == "podziel")
                //{
                //    Console.WriteLine("Wynik: " + (number1 / number2));
                //}
            }

        }
    }
}
