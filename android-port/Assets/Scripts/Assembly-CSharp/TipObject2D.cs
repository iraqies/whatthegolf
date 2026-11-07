using UnityEngine;

public class TipObject2D : TippableObjectBase
{
	public float SleepThreshold;

	public float DotThreshold;

	public Vector3 AxisToCheck;

	private Rigidbody2D m_rigidbody2D;

	private bool wasMoving;

	private bool hasBeenTipped;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}
}
