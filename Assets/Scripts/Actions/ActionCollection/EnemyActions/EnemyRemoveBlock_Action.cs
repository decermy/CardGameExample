using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "StateMachine/EnemyAction/EnemyRemoveBlock_Action", fileName = "EnemyRemoveBlock_Action")]
public class EnemyRemoveBlock_Action : StateAction
{

	public override void Do(Action DoTransitionCallback)
	{
		if (GameConfigManager.Instance.isDebug)
			Debug.Log("EnemyRemoveBlock");

		BattleManager.Instance.enemyAvatar.Block = 0;
		BattleManager.Instance.enemyVisualModel.SetBlock(0);

		DoTransitionCallback.Invoke();
	}
}
