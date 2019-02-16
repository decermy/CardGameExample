using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CardsCollection
{
	public List<Card> cards { get; private set; }

	public List<Card> cardsInDrop = new List<Card>();

	public int cardsInDeckMax { get; private set; }

	private Transform cardsParent;

	public CardsCollection(Card[] cardsDeckPrefabs)
	{
		this.cardsInDeckMax = cardsDeckPrefabs.Length;

		cards = CreateCards(cardsDeckPrefabs).ToList();
	}

	private Card[] CreateCards(Card[] cardsDeckPrefabs)
	{
		cardsParent = new GameObject().transform;
		cardsParent.name = "CardsParent";

		var cards = new Card[cardsDeckPrefabs.Length];
		for (int i = 0; i < cards.Length; i++)
		{
			GameObject go = GameObject.Instantiate(cardsDeckPrefabs[i].gameObject, cardsParent) as GameObject;
			cards[i] = go.GetComponent<Card>();
		}

		return cards;
	}

	public List<Card> GiveCards(int number)
	{
		if (cards == null || cards.Count == 0)
		{
			return null;
		}

		if (cards.Count < number)
		{
			number = cards.Count;
		}

		var givingCard = cards.GetRange(0, number);
		cards.RemoveRange(0, number);

		return givingCard;
	}

	public Card GiveCards()
	{
		if (cards == null || cards.Count < 1)
		{
			return null;
		}

		var card = cards[0];
		cards.Remove(card);

		return card;
	}
}
