using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;
using UnityEngine.Events;

public class TowerController : MonoBehaviour
{
	public List<float> PowerGoals;

	public List<Transform> Positions;

	public Transform FlagPosition;

	public Transform TowerRoot;

	public TowerPowerGoal TowerPower;

	public Animator Animator;

	public WhackHammerController Hammer;

	public float AcceptedErrorMargin = 0.1f;

	public ClipSettingsCollection BellRingClip;

	public ClipSettingsCollection HitPlatformClip;

	public ClipSettingsCollection TowerMovingClip;

	public ClipSettingsCollection HoleMovingClip;

	public ClipSettingsCollection IncorrectHitClip;

	private bool hasHitCorrectPower;

	private int currentIndex;

	private bool readyForHits;

	[SerializeField]
	private bool ShowFlag = true;

	[SerializeField]
	private bool HideOnDone = true;

	[SerializeField]
	private bool PlayHoleMoving = true;

	[SerializeField]
	private bool UseIncorrectAnimation = true;

	[SerializeField]
	private GameObject Sphere;

	[SerializeField]
	private GameObject RealSphere;

	[SerializeField]
	private UnityEvent OnHitDone;

	private void Start()
	{
		if (Hammer != null)
		{
			Hammer.OnHit = (Action<float>)Delegate.Combine(Hammer.OnHit, new Action<float>(OnHit));
		}
		StartCoroutine(SetTower());
	}

	private IEnumerator SetTower()
	{
		while (PowerGoals != null && currentIndex < PowerGoals.Count)
		{
			if (TowerPower != null)
			{
				TowerPower.ChangeArrow(0f, 0f);
			}
			if (Positions != null && currentIndex < Positions.Count && Positions[currentIndex] != null)
			{
				base.transform.position = Positions[currentIndex].position;
				base.transform.rotation = Positions[currentIndex].rotation;
			}
			yield return new WaitForSeconds(1f);
			if (Animator != null)
			{
				Animator.SetTrigger("Show");
			}
			yield return new WaitForSeconds(2f);
			if (TowerPower != null)
			{
				TowerPower.ChangeArrow(0.5f, PowerGoals[currentIndex]);
			}
			readyForHits = true;
			while (!hasHitCorrectPower)
			{
				yield return null;
			}
			if (Animator != null)
			{
				Animator.SetTrigger("CorrectHit");
			}
			currentIndex++;
			hasHitCorrectPower = false;
			readyForHits = false;
			if (HideOnDone)
			{
				yield return new WaitForSeconds(3.75f);
			}
			if (currentIndex < PowerGoals.Count && HideOnDone && Animator != null)
			{
				Animator.SetTrigger("Hide");
			}
		}
		if (FlagPosition != null)
		{
			base.transform.position = FlagPosition.position;
			base.transform.rotation = FlagPosition.rotation;
		}
		if (ShowFlag && Animator != null)
		{
			Animator.SetTrigger("ShowFlag");
		}
		if (OnHitDone != null)
		{
			OnHitDone.Invoke();
		}
	}

	private void OnHit(float power)
	{
		if (!readyForHits || PowerGoals == null || currentIndex >= PowerGoals.Count)
		{
			return;
		}
		float num = Mathf.Abs(PowerGoals[currentIndex] - power) - AcceptedErrorMargin;
		if (!UseIncorrectAnimation && num <= 0f)
		{
			if (Mathf.Abs(power / PowerGoals[currentIndex]) >= 0.9f)
			{
				hasHitCorrectPower = true;
			}
			if (Animator != null)
			{
				Animator.SetTrigger("IncorrectHitMisusSphere");
			}
			float startY = -9.42f;
			float endY = power / Mathf.Abs(PowerGoals[currentIndex]) * 9.4f;
			StartCoroutine(pTween.To(1.2f, 0f, 1f, delegate(float t)
			{
				if (Sphere != null)
				{
					Vector3 localPosition = Sphere.transform.localPosition;
					localPosition.y = Mathf.Lerp(startY, endY, Bounce.Out(t));
					Sphere.transform.localPosition = localPosition;
				}
			}));
			return;
		}
		if (Sphere != null)
		{
			Sphere.SetActive(false);
		}
		if (RealSphere != null)
		{
			RealSphere.SetActive(true);
		}
		if (num <= 0f)
		{
			hasHitCorrectPower = true;
		}
		else if (IncorrectHitClip != null)
		{
			IncorrectHitClip.Play(null, base.transform.position);
		}
	}

	public void RingBell()
	{
		if (BellRingClip != null)
		{
			BellRingClip.Play(null, base.transform.position);
		}
	}

	public void HitPlatform()
	{
		if (HitPlatformClip != null)
		{
			HitPlatformClip.Play(null, base.transform.position);
		}
	}

	public void TowerMoving()
	{
		if (TowerMovingClip != null)
		{
			TowerMovingClip.Play(null, base.transform.position);
		}
	}

	public void HoleMoving()
	{
		if (PlayHoleMoving && HoleMovingClip != null)
		{
			HoleMovingClip.Play(null, base.transform.position);
		}
	}
}
