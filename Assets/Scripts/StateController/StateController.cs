using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class StateController : MonoBehaviour
{
	[SerializeField]
	private RootStateManager rootStateManager;

	private void Start()
	{
		BattleManager.Instance.Init();
		rootStateManager.Init();
	}

	private void Update()
	{
		rootStateManager.UpdateManager();
	}
}

