using Godot;
using System;

public interface Resource
{
	//Resource
	int GetAmount();

	int GetMaxAmount();

	Sprite GetSprite();

	//
	// Instance Modification
	//

	Resource Split(int amount);
}
