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
	private float paritcleEmissionMod;

	[SerializeField]
	private GameObject finalHole;

	[SerializeField]
	private List<ActionAfterDelay> actions;

	[SerializeField]
	private Vector2 StayUpDurationRange;

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
	}

	private void Start()
	{
	}

	private void GoUp(Hole h)
	{
	}

	private void LateUpdate()
	{
	}

	private IEnumerator Swap()
	{
		return null;
	}

	public void ActivateFinalHole()
	{
	}

	public void HasBeenWhacked()
	{
	}

	public void TweenLight()
	{
	}
}
