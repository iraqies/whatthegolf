using System;
using System.Collections;
using System.Collections.Generic;
using Chronos;
using UnityEngine;

public class WindArea2D : MonoBehaviour
{
	[Serializable]
	public class SpecialCaseWind
	{
		public LayerMask Layer;

		public float ForceMod;
	}

	private class RigidbodyAdded
	{
		public Rigidbody2D rigidbody;

		public float forceRatio;
	}

	private class TimelineAdded
	{
		public Timeline timeline;

		public float forceRatio;
	}

	public ForceMode2D ForceMode;

	public Vector2 WindForce;

	public bool isUsingTargetAsGravity;

	public Transform gravityTarget;

	public bool isMinimizingDrag;

	public float inZoneDragMultiplier;

	public float OverrideDragValue;

	public float OverrideMassValue;

	public int inAirShots;

	public bool playGravitySwitchSfxOnBall;

	public List<SpecialCaseWind> SpecialCases;

	private List<RigidbodyAdded> added;

	private List<TimelineAdded> addedTimelines;

	private float baseBallDrag;

	private float baseBallMass;

	private float targetDrag;

	private List<Timeline> destroyedTimelines;

	private void Awake()
	{
	}

	private IEnumerator Start()
	{
		return null;
	}

	private void Ball_OnDisabled(OverworldBall2D ball)
	{
	}

	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape)
	{
	}

	private Vector2 GetWindForce(Vector2 from)
	{
		return default;
	}

	private void FixedUpdate()
	{
	}

	private bool IsAdded(Timeline timeline)
	{
		return false;
	}

	private bool IsAdded(Rigidbody2D rigidbody)
	{
		return false;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private IEnumerator DelayedDrag(RigidbodyTimeline2D rigid)
	{
		return null;
	}

	private void OnDisable()
	{
	}

	private void OnTriggerExit2D(Collider2D other)
	{
	}
}
