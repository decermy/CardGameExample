
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSpellComponent : SpellComponent
{
	[SerializeField]
	private int damage;

	public override void SpellPreset()
	{
		if (GameConfigManager.Instance.isDebug)
			Debug.Log("DamageSpellComponent Preset");

		BattleManager.Instance.enemyVisualModel.SetAnnouncedAttack(damage);
	}

	public override void AnnouncedAction()
	{
		if (GameConfigManager.Instance.isDebug)
			Debug.Log("DamageSpellComponent AnnouncedAction");

		BattleManager battleManager = BattleManager.Instance;

		int currentBlock = battleManager.heroAvatar.Block;
		int currentHealth = battleManager.heroAvatar.Health;

		if (currentBlock >= damage)
		{
			currentBlock -= damage;
		}
		else
		{
			currentHealth -= damage - currentBlock;
			currentBlock = 0;
		}

		battleManager.heroAvatar.Block = currentBlock;
		battleManager.heroAvatar.Health = currentHealth;

		battleManager.heroVisualModel.SetBlock(currentBlock);
		battleManager.heroVisualModel.SetHealth(currentHealth, battleManager.heroAvatar.maxHealth);
	}
}
