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
		public float ForceMod = 1f;
	}

	private class RigidbodyAdded
	{
		public Rigidbody2D rigidbody;
		public float forceRatio = 1f;
	}

	private class TimelineAdded
	{
		public Timeline timeline;
		public float forceRatio = 1f;
	}

	public ForceMode2D ForceMode = ForceMode2D.Force;
	public Vector2 WindForce;
	public bool isUsingTargetAsGravity;
	public Transform gravityTarget;
	public bool isMinimizingDrag;
	public float inZoneDragMultiplier = 1f;
	public float OverrideDragValue;
	public float OverrideMassValue;
	public int inAirShots;
	public bool playGravitySwitchSfxOnBall;
	public List<SpecialCaseWind> SpecialCases;
	private List<RigidbodyAdded> added = new List<RigidbodyAdded>();
	private List<TimelineAdded> addedTimelines = new List<TimelineAdded>();
	private float baseBallDrag;
	private float baseBallMass;
	private float targetDrag;
	private List<Timeline> destroyedTimelines;

	private void Awake()
	{
		if (added == null) added = new List<RigidbodyAdded>();
		if (addedTimelines == null) addedTimelines = new List<TimelineAdded>();
	}

	private IEnumerator Start()
	{
		yield break;
	}

	private void Ball_OnDisabled(OverworldBall2D ball)
	{
	}

	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape)
	{
	}

	private Vector2 GetWindForce(Vector2 from)
	{
		if (isUsingTargetAsGravity && gravityTarget != null)
		{
			Vector2 dir = ((Vector2)gravityTarget.position - from).normalized;
			return dir * WindForce.magnitude;
		}
		return WindForce;
	}

	private void FixedUpdate()
	{
		if (added == null || added.Count == 0)
			return;
		for (int i = added.Count - 1; i >= 0; i--)
		{
			var item = added[i];
			if (item == null || item.rigidbody == null)
			{
				added.RemoveAt(i);
				continue;
			}
			item.rigidbody.AddForce(GetWindForce(item.rigidbody.position) * item.forceRatio, ForceMode);
		}
	}

	private bool IsAdded(Timeline timeline) => false;

	private bool IsAdded(Rigidbody2D rigidbody)
	{
		if (added == null || rigidbody == null) return false;
		for (int i = 0; i < added.Count; i++)
		{
			if (added[i] != null && added[i].rigidbody == rigidbody)
				return true;
		}
		return false;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other == null) return;
		var rb = other.attachedRigidbody ?? other.GetComponent<Rigidbody2D>();
		if (rb != null && !IsAdded(rb))
		{
			float ratio = 1f;
			if (SpecialCases != null)
			{
				int mask = 1 << other.gameObject.layer;
				for (int i = 0; i < SpecialCases.Count; i++)
				{
					if (SpecialCases[i] != null && (SpecialCases[i].Layer.value & mask) != 0)
						ratio *= SpecialCases[i].ForceMod;
				}
			}
			added.Add(new RigidbodyAdded { rigidbody = rb, forceRatio = ratio });
		}
	}

	private IEnumerator DelayedDrag(RigidbodyTimeline2D rigid)
	{
		yield break;
	}

	private void OnDisable()
	{
		if (added != null)
			added.Clear();
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other == null || added == null) return;
		var rb = other.attachedRigidbody ?? other.GetComponent<Rigidbody2D>();
		if (rb == null) return;
		for (int i = added.Count - 1; i >= 0; i--)
		{
			if (added[i] != null && added[i].rigidbody == rb)
				added.RemoveAt(i);
		}
	}
}
