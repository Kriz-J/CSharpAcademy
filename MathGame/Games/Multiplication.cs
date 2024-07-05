using MathGame.Enums;

namespace MathGame.Games;

public class Multiplication : Game
{
    public Multiplication(ResultKeeper resultKeeper) : base(resultKeeper)
    {
        Settings.GameType = GameType.Multiplication;
    }

    public override void Start()
    {
        while (!Quit)
        {
            if (NewGame)
            {
                PrintMenu(StylizedTitles.Multiplication,"Each question will be a multiplication problem between two factors.");
            }

            ReadAndRouteUserSelection();
        }
    }
}