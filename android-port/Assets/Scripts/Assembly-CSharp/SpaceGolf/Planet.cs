using Core;
using UnityEngine;

namespace SpaceGolf
{
	public class Planet : MonoBehaviour
	{
		public const float GravityMultiplier = 2000f;

		[SerializeField]
		private float gravityMultiplier = 1f;

		public float bounceMultiplier = 1f;

		public Vector3 currentVelocity;

		private GolfBallController ball;

		private Rigidbody ballRB;

		private Vector3 lastposition;

		private float planetRadius => transform.localScale.x * 0.5f;

		private Vector3 Gravity => (ball != null) ? CalcGrav(ball.transform.position) : Vector3.zero;

		public Vector3 CalcGrav(Vector3 ballPosition)
		{
			Vector3 toPlanet = transform.position - ballPosition;
			float dist = toPlanet.magnitude;
			if (dist <= 0.0001f)
				return Vector3.zero;
			Vector3 dir = toPlanet.normalized * 2000f * planetRadius / (dist * dist);
			return dir * gravityMultiplier;
		}

		private void Awake()
		{
			if (Level.Instance != null)
			{
				ball = Level.Instance.Ball;
				if (ball != null)
					ballRB = ball.GetComponent<Rigidbody>();
			}
		}

		private void Update()
		{
			if (Time.timeScale == 0f || Time.deltaTime == 0f)
				return;
			currentVelocity = (transform.position - lastposition) / Time.deltaTime;
			lastposition = transform.position;
		}

		private void FixedUpdate()
		{
			if (Time.timeScale == 0f || Time.deltaTime == 0f)
				return;
			if (ballRB != null && !ballRB.isKinematic && ball != null)
			{
				ballRB.AddForce(CalcGrav(ball.transform.position) * Time.fixedDeltaTime, ForceMode.VelocityChange);
			}
		}
	}
}
