using Godot;
using System;

public class Paddle : KinematicBody2D
{
    private const float Speed = 300;
    private Vector2 screenSize;

    public override void _Ready()
    {
        // Get the size of the game window
        screenSize = GetViewportRect().Size;
    } 


    public override void _Process(float delta)
    {
        var velocity = Vector2.Zero;

        if (Input.IsActionPressed("ui_up"))
            velocity.y -= Speed;
        if (Input.IsActionPressed("ui_down"))
            velocity.y += Speed;

        

        velocity = MoveAndSlide(velocity);

        ClampToScreen();


    }

  
    public void OnBallCollision(KinematicBody2D ball)
    {
        // Reverse the ball's vertical velocity
        var ballScript = (Ball)ball;
        ballScript.velocity.y = -ballScript.velocity.y;
    }

    private void ClampToScreen()
    {
        // Get the current position of the player
        Vector2 position = Position;

        // Clamp the position to be within the screen boundaries
        //position.x = Mathf.Clamp(position.x, 0, screenSize.x);
        position.y = Mathf.Clamp(position.y, 0, screenSize.y);

        // Set the updated position
        Position = position;
    }





}
