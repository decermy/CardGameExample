using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "StateMachine/HeroAction/HeroStartTurn_Action", fileName = "HeroStartTurn_Action")]
public class HeroStartTurn_Action : StateAction
{
	public override void Do(Action DoTransitionCallback)
	{
		if (GameConfigManager.Instance.isDebug)
			Debug.Log("Hero Start Turn");

		DoTransitionCallback.Invoke();
	}
}
