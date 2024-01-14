using Godot;
using System;

public partial class Player : CharacterBody2D
{
	private int speed = 100;
	private String playerState;

    public override void _PhysicsProcess(double delta)
    {
        Vector2 direction = Input.GetVector("left", "right", "up", "down");
		Vector2 velocity = Velocity;

		if(direction == Vector2.Zero){
			playerState = "idle";
		}
		else{
			playerState = "walking";
		}

		velocity = direction * speed;
		Velocity = velocity;

		MoveAndSlide();
    }

}
