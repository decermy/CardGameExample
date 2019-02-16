using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
	public static BattleManager Instance;

	public EnemyVisualModel enemyVisualModel;
	public HeroVisualModel heroVisualModel;

	public CardsPanelVisualModel cardsPanelVisualModel;

	public HeroAvatar heroAvatar;
	public EnemyAvatar enemyAvatar;

	public CardsCollection cardsCollection;
	public CardsInHand cardsInHand;

	private void Awake()
	{
		if (Instance == this)
		{
			Destroy(Instance.gameObject);
		}

		Instance = this;
	}

	public void Init()
	{
		Debug.Log("BattleManager Init");

		GameConfigManager gameConfigManager = GameConfigManager.Instance;

		heroAvatar = new HeroAvatar(gameConfigManager.HeroConfig.health, gameConfigManager.HeroConfig.maxMana);
		enemyAvatar = new EnemyAvatar(gameConfigManager.EnemyConfig.health);

		cardsCollection = new CardsCollection(gameConfigManager.CardConfig.cardsDeck);

		cardsInHand = new CardsInHand(cardsPanelVisualModel.GetCardsPanel(), GameConfigManager.Instance.CardConfig.cardPrefab);

		UpdateVisualModels();
	}

	private void UpdateVisualModels()
	{
		heroVisualModel.SetHealth(heroAvatar.Health, heroAvatar.maxHealth);
		heroVisualModel.SetBlock(0);
		heroVisualModel.SetMana(heroAvatar.mana, heroAvatar.maxMana);

		enemyVisualModel.SetAnnouncedAttack(0);
		enemyVisualModel.SetAnnouncedBlock(0);
		enemyVisualModel.SetBlock(0);
		enemyVisualModel.SetHealth(enemyAvatar.Health, enemyAvatar.maxHealth);

		cardsPanelVisualModel.SetCardsInDeck(cardsCollection.cards.Count, cardsCollection.cardsInDeckMax);
		cardsPanelVisualModel.SetCardsInHand(0);
		cardsPanelVisualModel.SetCardsInDrop(0);
	}
}
