using UnityEngine.UI;
using UnityEngine;

public class BlockCardComponent : CardComponent
{
	[SerializeField]
	private int block;

	public override void RealizeComponent()
	{
		BattleManager battleManager = BattleManager.Instance;
		battleManager.heroAvatar.Block += block;

		battleManager.heroVisualModel.SetBlock(battleManager.heroAvatar.Block);
	}

	public override void SetFields()
	{
		GetComponent<Card>().CardField.block = block;
	}
}
