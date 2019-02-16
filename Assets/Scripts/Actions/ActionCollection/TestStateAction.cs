using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "StateMachine/Actions/TestAction", fileName = "TestAction")]
public class TestStateAction : StateAction
{
	public override void Do(Action DoTransitionCallback)
	{
		Debug.Log("TestStateAction");

		if (InputController.Instance == null)
		{
			Debug.LogError("InputController not found");
			return;
		}

		InputController.Instance.SetransitionCallback(DoTransitionCallback);
	}
}
