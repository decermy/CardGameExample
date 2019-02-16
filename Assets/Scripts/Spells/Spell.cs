using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Spell : MonoBehaviour
{
	public string name;
	public SpellComponent[] spellComponents;

	public void SetSpellComponent(SpellComponent[] spellComponents)
	{
		this.spellComponents = spellComponents;
	}

	public void UpdateSpellComponents()
	{
		spellComponents = GetComponents<SpellComponent>();
	}
}

#if UNITY_EDITOR
[UnityEditor.CustomEditor(typeof(Spell))]
public class SpellEditor : UnityEditor.Editor
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
		Spell spell = (Spell)target;
		spell.SetSpellComponent(spell.GetComponents<SpellComponent>());
	}
}
#endif
