using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class GolfAudioManager : MonoBehaviour
{
	private GolfPullAudioHandler activePull;
	private List<GolfPullAudioHandler> multiplayerPulls;
	public GolfBallController overworldBall;
	public GolfPullAudioHandler defaultPull;
	private Level currentLevel;
	private bool initialized;
	private float nextCheckTime = 0.5f;

	public void SetOverworldBall(GolfBallController controller)
	{
		overworldBall = controller;
		if (activePull != null)
			activePull.Initialize(overworldBall);
	}

	private void Start()
	{
		Initialize();
	}

	public void Initialize()
	{
		if (initialized) return;
		initialized = true;
		activePull = GetComponentInChildren<GolfPullAudioHandler>(true);
		NewPull(defaultPull);
		if (OverworldBallManager.Instance != null)
			OverworldBallManager.Instance.OnNewBall += OnNewOverworldBall;
		if (overworldBall != null && activePull != null)
			activePull.Initialize(overworldBall);
	}

	public void OnLevelDesignerReset()
	{
		if (activePull != null)
			activePull.OnCancel();
	}

	private void OnNewOverworldBall(Transmogrif.BALLSHAPES newShape)
	{
		if (OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null)
		{
			overworldBall = OverworldBallManager.Instance.Ball.GetComponent<GolfBallController>();
			if (overworldBall != null && activePull != null)
				activePull.Initialize(overworldBall);
		}
	}

	public void InitializeNewScene()
	{
		Initialize();
		if (Level.HasInstance && Level.Instance != null)
			currentLevel = Level.Instance;

		if (multiplayerPulls != null)
		{
			for (int i = 0; i < multiplayerPulls.Count; i++)
			{
				if (multiplayerPulls[i] != null)
					Destroy(multiplayerPulls[i].gameObject);
			}
			multiplayerPulls = null;
		}

		if (Level.HasInstance && Level.Instance != null && Level.Instance.IsMultiplayer)
		{
			if (activePull != null)
				activePull.enabled = false;
			nextCheckTime = Time.time;
			return;
		}

		var handlers = FindObjectsOfType<GolfPullAudioHandler>();
		if (handlers != null)
		{
			for (int i = 0; i < handlers.Length; i++)
			{
				if (handlers[i] != null && handlers[i] != activePull && handlers[i].overrideGlobalSetting)
				{
					NewPull(handlers[i]);
				}
			}
		}

		if (activePull != null)
			activePull.enabled = true;
		nextCheckTime = Time.time;
	}

	public void AddMultiplayerPull(GolfBallController controller)
	{
		if (defaultPull == null || controller == null) return;
		if (multiplayerPulls == null)
			multiplayerPulls = new List<GolfPullAudioHandler>();
		var pull = Instantiate(defaultPull, transform);
		if (pull != null)
		{
			pull.Initialize(controller);
			multiplayerPulls.Add(pull);
		}
	}

	public void RemoveMultiplayerPull(GolfBallController controller)
	{
		if (multiplayerPulls == null || controller == null) return;
		for (int i = multiplayerPulls.Count - 1; i >= 0; i--)
		{
			if (multiplayerPulls[i] != null && multiplayerPulls[i].ball == controller)
			{
				Destroy(multiplayerPulls[i].gameObject);
				multiplayerPulls.RemoveAt(i);
			}
		}
	}

	public void OnLevelWillUnload()
	{
		currentLevel = null;
		NewPull(defaultPull);
		if (activePull != null && overworldBall != null)
			activePull.Initialize(overworldBall);
	}

	private void Update()
	{
		if (currentLevel == null || currentLevel.IsMultiplayer || activePull == null)
			return;
		if (ValidBall(activePull.ball))
			return;
		if (Time.time < nextCheckTime)
			return;

		if (activePull.ball != null)
			activePull.Deinitialize();

		var controllers = currentLevel.GetControllers();
		if (controllers != null)
		{
			for (int i = 0; i < controllers.Count; i++)
			{
				if (ValidBall(controllers[i]))
				{
					activePull.Initialize(controllers[i]);
					break;
				}
			}
		}
		nextCheckTime = Time.time + 0.3f;
	}

	private bool ValidBall(GolfBallController ball)
	{
		return ball != null && ball.isActiveAndEnabled && !ball.DisablePullSounds;
	}

	private void NewPull(GolfPullAudioHandler newPull)
	{
		if (newPull == null) return;
		if (activePull != null)
		{
			activePull.Deinitialize();
			Destroy(activePull.gameObject);
		}
		activePull = Instantiate(newPull, transform);
	}
}
