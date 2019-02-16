using System;

public interface IStateAction
{
	void Do(Action DoTransitionCallback);
}
