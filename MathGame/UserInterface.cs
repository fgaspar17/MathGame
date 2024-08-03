using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public enum Options { Unknown = 0, Addition = 1, Substraction = 2, Multiplication = 3, Division = 4, History = 5, Quit = 6, }
    internal class UserInterface
    {
        public static Options ShowMenu()
        {
            Options optionSelected = new Options();
            do
            {
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Substraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. History");
                Console.WriteLine("6. Quit");
            } while (InputValidator.MenuValidator(Console.ReadLine(), out optionSelected) == false);

            return optionSelected;
        }
    }
}
