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
		private bool copyShootVelocityFromShooter;

		[SerializeField]
		private float fullShootVelocity;

		[SerializeField]
		private float pitch;

		[SerializeField]
		private float ballRadius;

		[SerializeField]
		private int maxSamples;

		[SerializeField]
		private float sampleRate;

		[SerializeField]
		private float lineLength;

		[SerializeField]
		private float lineWidth;

		[SerializeField]
		private bool debug;

		[SerializeField]
		private LayerMask collideLayers;

		[SerializeField]
		private float circleRadius;

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
		}

		protected virtual void Start()
		{
		}

		public void AddIgnoreObject(Collider go)
		{
		}

		public void RemoveIgnoreObject(Collider go)
		{
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
		}

		private void OnAim(Vector3 boost)
		{
		}

		protected virtual void OnDisable()
		{
		}

		private Vector3 CalcGravity(Vector3 ballPosition)
		{
			return default;
		}

		private void DrawCircle(Vector3 worldPosition)
		{
		}
	}
}
