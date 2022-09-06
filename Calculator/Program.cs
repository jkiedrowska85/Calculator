// See https://aka.ms/new-console-template for more information
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                char operation;
                double number1;
                double number2;
                char.TryParse(args[1], out operation);
                double.TryParse(args[0], out number1);
                double.TryParse(args[2], out number2);

                switch (operation)
                {
                    case '+':
                        {
                            Console.WriteLine("Wynik: " + (number1 + number2));
                            break;
                        }
                    case '-':
                        {
                            Console.WriteLine("Wynik: " + (number1 - number2));
                            break;
                        }
                    case '*':
                        {
                            Console.WriteLine("Wynik: " + (number1 * number2));
                            break;
                        }
                    case '/':
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

             
            }

        }
    }
}
