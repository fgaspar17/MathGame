using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public enum Options { Unknown = 0, Addition = 1, Subtraction = 2, Multiplication = 3, Division = 4, History = 5, Quit = 6, }
    internal class UserInterface
    {
        public static Options ShowMenu()
        {
            Options optionSelected = new Options();
            bool validSelection = false;
            do
            {
                DisplayMenuOptions();
                Console.Write("Please enter a number (1-6): ");
                validSelection = InputValidator.MenuValidator(Console.ReadLine(), out optionSelected);
                if (!validSelection)
                {
                    Console.WriteLine("Invalid selection. Please try again.");

                }

            } while (!validSelection);

            return optionSelected;
        }

        private static void DisplayMenuOptions()
        {
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction"); 
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. History");
            Console.WriteLine("6. Quit");
        }

        // TODO: return a result object with the data of the game to save it
        public static int ShowOperation(IOperation operation)
        {
            int result = 0;
            bool validInput = false;
            do
            {
                // Print the operation in console
                Console.WriteLine(operation.ToString());
                Console.Write("Please enter the result of the operation: ");

                validInput = InputValidator.OperationValidator(Console.ReadLine(), operation);
                if (!validInput)
                {
                    Console.WriteLine("Failed, try again!");
                }

            } while (!validInput);

            return result;
        }

        public static void ShowHistory(List<GameRecord> history)
        {
            foreach (GameRecord record in history)
            {
                Console.WriteLine();
                Console.WriteLine("History:");
                Console.WriteLine(record.ToString());
                Console.WriteLine();
            }
        }
    }
}
