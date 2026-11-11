using System;
using System.Collections;
using Core;
using UnityEngine;

public class OverworldOptimizations : MonoBehaviour
{
	[Serializable]
	public class Physics2DSettings
	{
		public int velocityIterations;

		public int positionIterations;

		public float timeToSleep;

		public float linearSleepTolerance;

		public float angularSleepTolerence;
	}

	private Physics2DSettings defaultSettings;

	public Physics2DSettings optimizedSettings;

	private IEnumerator Start()
	{
		for (int i = 0; i < 10; i++)
		{
			yield return null;
		}
		if (PlatformSettings.Instance.GetCurrent().usePhysicsOptimizationsInOverworld)
		{
			defaultSettings = new Physics2DSettings();
			defaultSettings.velocityIterations = Physics2D.velocityIterations;
			defaultSettings.positionIterations = Physics2D.positionIterations;
			defaultSettings.timeToSleep = Physics2D.timeToSleep;
			defaultSettings.linearSleepTolerance = Physics2D.linearSleepTolerance;
			defaultSettings.angularSleepTolerence = Physics2D.angularSleepTolerance;
			EnterOverworld();
			OverworldManager2d.Instance.OnToggleOverworld += Instance_OnToggleOverworld;
		}
	}

	private void Instance_OnToggleOverworld(bool isActive)
	{
		if (isActive)
		{
			EnterOverworld();
		}
		else
		{
			ExitOverworld();
		}
	}

	public void EnterOverworld()
	{
		Physics2D.velocityIterations = optimizedSettings.velocityIterations;
		Physics2D.positionIterations = optimizedSettings.positionIterations;
		Physics2D.timeToSleep = optimizedSettings.timeToSleep;
		Physics2D.linearSleepTolerance = optimizedSettings.linearSleepTolerance;
		Physics2D.angularSleepTolerance = optimizedSettings.angularSleepTolerence;
	}

	public void ExitOverworld()
	{
		Physics2D.velocityIterations = defaultSettings.velocityIterations;
		Physics2D.positionIterations = defaultSettings.positionIterations;
		Physics2D.timeToSleep = defaultSettings.timeToSleep;
		Physics2D.linearSleepTolerance = defaultSettings.linearSleepTolerance;
		Physics2D.angularSleepTolerance = defaultSettings.angularSleepTolerence;
	}
}
