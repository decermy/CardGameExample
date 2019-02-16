using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "StateMachine/Actions/TestActionAnother", fileName = "TestActionAnother")]
public class TestStateActionAnother : StateAction
{
	public override void Do(Action DoTransitionCallback)
	{
		if (GameConfigManager.Instance.isDebug)
			Debug.Log("TestStateActionAnother");

		if (InputController.Instance == null)
		{
			Debug.LogError("InputController not found");
			return;
		}

		InputController.Instance.SetransitionCallback(DoTransitionCallback);
	}
}
