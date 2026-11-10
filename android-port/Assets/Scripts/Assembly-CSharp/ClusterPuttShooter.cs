using System.Linq;
using Core;
using UnityEngine;

public class ClusterPuttShooter : GolfBallShooterBase
{
	public float Force;

	public float Pitch;

	public Vector2 RandomRange = new Vector2(0.8f, 1.2f);

	public float InheritVelocity;

	public Rigidbody[] rigidbodies;

	public Rigidbody[] blacklist;

	public GameObject Tracker;

	public float MaxAutoAimDistance = 75f;

	public float SphereCastRadius = 15f;

	private Collider onCar;

	private BlockIfNotNearStuff blocker;

	private float delay;

	private float trackerTimer;

	private Collider lastTrackerHit;

	private string carLayer = "Car";

	protected override void Awake()
	{
		base.Awake();
		blocker = GetComponent<BlockIfNotNearStuff>();
		rigidbodies = GetComponentsInChildren<Rigidbody>();
		if (rigidbodies != null && blacklist != null && blacklist.Length > 0)
		{
			rigidbodies = rigidbodies.Where(rb => !blacklist.Contains(rb)).ToArray();
		}
	}

	private void Update()
	{
		if (delay > 0f)
		{
			delay -= Time.deltaTime;
			if (delay <= 0f)
			{
				if (GolfBallController != null)
				{
					GolfBallController.canShoot = false;
				}
				if (blocker != null)
				{
					blocker.enabled = true;
				}
			}
		}
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (Tracker != null)
		{
			Tracker.SetActive(false);
		}
		Vector3 origin = base.transform.position - Vector3.up * 5f;
		RaycastHit[] hits = Physics.SphereCastAll(origin, SphereCastRadius, boost.normalized, MaxAutoAimDistance, 1 << LayerMask.NameToLayer(carLayer));
		if (hits == null || hits.Length == 0)
			return;

		RaycastHit[] sorted = hits.Where(h => h.collider != onCar).OrderBy(c => Vector3.Distance(base.transform.position, c.transform.position)).ToArray();
		if (sorted.Length == 0 || sorted[0].collider == null)
			return;

		if (lastTrackerHit != sorted[0].collider)
		{
			trackerTimer = 0f;
			lastTrackerHit = sorted[0].collider;
		}
		Bounds bounds = sorted[0].collider.bounds;
		Vector3 targetPos = new Vector3(bounds.center.x, bounds.max.y, bounds.center.z);
		if (Tracker != null)
		{
			Tracker.SetActive(true);
			trackerTimer += Time.unscaledDeltaTime * 2f;
			if (trackerTimer > 1f)
			{
				Vector3 topPos = targetPos + Vector3.up * 2f;
				float t = Mathf.Sin(trackerTimer * (float)System.Math.PI);
				Tracker.transform.position = Vector3.Lerp(targetPos, topPos, t);
			}
			else
			{
				Vector3 startPos = targetPos + Vector3.up * 20f;
				Tracker.transform.position = Vector3.Lerp(startPos, targetPos, Mathf.Clamp01(trackerTimer));
			}
		}
	}

	public override void OnCancel()
	{
		if (Tracker != null)
		{
			Tracker.SetActive(false);
		}
		trackerTimer = 0f;
	}

	public override void OnShoot(Vector3 boost)
	{
		Vector3 origin = base.transform.position - Vector3.up * 5f;
		RaycastHit[] hits = Physics.SphereCastAll(origin, SphereCastRadius, boost.normalized, MaxAutoAimDistance, 1 << LayerMask.NameToLayer(carLayer));
		bool autoAimed = false;
		if (hits != null && hits.Length > 0)
		{
			RaycastHit[] sorted = hits.Where(h => h.collider != onCar).OrderBy(c => Vector3.Distance(base.transform.position, c.transform.position)).ToArray();
			if (sorted.Length > 0 && sorted[0].collider != null && sorted[0].rigidbody != null)
			{
				Bounds bounds = sorted[0].collider.bounds;
				Vector3 targetBase = new Vector3(bounds.center.x, bounds.max.y, bounds.center.z);
				Vector3 rbVel = sorted[0].rigidbody.velocity;
				float dist = Vector3.Distance(base.transform.position, targetBase);
				float factor = 1f - dist / MaxAutoAimDistance;
				float angle = Mathf.Lerp(15f, 45f, factor);
				float leadTime = factor + 1.75f;
				Vector3 targetLead = targetBase + new Vector3(rbVel.x * leadTime, 0f, rbVel.z * leadTime);
				boost = CalculateVelocityForTarget(base.transform.position, targetLead, angle);
				autoAimed = true;
			}
		}

		base.OnShoot(boost);
		if (!autoAimed && Pitch != 0f && GolfBallController != null)
		{
			Vector3 planeNormal = GolfBallController.GetPlane(GolfBallController.planeType).normal;
			Vector3 axis = Vector3.Cross(boost, planeNormal);
			boost = Quaternion.AngleAxis(Pitch, axis) * boost;
		}

		Vector3 inherited = Vector3.zero;
		if (onCar != null && InheritVelocity > 0f && rigidbodies != null && rigidbodies.Length > 0 && rigidbodies[0] != null)
		{
			inherited = rigidbodies[0].velocity;
		}

		if (rigidbodies != null)
		{
			for (int i = 0; i < rigidbodies.Length; i++)
			{
				Rigidbody rb = rigidbodies[i];
				if (rb == null)
					continue;
				rb.velocity = Vector3.zero;
				rb.angularVelocity = Vector3.zero;
				if (autoAimed)
				{
					rb.velocity = boost;
				}
				else
				{
					float rand = Random.Range(RandomRange.x, RandomRange.y);
					Vector3 force = boost * rand * Force + inherited * InheritVelocity;
					rb.AddForce(force, ForceMode.Impulse);
				}
			}
		}

		if (Tracker != null)
		{
			Tracker.SetActive(false);
		}
		trackerTimer = 0f;
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other != null && other.gameObject != null && other.gameObject.tag == "OutOfBounds")
		{
			delay = 1f;
			if (blocker != null)
			{
				blocker.enabled = false;
			}
			if (GolfBallController != null)
			{
				GolfBallController.canShoot = true;
				GolfBallController.OutOfBounds("ID_OUTOFBOUNDS", 1f);
			}
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other != null && other.gameObject != null && other.gameObject.layer == LayerMask.NameToLayer(carLayer) && other.transform.parent != null)
		{
			onCar = other.transform.parent.GetComponent<Collider>();
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other != null && other.gameObject != null && other.gameObject.layer == LayerMask.NameToLayer(carLayer))
		{
			onCar = null;
		}
	}

	public static Vector3 CalculateVelocityForTarget(Vector3 startPosition, Vector3 target, float initialAngle)
	{
		float g = Physics.gravity.magnitude;
		float rad = initialAngle * ((float)System.Math.PI / 180f);
		Vector3 planarTarget = new Vector3(target.x, 0f, target.z);
		Vector3 planarStart = new Vector3(startPosition.x, 0f, startPosition.z);
		float dist = Vector3.Distance(planarTarget, planarStart);
		float yOffset = startPosition.y - target.y;
		float cos = Mathf.Cos(rad);
		float sin = Mathf.Sin(rad);
		float tan = Mathf.Tan(rad);
		float v = (1f / cos) * Mathf.Sqrt((0.5f * g * dist * dist) / (dist * tan + yOffset));
		Vector3 localVel = new Vector3(0f, sin * v, cos * v);
		float yaw = Vector3.Angle(Vector3.forward, planarTarget - planarStart);
		if (target.x < startPosition.x)
		{
			yaw = -yaw;
		}
		return Quaternion.AngleAxis(yaw, Vector3.up) * localVel;
	}
}
