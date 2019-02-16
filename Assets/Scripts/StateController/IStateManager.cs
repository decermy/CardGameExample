using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStateManager
{
	void Transition(IState nextState);
	void UpdateManager();
}
