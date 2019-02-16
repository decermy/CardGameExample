using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyAvatar : IAvatar
{
	public int maxHealth { get; private set; }

	public int attack { get; private set; }

	private int health;
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
				InputController.Instance.Win();
			}
		}
	}

	public int Block { get; set; }

	public Action enemyAction;

	public EnemyAvatar(int maxHealth)
	{
		this.health = maxHealth;
		this.maxHealth = maxHealth;
	}
}
