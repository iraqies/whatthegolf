using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SaveAndLoadPositionOnQuit : GolfBehaviour
{
	public GridFiller grid;
	public float CheckInterval = 1f;
	private readonly string key = "OverworldBallPosition";
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
		base.OnPrePlayOrPreCompile();
		if (follower == null) follower = GetComponent<OverworldBallFollower>();
		if (savespots != null) savespots.RemoveAll(s => s == null);
		if (deafultSaveSpot == null) deafultSaveSpot = FindObjectOfType<DefaultSaveSpot>();
	}

	private void Start()
	{
		OverworldBall2D b = null;
		if (OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null && OverworldBallManager.Instance.Ball.gameObject.scene.IsValid())
			b = OverworldBallManager.Instance.Ball;
		else if (OverworldManager2d.HasInstance && OverworldManager2d.Instance.ball != null && OverworldManager2d.Instance.ball.gameObject.scene.IsValid())
			b = OverworldManager2d.Instance.ball;
		else
			b = FindObjectOfType<OverworldBall2D>();

		if (b != null)
		{
			controller = b.GetComponent<GolfBallController>();
			saveEvents = b.GetComponent<SaveEvents>();
		}
		if (savespots != null)
		{
			foreach (var s in savespots)
				if (s != null) s.Init();
		}
		if (saveEvents != null)
		{
			saveEvents.OnEnterSaveSpot -= SaveEvents_OnEnterSaveSpot;
			saveEvents.OnEnterSaveSpot += SaveEvents_OnEnterSaveSpot;
		}
		if (OverworldBallManager.Instance != null)
		{
			OverworldBallManager.Instance.OnNewBall -= Instance_OnNewBall;
			OverworldBallManager.Instance.OnNewBall += Instance_OnNewBall;
		}
		bool playingIntroTunnel = !isInHub && !SaveGame.IsIntroAnimationComplete && OverworldManager2d.HasInstance && OverworldManager2d.Instance != null && OverworldManager2d.Instance.introTunnel != null;
		if (playingIntroTunnel)
		{
			if (b != null)
			{
				transform.position = b.transform.position;
				if (follower != null)
					follower.SetTarget(b.transform);
			}
		}
		else if (!isInHub || HubSceneLoader.Instance == null || HubSceneLoader.Instance.HasBeenLoadedBefore)
		{
			TeleportBallToCurrentSpot();
		}
		else if (b != null)
		{
			if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null && OverworldManager2d.Instance.introTunnel != null && (!SaveGame.IsIntroAnimationComplete || (isInHub && HubSceneLoader.Instance != null && !HubSceneLoader.Instance.HasBeenLoadedBefore)))
			{
				var tunnel = OverworldManager2d.Instance.introTunnel;
				var path = OverworldManager2d.Instance.canStartAtLogoWhenStartingOverworld ? tunnel.pathFromLogo : tunnel.pathToLogo;
				if (path != null && path.Count > 0 && path[0] != null)
					b.transform.position = path[0].position;
			}
			transform.position = b.transform.position;
			if (follower != null)
				follower.SetTarget(b.transform);
		}
	}

	public void TeleportBallToCurrentSpot()
	{
		var curOw = SaveGame.currentOverworld;
		string savePosId = curOw != null ? curOw.SavePosition : null;
		Transmogrif.BALLSHAPES shape = (Transmogrif.BALLSHAPES)SaveGame.SavePositionShape;
		Vector3 targetPos = deafultSaveSpot != null ? deafultSaveSpot.transform.position : transform.position;
		if (!string.IsNullOrEmpty(savePosId))
		{
			SaveSpot found = null;
			if (savespots != null)
				found = savespots.FirstOrDefault(s => s != null && s.ID == savePosId);
			if (found != null)
				targetPos = found.transform.position;
			else
				shape = Transmogrif.BALLSHAPES.ball;

			if (OverworldBallManager.Instance != null)
				OverworldBallManager.Instance.Load(shape);
			if (controller == null && OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null)
				controller = OverworldBallManager.Instance.Ball.GetComponent<GolfBallController>();
			if (controller != null)
			{
				controller.transform.position = targetPos;
				if (follower != null)
					follower.SetTarget(controller.transform);
			}
			transform.position = targetPos;
			lastValidPosition = transform.position;
			hasValidPositionEverBeenFound = true;
		}
		else if (deafultSaveSpot != null)
		{
			if (OverworldBallManager.Instance != null)
				OverworldBallManager.Instance.Load(Transmogrif.BALLSHAPES.ball);
			if (controller == null && OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null)
				controller = OverworldBallManager.Instance.Ball.GetComponent<GolfBallController>();
			if (controller != null)
			{
				controller.transform.position = targetPos;
				if (follower != null)
					follower.SetTarget(controller.transform);
			}
			transform.position = targetPos;
			lastValidPosition = transform.position;
			hasValidPositionEverBeenFound = true;
		}
	}

	public HubSection HubSectionFromSaveSpot(string savePosition)
	{
		if (string.IsNullOrEmpty(savePosition) || savespots == null) return null;
		var found = savespots.FirstOrDefault(s => s != null && s.ID == savePosition);
		return found != null ? found.GetComponentInParent<HubSection>() : null;
	}

	public List<HubSection> HubSectionFromLevelSection(OverworldLevelSection section)
	{
		var res = new List<HubSection>();
		if (levelHubSections != null && section != null && section.levels != null)
		{
			foreach (var lv in section.levels)
			{
				if (lv != null && levelHubSections.TryGetValue(lv, out var hsList) && hsList != null)
				{
					foreach (var hs in hsList)
					{
						if (hs != null && !res.Contains(hs))
							res.Add(hs);
					}
				}
			}
		}
		return res;
	}

	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape)
	{
		if (OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null)
		{
			var b = OverworldBallManager.Instance.Ball;
			controller = b.GetComponent<GolfBallController>();
			saveEvents = b.GetComponent<SaveEvents>();
			if (saveEvents != null)
			{
				saveEvents.OnEnterSaveSpot -= SaveEvents_OnEnterSaveSpot;
				saveEvents.OnEnterSaveSpot += SaveEvents_OnEnterSaveSpot;
			}
		}
	}

	private void SaveEvents_OnEnterSaveSpot(SaveSpot savespot)
	{
		if (savespot == null) return;
		lastSavePosition = savespot;
		if (!string.IsNullOrEmpty(savespot.ID) && SaveGame.currentOverworld != null)
		{
			SaveGame.currentOverworld.SavePosition = savespot.ID;
			if (OverworldBallManager.HasInstance && OverworldBallManager.Instance != null)
				SaveGame.SavePositionShape = (Transmogrif.BALLSHAPES)OverworldBallManager.Instance.GetCurrentShapeAsInt();
		}
	}

	private void Update()
	{
		if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null && OverworldManager2d.Instance.State != OverworldManager2d.STATES.active)
			return;
		if (controller == null || !controller.enabled)
			return;
		var trav = controller.GetComponent<ShortcutTunnelTraversable>();
		if (trav != null && trav.isTraveling)
			return;
		checkTimer += Time.unscaledDeltaTime;
		if (follower == null || !follower.isFollowing || checkTimer < CheckInterval)
			return;
		if (grid == null || grid.currentGroundMap == null)
			return;

		Tilemap gMap = grid.currentGroundMap;
		Vector3Int cell = gMap.WorldToCell(transform.position);
		if (gMap.GetTile(cell) != null || grid.IsTileTarget(cell))
		{
			lastValidPosition = transform.position;
			hasValidPositionEverBeenFound = true;
		}
		else if (hasValidPositionEverBeenFound)
		{
			var b = controller.GetComponent<OverworldBall2D>();
			if (b != null && b.rigidBody != null)
			{
				b.rigidBody.velocity = Vector2.zero;
				b.rigidBody.angularVelocity = 0f;
			}
			controller.transform.position = lastValidPosition;
			transform.position = lastValidPosition;
		}
		checkTimer = 0f;
	}
}
