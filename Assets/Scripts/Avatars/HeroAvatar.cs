using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HeroAvatar : IAvatar
{
	private int health;
	public int maxHealth { get; private set; }

	public int mana;
	public int maxMana;

	public int Health
	{
		get
		{
			return health;
		}

		set
		{
			if (value <= 0)
			{
				health = 0;
			}
			else
			{
				health = value;
			}

			if (health == 0)
			{
				InputController.Instance.Defeat();
			}
		}
	}

	public int Block { get; set; }

	public HeroAvatar(int maxHealth, int maxMana)
	{
		this.health = maxHealth;
		this.maxHealth = maxHealth;

		this.mana = 0;
		this.maxMana = maxMana;
	}
}
