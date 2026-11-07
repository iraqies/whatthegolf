using UnityEngine;

public class RotateWheelInAimDirection : MonoBehaviour
{
	public Vector3 Up;

	public Rigidbody2D rigid2D;

	private float angleDrag;

	private Vector3 lastBoostDirection;

	private float currentDragVel;

	private void Start()
	{
	}

	private void OnOnAimUpdate(Vector3 boost, bool b)
	{
	}

	private void FixedUpdate()
	{
	}
}
