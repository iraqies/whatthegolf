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
			newBottle.gameObject.SetActive(value: true);
			newBottle.MovePosition(m_LauncherContainer.position);
			newBottle.velocity = m_LauncherContainer.up * force;
			newBottle.angularVelocity = m_LauncherContainer.right * angularForce;
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
		timeAtStart = Time.time;
		controller = UnityEngine.Object.FindObjectOfType<GolfBallController>();
		for (int i = 0; i < launchers.Length; i++)
		{
			for (int j = 0; j < launchers[i].m_LaunchTimes.Count; j++)
			{
				finalLaunchTime = (int)Mathf.Max(finalLaunchTime, launchers[i].m_LaunchTimes[j]);
			}
		}
		LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(HitsToWin, StrokeCounter.CounterTypes.CardsDisappearing, useExternalCountActivator: true);
	}

	private void FixedUpdate()
	{
		int num = Mathf.RoundToInt(Time.time - timeAtStart) % finalLaunchTime;
		if (lastSecond == num)
		{
			return;
		}
		lastSecond = num;
		for (int i = 0; i < launchers.Length; i++)
		{
			Launcher launcher = launchers[i];
			foreach (float launchTime in launcher.m_LaunchTimes)
			{
				if (num == (int)launchTime)
				{
					BreakableBottle breakableBottle = UnityEngine.Object.Instantiate(prefab);
					IHitscanTarget hitscanTarget = breakableBottle;
					hitscanTarget.OnHitscanHit = (Action<IHitscanTarget>)Delegate.Combine(hitscanTarget.OnHitscanHit, new Action<IHitscanTarget>(OnBottleHit));
					launcher.ThrowBottle(breakableBottle.GetComponent<Rigidbody>());
				}
			}
		}
	}

	public override string GetDescription()
	{
		if (string.IsNullOrEmpty(DescriptionLocalizationId))
		{
			return string.Format(Localization.Instance.GetString("ID_CHALLENGE_BOTTLESHOOTER"), HitsToWin);
		}
		return string.Format(Localization.Instance.GetString(DescriptionLocalizationId), HitsToWin);
	}

	private void OnBottleHit(IHitscanTarget target)
	{
		hitCount++;
		LevelManager.Instance.InGameMenu.CountStroke(controller, hitCount);
		if (hitCount >= HitsToWin)
		{
			Complete();
		}
	}
}
