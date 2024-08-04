using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Division : IOperation
    {
        public int FirstOperand { get; init; }
        public int SecondOperand { get; init; }

        public Division(Difficulty difficulty)
        {
            int dividend;
            int divisor;

            do
            {
                switch (difficulty)
                {
                    case Difficulty.Easy:
                        dividend = GlobalRandom.Instance.Next(0, 11);
                        break;
                    case Difficulty.Medium:
                        dividend = GlobalRandom.Instance.Next(10, 101);
                        break;
                    case Difficulty.Hard:
                        dividend = GlobalRandom.Instance.Next(100, 201);
                        break;
                    default:
                        throw new InvalidEnumArgumentException($"The difficulty {Enum.GetName(typeof(Difficulty), difficulty)} isn't valid");
                }
                divisor = GlobalRandom.Instance.Next(80, 101);
            }
            while (dividend % divisor != 0);

            FirstOperand = dividend;
            SecondOperand = divisor;
        }

        public int PerformOperation()
        {
            return FirstOperand / SecondOperand;
        }

        public override string ToString()
        {
            return $"{FirstOperand} / {SecondOperand}";
        }
    }
}
