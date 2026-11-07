using System.Collections.Generic;
using UnityEngine;

public class RealCar : MonoBehaviour
{
	public List<AxleInfo> axleInfos;

	public float maxMotorTorque;

	public float maxSteeringAngle;

	public float speed;

	public List<Transform> WaypointRoutes;

	public Transform CenterOfMass;

	public float OffsetDiminissSpeed;

	private float startOffset;

	private float currentOffset;

	private int routeIndex;

	private Rigidbody rigid;

	private void Start()
	{
	}

	public void ResetOffset()
	{
	}

	public void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
