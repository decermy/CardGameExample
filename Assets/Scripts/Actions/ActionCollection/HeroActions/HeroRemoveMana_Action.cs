using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "StateMachine/HeroAction/HeroRemoveMana_Action", fileName = "HeroRemoveMana_Action")]
public class HeroRemoveMana_Action : StateAction
{
	public override void Do(Action DoTransitionCallback)
	{
		if (GameConfigManager.Instance.isDebug)
			Debug.Log(this.GetType());

		BattleManager battleController = BattleManager.Instance;

		battleController.heroAvatar.mana = 0;
		battleController.heroVisualModel.SetMana(0, battleController.heroAvatar.maxMana);

		DoTransitionCallback.Invoke();
	}
}
