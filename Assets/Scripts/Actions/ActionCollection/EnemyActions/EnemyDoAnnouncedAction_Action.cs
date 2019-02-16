using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "StateMachine/EnemyAction/EnemyDoAnnouncedAction_Action", fileName = "EnemyDoAnnouncedAction_Action")]
public class EnemyDoAnnouncedAction_Action : StateAction
{
	public override void Do(Action DoTransitionCallback)
	{
		if (GameConfigManager.Instance.isDebug)
			Debug.Log("EnemyDoAnnouncedAction");

		if (BattleManager.Instance.enemyAvatar.enemyAction != null)
		{
			BattleManager.Instance.enemyAvatar.enemyAction.Invoke();
		}

		DoTransitionCallback.Invoke();
	}
}
