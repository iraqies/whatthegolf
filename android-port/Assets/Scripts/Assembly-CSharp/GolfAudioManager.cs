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

	private float nextCheckTime;

	public void SetOverworldBall(GolfBallController controller)
	{
	}

	private void Start()
	{
	}

	public void Initialize()
	{
	}

	public void OnLevelDesignerReset()
	{
	}

	private void OnNewOverworldBall(Transmogrif.BALLSHAPES newShape)
	{
	}

	public void InitializeNewScene()
	{
	}

	public void AddMultiplayerPull(GolfBallController controller)
	{
	}

	public void RemoveMultiplayerPull(GolfBallController controller)
	{
	}

	public void OnLevelWillUnload()
	{
	}

	private void Update()
	{
	}

	private bool ValidBall(GolfBallController ball)
	{
		return false;
	}

	private void NewPull(GolfPullAudioHandler newPull)
	{
	}
}
