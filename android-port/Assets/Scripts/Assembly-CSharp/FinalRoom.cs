using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class FinalRoom : GolfBehaviour
{
	public OverworldGoal goal;

	public GameObject evilContainer;

	public SpriteMask mask;

	public List<Transform> exitPath;

	public ConfettiSpawner confetti;

	public OverworldMusicData triumpOverworldMusicData;

	public OverworldMusic overworldMusicManager;

	public float ballMoveSpeed = 1f;

	public float shootoutSpeed = 1f;

	private bool completed;

	public UnlockAchievement bossAchievement;

	private void Start()
	{
		if (mask != null)
			mask.enabled = false;
		if (goal != null)
		{
			if (goal.IsCompleted())
			{
				completed = true;
				if (mask != null)
					mask.enabled = true;
				goal.OnUpdateData += Goal_Completed_OnUpdateData;
			}
			else
			{
				goal.OnUpdateData += Goal_OnUpdateData;
			}
		}
	}

	private void Goal_Completed_OnUpdateData(OverworldGoal obj)
	{
		if (OverworldBallManager.Instance != null && OverworldBallManager.Instance.CurrentBall != null)
			OverworldBallManager.Instance.CurrentBall.LockForDuration(0.2f);
	}

	private void Goal_OnUpdateData(OverworldGoal flag)
	{
		if (completed || goal == null || !goal.IsCompleted())
			return;
		if (overworldMusicManager != null && triumpOverworldMusicData != null)
			overworldMusicManager.StartWithoutTransition(triumpOverworldMusicData);
		if (bossAchievement != null)
			bossAchievement.ManualUnlock();
		StartCoroutine(EndRoutine());
		goal.OnUpdateData -= Goal_OnUpdateData;
	}

	private IEnumerator EndRoutine()
	{
		if (confetti != null)
			confetti.PlayConfettiSound(false);
		if (evilContainer != null)
			evilContainer.SetActive(true);
		yield return new WaitForSeconds(0.5f);

		if (mask != null)
		{
			mask.enabled = true;
			Vector3 targetScale = mask.transform.localScale;
			StartCoroutine(pTween.To(0.4f, t =>
			{
				if (mask != null)
					mask.transform.localScale = Vector3.Lerp(Vector3.zero, targetScale, Mathf.Clamp01(TweenFunctions.EaseIn(t)));
			}));
		}
		yield return new WaitForSeconds(0.6f);

		OverworldBall2D ball = OverworldBallManager.Instance != null ? OverworldBallManager.Instance.CurrentBall : null;
		if (ball != null)
		{
			if (ball.Rigidbody != null)
				ball.Rigidbody.isKinematic = true;
			ball.SetColliders(false);
			ball.enabled = false;
			if (ball.Controller != null)
				ball.Controller.enabled = false;
		}

		float nextConfettiTime = 0f;
		int idx = 0;
		if (exitPath != null && ball != null && ball.Rigidbody != null)
		{
			foreach (Transform pt in exitPath)
			{
				while (pt != null && Vector3.Distance(ball.Rigidbody.position, pt.position) > 0.01f)
				{
					Vector3 nextPos = Vector3.MoveTowards(ball.transform.position, pt.position, Time.unscaledDeltaTime * ballMoveSpeed);
					ball.Rigidbody.MovePosition(nextPos);
					if (Time.time > nextConfettiTime && idx <= 4 && confetti != null)
					{
						for (int i = 0; i < 10; i++)
							confetti.SpawnConfetti(nextPos + Vector3.down * Random.Range(0f, 0.2f));
						nextConfettiTime = Time.time + 0.04f;
					}
					yield return null;
				}
				idx++;
			}
		}

		if (ball != null)
		{
			if (ball.Rigidbody != null)
				ball.Rigidbody.velocity = Vector2.zero;
			ball.SetColliders(true);
		}
		yield return new WaitForFixedUpdate();

		if (ball != null && ball.Rigidbody != null)
		{
			ball.Rigidbody.isKinematic = false;
			ball.Rigidbody.velocity = new Vector2(-shootoutSpeed, -shootoutSpeed);
		}
		yield return new WaitForSecondsRealtime(0.3f);

		if (ball != null && ball.Controller != null)
			ball.Controller.enabled = true;
		SetCompletedState();
	}

	private void SetCompletedState()
	{
		completed = true;
		if (mask != null)
			mask.enabled = true;
	}
}
