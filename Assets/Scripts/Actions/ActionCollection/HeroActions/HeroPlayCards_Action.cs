using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "StateMachine/HeroAction/HeroPlayCards_Action", fileName = "HeroPlayCards_Action")]
public class HeroPlayCards_Action : StateAction
{

	public override void Do(Action DoTransitionCallback)
	{
		if (GameConfigManager.Instance.isDebug)
			Debug.Log("Hero Play Cards");

		if (InputController.Instance == null)
		{
			Debug.LogError("InputController not found");
			return;
		}

		InputController.Instance.SetransitionCallback(DoTransitionCallback);
	}
}
