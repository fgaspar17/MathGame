using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    // TODO: Convertir en interface
    internal class MathOperations
    {
        public int FirstOperand { get; init; }
        public int SecondOperand { get; init; }

        // TODO: Añadir dificultad en el Next()
        public static MathOperations GetOperation(Options option)
        {
            return option switch
            {
                Options.Addition or Options.Multiplication or Options.Subtraction =>
                    new MathOperations() { FirstOperand = GlobalRandom.Instance.Next(0, 101), SecondOperand = GlobalRandom.Instance.Next(0, 101) },
                Options.Division =>
                    GetDivision(),
                _ => throw new InvalidEnumArgumentException($"The option {Enum.GetName(typeof(Options), option)} isn't valid")

            };
        }

        // Divisor or SeconOperand between 80 and 100 and it must be an integer division
        private static MathOperations GetDivision()
        {
            int dividend;
            int divisor;

            do
            {
                dividend = GlobalRandom.Instance.Next();
                divisor = GlobalRandom.Instance.Next(80, 101);
            }
            while (dividend % divisor != 0);

            return new MathOperations() { FirstOperand = dividend, SecondOperand = divisor };
        }

        public static int PerformOperation(Options option, MathOperations math)
        {
            int result;

            switch (option)
            {
                case Options.Addition:
                    result = math.FirstOperand + math.SecondOperand;
                    break;
                case Options.Subtraction:
                    result = math.FirstOperand - math.SecondOperand;
                    break;
                case Options.Multiplication:
                    result = math.FirstOperand * math.SecondOperand;
                    break;
                case Options.Division:
                    result = math.FirstOperand / math.SecondOperand;
                    break;
                default:
                    throw new InvalidEnumArgumentException($"The option {Enum.GetName(typeof(Options), option)} isn't valid");
            }

            return result;
        }
    }
}
