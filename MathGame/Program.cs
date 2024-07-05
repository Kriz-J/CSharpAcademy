using MathGame;

var mainMenu = new MainMenu();

while (!mainMenu.Quit)
{
    MainMenu.Print();
    mainMenu.Selection = ConsoleHelperMethods.ReadUserSelection();
    mainMenu.RouteSelection();
}