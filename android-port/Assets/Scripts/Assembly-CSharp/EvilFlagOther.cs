using UnityEngine;

public class EvilFlagOther : MonoBehaviour
{
	public Transform[] positions;

	public float velocity = 10f;

	public Rigidbody ball;

	public int fleeLimitTimes = 1;

	public float nextFlee;

	public float fleeDistance = 15f;

	public float safeGreenDist = 10f;

	public float ballVelocityThreshold = 1f;

	public float delay;

	private Rigidbody rigidbody;

	private int currentTarget;

	private float delayTimer;

	public void SetBallVelocityThreshold(float v)
	{
		ballVelocityThreshold = v;
	}

	private void Start()
	{
		rigidbody = GetComponent<Rigidbody>();
		currentTarget = 0;
		if (positions != null && positions.Length > 0 && positions[0] != null && rigidbody != null)
		{
			rigidbody.MovePosition(positions[0].position);
		}
		nextFlee = Time.time;
	}

	private void Update()
	{
		if (ball == null || positions == null)
			return;
		if (ball.velocity.magnitude > ballVelocityThreshold)
		{
			Vector3 predictedPos = ball.position + ball.velocity.normalized;
			int bestIdx = 0;
			float bestDist = 0f;
			for (int i = 0; i < positions.Length; i++)
			{
				if (positions[i] == null) continue;
				float d = Vector3.Distance(predictedPos, positions[i].position);
				if (d > bestDist)
				{
					bestDist = d;
					bestIdx = i;
				}
			}
			if (Time.time > nextFlee && currentTarget != bestIdx && fleeLimitTimes >= 1)
			{
				nextFlee = Time.time + 0.5f;
				currentTarget = bestIdx;
				fleeLimitTimes--;
				delayTimer = delay;
			}
		}
	}

	private void FixedUpdate()
	{
		if (delayTimer > 0f)
		{
			delayTimer -= Time.deltaTime;
			return;
		}
		if (positions == null || currentTarget < 0 || currentTarget >= positions.Length || positions[currentTarget] == null || rigidbody == null)
			return;
		Vector3 delta = positions[currentTarget].position - transform.position;
		float step = Mathf.Min(delta.magnitude, velocity * Time.fixedDeltaTime);
		rigidbody.MovePosition(transform.position + delta.normalized * step);
	}

	private void OnDrawGizmos()
	{
		if (positions != null && currentTarget >= 0 && currentTarget < positions.Length && positions[currentTarget] != null)
		{
			Gizmos.DrawWireSphere(positions[currentTarget].position, fleeDistance);
		}
	}
}
