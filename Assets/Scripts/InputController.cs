using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class InputController : MonoBehaviour
{
	public static InputController Instance;

	private Action transitionCallback = delegate { };

	[SerializeField]
	private StateController stateController;
	[SerializeField]
	private GameObject winPanel;
	[SerializeField]
	private GameObject defeatPanel;

	public void SetransitionCallback(Action transitionCallback)
	{
		this.transitionCallback = transitionCallback;
	}

	private void Awake()
	{
		if (Instance == this)
		{
			Destroy(Instance.gameObject);
		}

		Instance = this;
	}

	private void OnEnable()
	{
		CardVisualModel.onPointerClick += OnPointerClickToCardVisualModel;
	}

	private void OnDisable()
	{
		CardVisualModel.onPointerClick -= OnPointerClickToCardVisualModel;
	}


	private void OnPointerClickToCardVisualModel(CardVisualModel cardVisualModel, PointerEventData pointerEventData)
	{
		BattleManager battleManager = BattleManager.Instance;
		if (cardVisualModel.card.GetManaCost() <= battleManager.heroAvatar.mana)
		{
			var components = cardVisualModel.card.GetCardComponents();

			for (int i = 0; i < components.Length; i++)
			{
				components[i].RealizeComponent();
			}

			battleManager.cardsInHand.cardVisualModels.Remove(cardVisualModel);
			battleManager.cardsCollection.cardsInDrop.Add(cardVisualModel.card);

			battleManager.cardsPanelVisualModel.SetCardsInHand(battleManager.cardsInHand.cardVisualModels.Count);
			battleManager.cardsPanelVisualModel.SetCardsInDrop(battleManager.cardsCollection.cardsInDrop.Count);

			Destroy(cardVisualModel.gameObject);

			battleManager.heroAvatar.mana -= cardVisualModel.card.GetManaCost();
			battleManager.heroVisualModel.SetMana(battleManager.heroAvatar.mana, battleManager.heroAvatar.maxMana);

			if (battleManager.heroAvatar.mana == 0)
			{
				EndTurn();
			}
		}
	}

	private void NextStateForStateMachine()
	{
		if (transitionCallback == null)
		{
			Debug.LogError("transitionCallback not found");
			return;
		}

		transitionCallback.Invoke();
		transitionCallback = null;
	}

	public void EndTurn()
	{
		NextStateForStateMachine();
	}

	public void Restart()
	{
		var activeScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
		UnityEngine.SceneManagement.SceneManager.LoadScene(activeScene.name);
	}

	public void Defeat()
	{
		stateController.enabled = false;
		defeatPanel.SetActive(true);
	}

	public void Win()
	{
		stateController.enabled = false;
		winPanel.SetActive(true);
	}
}
