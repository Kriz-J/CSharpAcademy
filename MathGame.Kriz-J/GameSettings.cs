﻿namespace MathGame.Kriz_J;

public enum Difficulty
{
    Easy = 'E',
    Medium = 'M',
    Hard = 'H'
}

public enum Mode
{
    Standard = 'S',
    Timed = 'T',
    Custom = 'C'
}

public class GameSettings
{
    public Difficulty Difficulty { get; set; } = Difficulty.Easy;

    public Mode Mode { get; set; } = Mode.Standard;

    public int NumberOfQuestions { get; set; } = 10;

    public (int Lower, int Upper) IntegerBounds => SetIntegerBounds(Difficulty);

    private static (int lower, int upper) SetIntegerBounds(Difficulty difficulty)
    {
        return difficulty switch
        {
            Difficulty.Easy => (lower: 1, upper: 10),
            Difficulty.Medium => (lower: 11, upper: 100),
            Difficulty.Hard => (lower: 101, upper: 1000),
            _ => throw new ArgumentOutOfRangeException(nameof(difficulty), difficulty, "Only '[E]asy', '[M]edium', and '[H]ard' are accepted as difficulties.")
        };
    }

    public void ChangeDifficultyOrMode(char input)
    {
        if (Enum.IsDefined(typeof(Difficulty), (int)input))
            Difficulty = (Difficulty)input;

        if (Enum.IsDefined(typeof(Mode), (int)input))
            Mode = (Mode)input;
    }

    public static void PrintGameDifficulties(Difficulty difficulty)
    {
        switch (difficulty)
        {
            case Difficulty.Easy:
                ConsoleHelperMethods.FormatWriteLineWithHighlight("", "\t\t[E]asy", " [M]edium [H]ard");
                break;
            case Difficulty.Medium:
                ConsoleHelperMethods.FormatWriteLineWithHighlight("\t\t[E]asy ", "[M]edium", " [H]ard");
                break;
            case Difficulty.Hard:
                ConsoleHelperMethods.FormatWriteLineWithHighlight("\t\t[E]asy [M]edium ", "[H]ard", "");
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(difficulty), difficulty, null);
        }
    }

    public static void PrintGameModes(Mode mode)
    {
        switch (mode)
        {
            case Mode.Standard:
                ConsoleHelperMethods.FormatWriteLineWithHighlight("", "\t\t[S]tandard", " [T]imed [C]ustom");
                break;
            case Mode.Timed:
                ConsoleHelperMethods.FormatWriteLineWithHighlight("\t\t[S]tandard ", "[T]imed", " [C]ustom");
                break;
            case Mode.Custom:
                ConsoleHelperMethods.FormatWriteLineWithHighlight("\t\t[S]tandard [T]imed ", "[C]ustom", "");
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
        }
    }
}