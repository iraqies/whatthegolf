using System;
using System.Collections.Generic;
using UnityEngine;

namespace Buoyancy
{
	public class BuoyancyTarget : MonoBehaviour, IBuoyant
	{
		[SerializeField]
		private float buoyancyMultiplier = 1f;

		[SerializeField]
		private Rigidbody targetRigidbody;

		[SerializeField]
		private Vector3[] extraCheckPoints = new Vector3[0];

		[SerializeField]
		private bool checkColliderCorners = true;

		[SerializeField]
		private bool increaseBuoyancyByDepth;

		[SerializeField]
		private float maxDepth = 50f;

		[SerializeField]
		private bool canDoSkip;

		[SerializeField]
		private float xzFrictionOnSkip = 0.1f;

		[SerializeField]
		private float yFrictionOnSkip;

		[SerializeField]
		private float sqrMagnitudeThreshold = 5f;

		[SerializeField]
		private bool isRagdoll;

		[SerializeField]
		private bool sinkAfterDelay;

		[SerializeField]
		private float sinkVelocityThreshold = 700f;

		[SerializeField]
		private float sinkDelay = 0.8f;

		private List<Rigidbody> ragdollRigidbodies;

		private List<Vector3> localBuoyancyPoints;

		private float sinkTimer;

		public ForceMode rotationForceMode;

		public Transform Transform { get; private set; }

		public Collider TargetCollider { get; private set; }

		public Rigidbody Rigid => targetRigidbody;

		public Vector3 ColliderSize { get; private set; }

		public Vector3 ColliderCenter { get; private set; }

		public Vector3 ColliderOffset { get; private set; }

		public float SinkMultiplier { get; private set; }

		public bool Remove { get; private set; }

		public bool IsInWater { get; private set; }

		public bool IsFloatingOnSurface { get; private set; }

		public bool IsSinking { get; private set; }

		public Action<Vector3> OnPostSkip { get; set; }

		public Action<Vector3> OnEnterWaterNoSkip { get; set; }

		public Action OnTargetEnteredWater { get; set; }

		public Action OnTargetExitedWater { get; set; }

		private void Awake()
		{
			if (targetRigidbody == null)
			{
				targetRigidbody = GetComponent<Rigidbody>();
			}
			if (targetRigidbody != null)
			{
				Transform = targetRigidbody.transform;
			}
			ragdollRigidbodies = new List<Rigidbody>();
			if (isRagdoll && targetRigidbody != null)
			{
				targetRigidbody.GetComponentsInChildren(ragdollRigidbodies);
			}
			Initialize();
		}

		public void Initialize()
		{
			localBuoyancyPoints = new List<Vector3>();
			TargetCollider = GetComponentInChildren<Collider>();
			BuoyancyUtil.SetColliderValues(TargetCollider, out Vector3 size, out Vector3 center, out Vector3 offset);
			ColliderSize = size;
			ColliderCenter = center;
			ColliderOffset = offset;
			InitializeBuoyancyPoints();
		}

		private int GetTargetPointCount()
		{
			if (extraCheckPoints == null)
				return checkColliderCorners ? 8 : 0;
			return extraCheckPoints.Length + (checkColliderCorners ? 8 : 0);
		}

		private void InitializeBuoyancyPoints()
		{
			if (localBuoyancyPoints == null)
				localBuoyancyPoints = new List<Vector3>();

			if (checkColliderCorners)
			{
				bool hasCollider = TargetCollider != null;
				localBuoyancyPoints.Clear();
				if (hasCollider)
				{
					Vector3 halfSize = ColliderSize * 0.5f;
					for (int x = -1; x < 2; x++)
					{
						float px = halfSize.x * x;
						for (int y = -1; y < 2; y++)
						{
							float py = halfSize.y * y;
							for (int z = -1; z < 2; z++)
							{
								if (x == 0 || y == 0 || z == 0)
									continue;
								localBuoyancyPoints.Add(new Vector3(px, py, halfSize.z * z));
							}
						}
					}
				}
			}
			else
			{
				localBuoyancyPoints.Clear();
			}

			if (extraCheckPoints != null)
			{
				localBuoyancyPoints.AddRange(extraCheckPoints);
			}
		}

		public List<Vector3> GetPointsWorld()
		{
			if (localBuoyancyPoints == null || GetTargetPointCount() != localBuoyancyPoints.Count)
			{
				InitializeBuoyancyPoints();
			}
			if (Transform == null)
			{
				Transform = (targetRigidbody != null) ? targetRigidbody.transform : base.transform;
			}
			List<Vector3> worldPoints = new List<Vector3>();
			if (localBuoyancyPoints != null && Transform != null)
			{
				for (int i = 0; i < localBuoyancyPoints.Count; i++)
				{
					worldPoints.Add(Transform.TransformPoint(localBuoyancyPoints[i] + ColliderOffset));
				}
			}
			return worldPoints;
		}

		public void HandleFloating(IBuoyantWater water)
		{
			if (targetRigidbody == null)
			{
				Remove = true;
				return;
			}
			IsFloatingOnSurface = false;
			float floatFactor = 1f - SinkMultiplier;
			List<Vector3> pointsWorld = GetPointsWorld();
			if (pointsWorld != null && water != null)
			{
				foreach (Vector3 point in pointsWorld)
				{
					float depth = point.y - water.SurfacePositionY;
					if (depth < 0f)
					{
						if (increaseBuoyancyByDepth)
						{
							float depthFactor = depth / (-maxDepth);
							targetRigidbody.AddForceAtPosition(water.WaterForceUp * Vector3.up * depthFactor * buoyancyMultiplier, point);
						}
						targetRigidbody.AddForceAtPosition(water.WaterForceUp * Vector3.up * buoyancyMultiplier * floatFactor, point);
						Vector3 vel = targetRigidbody.velocity;
						targetRigidbody.AddForceAtPosition(-water.Viscosity * vel, point);
						Vector3 angVel = targetRigidbody.angularVelocity;
						targetRigidbody.AddTorque(-water.Viscosity * angVel, rotationForceMode);
					}
					else
					{
						IsFloatingOnSurface = true;
						targetRigidbody.AddForceAtPosition(Physics.gravity * 0.5f, point);
					}
				}
			}

			if (sinkAfterDelay)
			{
				Vector3 xzVel = new Vector3(targetRigidbody.velocity.x, 0f, targetRigidbody.velocity.z);
				if (xzVel.sqrMagnitude < sinkVelocityThreshold)
				{
					sinkTimer += Time.fixedDeltaTime;
				}
				else
				{
					sinkTimer = 0f;
				}

				if (sinkTimer < sinkDelay)
				{
					IsSinking = false;
					SinkMultiplier = 0f;
				}
				else
				{
					IsSinking = true;
					SinkMultiplier = Mathf.Clamp01(SinkMultiplier + Time.fixedDeltaTime);
				}
			}
		}

		public void OnEnterWater(IBuoyantWater water)
		{
			IsSinking = false;
			Remove = false;
			IsInWater = true;
			if (!canDoSkip || targetRigidbody.velocity.y >= 0f || !DoSkip())
			{
				OnEnterWaterNoSkip?.Invoke(targetRigidbody.velocity);
			}
			OnTargetEnteredWater?.Invoke();
		}

		public void OnExitWater(IBuoyantWater water)
		{
			IsInWater = false;
			IsFloatingOnSurface = false;
			OnTargetExitedWater?.Invoke();
		}

		public void OnEnterWater()
		{
			if (!canDoSkip || targetRigidbody.velocity.y >= 0f || !DoSkip())
			{
				OnEnterWaterNoSkip?.Invoke(targetRigidbody.velocity);
			}
			OnTargetEnteredWater?.Invoke();
		}

		private bool DoSkip()
		{
			if (targetRigidbody == null)
				return false;

			Vector3 velocity = targetRigidbody.velocity;
			Vector3 planarVel = Vector3.ProjectOnPlane(velocity, Vector3.up);
			Vector3 reflected = Vector3.Reflect(velocity, Vector3.up);
			float sqrMag = planarVel.sqrMagnitude;
			if (sqrMag >= sqrMagnitudeThreshold)
			{
				float xzFactor = 1f - xzFrictionOnSkip;
				float yFactor = 1f - yFrictionOnSkip;
				Vector3 skipVel = new Vector3(reflected.x * xzFactor, reflected.y * yFactor, reflected.z * xzFactor);
				Vector3 torque = (Quaternion.Euler(0f, 90f, 0f) * skipVel) * 50f;
				targetRigidbody.velocity = skipVel;
				targetRigidbody.AddTorque(torque);
				if (ragdollRigidbodies != null)
				{
					foreach (Rigidbody rb in ragdollRigidbodies)
					{
						if (rb != null)
						{
							rb.velocity = skipVel;
							rb.AddTorque(torque);
						}
					}
				}
				OnPostSkip?.Invoke(skipVel);
			}
			return sqrMag >= sqrMagnitudeThreshold;
		}

		private void OnDrawGizmosSelected()
		{
			if (!Application.isPlaying)
			{
				Initialize();
			}
			Gizmos.color = Color.cyan;
			List<Vector3> points = GetPointsWorld();
			if (points != null)
			{
				foreach (Vector3 pt in points)
				{
					Gizmos.DrawWireSphere(pt, 0.1f);
				}
			}
		}
	}
}
