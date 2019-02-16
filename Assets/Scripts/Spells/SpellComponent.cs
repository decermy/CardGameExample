
using UnityEngine;

[RequireComponent(typeof(Spell))]
public abstract class SpellComponent : MonoBehaviour, ISpellComponent
{
	public abstract void SpellPreset();
	public abstract void AnnouncedAction();

	protected void OnValidate()
	{
		GetComponent<Spell>().UpdateSpellComponents();
	}
}
