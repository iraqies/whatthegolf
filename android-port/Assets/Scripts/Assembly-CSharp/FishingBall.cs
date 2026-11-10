using System.Collections.Generic;
using Chronos;
using UnityEngine;
using Utility;

public class FishingBall : MonoBehaviour
{
	public ObjectPool<GameObject> BulletPool;

	public float MoveSpeed = 10f;

	public float LifeTime = 10f;

	public ParticleSystem BulletDeathParticles;

	public Collider collider;

	private float currentLifeTime;

	private Rigidbody rigidBody;

	private Timeline timeline;

	private TrailRenderer trail;

	private LineRenderer line;

	private Vector3 lastLinePos;

	public float lineSegmentDistance;

	private int lineSections;

	private List<Vector3> linePositions;

	private bool inWater;

	private void Awake()
	{
		rigidBody = GetComponent<Rigidbody>();
		timeline = GetComponent<Timeline>();
		collider = GetComponent<Collider>();
		trail = GetComponent<TrailRenderer>();
		linePositions = new List<Vector3>();
	}

	private void OnEnable()
	{
		if (rigidBody != null)
		{
			rigidBody.angularVelocity = Vector3.zero;
			rigidBody.velocity = base.transform.forward * MoveSpeed;
		}
		currentLifeTime = LifeTime;
		line = GetComponent<LineRenderer>();
		if (Camera.main != null)
		{
			lastLinePos = Camera.main.transform.position;
		}
	}

	public void SetSpeed(float speedMod)
	{
		if (rigidBody != null)
		{
			rigidBody.velocity = base.transform.forward * MoveSpeed * speedMod;
		}
	}

	private void Update()
	{
		if (timeline != null)
		{
			currentLifeTime -= timeline.deltaTime;
		}
		else
		{
			currentLifeTime -= Time.deltaTime;
		}
		if (currentLifeTime <= 0f)
		{
			KillBullet(base.transform.position);
		}
		if (rigidBody != null)
		{
			rigidBody.useGravity = true;
		}
		DrawFishingLine();
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other == null || other.collider == null)
			return;

		if (other.collider.CompareTag("Ground"))
		{
			inWater = false;
			if (line != null)
			{
				line.positionCount = 0;
			}
			linePositions?.Clear();
			KillBullet(base.transform.position);
		}
		else if (rigidBody != null)
		{
			rigidBody.isKinematic = true;
			inWater = true;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null)
			return;
		if (other.transform.CompareTag("OutOfBounds") || other.transform.CompareTag("OutOfBoundsReset"))
		{
			KillBullet(base.transform.position);
		}
	}

	private void KillBullet(Vector3 point)
	{
		if (rigidBody != null)
		{
			rigidBody.velocity = Vector3.zero;
			rigidBody.angularVelocity = Vector3.zero;
		}
		if (trail != null)
		{
			trail.Clear();
		}
		if (BulletDeathParticles != null)
		{
			BulletDeathParticles.transform.position = point;
			BulletDeathParticles.transform.rotation = Quaternion.LookRotation(-base.transform.forward);
			BulletDeathParticles.Emit(100);
		}
		if (BulletPool != null)
		{
			BulletPool.Return(base.gameObject, true);
		}
	}

	private void DrawFishingLine()
	{
		if ((rigidBody != null && rigidBody.isKinematic) || inWater)
		{
			if (trail != null)
			{
				trail.Clear();
			}
			if (line != null && linePositions != null)
			{
				line.positionCount = linePositions.Count;
				line.SetPositions(linePositions.ToArray());
				if (linePositions.Count < 3)
				{
					if (line.positionCount >= 1)
					{
						linePositions.RemoveAt(1);
						linePositions.Add(base.transform.position);
						linePositions.RemoveAt(0);
						linePositions.Add(FirstPersonFisher.fishingRodTop);
					}
				}
				else
				{
					linePositions.RemoveAt(1);
					line.SetPosition(0, FirstPersonFisher.fishingRodTop);
					lineSections--;
				}
			}
		}
		else if (Vector3.Distance(base.transform.position, lastLinePos) > lineSegmentDistance)
		{
			if (linePositions != null)
			{
				if (lineSections != 0)
				{
					linePositions.Add(base.transform.position);
				}
				else
				{
					linePositions.Add(FirstPersonFisher.fishingRodTop);
				}
			}
			lineSections++;
		}
	}
}
