using Godot;
using System;

public class Player : KinematicBody2D
{
	//Instance Variables
	private float MoveSpeed = 200f;
	private float acceleration = 0.45f; //Should ONLY be [0, 1]
	
	//Velocity
	private Vector2 velocity;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this.velocity = new Vector2();
	}

  // Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta)
	{
		//Get Move Input
		Vector2 input = inputVec();

		//Enterpolate Velocity
		//Lower "Acceleration" makes player feel more slippery
		Vector2 g = input * MoveSpeed;
		velocity = velocity.LinearInterpolate(g, acceleration);

		//Move + Get The Updated Velocity
		velocity = this.SnapVelocity(this.MoveAndSlide(velocity));

		//Output
		GD.Print(this.velocity);
	}
	
	public Vector2 inputVec() {
		
		//Get
		bool right = Input.IsKeyPressed((int) KeyList.D);
		bool left = Input.IsKeyPressed((int) KeyList.A);
		bool up = Input.IsKeyPressed((int) KeyList.W);
		bool down = Input.IsKeyPressed((int) KeyList.S);
		
		//move (ew)
		Vector2 input = new Vector2();
		if (right) input.x += 1;
		if (left) input.x -= 1;
		if (up) input.y -= 1;
		if (down) input.y += 1;
		
		//return
		return input.Normalized();
	}

	//Don't Do Weird 1.3245e-5 stuff in the velocity (don't move by neglageble amount)
	private Vector2 SnapVelocity(Vector2 v) => new Vector2((Math.Abs(v.x) < 0.001) ? 0 : v.x, (Math.Abs(v.y) < 0.001) ? 0 : v.y);
}
