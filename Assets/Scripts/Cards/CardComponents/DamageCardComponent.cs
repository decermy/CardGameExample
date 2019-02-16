using UnityEngine.UI;
using UnityEngine;

public class DamageCardComponent : CardComponent
{
	[SerializeField]
	private int damage;

	public override void RealizeComponent()
	{
		BattleManager battleManager = BattleManager.Instance;

		int currentBlock = battleManager.enemyAvatar.Block;
		int currentHealth = battleManager.enemyAvatar.Health;

		if (currentBlock >= damage)
		{
			currentBlock -= damage;
		}
		else
		{
			currentHealth -= damage - currentBlock;
			currentBlock = 0;
		}

		battleManager.enemyAvatar.Block = currentBlock;
		battleManager.enemyAvatar.Health = currentHealth;

		battleManager.enemyVisualModel.SetBlock(currentBlock);
		battleManager.enemyVisualModel.SetHealth(currentHealth, battleManager.enemyAvatar.maxHealth);
	}

	public override void SetFields()
	{
		GetComponent<Card>().CardField.damage = damage;
	}
}
