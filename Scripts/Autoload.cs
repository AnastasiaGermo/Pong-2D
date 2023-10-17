using Godot;
using System;

public class Autoload : Node2D
{
    private static int player1Score = 0;
    private static int player2Score = 0;

    // Getter methods for scores
    public static int GetPlayer1Score() => player1Score;
    public static int GetPlayer2Score() => player2Score;

    // Increment player 1 score
    public static void IncrementPlayer1Score()
    {
        player1Score++;
        GD.Print("Player 1 Score: ", player1Score);
    }

    // Increment player 2 score
    public static void IncrementPlayer2Score()
    {
        player2Score++;
        GD.Print("Player 2 Score: ", player2Score);
    }
}
