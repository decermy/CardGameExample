using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Config/CardConfig", fileName = "CardConfig")]
public class CardConfig : ScriptableObject
{
	public CardVisualModel cardPrefab;

	public int addCardsInTurn;
	public Card[] cardsDeck;
}
