using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolesToWack : MonoBehaviour
{
	[Serializable]
	public struct Hole
	{
		public GameObject HoleTransform;

		public Animator HoleAnimator;
	}

	[SerializeField]
	private List<Hole> holes;

	[SerializeField]
	private List<GameObject> thingsInHolePrefab;

	[SerializeField]
	private ParticleSystem DizzySystem;

	[SerializeField]
	private List<float> thingsInHoleUpMod;

	[SerializeField]
	private ActionAfterNumEvents ticker;

	[SerializeField]
	private GolfGoal finalFlag;

	[SerializeField]
	private float paritcleEmissionMod = 1f;

	[SerializeField]
	private GameObject finalHole;

	[SerializeField]
	private List<ActionAfterDelay> actions;

	[SerializeField]
	private Vector2 StayUpDurationRange = new Vector2(1.5f, 3f);

	[SerializeField]
	private ParticleSystem HitParticles;

	private float stayUpTimer;

	private int currentIndex;

	private int currentThingIndex;

	private bool final;

	private GameObject currentThing;

	private Coroutine swap;

	private void Awake()
	{
		if (finalHole != null)
		{
			finalHole.SetActive(false);
		}
	}

	private void Start()
	{
		if (holes != null && holes.Count > 0)
		{
			swap = StartCoroutine(Swap());
		}
	}

	private void GoUp(Hole h)
	{
		if (h.HoleAnimator != null)
		{
			h.HoleAnimator.SetTrigger("Up");
		}
		if (thingsInHolePrefab != null && thingsInHolePrefab.Count > 0 && h.HoleTransform != null)
		{
			currentThingIndex = UnityEngine.Random.Range(0, thingsInHolePrefab.Count);
			GameObject prefab = thingsInHolePrefab[currentThingIndex];
			if (prefab != null)
			{
				if (currentThing != null)
				{
					UnityEngine.Object.Destroy(currentThing);
				}
				currentThing = UnityEngine.Object.Instantiate(prefab, h.HoleTransform.transform.position, Quaternion.identity, h.HoleTransform.transform);
				currentThing.SetActive(true);
			}
		}
	}

	private void LateUpdate()
	{
	}

	private IEnumerator Swap()
	{
		while (!final && holes != null && holes.Count > 0)
		{
			currentIndex = UnityEngine.Random.Range(0, holes.Count);
			Hole h = holes[currentIndex];
			GoUp(h);
			stayUpTimer = UnityEngine.Random.Range(StayUpDurationRange.x, StayUpDurationRange.y);
			yield return new WaitForSeconds(Mathf.Max(0.5f, stayUpTimer));
			if (h.HoleAnimator != null)
			{
				h.HoleAnimator.SetTrigger("Down");
			}
			yield return new WaitForSeconds(0.5f);
		}
	}

	public void ActivateFinalHole()
	{
		final = true;
		if (swap != null)
		{
			StopCoroutine(swap);
		}
		if (finalHole != null)
		{
			finalHole.SetActive(true);
		}
		if (finalFlag != null)
		{
			finalFlag.gameObject.SetActive(true);
		}
	}

	public void HasBeenWhacked()
	{
		if (HitParticles != null)
		{
			HitParticles.Play();
		}
		if (DizzySystem != null)
		{
			DizzySystem.Play();
		}
		if (ticker != null)
		{
			ticker.Tick();
			if (ticker.Progress() >= 1f)
			{
				ActivateFinalHole();
			}
		}
	}

	public void TweenLight()
	{
		if (actions != null)
		{
			for (int i = 0; i < actions.Count; i++)
			{
				if (actions[i] != null)
				{
					actions[i].DoAction();
				}
			}
		}
	}
}
