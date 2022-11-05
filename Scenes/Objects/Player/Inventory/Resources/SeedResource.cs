using Godot;
using System;

public interface SeedResource : Resource 
{

	float GetMaxDamage();

	float GetMaxDamageRange();

	float GetFallOffDistance();

	float GetMinimumDamage();

}
