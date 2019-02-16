using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "StateMachine/HeroAction/HeroRemoveBlock_Action", fileName = "HeroRemoveBlock_Action")]
public class HeroRemoveBlock_Action : StateAction
{
	public override void Do(Action DoTransitionCallback)
	{
		if (GameConfigManager.Instance.isDebug)
			Debug.Log(this.GetType());

		BattleManager battleController = BattleManager.Instance;

		battleController.heroAvatar.Block = 0;
		battleController.heroVisualModel.SetBlock(0);

		DoTransitionCallback.Invoke();
	}
}
