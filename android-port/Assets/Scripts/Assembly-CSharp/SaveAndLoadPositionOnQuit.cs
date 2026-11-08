using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

public class SaveAndLoadPositionOnQuit : GolfBehaviour
{
	public GridFiller grid;
	public float CheckInterval = 1f;
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
		base.OnPrePlayOrPreCompile();
		if (follower == null) follower = GetComponent<OverworldBallFollower>();
		if (savespots != null) savespots.RemoveAll(s => s == null);
		if (deafultSaveSpot == null) deafultSaveSpot = FindObjectOfType<DefaultSaveSpot>();
	}

	private void Start()
	{
		OverworldBall2D b = null;
		if (OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null)
			b = OverworldBallManager.Instance.Ball;
		else if (OverworldManager2d.HasInstance && OverworldManager2d.Instance.ball != null)
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
		if (!isInHub || HubSceneLoader.Instance == null || HubSceneLoader.Instance.HasBeenLoadedBefore)
		{
			TeleportBallToCurrentSpot();
		}
		else if (b != null)
		{
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
		if (!string.IsNullOrEmpty(savePosId) && savespots != null)
		{
			var found = savespots.FirstOrDefault(s => s != null && s.ID == savePosId);
			if (found != null)
				targetPos = found.transform.position;
			else
				shape = Transmogrif.BALLSHAPES.ball;
		}
		else
		{
			shape = Transmogrif.BALLSHAPES.ball;
		}
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
	}
}
