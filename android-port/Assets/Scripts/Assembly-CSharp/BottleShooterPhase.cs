using System.Collections.Generic;
using UnityEngine;

public class BottleShooterPhase : MonoBehaviour
{
	public bool startOnEnable;

	public GameObject[] LauncherObjects;

	public BottleShooterPhase nextPhase;

	public bool isRunning;

	private int hitCount;

	private IObjectLauncher[] launchers;

	private List<IHitscanTarget> targets;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void StartPhase()
	{
	}

	private void OnBottleHit(IHitscanTarget obj)
	{
	}
}
