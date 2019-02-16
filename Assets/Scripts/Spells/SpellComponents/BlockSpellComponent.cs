using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpellComponent : SpellComponent
{

	[SerializeField]
	private int block;

	public override void SpellPreset()
	{
		if (GameConfigManager.Instance.isDebug)
			Debug.Log("BlockSpellComponent Preset");

		BattleManager.Instance.enemyVisualModel.SetAnnouncedBlock(block);
	}

	public override void AnnouncedAction()
	{
		if (GameConfigManager.Instance.isDebug)
			Debug.Log("BlockSpellComponent AnnouncedAction");

		BattleManager.Instance.enemyAvatar.Block = block;
		BattleManager.Instance.enemyVisualModel.SetBlock(block);
	}
}
