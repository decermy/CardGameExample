using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootState : MonoBehaviour, IState
{
	public IState NextState { get; set; }

	[SerializeField]
	private string avatarName;
	[SerializeField]
	private StateManager stateManager;

	private IStateManager rootStateManager;

	public StateManager GetStateManaget()
	{
		return stateManager;
	}

	public void Init(IStateManager rootStateManager)
	{
		this.rootStateManager = rootStateManager;

		stateManager.Init(this);
	}

	public void DoActions()
	{
		stateManager.UpdateManager();
	}

	public void DoTransition()
	{
		rootStateManager.Transition(NextState);
	}
}
