using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "StateMachine/EnemyAction/EnemyStartTurn_Action", fileName = "EnemyStartTurn_Action")]
public class EnemyStartTurn_Action : StateAction
{
	public override void Do(Action DoTransitionCallback)
	{
		if (GameConfigManager.Instance.isDebug)
			Debug.Log("Enemy Start Turn");

		DoTransitionCallback.Invoke();
	}
}
