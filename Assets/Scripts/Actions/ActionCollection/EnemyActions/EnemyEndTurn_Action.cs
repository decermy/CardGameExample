using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "StateMachine/EnemyAction/EnemyEndTurn_Action", fileName = "EnemyEndTurn_Action")]
public class EnemyEndTurn_Action : StateAction
{
	public override void Do(Action DoTransitionCallback)
	{
		if (GameConfigManager.Instance.isDebug)
			Debug.Log("Enemy End Turn");

		DoTransitionCallback.Invoke();
	}
}
