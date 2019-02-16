using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsInHand
{
	private Transform cardsPanel;
	private CardVisualModel cardVisualModelPrefab;

	public List<CardVisualModel> cardVisualModels { get; private set; }

	public CardsInHand(Transform cardsPanel, CardVisualModel cardVisualModelPrefab)
	{
		cardVisualModels = new List<CardVisualModel>();

		this.cardsPanel = cardsPanel;
		this.cardVisualModelPrefab = cardVisualModelPrefab;
	}

	public void AddCardVisualModels(List<Card> cardsList)
	{
		for (int i = 0; i < cardsList.Count; i++)
		{
			GameObject go = GameObject.Instantiate(cardVisualModelPrefab.gameObject) as GameObject;
			go.transform.SetParent(cardsPanel);

			go.transform.localScale = Vector3.one;

			var cardVisualModel = go.GetComponent<CardVisualModel>();
			cardVisualModel.card = cardsList[i];
			cardVisualModels.Add(cardVisualModel);

			cardVisualModel.SetBlock(cardVisualModel.card.CardField.block);
			cardVisualModel.SetDamage(cardVisualModel.card.CardField.damage);
			cardVisualModel.SetManacost(cardVisualModel.card.GetManaCost());
		}
	}
}
