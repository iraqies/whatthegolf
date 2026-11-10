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
		if (LauncherObjects == null)
			return;

		launchers = new IObjectLauncher[LauncherObjects.Length];
		targets = new List<IHitscanTarget>();
		for (int i = 0; i < LauncherObjects.Length; i++)
		{
			if (LauncherObjects[i] != null)
			{
				launchers[i] = LauncherObjects[i].GetComponent<IObjectLauncher>();
				targets.AddRange(LauncherObjects[i].GetComponentsInChildren<IHitscanTarget>());
			}
		}

		for (int i = 0; i < targets.Count; i++)
		{
			if (targets[i] != null)
			{
				targets[i].OnHitscanHit += OnBottleHit;
			}
		}
	}

	private void OnEnable()
	{
		if (startOnEnable)
		{
			StartPhase();
		}
	}

	public void StartPhase()
	{
		if (launchers != null)
		{
			for (int i = 0; i < launchers.Length; i++)
			{
				launchers[i]?.StartLauncher();
			}
		}
		isRunning = true;
	}

	private void OnBottleHit(IHitscanTarget obj)
	{
		hitCount++;
		if (targets != null && hitCount == targets.Count && nextPhase != null)
		{
			nextPhase.StartPhase();
			isRunning = false;
		}
	}
}
