using UnityEngine;

public class TipObject : TippableObjectBase
{
	public float SleepThreshold;

	public float DotThreshold;

	public float CheckTimer;

	public Vector3 AxisToCheck;

	private bool hasBeenTipped;

	private float timer;

	public bool extremeTip;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void Tip()
	{
	}
}
