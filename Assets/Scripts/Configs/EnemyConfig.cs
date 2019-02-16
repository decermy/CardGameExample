using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "Config/EnemyConfig", fileName = "EnemyConfig")]
public class EnemyConfig : ScriptableObject
{
	public string enemyName;

	[Serializable]
	public struct SpellChance
	{
		public Spell spell;
		public float chance;
	}

	public int health;

	public SpellChance[] spells;
}