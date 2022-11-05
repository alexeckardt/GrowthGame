using Godot;
using System;

public abstract class Gun : Node
{
	//Stats
	private float FireRate = 1f;
	private int MagazineSize = 30;
	private float ReloadSeconds = 1f;
	
	private SeedResource ammo;
}
