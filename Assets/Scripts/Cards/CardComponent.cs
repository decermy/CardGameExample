using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Card))]
public abstract class CardComponent : MonoBehaviour, ICardComponent
{
	public abstract void SetFields();

	public abstract void RealizeComponent();

	protected void OnValidate()
	{
		GetComponent<Card>().UpdateCardComponents();
	}
}
