using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Config/HeroConfig", fileName = "HeroConfig")]
public class HeroConfig : ScriptableObject
{
	public int health;
	public int maxMana;
}
