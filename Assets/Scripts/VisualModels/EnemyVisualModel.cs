using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyVisualModel : MonoBehaviour
{
	[SerializeField]
	private Text health;
	[SerializeField]
	private Text block;
	[SerializeField]
	private Text announcedBlock;
	[SerializeField]
	private GameObject announcedBlockIcon;
	[SerializeField]
	private Text announcedAttack;
	[SerializeField]
	private GameObject announcedAttackkIcon;

	public void SetHealth(int health, int maxHealth)
	{
		if (health < 0)
		{
			health = 0;
		}
		this.health.text = health.ToString() + "/" + maxHealth.ToString();
	}

	public void SetAnnouncedAttack(int attack)
	{
		this.announcedAttack.text = attack.ToString();
	}

	public void SetBlock(int block)
	{
		this.block.text = block.ToString();
	}

	public void SetAnnouncedBlock(int block)
	{
		this.announcedBlock.text = block.ToString();
	}


}
