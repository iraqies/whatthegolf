using UnityEngine;

public class ClampVelocity2D : MonoBehaviour
{
	public float MaxSpeed;

	public bool HardClamp;

	private Rigidbody2D rigid;

	private float sqrMaxSpeed;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}
}
