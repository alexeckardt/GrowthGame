using Godot;
using System;

public class Player : KinematicBody2D
{
	// Declare member variables here. Examples:
	// private int a = 2;dddd
	// private string b = "text";
	private float MoveSpeed = 1.25f;
	

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

  // Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta)
	{
		//Get Move Input
		Vector2 input = inputVec();
		Vector2 velocity = new Vector2();
		
		//Move
		var collision = this.MoveAndCollide(input * MoveSpeed * delta);
		
		GD.Print(this.Position);
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
		return input;
	}
}
