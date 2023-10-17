using Godot;
using System;

public class Autoload : Node2D
{
    private static int paddleScore = 0;
    private static int paddle2Score = 0;

    // Getter methods for scores
    public static int GetPaddleScore() => paddleScore;
    public static int GetPaddle2Score() => paddle2Score;

    // Increment player 1 score
    public static void IncrementPaddleScore()
    {
        paddleScore++;
        GD.Print("Player 1 Score: ", player1Score);
    }

    // Increment player 2 score
    public static void IncrementPaddle2Score()
    {
        paddle2Score++;
        GD.Print("Player 2 Score: ", player2Score);
    }
}
