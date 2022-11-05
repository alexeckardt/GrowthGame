using Godot;
using System;

public class CarrotSeed : SeedResource
{
	//Instance Variables
	private int Amount;

	//
	// Resource Properties
	//
	private static Sprite Sprite = null;
	private static int MaxAmount = 0;

	//Point Blank Damage
	private static float MaxDamage = 10f;
	private static float MaxDamageRange = 100f; 

	//Fall Off Damage (Range is the falloff amount)
	private static float MinDamage = 5f;
	private static float FallOffRange = 100; 

	//
	//
	//

	public CarrotSeed() {
		this.Amount = 0;
	}

	public CarrotSeed(int amount) {
		this.Amount = amount;
	}

	//
	// Instance Modification
	//

	public Resource Split(int amount) {

		//Decide REAL Amount
		//Currently Doesn't Matter (Make sure if you split more then you remove me as an instance)

		//Create
		CarrotSeed splittee = new CarrotSeed(amount);

		//Remove Amount
		this.Amount -= amount;

		return splittee;
	}

	//
	// Gets
	//

	public int GetMaxAmount()
	{
		return CarrotSeed.MaxAmount;
	}

	public int GetAmount()
	{
		return Amount;
	}

	public Sprite GetSprite()
	{
		return CarrotSeed.Sprite;
	}

	public float GetMaxDamage()
	{
		return CarrotSeed.MaxDamage;
	}

	public float GetMaxDamageRange()
	{
		return CarrotSeed.MaxDamageRange;
	}

	public float GetFallOffDistance()
	{
		return CarrotSeed.FallOffRange;
	}

	public float GetMinimumDamage()
	{
		return CarrotSeed.MinDamage;
	}
}
