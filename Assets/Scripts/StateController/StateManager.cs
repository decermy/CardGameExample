using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateManager : MonoBehaviour, IStateManager
{
	public IState currentState { get; private set; }
	public IState prevState { get; private set; }

	public float stateTimeElapsed;

	[SerializeField]
	private StateAction[] stateActions;
	private IState[] states;

	private RootState rootState;

	public void Init(RootState rootState)
	{
		this.rootState = rootState;

		states = new IState[stateActions.Length];

		IState prev = null;
		for (int i = 0; i < stateActions.Length; i++)
		{
			IState state = new State(stateActions[i], this);
			states[i] = state;

			if (prev != null)
			{
				prev.NextState = state;
			}

			prev = state;
		}

		this.currentState = states[0];
	}

	public void ResetState()
	{
		currentState = states[0];
		prevState = null;
	}

	public void Transition(IState nextState)
	{
		currentState = nextState;
		OnExitState();
	}

	public bool CheckIfCountDownElapsed(float duration)
	{
		stateTimeElapsed += Time.deltaTime;
		return (stateTimeElapsed >= duration);
	}

	private void OnExitState()
	{
		stateTimeElapsed = 0;
	}

	public void UpdateManager()
	{
		if (currentState == null)
		{
			rootState.DoTransition();
			ResetState();
			return;
		}

		if (currentState != prevState)
		{

			prevState = currentState;

			currentState.DoActions();
		}
	}
}