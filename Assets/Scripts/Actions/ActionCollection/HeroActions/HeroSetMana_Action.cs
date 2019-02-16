using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "StateMachine/HeroAction/HeroSetMana_Action", fileName = "HeroSetMana_Action")]
public class HeroSetMana_Action : StateAction
{
	public override void Do(Action DoTransitionCallback)
	{
		if (GameConfigManager.Instance.isDebug)
			Debug.Log(this.GetType());

		int mana = GameConfigManager.Instance.HeroConfig.maxMana;

		BattleManager battleManager = BattleManager.Instance;

		battleManager.heroAvatar.mana = mana;
		battleManager.heroAvatar.maxMana = mana;

		battleManager.heroVisualModel.SetMana(mana, battleManager.heroAvatar.maxMana);

		DoTransitionCallback.Invoke();
	}
}
