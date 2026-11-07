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
	}

	private void OnPreChestOpen(Chest chest)
	{
	}

	private void OnPostChestOpen(Chest chest)
	{
	}
}
