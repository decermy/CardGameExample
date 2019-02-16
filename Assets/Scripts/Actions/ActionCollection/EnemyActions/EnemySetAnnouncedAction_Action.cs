using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "StateMachine/EnemyAction/EnemySetAnnouncedAction_Action", fileName = "EnemySetAnnouncedAction_Action")]
public class EnemySetAnnouncedAction_Action : StateAction
{

	public override void Do(Action DoTransitionCallback)
	{
		if (GameConfigManager.Instance.isDebug)
			Debug.Log("EnemySetAnnouncedAction");


		SetAction(GameConfigManager.Instance);

		DoTransitionCallback.Invoke();
	}

	private void SetAction(GameConfigManager gameConfigManager)
	{
		ClearAnnouncedActions();

		float chance = UnityEngine.Random.Range(0f, 1f);

		float spellsChanceSum = 0f;

		for (int i = 0; i < gameConfigManager.EnemyConfig.spells.Length; i++)
		{

			var spellChance = gameConfigManager.EnemyConfig.spells[i];

			if (chance >= spellsChanceSum && chance <= spellsChanceSum + spellChance.chance)
			{

				var spellComponents = spellChance.spell.spellComponents;

				UseSpellComponentsPresets(spellComponents);
				SetSpellAnnouncedAction(spellComponents);

				break;
			}

			spellsChanceSum += spellChance.chance;
		}
	}

	private void UseSpellComponentsPresets(SpellComponent[] spellComponents)
	{
		for (int i = 0; i < spellComponents.Length; i++)
		{
			spellComponents[i].SpellPreset();
		}
	}

	private void SetSpellAnnouncedAction(SpellComponent[] spellComponents)
	{
		BattleManager.Instance.enemyAvatar.enemyAction = () =>
		{
			for (int i = 0; i < spellComponents.Length; i++)
			{
				spellComponents[i].AnnouncedAction();
			}
		};
	}

	private void ClearAnnouncedActions()
	{
		BattleManager battleManager = BattleManager.Instance;
		battleManager.enemyVisualModel.SetAnnouncedAttack(0);
		battleManager.enemyVisualModel.SetAnnouncedBlock(0);
	}
}