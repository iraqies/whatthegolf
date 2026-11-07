using UnityEngine;

public class CarAntiRoll : MonoBehaviour
{
	public WheelCollider WheelL;

	public WheelCollider WheelR;

	public float AntiRoll;

	private Rigidbody rigidbody;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}
}
