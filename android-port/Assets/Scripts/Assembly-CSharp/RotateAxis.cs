using Chronos;
using UnityEngine;

public class RotateAxis : MonoBehaviour
{
	public bool UsePhysics;
	public Vector3 Axis = Vector3.up;
	public float Speed = 90f;
	private Rigidbody rigidbody;
	private Timeline timeline;

	private void Awake()
	{
		rigidbody = GetComponent<Rigidbody>();
	}

	private void Update()
	{
		if (!UsePhysics)
			transform.Rotate(Axis, Speed * GetDelta(), Space.Self);
	}

	private void FixedUpdate()
	{
		if (UsePhysics)
			transform.Rotate(Axis, Speed * GetDelta(), Space.Self);
	}

	private float GetDelta() => UsePhysics ? Time.fixedDeltaTime : Time.deltaTime;
}
