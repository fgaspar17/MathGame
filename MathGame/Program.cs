// See https://aka.ms/new-console-template for more information
using MathGame;

Options optionSelected = UserInterface.ShowMenu();
// TODO: Validation for quit and history
MathOperations operation = MathOperations.GetOperation(optionSelected);
UserInterface.ShowOperation(optionSelected, operation);

