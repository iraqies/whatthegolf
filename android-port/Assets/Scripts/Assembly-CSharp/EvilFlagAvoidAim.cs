using Core;
using UnityEngine;

public class EvilFlagAvoidAim : MonoBehaviour
{
	public float velocity = 10f;

	public float distance = 5f;

	public float groundCheckDist = 2f;

	private float changeDirChance = 0.1f;

	public GolfBallController ball;

	public Collider trigger;

	private Rigidbody rigidbody;

	private Vector3 currentTarget;

	private float lastDir = 1f;

	private bool done;

	private bool wasAimTouching;

	private void Start()
	{
		rigidbody = GetComponent<Rigidbody>();
		currentTarget = transform.position;
		if (ball != null)
		{
			ball.OnAimUpdate -= Ball_OnAimUpdate;
			ball.OnAimUpdate += Ball_OnAimUpdate;
		}
	}

	private void Ball_OnAimUpdate(Vector3 aimDir, bool isCancelled)
	{
		if (isCancelled || ball == null || trigger == null)
		{
			wasAimTouching = false;
			return;
		}
		Ray ray = new Ray(ball.transform.position, aimDir);
		if (!trigger.Raycast(ray, out RaycastHit hit, 100f))
		{
			wasAimTouching = false;
			return;
		}
		Vector3 perp = Vector3.Cross(Vector3.up, aimDir);
		perp.y = 0f;
		if (!wasAimTouching && Random.Range(0f, 1f) < changeDirChance)
		{
			lastDir = -lastDir;
		}
		Vector3 candidate = transform.position + perp.normalized * lastDir * distance;
		currentTarget = candidate;
		if (!Physics.Raycast(candidate + Vector3.up * 0.5f, Vector3.down, out RaycastHit groundHit, groundCheckDist) || Vector3.Angle(groundHit.normal, Vector3.up) > 1f)
		{
			lastDir = -lastDir;
			currentTarget = transform.position + perp.normalized * lastDir * distance;
		}
		wasAimTouching = true;
	}

	private void FixedUpdate()
	{
		if (done) return;
		if (Physics.Raycast(transform.position + Vector3.up * 0.5f, Vector3.down, out RaycastHit groundHit, groundCheckDist) && Vector3.Angle(groundHit.normal, Vector3.up) < 1f)
		{
			Vector3 delta = currentTarget - transform.position;
			float step = Mathf.Min(delta.magnitude, velocity * Time.fixedUnscaledDeltaTime);
			if (rigidbody != null)
				rigidbody.MovePosition(transform.position + delta.normalized * step);
		}
		else
		{
			done = true;
			if (rigidbody != null)
				rigidbody.isKinematic = false;
			if (ball != null)
				ball.OnAimUpdate -= Ball_OnAimUpdate;
		}
	}
}
