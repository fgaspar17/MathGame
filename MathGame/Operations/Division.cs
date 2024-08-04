using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Division : IOperation
    {
        public int FirstOperand { get; init; }
        public int SecondOperand { get; init; }

        public Division()
        {
            int dividend;
            int divisor;

            do
            {
                dividend = GlobalRandom.Instance.Next();
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
