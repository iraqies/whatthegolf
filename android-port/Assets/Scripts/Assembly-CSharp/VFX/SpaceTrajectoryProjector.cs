using Core;
using SpaceGolf;
using UnityEngine;

namespace VFX
{
	public class SpaceTrajectoryProjector : MonoBehaviour
	{
		[SerializeField]
		private LineRenderer trajectoryProjectionPrefab;

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
		private bool debug;

		private LineRenderer trajectoryProjection;

		private LineRenderer circle;

		private GolfBallController golfBallController;

		private ConstantForce constantForce;

		private Rigidbody rigidbody;

		private Planet[] planets;

		private Vector3 prev;

		private void Awake()
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

		private Vector3 CalcGravity(Vector3 ballPosition)
		{
			return default;
		}

		private void DrawCircle(Vector3 worldPosition)
		{
		}
	}
}
