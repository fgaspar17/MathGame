using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public enum Options 
    { 
        Unknown = 0, 
        Addition = 1, 
        Subtraction = 2, 
        Multiplication = 3, 
        Division = 4, 
        RandomOperation = 5, 
        NumberOfGames = 6, 
        History = 7, 
        Difficulty = 8, 
        Quit = 9, 
    }
    public enum Difficulty { Easy = 1, Medium = 2, Hard = 3 }
    internal class Game
    {
        List<GameRecord> history = new List<GameRecord>();
        int idRecord = 1;

        Difficulty difficulty = Difficulty.Medium;

        DateTime init;
        DateTime end;

        int countCurrentGames = 0;
        int maxGames = 0;
        bool isGameCounting = false;

        bool continueRunning = true;

        public Game() { }

        public void Run()
        {
            while (continueRunning)
            {
                Options optionSelected = UserInterface.ShowMenu();

                continueRunning = HandleOption(optionSelected);

                if (isGameCounting) { countCurrentGames++; }
                if (isGameCounting && countCurrentGames >= maxGames) break;
            }
        }

        private bool HandleOption(Options optionSelected)
        {
            switch (optionSelected)
            {
                case Options.NumberOfGames:
                    maxGames = UserInterface.ShowNumberOfGames();
                    isGameCounting = true;
                    break;
                case Options.History:
                    UserInterface.ShowHistory(history);
                    break;
                case Options.Difficulty:
                    difficulty = UserInterface.ShowDifficultyOptions();
                    break;
                case Options.RandomOperation:
                    Options randomOperation = GetRandomOperation();
                    PerformMathOperation(randomOperation);
                    break;
                case Options.Quit:
                    return false;
                    break;
                default:
                    PerformMathOperation(optionSelected);
                    break;
            }

            return true;
        }

        private void PerformMathOperation(Options optionSelected)
        {
            Operation operation = optionSelected switch
            {
                Options.Addition => new Addition(difficulty),
                Options.Subtraction => new Subtraction(difficulty),
                Options.Multiplication => new Multiplication(difficulty),
                Options.Division => new Division(difficulty),
                _ => throw new InvalidEnumArgumentException($"The option {Enum.GetName(typeof(Options), optionSelected)} isn't valid")
            };

            init = DateTime.Now;
            UserInterface.ShowOperation(operation);
            end = DateTime.Now;

            history.Add(new GameRecord(idRecord++, operation.ToString(), operation.PerformOperation(), (end - init).Seconds));
        }

        private Options GetRandomOperation()
        {
            int random = GlobalRandom.Instance.Next(1, 5);
            return (Options)random;
        }
    }
}
