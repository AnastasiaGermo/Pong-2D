using Godot;
using System;

public class Ball : KinematicBody2D
{

    public Vector2 velocity = new Vector2(200, 200);

    public override void _Process(float delta)
    {
        // Move the ball
        MoveAndSlide(velocity);


        // Check collisions with left and right walls
        if (Position.x < 0 || Position.x > GetViewportRect().Size.x)
        {
            if (Position.x < 0)
                Autoload.IncrementPaddleScore();
            else
                Autoload.IncrementPaddleScore();

            GetTree().ReloadCurrentScene();
        }
        

        if (Position.y < 0 || Position.y > GetViewportRect().Size.y)
            velocity.y = -velocity.y;
    }
    public void Bounce(Vector2 normal)
    {
        velocity = velocity.Bounce(normal);
    }

    public void OnPaddleCollision(KinematicBody2D paddle)
    {
        // Reverse the ball's horizontal velocity
        velocity.x = -velocity.x;
    }

}
