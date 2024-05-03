﻿using MathGame.Kriz_J.GameSections;

namespace MathGame.Kriz_J;

public class MainMenuSelection(char? value = null)
{
    public char? Value { get; } = value;

    public void Route()
    {
        GameSection _ = Value switch
        {
            'A' => new Addition(),
            'S' => new Subtraction(),
            'M' => new Multiplication(),
            'D' => new Division(),
            'R' => new RecentGames(),
            'Q' => new Quit(),
            _ => new NotImplemented()
        };
    }
}