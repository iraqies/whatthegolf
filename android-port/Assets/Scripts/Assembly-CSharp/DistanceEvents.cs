using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;
using UnityEngine.Events;

public class DistanceEvents : MonoBehaviour
{
	public UnityEvent OnGotClose;

	public float radius;

	public List<Transform> targets;

	public bool addGolfBallControllersToTargets;

	public float updateInterval;

	public float activationDelayMin;

	public float activationDelayMax;

	public bool enableOnStart;

	private bool isActivated;

	public void Reset()
	{
	}

	public void SetDistanceCheckStatus(bool enabled)
	{
	}

	private void Start()
	{
	}

	private void Instance_OnMultiplayerSetup(MultiplayerLevelInfo multiplayerLevel)
	{
	}

	private void Instance_OnFail(GolfBallController player, string arg2, Level.State arg3)
	{
	}

	private void HandleNewPlayerSpawned(GolfBallController newPlayer)
	{
	}

	private IEnumerator CheckDistanceRoutine()
	{
		return null;
	}

	private void OnDrawGizmosSelected()
	{
	}
}
