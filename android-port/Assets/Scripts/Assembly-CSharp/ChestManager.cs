using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestManager : GolfBehaviour
{
	public Transmogrif grif;

	public Transform tropheeCenter;

	public OverworldCameraSettings cameraForOpeningChest;

	public OverworldCameraSettings CameraSettingsForTeleport;

	public bool isAlwaysTeleportingBall;

	public List<ChestTrophee> allChestsTrophees;

	public OverworldTriggerCameraBlender winAreaBlender;

	private bool previousBallState;

	public int OpenedChests => 0;

	public override void OnPrePlayOrPreCompile()
	{
	}

	private void Start()
	{
	}

	private void Chest_OnChestPreOpen(ChestTrophee trophee, Chest chest)
	{
	}

	private void Chest_OnPostChestOpenFirst(ChestTrophee trophee, Chest chest)
	{
	}

	private IEnumerator OnOpenChestPost(ChestTrophee trophee, Chest chest)
	{
		return null;
	}
}
