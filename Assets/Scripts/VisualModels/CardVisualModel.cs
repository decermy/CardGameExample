using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class CardVisualModel : MonoBehaviour, IPointerClickHandler
{
	public static event Action<CardVisualModel, PointerEventData> onPointerClick = delegate { };

	[SerializeField]
	private Text manaCost;
	[SerializeField]
	private Text damage;
	[SerializeField]
	private Text block;
	[HideInInspector]
	public Card card;

	public void SetManacost(int manaCost)
	{
		this.manaCost.text = manaCost.ToString();
	}
	public void SetDamage(int damage)
	{
		this.damage.text = damage.ToString();
	}
	public void SetBlock(int block)
	{
		this.block.text = block.ToString();
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		onPointerClick.Invoke(this, eventData);
	}
}
