using System.Collections.Generic;
using UnityEngine;

public class OverworldIslandChest : MonoBehaviour
{
	public ChestManager ChestManager;

	public Chest ChestOnIsland;

	public Transmogrif BallTransmogrif;

	public OverworldIsland Island;

	public List<PierTransmogrif> Piers;

	private void Awake()
	{
		if (ChestOnIsland != null)
		{
			ChestOnIsland.OnPostChestOpen += OnPostChestOpen;
			ChestOnIsland.OnPreChestOpen += OnPreChestOpen;
		}
	}

	private void OnPreChestOpen(Chest chest)
	{
		if (Island != null)
		{
			Island.ToogleBallOnIsland(false);
		}
	}

	private void OnPostChestOpen(Chest chest)
	{
		if (ChestManager != null && ChestManager.OpenedChests == 1)
		{
			if (OverworldBallManager.Instance != null && OverworldBallManager.Instance.ball != null)
			{
				Transmogriffable componentInParent = OverworldBallManager.Instance.ball.gameObject.GetComponentInParent<Transmogriffable>();
				if (componentInParent != null)
				{
					componentInParent.TransmogrifBall(componentInParent, BallTransmogrif);
				}
			}
			if (Island != null)
			{
				Island.DestroyBallOnIsland();
			}
			if (Piers != null)
			{
				foreach (PierTransmogrif pier in Piers)
				{
					if (pier != null)
					{
						pier.Reset();
					}
				}
			}
		}
		else if (Island != null)
		{
			Island.ToogleBallOnIsland(true);
		}
	}
}
