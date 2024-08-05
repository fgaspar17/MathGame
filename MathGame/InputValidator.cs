using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal static class InputValidator
    {
        public static bool MenuValidator(string? input, out Options optionSelected)
        {
            optionSelected = Options.Unknown;
            if (input == null) return false;

            if (Options.TryParse<Options>(input.Trim(), out optionSelected))
            {
                return true;
            }

            return false;
        }

        public static bool DifficultyValidator(string? input, out Difficulty difficulty)
        {
            difficulty = new Difficulty();
            if (input == null) return false;

            if (Difficulty.TryParse<Difficulty>(input.Trim(), out difficulty))
            {
                return true;
            }

            return false;
        }

        public static bool OperationValidator(string? input, Operation operation)
        {
            int result = 0;

            if (input == null) return false;
            if(!int.TryParse(input,out result))
            {
                return false;
            }
            if(result != operation.PerformOperation())
            {
                return false;
            }

            return true;
        }
    }
}
