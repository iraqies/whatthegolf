using Core;
using UnityEngine;

namespace SpaceGolf
{
	public class Planet : MonoBehaviour
	{
		public const float GravityMultiplier = 2000f;

		[SerializeField]
		private float gravityMultiplier;

		public float bounceMultiplier;

		public Vector3 currentVelocity;

		private GolfBallController ball;

		private Rigidbody ballRB;

		private Vector3 lastposition;

		private float planetRadius => 0f;

		private Vector3 Gravity => default;

		public Vector3 CalcGrav(Vector3 ballPosition)
		{
			return default;
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
