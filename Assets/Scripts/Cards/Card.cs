using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Card : MonoBehaviour
{
	public struct CardFields
	{
		public int damage;
		public int block;
	}

	[SerializeField]
	private string name;
	[SerializeField]
	private int manaCost;
	[SerializeField]
	private CardComponent[] cardComponents;

	[HideInInspector]
	public CardFields CardField;

	public CardComponent[] GetCardComponents()
	{
		return cardComponents;
	}
	public int GetManaCost()
	{
		return manaCost;
	}

	public void SetCardComponents(CardComponent[] cardComponents)
	{
		this.cardComponents = cardComponents;
	}

	public void UpdateCardComponents()
	{
		cardComponents = GetComponents<CardComponent>();
	}

#if UNITY_EDITOR
	[UnityEditor.CustomEditor(typeof(Card))]
	public class CardEditor : UnityEditor.Editor
	{
		void OnEnable()
		{
			InitSpellsComponents();
		}

		private void OnDisable()
		{
			InitSpellsComponents();
		}

		private void InitSpellsComponents()
		{
			Card spell = (Card)target;
			spell.SetCardComponents(spell.GetComponents<CardComponent>());
		}
	}
#endif
}