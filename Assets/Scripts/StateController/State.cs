using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class State : IState
{
	public IState NextState { get; set; }

	private IStateManager stateManager;
	private IStateAction stateAction;

	public State(IStateAction stateAction, IStateManager stateManager)
	{
		this.stateAction = stateAction;
		this.stateManager = stateManager;
	}

	public void DoActions()
	{
		stateAction.Do(DoTransition);
	}

	public void DoTransition()
	{
		stateManager.Transition(NextState);
	}

}