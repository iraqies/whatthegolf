using Chronos;
using UnityEngine;

public class RotateAxis : MonoBehaviour
{
	public bool UsePhysics;

	public Vector3 Axis;

	public float Speed;

	private Rigidbody rigidbody;

	private Timeline timeline;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private float GetDelta()
	{
		return 0f;
	}
}
