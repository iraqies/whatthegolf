using UnityEngine;

public class TipObject : TippableObjectBase
{
	public float SleepThreshold = 0.1f;
	public float DotThreshold = 0.5f;
	public float CheckTimer = 0.2f;
	public Vector3 AxisToCheck = Vector3.up;
	private bool hasBeenTipped;
	private float timer;
	public bool extremeTip;

	private void Awake()
	{
		if (AxisToCheck.sqrMagnitude < 1e-4f) AxisToCheck = Vector3.up;
	}

	private void FixedUpdate()
	{
		if (hasBeenTipped) return;
		timer += Time.fixedDeltaTime;
		if (timer >= CheckTimer)
		{
			timer = 0f;
			if (Vector3.Dot(transform.TransformDirection(AxisToCheck), Vector3.up) < DotThreshold)
				Tip();
		}
	}

	private void OnCollisionEnter(Collision other) { }
	private void OnTriggerEnter(Collider other) { }

	private void Tip()
	{
		if (hasBeenTipped) return;
		hasBeenTipped = true;
		OnTip?.Invoke(gameObject);
	}
}
