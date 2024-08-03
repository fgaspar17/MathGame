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
    }
}
