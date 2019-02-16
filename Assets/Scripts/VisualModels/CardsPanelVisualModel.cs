using UnityEngine;
using UnityEngine.UI;

public class CardsPanelVisualModel : MonoBehaviour
{
	[SerializeField]
	private Text cardsInDeckCount;

	[SerializeField]
	private Text cardsInHand;

	[SerializeField]
	private Text cardsInDrop;

	[SerializeField]
	private Transform cardsPanel;

	public Transform GetCardsPanel()
	{
		return cardsPanel;
	}

	public void SetCardsInDeck(int cards, int cardsInDeckCount)
	{
		this.cardsInDeckCount.text = cards.ToString() + "/" + cardsInDeckCount.ToString();
	}

	public void SetCardsInHand(int cards)
	{
		this.cardsInHand.text = cards.ToString();
	}

	public void SetCardsInDrop(int cards)
	{
		this.cardsInDrop.text = cards.ToString();
	}
}
