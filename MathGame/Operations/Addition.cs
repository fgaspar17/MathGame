using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Addition : IOperation
    {
        public int FirstOperand { get; init; }
        public int SecondOperand { get; init; }

        public Addition()
        {
            FirstOperand = GlobalRandom.Instance.Next(0, 101);
            SecondOperand = GlobalRandom.Instance.Next(0, 101);
        }

        public int PerformOperation()
        {
            return FirstOperand + SecondOperand;
        }

        public override string ToString()
        {
            return $"{FirstOperand} + {SecondOperand}";
        }
    }
}
