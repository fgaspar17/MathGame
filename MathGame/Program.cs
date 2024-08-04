// See https://aka.ms/new-console-template for more information
using MathGame;
using System.ComponentModel;

List<GameRecord> history = new List<GameRecord>();
int idRecord = 1;

while (true)
{
    Options optionSelected = UserInterface.ShowMenu();
    // TODO: Validation for quit and history
    if(optionSelected == Options.Quit) break;

    if (optionSelected == Options.History)
    {
        UserInterface.ShowHistory(history);
        continue; 
    }

    IOperation operation = optionSelected switch
    {
        Options.Addition => new Addition(),
        Options.Subtraction => new Subtraction(),
        Options.Multiplication => new Multiplication(),
        Options.Division => new Division(),
        _ => throw new InvalidEnumArgumentException($"The option {Enum.GetName(typeof(Options), optionSelected)} isn't valid")
    };

    UserInterface.ShowOperation(operation);
    history.Add(new GameRecord(idRecord++, operation.ToString(), operation.PerformOperation()));
}

