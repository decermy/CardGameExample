using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "StateMachine/HeroAction/HeroGiveCards_Action", fileName = "HeroGiveCards_Action")]
public class HeroGiveCards_Action : StateAction
{
	public override void Do(Action DoTransitionCallback)
	{
		if (GameConfigManager.Instance.isDebug)
			Debug.Log(this.GetType());

		BattleManager battleController = BattleManager.Instance;
		var givingCards = battleController.cardsCollection.GiveCards(GameConfigManager.Instance.CardConfig.addCardsInTurn);

		if (givingCards == null)
		{
			Debug.LogWarning("card deck out");
		}
		else
		{
			SetFieldsForCardComponents(givingCards);

			battleController.cardsInHand.AddCardVisualModels(givingCards);

			battleController.cardsPanelVisualModel.SetCardsInDeck(battleController.cardsCollection.cards.Count, battleController.cardsCollection.cardsInDeckMax);
			battleController.cardsPanelVisualModel.SetCardsInHand(battleController.cardsInHand.cardVisualModels.Count);
		}

		DoTransitionCallback.Invoke();
	}

	private void SetFieldsForCardComponents(List<Card> cards)
	{
		for (int i = 0; i < cards.Count; i++)
		{
			var component = cards[i].GetCardComponents();

			for (int j = 0; j < component.Length; j++)
			{
				component[j].SetFields();
			}
		}
	}
}
