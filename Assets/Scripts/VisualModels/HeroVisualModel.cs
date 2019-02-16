using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroVisualModel : MonoBehaviour
{
	[SerializeField]
	private Text health;
	[SerializeField]
	private Text block;
	[SerializeField]
	private Text mana;

	public void SetHealth(int health, int maxHealth)
	{
		if (health < 0)
		{
			health = 0;
		}
		this.health.text = health.ToString() + "/" + maxHealth.ToString();
	}

	public void SetBlock(int block)
	{
		this.block.text = block.ToString();
	}

	public void SetMana(int mana, int maxMana)
	{
		this.mana.text = mana.ToString() + "/" + maxMana.ToString();
	}
}
