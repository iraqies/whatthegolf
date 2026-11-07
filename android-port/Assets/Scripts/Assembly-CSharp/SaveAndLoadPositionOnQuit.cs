using System.Collections.Generic;
using Core;
using UnityEngine;

public class SaveAndLoadPositionOnQuit : GolfBehaviour
{
	public GridFiller grid;

	public float CheckInterval;

	private readonly string key;

	private float checkTimer;

	private SaveSpot lastSavePosition;

	private Vector3 lastValidPosition;

	private int lastSaveShape;

	private GolfBallController controller;

	private bool hasValidPositionEverBeenFound;

	private SaveEvents saveEvents;

	[SerializeField]
	private OverworldBallFollower follower;

	[SerializeField]
	private List<SaveSpot> savespots;

	[SerializeField]
	private DefaultSaveSpot deafultSaveSpot;

	[SerializeField]
	private LevelToHubSectionDictionary levelHubSections;

	[SerializeField]
	private bool isInHub;

	public override void OnPrePlayOrPreCompile()
	{
	}

	private void Start()
	{
	}

	public void TeleportBallToCurrentSpot()
	{
	}

	public HubSection HubSectionFromSaveSpot(string savePosition)
	{
		return null;
	}

	public List<HubSection> HubSectionFromLevelSection(OverworldLevelSection section)
	{
		return null;
	}

	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape)
	{
	}

	private void SaveEvents_OnEnterSaveSpot(SaveSpot savespot)
	{
	}

	private void Update()
	{
	}
}
