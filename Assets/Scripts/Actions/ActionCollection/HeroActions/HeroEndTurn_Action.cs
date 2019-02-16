using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "StateMachine/HeroAction/HeroEndTurn_Action", fileName = "HeroEndTurn_Action")]
public class HeroEndTurn_Action : StateAction
{
	public override void Do(Action DoTransitionCallback)
	{
		if (GameConfigManager.Instance.isDebug)
			Debug.Log("Hero End Turn");

		DoTransitionCallback.Invoke();
	}
}
