// See https://aka.ms/new-console-template for more information
using MathGame;
using System.ComponentModel;

Options optionSelected = UserInterface.ShowMenu();
// TODO: Validation for quit and history
IOperation operation = optionSelected switch
{
    Options.Addition => new Addition(),
    Options.Subtraction => new Subtraction(),
    Options.Multiplication => new Multiplication(),
    Options.Division => new Division(),
    _ => throw new InvalidEnumArgumentException($"The option {Enum.GetName(typeof(Options), optionSelected)} isn't valid")
};

UserInterface.ShowOperation(operation);

