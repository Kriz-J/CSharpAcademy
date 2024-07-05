using MathGame.Enums;

namespace MathGame.Games;

public class Subtraction : Game
{
    public Subtraction(ResultKeeper resultKeeper) : base(resultKeeper)
    {
        Settings.GameType = GameType.Subtraction;
    }

    public override void Start()
    {
        while (!Quit)
        {
            if (NewGame)
            {
                PrintMenu(StylizedTitles.Subtraction, "Each question will be a subtraction problem between two terms.");
            }

            ReadAndRouteUserSelection();
        }
    }
}