using System.Collections.Generic;
using Core;
using UnityEngine;

public class NearestVertGravity : MonoBehaviour
{
	public Collider GravityCollider;

	public bool SetWorldUp = true;

	public bool SetModelRotation;

	public GameObject nearest;

	public Transform CheckTransform;

	public bool FlipOnHitByGolfBall;

	public float upwardsImpulseOnHit;

	public List<Transform> ModelsToMatchUpWith;

	private ConstantForce constForce;

	private Vector3 lastUp;

	private Rigidbody rigid;

	private float delay;

	private bool isFlipped;

	private float magnitude;

	private void Start()
	{
		constForce = GetComponent<ConstantForce>();
		rigid = GetComponent<Rigidbody>();
		lastUp = transform.up;
		if (nearest != null)
		{
			nearest.transform.up = transform.up;
		}
		if (CheckTransform == null)
		{
			CheckTransform = transform;
		}
		if (constForce == null && rigid != null)
		{
			constForce = rigid.gameObject.AddComponent<ConstantForce>();
			constForce.force = Physics.gravity;
		}
		if (constForce != null)
		{
			magnitude = constForce.force.magnitude;
			constForce.force = Vector3.zero;
		}
	}

	private void FixedUpdate()
	{
		if (CheckTransform == null || GravityCollider == null)
		{
			return;
		}
		Vector3 closest = GravityCollider.ClosestPoint(CheckTransform.position);
		Vector3 dir = (CheckTransform.position - closest).normalized;
		if (nearest != null)
		{
			nearest.transform.position = closest;
		}
		Ray ray = new Ray(closest + dir, -dir);
		if (GravityCollider.Raycast(ray, out RaycastHit hit, float.PositiveInfinity))
		{
			if (constForce != null)
			{
				float flipMul = isFlipped ? -1f : 1f;
				constForce.force = -hit.normal * magnitude * flipMul;
			}
			if (delay <= 0f)
			{
				float angle = Vector3.Angle(lastUp, -hit.normal);
				Vector3 axis = Vector3.Cross(lastUp, -hit.normal);
				Quaternion rotDelta = Quaternion.AngleAxis(angle, axis);
				Vector3 newFwd = rotDelta * transform.forward;
				if (nearest != null)
				{
					nearest.transform.up = hit.normal;
				}
				if (SetWorldUp)
				{
					transform.rotation = Quaternion.LookRotation(newFwd, hit.normal);
				}
				if (ModelsToMatchUpWith != null)
				{
					for (int i = 0; i < ModelsToMatchUpWith.Count; i++)
					{
						Transform m = ModelsToMatchUpWith[i];
						if (m != null)
						{
							m.rotation = Quaternion.LookRotation(transform.forward, hit.normal);
						}
					}
				}
				if (rigid != null)
				{
					rigid.velocity = rotDelta * rigid.velocity;
				}
				lastUp = -hit.normal;
				delay = 0f;
			}
		}
		delay -= Time.deltaTime;
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (FlipOnHitByGolfBall && !isFlipped && collision != null && collision.rigidbody != null)
		{
			if (collision.rigidbody.GetComponent<GolfBallController>() != null)
			{
				isFlipped = true;
				if (upwardsImpulseOnHit > 0f)
				{
					collision.rigidbody.AddForce(transform.up * upwardsImpulseOnHit, ForceMode.Impulse);
				}
			}
		}
	}
}
