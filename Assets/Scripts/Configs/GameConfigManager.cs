
using UnityEngine;

public class GameConfigManager : MonoBehaviour
{
	public static GameConfigManager Instance;

	[SerializeField]
	private CardConfig cardConfig;
	[SerializeField]
	private EnemyConfig enemyConfig;
	[SerializeField]
	private HeroConfig heroConfig;

	public bool isDebug = true;

	public CardConfig CardConfig { get { return cardConfig; } }
	public EnemyConfig EnemyConfig { get { return enemyConfig; } }
	public HeroConfig HeroConfig { get { return heroConfig; } }

	private void Awake()
	{
		if (Instance == this)
		{
			Destroy(Instance.gameObject);
		}

		Instance = this;
	}
}
