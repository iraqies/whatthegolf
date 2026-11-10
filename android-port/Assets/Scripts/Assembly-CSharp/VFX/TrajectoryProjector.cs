using System.Collections.Generic;
using Core;
using UnityEngine;

namespace VFX
{
	public class TrajectoryProjector : MonoBehaviour
	{
		[SerializeField]
		private LineRenderer trajectoryProjectionPrefab;

		[SerializeField]
		private bool copyShootVelocityFromShooter = true;

		[SerializeField]
		private float fullShootVelocity = 20f;

		[SerializeField]
		private float pitch = 30f;

		[SerializeField]
		private float ballRadius = 0.25f;

		[SerializeField]
		private int maxSamples = 30;

		[SerializeField]
		private float sampleRate = 0.05f;

		[SerializeField]
		private float lineLength = 15f;

		[SerializeField]
		private float lineWidth = 0.15f;

		[SerializeField]
		private bool debug;

		[SerializeField]
		private LayerMask collideLayers = -1;

		[SerializeField]
		private float circleRadius = 0.5f;

		[SerializeField]
		private bool normalizeBoost;

		[SerializeField]
		private GolfBallController controllerOverride;

		[SerializeField]
		private GolfBallShooterExperimental shooterOverride;

		private LineRenderer trajectoryProjection;

		private LineRenderer circle;

		private GolfBallController golfBallController;

		private ConstantForce constantForce;

		private Rigidbody rigidbody;

		private GolfBallShooterExperimental golfBallShooterExperimental;

		private float lineLengthSqr;

		private List<Collider> ignoredObjects;

		private Vector3 prev;

		protected virtual void Awake()
		{
			ignoredObjects = new List<Collider>(GetComponentsInChildren<Collider>());
			rigidbody = GetComponent<Rigidbody>();
			constantForce = GetComponent<ConstantForce>();
			golfBallController = controllerOverride != null ? controllerOverride : GetComponent<GolfBallController>();
			golfBallShooterExperimental = shooterOverride != null ? shooterOverride : GetComponent<GolfBallShooterExperimental>();
			lineLengthSqr = lineLength * lineLength;
			if (trajectoryProjectionPrefab != null)
			{
				trajectoryProjection = Object.Instantiate(trajectoryProjectionPrefab, transform);
				trajectoryProjection.enabled = false;
			}
		}

		protected virtual void Start()
		{
			if (golfBallController != null)
			{
				golfBallController.OnAimStart += () => ProbActive(true);
				golfBallController.OnAimUpdate += (boost, _) => OnAim(boost);
				golfBallController.OnShoot += _ => ProbActive(false);
				golfBallController.OnCancel += () => ProbActive(false);
			}
		}

		public void AddIgnoreObject(Collider go)
		{
			if (go != null && ignoredObjects != null && !ignoredObjects.Contains(go))
			{
				ignoredObjects.Add(go);
			}
		}

		public void RemoveIgnoreObject(Collider go)
		{
			if (go != null && ignoredObjects != null)
			{
				ignoredObjects.Remove(go);
			}
		}

		private void FixedUpdate()
		{
		}

		private void Update()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void ProbActive(bool active)
		{
			if (trajectoryProjection != null)
			{
				trajectoryProjection.enabled = active;
			}
			if (circle != null)
			{
				circle.enabled = active;
			}
		}

		private void OnAim(Vector3 boost)
		{
			if (trajectoryProjection == null)
			{
				return;
			}
			ProbActive(true);
			Vector3 dir = normalizeBoost ? boost.normalized : boost;
			Vector3 planeNormal = Vector3.up;
			Vector3 axis = Vector3.Cross(dir, planeNormal);
			if (axis.sqrMagnitude > 1e-6f && Mathf.Abs(pitch) > 0.01f)
			{
				dir = Quaternion.AngleAxis(pitch, axis) * dir;
			}
			Vector3 vel = dir * fullShootVelocity;
			Vector3 pos = transform.position;
			int samples = Mathf.Max(2, maxSamples);
			trajectoryProjection.positionCount = samples;
			float dt = Mathf.Max(0.01f, sampleRate);
			for (int i = 0; i < samples; i++)
			{
				trajectoryProjection.SetPosition(i, pos);
				Vector3 grav = CalcGravity(pos);
				Vector3 nextPos = pos + vel * dt + 0.5f * grav * (dt * dt);
				vel += grav * dt;
				if (Physics.SphereCast(pos, Mathf.Max(0.05f, ballRadius), (nextPos - pos).normalized, out RaycastHit hit, Vector3.Distance(pos, nextPos), collideLayers))
				{
					if (ignoredObjects == null || !ignoredObjects.Contains(hit.collider))
					{
						trajectoryProjection.positionCount = i + 2;
						trajectoryProjection.SetPosition(i + 1, hit.point);
						DrawCircle(hit.point);
						break;
					}
				}
				pos = nextPos;
			}
		}

		protected virtual void OnDisable()
		{
			ProbActive(false);
		}

		private Vector3 CalcGravity(Vector3 ballPosition)
		{
			if (constantForce != null && constantForce.enabled)
			{
				return Physics.gravity + constantForce.force;
			}
			return Physics.gravity;
		}

		private void DrawCircle(Vector3 worldPosition)
		{
			if (circle == null)
			{
				return;
			}
			int segments = 16;
			circle.positionCount = segments + 1;
			for (int i = 0; i <= segments; i++)
			{
				float a = (float)i / segments * Mathf.PI * 2f;
				circle.SetPosition(i, worldPosition + new Vector3(Mathf.Cos(a) * circleRadius, 0.05f, Mathf.Sin(a) * circleRadius));
			}
		}
	}
}
