using System;

public interface IState
{
	IState NextState { get; set; }

	void DoActions();

	void DoTransition();
}
