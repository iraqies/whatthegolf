using System;
using UnityEngine;

namespace Buoyancy
{
	[ExecuteAlways]
	public class RealisticFloatingProp : MonoBehaviour, IBuoyant
	{
		[SerializeField]
		private float drag;

		[SerializeField]
		private float angularDrag;

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
		private MinMax depthRange = new MinMax(10f, 50f);

		private Vector3[] localBuoyancyPoints;

		private Vector3[] worldPoints;

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

		public bool IsActive { get; set; } = true;

		public bool active
		{
			get => IsActive;
			set => IsActive = value;
		}

		private void Awake()
		{
			Initialize();
		}

		public void Initialize()
		{
			if (targetRigidbody == null)
			{
				targetRigidbody = GetComponent<Rigidbody>();
			}
			if (targetRigidbody != null)
			{
				Transform = targetRigidbody.transform;
			}
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
			if (checkColliderCorners && TargetCollider != null)
			{
				int extraLen = extraCheckPoints != null ? extraCheckPoints.Length : 0;
				localBuoyancyPoints = new Vector3[extraLen + 8];
				int idx = 0;
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
							if (idx < localBuoyancyPoints.Length)
							{
								localBuoyancyPoints[idx] = new Vector3(px, py, halfSize.z * z);
								idx++;
							}
						}
					}
				}
				if (extraCheckPoints != null)
				{
					for (int i = 0; i < extraCheckPoints.Length && idx + i < localBuoyancyPoints.Length; i++)
					{
						localBuoyancyPoints[idx + i] = extraCheckPoints[i];
					}
				}
			}
			else
			{
				localBuoyancyPoints = extraCheckPoints != null ? extraCheckPoints : new Vector3[0];
			}
			worldPoints = new Vector3[localBuoyancyPoints.Length];
		}

		public void SetBuoyancy(float b)
		{
			buoyancyMultiplier = b;
		}

		public void SetWorldPoints()
		{
			if (localBuoyancyPoints == null || Transform == null || worldPoints == null)
				return;
			for (int i = 0; i < localBuoyancyPoints.Length && i < worldPoints.Length; i++)
			{
				worldPoints[i] = Transform.TransformPoint(localBuoyancyPoints[i] + ColliderOffset);
			}
		}

		public void HandleFloating(IBuoyantWater water)
		{
			if (!IsActive)
				return;
			if (targetRigidbody == null)
			{
				Remove = true;
				return;
			}
			IsFloatingOnSurface = false;
			SetWorldPoints();
			if (worldPoints == null || worldPoints.Length < 1 || water == null)
				return;

			float count = worldPoints.Length;
			for (int i = 0; i < worldPoints.Length; i++)
			{
				Vector3 pt = worldPoints[i];
				float depth = pt.y - water.SurfacePositionY;
				if (depth < 0f)
				{
					if (increaseBuoyancyByDepth && depthRange != null)
					{
						float t = Mathf.Clamp01((-depth - depthRange.min) / (depthRange.max - depthRange.min));
						targetRigidbody.AddForceAtPosition(water.WaterForceUp * Vector3.up * t * buoyancyMultiplier, pt);
					}
					targetRigidbody.AddForceAtPosition((water.WaterForceUp * Vector3.up * buoyancyMultiplier) / count, pt);

					Vector3 vel = targetRigidbody.velocity;
					float dt = Time.fixedDeltaTime;
					float visc = water.Viscosity;
					Vector3 angVel = targetRigidbody.angularVelocity;
					float dt2 = Time.fixedDeltaTime;
					float visc2 = water.Viscosity;

					float linearDragFactor = 1f - dt * visc * drag;
					targetRigidbody.AddForceAtPosition((vel * linearDragFactor) / count, pt);

					float angularDragFactor = 1f - dt2 * visc2 * angularDrag;
					targetRigidbody.AddTorque((angVel * angularDragFactor) / count, rotationForceMode);
				}
			}
		}

		public void OnEnterWater(IBuoyantWater water)
		{
			IsSinking = false;
			Remove = false;
			IsInWater = true;
			OnTargetEnteredWater?.Invoke();
			if (OnEnterWaterNoSkip != null && targetRigidbody != null)
			{
				OnEnterWaterNoSkip(targetRigidbody.velocity);
			}
		}

		public void OnExitWater(IBuoyantWater water)
		{
			IsInWater = false;
			IsFloatingOnSurface = false;
			OnTargetExitedWater?.Invoke();
		}

		public void OnEnterWater()
		{
			OnTargetEnteredWater?.Invoke();
			if (OnEnterWaterNoSkip != null && targetRigidbody != null)
			{
				OnEnterWaterNoSkip(targetRigidbody.velocity);
			}
		}

		private void OnDrawGizmosSelected()
		{
			if (!Application.isPlaying)
			{
				Initialize();
				SetWorldPoints();
			}
			if (worldPoints != null)
			{
				Gizmos.color = Color.cyan;
				for (int i = 0; i < worldPoints.Length; i++)
				{
					Gizmos.DrawWireSphere(worldPoints[i], 0.1f);
				}
			}
		}
	}
}
