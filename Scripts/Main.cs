using Godot;
using System;

public class Main : Node2D
{
    private Ball _ball;
    private Paddle paddle;
    


    public override void _Ready()
    {
        _ball = GetNode<Ball>("Ball");
        paddle = GetNode<Paddle>("Paddle");
        

}

public override void _Process(float delta)
    {
        // Handle game logic here
    }
}
