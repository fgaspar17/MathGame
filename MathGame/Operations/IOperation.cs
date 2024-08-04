using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal interface IOperation
    {
        int FirstOperand { get; init; }
        int SecondOperand { get; init; }

        int PerformOperation();
    }
}
