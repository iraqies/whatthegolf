using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class TargetShootingChallenge : Challenge
{
	[Serializable]
	public class Launcher
	{
		public float force;

		public float angularForce;

		public Transform m_LauncherContainer;

		public List<float> m_LaunchTimes;

		public void ThrowBottle(Rigidbody newBottle)
		{
		}
	}

	public int HitsToWin;

	public BreakableBottle prefab;

	public GameObject bottlePrefab;

	public Launcher[] launchers;

	private float timeAtStart;

	private int index;

	private int hitCount;

	private int targetsLeft;

	private GolfBallController controller;

	private int finalLaunchTime;

	private int lastSecond;

	protected override void Activate()
	{
	}

	private void FixedUpdate()
	{
	}

	public override string GetDescription()
	{
		return null;
	}

	private void OnBottleHit(IHitscanTarget target)
	{
	}
}
