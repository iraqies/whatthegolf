using UnityEngine;

public class TipObject : TippableObjectBase
{
	public float SleepThreshold = 1f;

	public float DotThreshold = 0.5f;

	public float CheckTimer = 0.2f;

	public Vector3 AxisToCheck = Vector3.up;

	private bool hasBeenTipped;

	private float timer;

	public bool extremeTip;

	private void Awake()
	{
		timer = CheckTimer;
		SleepThreshold *= SleepThreshold;
	}

	private void FixedUpdate()
	{
		if (hasBeenTipped)
		{
			timer = CheckTimer;
			return;
		}
		timer -= Time.deltaTime;
		if (timer > 0f)
		{
			return;
		}
		Vector3 gravUp = -Physics.gravity.normalized;
		if (Vector3.Project(base.transform.up, gravUp).magnitude < DotThreshold)
		{
			Tip();
		}
		else
		{
			timer = CheckTimer;
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (!extremeTip || other == null)
		{
			return;
		}
		if (other.transform.GetComponent<GolfBallController>() != null)
		{
			Rigidbody rb = GetComponent<Rigidbody>();
			if (rb != null)
			{
				rb.AddForce(other.impulse * rb.mass, ForceMode.Impulse);
			}
			Tip();
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (hasBeenTipped || other == null)
		{
			return;
		}
		if (other.CompareTag("Player") || other.CompareTag("Ball") || other.CompareTag("Goal"))
		{
			Tip();
		}
	}

	private void Tip()
	{
		OnTip?.Invoke(base.gameObject);
		hasBeenTipped = true;
	}
}
