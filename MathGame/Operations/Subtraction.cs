using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Subtraction : Operation
    {
        public int FirstOperand { get; init; }
        public int SecondOperand { get; init; }

        public Subtraction(Difficulty difficulty) : base(difficulty) { }

        public override int PerformOperation()
        {
            return FirstOperand - SecondOperand;
        }

        public override string ToString()
        {
            return $"{FirstOperand} - {SecondOperand}";
        }
    }
}
