using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
	public float inZoneDragMultiplier = 0.3f;
	public float OverrideDragValue;
	public float OverrideMassValue;
	public int inAirShots = 1;
	public bool playGravitySwitchSfxOnBall;
	public List<SpecialCaseWind> SpecialCases;
	private List<RigidbodyAdded> added = new List<RigidbodyAdded>();
	private List<TimelineAdded> addedTimelines = new List<TimelineAdded>();
	private float baseBallDrag;
	private float baseBallMass;
	private float targetDrag;
	private List<Timeline> destroyedTimelines = new List<Timeline>();

	private void Awake()
	{
		if (added == null) added = new List<RigidbodyAdded>();
		if (addedTimelines == null) addedTimelines = new List<TimelineAdded>();
	}

	private IEnumerator Start()
	{
		yield return null;
		if (OverworldBallManager.Instance != null)
		{
			OverworldBallManager.Instance.OnNewBall -= Instance_OnNewBall;
			OverworldBallManager.Instance.OnNewBall += Instance_OnNewBall;
			if (OverworldBallManager.Instance.CurrentBall != null)
			{
				var rb = OverworldBallManager.Instance.CurrentBall.GetComponent<Rigidbody2D>();
				if (rb != null)
				{
					baseBallDrag = rb.drag;
					baseBallMass = rb.mass;
				}
				OverworldBallManager.Instance.CurrentBall.OnDisabled -= Ball_OnDisabled;
				OverworldBallManager.Instance.CurrentBall.OnDisabled += Ball_OnDisabled;
			}
		}
	}

	private void Ball_OnDisabled(OverworldBall2D ball)
	{
		if (ball == null) return;
		var rb = ball.GetComponent<Rigidbody2D>();
		if (rb != null && added != null)
			added.RemoveAll(r => r != null && r.rigidbody == rb);
		var tl = ball.GetComponent<Timeline>();
		if (tl != null && addedTimelines != null)
			addedTimelines.RemoveAll(t => t != null && t.timeline == tl);
		var grav = ball.GetComponent<OverworldBallInGravityHelper>();
		if (grav != null)
			grav.ExitGravityZone(this);
	}

	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape)
	{
		if (OverworldBallManager.Instance != null && OverworldBallManager.Instance.CurrentBall != null)
		{
			var rb = OverworldBallManager.Instance.CurrentBall.GetComponent<Rigidbody2D>();
			if (rb != null)
			{
				baseBallDrag = rb.drag;
				baseBallMass = rb.mass;
			}
			OverworldBallManager.Instance.CurrentBall.OnDisabled -= Ball_OnDisabled;
			OverworldBallManager.Instance.CurrentBall.OnDisabled += Ball_OnDisabled;
		}
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
		if (added != null)
		{
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
		if (addedTimelines != null)
		{
			for (int i = addedTimelines.Count - 1; i >= 0; i--)
			{
				var item = addedTimelines[i];
				if (item == null || item.timeline == null || item.timeline.rigidbody2D == null)
				{
					addedTimelines.RemoveAt(i);
					continue;
				}
				Vector2 pos = item.timeline.transform.position;
				item.timeline.rigidbody2D.AddForce(GetWindForce(pos) * item.forceRatio, ForceMode);
				if (OverrideDragValue != 0f)
					item.timeline.rigidbody2D.drag = OverrideDragValue;
				else if (isMinimizingDrag && targetDrag > 0f)
					item.timeline.rigidbody2D.drag = targetDrag;
				if (OverrideMassValue != 0f)
					item.timeline.rigidbody2D.mass = OverrideMassValue;
			}
		}
	}

	private bool IsAdded(Timeline timeline)
	{
		if (addedTimelines == null || timeline == null) return false;
		for (int i = 0; i < addedTimelines.Count; i++)
		{
			if (addedTimelines[i] != null && addedTimelines[i].timeline == timeline)
				return true;
		}
		return false;
	}

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
		if (other == null || other.attachedRigidbody == null) return;
		if (other.attachedRigidbody.isKinematic && !other.CompareTag("Player")) return;

		float ratio = 1f;
		if (SpecialCases != null)
		{
			int mask = 1 << other.gameObject.layer;
			var sc = SpecialCases.FirstOrDefault(s => s != null && (s.Layer.value & mask) != 0);
			if (sc != null)
				ratio = sc.ForceMod;
		}

		var tl = other.GetComponent<Timeline>() ?? other.attachedRigidbody.GetComponent<Timeline>();
		if (tl != null)
		{
			if (!IsAdded(tl))
			{
				if (baseBallDrag <= 0f && other.attachedRigidbody != null)
					baseBallDrag = other.attachedRigidbody.drag;
				if (baseBallMass <= 0f && other.attachedRigidbody != null)
					baseBallMass = other.attachedRigidbody.mass;
				if (isMinimizingDrag)
				{
					targetDrag = baseBallDrag * inZoneDragMultiplier;
					if (tl.rigidbody2D != null)
						tl.rigidbody2D.drag = targetDrag;
				}
				else
				{
					targetDrag = baseBallDrag;
				}
				addedTimelines.Add(new TimelineAdded { timeline = tl, forceRatio = ratio });
			}
		}
		else if (!IsAdded(other.attachedRigidbody))
		{
			added.Add(new RigidbodyAdded { rigidbody = other.attachedRigidbody, forceRatio = ratio });
		}

		var grav = other.attachedRigidbody.GetComponent<OverworldBallInGravityHelper>();
		if (grav != null)
			grav.EnterGravityZone(this, inAirShots);

		if (OverrideDragValue != 0f && other.attachedRigidbody != null)
			other.attachedRigidbody.drag = OverrideDragValue;
	}

	private IEnumerator DelayedDrag(RigidbodyTimeline2D rigid)
	{
		yield return null;
		if (rigid != null)
		{
			baseBallDrag = rigid.drag;
			targetDrag = baseBallDrag * inZoneDragMultiplier;
			rigid.drag = targetDrag;
		}
	}

	private void OnDisable()
	{
		added?.Clear();
		addedTimelines?.Clear();
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other == null || other.attachedRigidbody == null || other.attachedRigidbody.isKinematic) return;
		if (added != null)
			added.RemoveAll(r => r != null && r.rigidbody == other.attachedRigidbody);
		var tl = other.GetComponent<Timeline>() ?? other.attachedRigidbody.GetComponent<Timeline>();
		if (tl != null)
		{
			if (isMinimizingDrag && baseBallDrag > 0f && tl.rigidbody2D != null)
			{
				tl.rigidbody2D.drag = baseBallDrag;
				targetDrag = baseBallDrag;
			}
			addedTimelines?.RemoveAll(t => t != null && t.timeline == tl);
		}
		var grav = other.attachedRigidbody.GetComponent<OverworldBallInGravityHelper>();
		if (grav != null)
			grav.ExitGravityZone(this);
		if (OverrideDragValue != 0f && baseBallDrag > 0f)
			other.attachedRigidbody.drag = baseBallDrag;
		if (OverrideMassValue != 0f && baseBallMass > 0f)
			other.attachedRigidbody.mass = baseBallMass;
	}
}
