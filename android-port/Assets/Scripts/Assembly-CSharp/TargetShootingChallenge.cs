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
			if (newBottle == null || m_LauncherContainer == null)
			{
				return;
			}
			newBottle.gameObject.SetActive(true);
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
		if (launchers != null)
		{
			for (int i = 0; i < launchers.Length; i++)
			{
				Launcher l = launchers[i];
				if (l != null && l.m_LaunchTimes != null)
				{
					for (int j = 0; j < l.m_LaunchTimes.Count; j++)
					{
						finalLaunchTime = (int)Mathf.Max(finalLaunchTime, l.m_LaunchTimes[j]);
					}
				}
			}
		}
		if (LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
		{
			LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(HitsToWin, true, true, false);
		}
	}

	private void FixedUpdate()
	{
		if (finalLaunchTime <= 0 || launchers == null)
		{
			return;
		}
		int elapsed = Mathf.RoundToInt(Time.time - timeAtStart) % finalLaunchTime;
		if (elapsed == lastSecond)
		{
			return;
		}
		lastSecond = elapsed;
		for (int i = 0; i < launchers.Length; i++)
		{
			Launcher l = launchers[i];
			if (l == null || l.m_LaunchTimes == null)
			{
				continue;
			}
			foreach (float lt in l.m_LaunchTimes)
			{
				if ((int)lt == elapsed && prefab != null)
				{
					BreakableBottle b = UnityEngine.Object.Instantiate(prefab);
					if (b != null)
					{
						IHitscanTarget ht = b;
						ht.OnHitscanHit = (Action<IHitscanTarget>)Delegate.Combine(ht.OnHitscanHit, new Action<IHitscanTarget>(OnBottleHit));
						l.ThrowBottle(b.GetComponent<Rigidbody>());
					}
				}
			}
		}
	}

	public override string GetDescription()
	{
		string key = string.IsNullOrEmpty(DescriptionLocalizationID) ? "CHALLENGE_SHOOT_TARGETS" : DescriptionLocalizationID;
		if (Localization.Instance != null)
		{
			return string.Format(Localization.Instance.GetString(key), HitsToWin);
		}
		return string.Format(key, HitsToWin);
	}

	private void OnBottleHit(IHitscanTarget target)
	{
		hitCount++;
		if (LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
		{
			LevelManager.Instance.InGameMenu.CountStroke(controller, hitCount);
		}
		if (hitCount >= HitsToWin)
		{
			Complete();
		}
	}
}
