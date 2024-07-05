using MathGame.Enums;

namespace MathGame.Games;

public class RandomOperation : Game
{
    public RandomOperation(ResultKeeper resultKeeper) : base(resultKeeper)
    {
        Settings.GameType = GameType.Random;
    }

    public override void Start()
    {
        while (!Quit)
        {
            if (NewGame)
            {
                PrintMenu(StylizedTitles.Random, "Each question will be a random operation between two numbers.");
            }

            ReadAndRouteUserSelection();
        }
    }
}