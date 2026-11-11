using System.Collections.Generic;
using UnityEngine;

public class RealCar : MonoBehaviour
{
	public List<AxleInfo> axleInfos;

	public float maxMotorTorque = 400f;

	public float maxSteeringAngle = 30f;

	public float speed = 15f;

	public List<Transform> WaypointRoutes;

	public Transform CenterOfMass;

	public float OffsetDiminissSpeed = 2f;

	private float startOffset;

	private float currentOffset;

	private int routeIndex;

	private Rigidbody rigid;

	private void Start()
	{
		if (WaypointRoutes != null && WaypointRoutes.Count > 0)
		{
			routeIndex = Random.Range(0, WaypointRoutes.Count);
		}
		rigid = GetComponent<Rigidbody>();
		if (CenterOfMass != null && rigid != null)
		{
			rigid.centerOfMass = CenterOfMass.localPosition;
		}
		if (WaypointRoutes != null && routeIndex >= 0 && routeIndex < WaypointRoutes.Count && WaypointRoutes[routeIndex] != null && WaypointRoutes[routeIndex].childCount > 0)
		{
			startOffset = transform.position.x - WaypointRoutes[routeIndex].GetChild(0).position.x;
		}
		ResetOffset();
		if (axleInfos != null)
		{
			for (int i = 0; i < axleInfos.Count; i++)
			{
				if (axleInfos[i] != null)
				{
					if (axleInfos[i].leftWheel != null)
					{
						axleInfos[i].leftWheel.ConfigureVehicleSubsteps(5f, 12, 15);
					}
					if (axleInfos[i].rightWheel != null)
					{
						axleInfos[i].rightWheel.ConfigureVehicleSubsteps(5f, 12, 15);
					}
				}
			}
		}
	}

	public void ResetOffset()
	{
		currentOffset = startOffset;
		if (axleInfos != null)
		{
			for (int i = 0; i < axleInfos.Count; i++)
			{
				if (axleInfos[i] == null)
				{
					continue;
				}
				if (axleInfos[i].steering)
				{
					if (axleInfos[i].leftWheel != null)
					{
						axleInfos[i].leftWheel.steerAngle = 0f;
					}
					if (axleInfos[i].rightWheel != null)
					{
						axleInfos[i].rightWheel.steerAngle = 0f;
					}
				}
				if (axleInfos[i].motor)
				{
					if (axleInfos[i].leftWheel != null)
					{
						axleInfos[i].leftWheel.motorTorque = 0f;
					}
					if (axleInfos[i].rightWheel != null)
					{
						axleInfos[i].rightWheel.motorTorque = 0f;
					}
				}
			}
		}
	}

	public void FixedUpdate()
	{
		currentOffset = Mathf.MoveTowards(currentOffset, 0f, Time.deltaTime * OffsetDiminissSpeed);
		Vector3 targetDir = transform.forward;
		if (WaypointRoutes != null && routeIndex >= 0 && routeIndex < WaypointRoutes.Count && WaypointRoutes[routeIndex] != null && WaypointRoutes[routeIndex].childCount > 0)
		{
			Transform route = WaypointRoutes[routeIndex];
			Transform bestWp = route.GetChild(0);
			float bestDist = float.PositiveInfinity;
			for (int i = 0; i < route.childCount; i++)
			{
				Transform wp = route.GetChild(i);
				if (wp != null && wp.position.z > transform.position.z)
				{
					float d = Vector3.Distance(transform.position, wp.position);
					if (d < bestDist)
					{
						bestDist = d;
						bestWp = wp;
					}
				}
			}
			if (bestWp != null)
			{
				Vector3 targetPos = bestWp.position + Vector3.right * currentOffset;
				targetDir = (targetPos - transform.position).normalized;
			}
		}
		float steer = Mathf.Clamp(Vector3.SignedAngle(transform.forward, targetDir, transform.up), -maxSteeringAngle, maxSteeringAngle);
		float motor = maxMotorTorque * speed;
		if (axleInfos != null)
		{
			for (int i = 0; i < axleInfos.Count; i++)
			{
				AxleInfo info = axleInfos[i];
				if (info == null)
				{
					continue;
				}
				if (info.steering)
				{
					if (info.leftWheel != null)
					{
						info.leftWheel.steerAngle = steer;
					}
					if (info.rightWheel != null)
					{
						info.rightWheel.steerAngle = steer;
					}
				}
				if (info.motor)
				{
					if (info.leftWheel != null)
					{
						info.leftWheel.motorTorque = motor;
					}
					if (info.rightWheel != null)
					{
						info.rightWheel.motorTorque = motor;
					}
				}
			}
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other == null || rigid == null || other.contacts == null || other.contacts.Length == 0)
		{
			return;
		}
		float imp = other.impulse.magnitude;
		if (imp > 5f)
		{
			rigid.AddExplosionForce(imp * 2f, other.contacts[0].point, 5f, 1.5f, ForceMode.Impulse);
		}
	}

	private void OnDrawGizmosSelected()
	{
	}
}
