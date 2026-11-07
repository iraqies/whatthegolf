using System;
using System.Collections;
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
		return null;
	}

	private void Instance_OnToggleOverworld(bool isActive)
	{
	}

	public void EnterOverworld()
	{
	}

	public void ExitOverworld()
	{
	}
}
