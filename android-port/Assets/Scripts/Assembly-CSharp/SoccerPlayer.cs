using System;
using System.Collections.Generic;
using System.Linq;
using Audio;
using Chronos;
using Core;
using UnityEngine;

public class SoccerPlayer : MonoBehaviour
{
	public List<Rigidbody> balls;

	public bool KickTarget = true;

	public float KickForce = 50f;

	public float kickRange = 360f;

	public float speed;

	public Vector2 RandomSpeedModRange = Vector2.one;

	public float reactDistance;

	public float stopDistance;

	public List<AudioClip> sfxKick;

	public float rotateSpeed = 250f;

	public bool lookAlongVelocity = true;

	public bool AvoidEdges = true;

	public float MaxRunTime = 1f;

	public bool MoveOnlyWhenGrounded;

	public float PlayerBlockTime = 0.2f;

	private Vector3 startPosition;

	private Quaternion startRotation;

	private Rigidbody rigid;

	private float nextHit;

	private Collider col;

	private float waitTime;

	private bool targetIsTouching;

	public Action onKick;

	private float runningTime;

	private bool didRunTooMuch;

	private LaserSentryTarget laserSentryTarget;

	private Rigidbody currentTarget;

	private Timeline timeline;

	private bool timelineFound;

	private float FixedDeltaTime
	{
		get
		{
			if (timelineFound && timeline != null)
			{
				return timeline.fixedDeltaTime;
			}
			return Time.fixedUnscaledDeltaTime;
		}
	}

	private float DeltaTime
	{
		get
		{
			if (timelineFound && timeline != null)
			{
				return timeline.deltaTime;
			}
			return Time.deltaTime;
		}
	}

	public Vector3 Velocity
	{
		get
		{
			if (timelineFound && timeline != null && timeline.rigidbody != null)
			{
				return timeline.rigidbody.velocity;
			}
			if (rigid != null)
			{
				return rigid.velocity;
			}
			return Vector3.zero;
		}
		set
		{
			if (timelineFound && timeline != null && timeline.rigidbody != null)
			{
				timeline.rigidbody.velocity = value;
			}
			else if (rigid != null)
			{
				rigid.velocity = value;
			}
		}
	}

	public Vector3 AngularVelocity
	{
		get
		{
			if (timelineFound && timeline != null && timeline.rigidbody != null)
			{
				return timeline.rigidbody.angularVelocity;
			}
			if (rigid != null)
			{
				return rigid.angularVelocity;
			}
			return Vector3.zero;
		}
		set
		{
			if (timelineFound && timeline != null && timeline.rigidbody != null)
			{
				timeline.rigidbody.angularVelocity = value;
			}
			else if (rigid != null)
			{
				rigid.angularVelocity = value;
			}
		}
	}

	public float Drag
	{
		get
		{
			if (timelineFound && timeline != null && timeline.rigidbody != null)
			{
				return timeline.rigidbody.component.drag;
			}
			if (rigid != null)
			{
				return rigid.drag;
			}
			return 0f;
		}
		set
		{
			if (timelineFound && timeline != null && timeline.rigidbody != null)
			{
				timeline.rigidbody.component.drag = value;
			}
			else if (rigid != null)
			{
				rigid.drag = value;
			}
		}
	}

	public float AngularDrag
	{
		get
		{
			if (timelineFound && timeline != null && timeline.rigidbody != null)
			{
				return timeline.rigidbody.component.angularDrag;
			}
			if (rigid != null)
			{
				return rigid.angularDrag;
			}
			return 0f;
		}
		set
		{
			if (timelineFound && timeline != null && timeline.rigidbody != null)
			{
				timeline.rigidbody.component.angularDrag = value;
			}
			else if (rigid != null)
			{
				rigid.angularDrag = value;
			}
		}
	}

	public float LocalTime
	{
		get
		{
			if (timelineFound && timeline != null)
			{
				return timeline.time;
			}
			return Time.time;
		}
	}

	public bool IsKinematic
	{
		get
		{
			if (timelineFound && timeline != null && timeline.rigidbody != null)
			{
				return timeline.rigidbody.isKinematic;
			}
			if (rigid != null)
			{
				return rigid.isKinematic;
			}
			return false;
		}
		set
		{
			if (timelineFound && timeline != null && timeline.rigidbody != null)
			{
				timeline.rigidbody.isKinematic = value;
			}
			else if (rigid != null)
			{
				rigid.isKinematic = value;
			}
		}
	}

	private void Awake()
	{
		timeline = GetComponent<Timeline>();
		timelineFound = timeline != null;
		if (Level.Instance != null)
		{
			Level.Instance.OnMultiplayerSetup += OnMultiplayerSetup;
		}
	}

	private void OnMultiplayerSetup(MultiplayerLevelInfo info)
	{
		if (info == null)
		{
			return;
		}
		IEnumerable<Rigidbody> enumerable = from c in info.GetAllControllers()
			select c.gameObject.GetComponentInChildren<Rigidbody>();
		if (balls == null)
		{
			balls = new List<Rigidbody>();
		}
		foreach (Rigidbody item in enumerable)
		{
			if (item != null && !balls.Contains(item))
			{
				balls.Add(item);
			}
		}
	}

	private void Start()
	{
		rigid = GetComponent<Rigidbody>();
		startPosition = base.transform.position;
		startRotation = base.transform.rotation;
		col = GetComponentInChildren<Collider>();
		Animator componentInChildren = GetComponentInChildren<Animator>();
		laserSentryTarget = GetComponent<LaserSentryTarget>();
		if (laserSentryTarget != null)
		{
			laserSentryTarget.OnLasered += LaserSentryTarget_OnLasered;
		}
		if (componentInChildren != null)
		{
			componentInChildren.speed = UnityEngine.Random.Range(0.9f, 1.1f);
		}
		if (balls != null && balls.Count >= 1)
		{
			currentTarget = balls[0];
		}
		speed *= UnityEngine.Random.Range(RandomSpeedModRange.x, RandomSpeedModRange.y);
	}

	public void AddBallTarget(Rigidbody ball)
	{
		if (balls != null)
		{
			balls.Add(ball);
		}
		if (currentTarget == null)
		{
			currentTarget = ball;
		}
	}

	public void AddBallTarget(GolfBallController controller)
	{
		if (balls != null)
		{
			for (int num = balls.Count - 1; num >= 0; num--)
			{
				if (balls[num] == null)
				{
					balls.RemoveAt(num);
				}
			}
		}
		if (controller != null && controller.TryGetComponent<Rigidbody>(out var component) && balls != null && !balls.Contains(component))
		{
			AddBallTarget(component);
		}
	}

	private void LaserSentryTarget_OnLasered()
	{
		base.enabled = false;
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null)
		{
			return;
		}
		Rigidbody rigidbody = collision.rigidbody;
		if (currentTarget != null && rigidbody == currentTarget && Time.time > nextHit && KickTarget)
		{
			Vector3 position = currentTarget.transform.position;
			position.y = rigid.position.y;
			if (Vector3.Angle(base.transform.forward, (position - rigid.position).normalized) > kickRange)
			{
				targetIsTouching = true;
				return;
			}
			targetIsTouching = false;
			DoKick(rigidbody);
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		if (collision != null && collision.rigidbody == currentTarget)
		{
			targetIsTouching = false;
		}
	}

	private void DoKick(Rigidbody other)
	{
		nextHit = Time.time + 0.15f;
		if (other == null)
		{
			return;
		}
		Timeline component = other.GetComponent<Timeline>();
		if (component != null && component.rigidbody != null)
		{
			Vector3 force = Vector3.up * KickForce * 0.2f + base.transform.forward * (KickForce * 6f);
			component.rigidbody.AddForce(force, ForceMode.Impulse);
		}
		else
		{
			Vector3 force2 = Vector3.up * KickForce * 0.2f + base.transform.forward * (KickForce * 6f);
			other.AddForce(force2, ForceMode.Impulse);
		}
		onKick?.Invoke();
		if (AudioManager.Instance != null && AudioManager.Instance.sfx != null && sfxKick != null)
		{
			AudioManager.Instance.sfx.Play(sfxKick, delegate(AudioSource s)
			{
				if (s != null)
				{
					s.transform.position = base.transform.position;
					s.volume = 0.5f;
					s.pitch = UnityEngine.Random.Range(0.8f, 1.2f);
				}
			}, true, false, 0f);
		}
		GolfBallController componentInChildren = other.gameObject.GetComponentInChildren<GolfBallController>();
		if (componentInChildren != null)
		{
			componentInChildren.TimedBlockShot(PlayerBlockTime);
		}
		runningTime += 0.2f;
	}

	private void FixedUpdate()
	{
		if (currentTarget == null)
		{
			Velocity = Vector3.zero;
			return;
		}
		if (balls != null && balls.Count >= 2)
		{
			float num = float.PositiveInfinity;
			for (int i = 0; i < balls.Count; i++)
			{
				if (balls[i] != null && balls[i].gameObject.activeInHierarchy)
				{
					float num2 = Vector3.Distance(base.transform.position, balls[i].position);
					if (num2 < num)
					{
						currentTarget = balls[i];
						num = num2;
					}
				}
			}
		}
		if (currentTarget == null || rigid == null)
		{
			return;
		}
		Vector3 position = currentTarget.transform.position;
		position.y = rigid.position.y;
		float num3 = Vector3.Angle(base.transform.forward, (position - rigid.position).normalized);
		if (targetIsTouching && num3 <= kickRange && Time.time > nextHit)
		{
			targetIsTouching = false;
			DoKick(currentTarget);
		}
		if (AvoidEdges && col != null)
		{
			Vector3 center = col.bounds.center;
			Vector3 velocity = Velocity;
			Vector3 origin = center + velocity * Time.deltaTime;
			float maxDistance = col.bounds.size.y / 1.9f;
			int layerMask = 1 << LayerMask.NameToLayer("Ground");
			if (!Physics.Raycast(origin, Vector3.down, maxDistance, layerMask))
			{
				Velocity = (startPosition - base.transform.position).normalized * speed;
				waitTime = 0.5f;
			}
		}
		bool flag = true;
		if (MoveOnlyWhenGrounded && col != null)
		{
			Vector3 center2 = col.bounds.center;
			float maxDistance2 = col.bounds.size.y / 1.9f;
			int layerMask2 = 1 << LayerMask.NameToLayer("Ground");
			flag = Physics.Raycast(center2, Vector3.down, maxDistance2, layerMask2);
		}
		if (waitTime > 0f)
		{
			flag = false;
			waitTime -= DeltaTime;
		}
		float num4 = speed;
		Vector3 vector = startPosition - currentTarget.transform.position;
		Vector3 vector2 = new Vector3(base.transform.position.x - currentTarget.transform.position.x, 0f, base.transform.position.z - currentTarget.transform.position.z);
		if (runningTime > MaxRunTime)
		{
			didRunTooMuch = true;
		}
		if (vector.magnitude > reactDistance || didRunTooMuch)
		{
			vector2 = base.transform.position - startPosition;
			runningTime = Mathf.MoveTowards(Mathf.Clamp01(runningTime), 0f, DeltaTime * 0.5f);
			if (runningTime <= 0f)
			{
				didRunTooMuch = false;
			}
		}
		else if (vector2.magnitude >= reactDistance * 0.1f)
		{
			runningTime += DeltaTime * 0.5f;
		}
		else
		{
			flag = false;
		}
		if (vector.magnitude > reactDistance * 2f)
		{
			num4 = speed * 0.05f;
			runningTime = 0f;
			didRunTooMuch = false;
		}
		float magnitude = vector2.magnitude;
		float magnitude2 = vector2.magnitude;
		if (flag)
		{
			if (num3 <= kickRange && stopDistance > 0f && magnitude2 < stopDistance)
			{
				Velocity = Vector3.zero;
				AngularVelocity = Vector3.zero;
			}
			else if (waitTime <= 0f)
			{
				if (vector2.magnitude > 1f || vector.magnitude > 1f)
				{
					vector2 *= num4;
					float magnitude3 = vector2.magnitude;
					if (magnitude3 * FixedDeltaTime > magnitude)
					{
						vector2 = vector2.normalized * magnitude;
					}
					if (vector2.magnitude > 1f)
					{
						vector2.Normalize();
					}
					Velocity = -vector2 * num4 * 0.9f;
				}
			}
		}
		if (lookAlongVelocity && Velocity.magnitude > 0.1f)
		{
			Quaternion to = Quaternion.LookRotation(rigid.velocity);
			rigid.MoveRotation(Quaternion.RotateTowards(base.transform.rotation, to, rotateSpeed * Time.unscaledDeltaTime));
		}
		else if (vector.magnitude < reactDistance)
		{
			Quaternion to2 = Quaternion.LookRotation((position - rigid.position).normalized, Vector3.up);
			rigid.rotation = Quaternion.RotateTowards(rigid.rotation, to2, rotateSpeed * Time.unscaledDeltaTime);
		}
		else if (Vector3.Distance(base.transform.position, startPosition) < 1f)
		{
			rigid.MoveRotation(Quaternion.RotateTowards(base.transform.rotation, startRotation, rotateSpeed * Time.unscaledDeltaTime));
		}
	}

	public Rigidbody GetRigid()
	{
		if (rigid == null)
		{
			rigid = GetComponent<Rigidbody>();
		}
		return rigid;
	}

	private void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
	{
		if (timelineFound && timeline != null && timeline.rigidbody != null)
		{
			timeline.rigidbody.AddForceAtPosition(force, position, forceMode);
		}
		else if (rigid != null)
		{
			rigid.AddForceAtPosition(force, position, forceMode);
		}
	}

	private void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
	{
		if (timelineFound && timeline != null && timeline.rigidbody != null)
		{
			timeline.rigidbody.AddForce(force, forceMode);
		}
		else if (rigid != null)
		{
			rigid.AddForce(force, forceMode);
		}
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(base.transform.position, reactDistance);
	}
}
