using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public enum Options { Addition, Substraction, Multiplication, Division, History, Quit }
    internal class UserInterface
    {
        public static Options ShowMenu()
        {
            
            do
            {
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Substraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. History");
                Console.WriteLine("6. Quit");
            } while (true);
        }
    }
}
