using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class UserInterface
    {
        public static Options ShowMenu()
        {
            Options optionSelected = new Options();
            bool validSelection = false;
            do
            {
                DisplayMenuOptions();
                Console.Write("Please enter a number (1-9): ");
                validSelection = InputValidator.MenuValidator(Console.ReadLine(), out optionSelected);
                if (!validSelection)
                {
                    Console.WriteLine("Invalid selection. Please try again.");

                }

            } while (!validSelection);

            return optionSelected;
        }

        public static int ShowOperation(Operation operation)
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
            Console.WriteLine();
            Console.WriteLine("History:");
            foreach (GameRecord record in history)
            {
                Console.WriteLine(record.ToString());
            }
            Console.WriteLine();
        }

        public static Difficulty ShowDifficultyOptions()
        {
            Difficulty difficulty = new Difficulty();
            bool validSelection = false;
            do
            {
                DisplayDifficultyOptions();
                Console.Write("Please enter a number (1-3): ");
                validSelection = InputValidator.DifficultyValidator(Console.ReadLine(), out difficulty);
                if (!validSelection)
                {
                    Console.WriteLine("Invalid selection. Please try again.");

                }

            } while (!validSelection);

            return difficulty;
        }

        public static int ShowNumberOfGames()
        {
            int result;
            bool validSelection = false;
            do
            {
                Console.Write("Please enter a number of games: ");
                validSelection = int.TryParse(Console.ReadLine(), out result);
                if (!validSelection)
                {
                    Console.WriteLine("Invalid selection. Please try again.");

                }

            } while (!validSelection);

            return result;
        }

        private static void DisplayMenuOptions()
        {
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Random Game");
            Console.WriteLine("6. Number of Games");
            Console.WriteLine("7. History");
            Console.WriteLine("8. Choose Difficulty");
            Console.WriteLine("9. Quit");
        }

        private static void DisplayDifficultyOptions()
        {
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Hard");
        }
    }
}
