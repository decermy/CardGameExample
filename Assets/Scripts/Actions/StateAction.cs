using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class StateAction : ScriptableObject, IStateAction
{
	public virtual void Do(Action DoTransitionCallback)
	{
		Debug.Log("StateAction");

		if (InputController.Instance == null)
		{
			Debug.LogError("InputController not found");
			return;
		}

		InputController.Instance.SetransitionCallback(DoTransitionCallback);
	}
}
