using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootStateManager : MonoBehaviour, IStateManager
{
	public IState currentState { get; private set; }
	public IState prevState { get; private set; }

	[SerializeField]
	private RootState[] rootStates;
	[SerializeField]
	private bool isLoop = false;

	public void Init()
	{
		Debug.Log("RootStateManager Init");

		IState prev = null;
		for (int i = 0; i < rootStates.Length; i++)
		{
			IState state = rootStates[i];
			(state as RootState).Init(this);

			if (prev != null)
			{
				prev.NextState = state;
			}

			prev = state;
		}

		if (isLoop && rootStates.Length > 1)
		{
			rootStates[rootStates.Length - 1].NextState = rootStates[0];
		}

		this.currentState = rootStates[0];
	}

	public void Transition(IState nextState)
	{
		currentState = nextState;
	}

	public void UpdateManager()
	{
		if (currentState == null)
		{
			return;
		}

		currentState.DoActions();
	}
}
