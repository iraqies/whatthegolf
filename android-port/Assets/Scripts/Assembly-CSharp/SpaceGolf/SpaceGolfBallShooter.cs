using System.Collections.Generic;
using Audio;
using Audio.Rumble;
using Core;
using GolfCourse;
using UnityEngine;

namespace SpaceGolf
{
	public class SpaceGolfBallShooter : GolfBallShooterBase
	{
		private struct TrajectoryPoint
		{
			public float time;

			public Vector3 point;

			public bool outOfBounds;

			public bool goal;
		}

		private struct Step
		{
			public Vector3 position;

			public Vector3 velocity;

			public bool run;

			public bool isGoal;

			public bool isOut;

			public bool isGrounded;

			public Planet groundedPlanet;

			public Vector3 groundedPlanetOffset;

			public float sampleRate;

			public bool isBounce;
		}

		[SerializeField]
		private bool isVisual;

		[SerializeField]
		private LineRenderer trajectoryProjectionPrefab;

		[SerializeField]
		private bool liveTrajectory;

		[SerializeField]
		private float fullShootVelocity;

		[SerializeField]
		private float minShootVelocity;

		[SerializeField]
		private float sampleRate;

		[SerializeField]
		private float terminationVelocity;

		[SerializeField]
		private bool debug;

		[SerializeField]
		private float bounce;

		[SerializeField]
		private float simulatedTime;

		public OnCollisionAudio bounceCollisionSFX;

		public float test;

		private List<Planet> planets;

		private LineRenderer trajectoryProjection;

		private float shootTime;

		private TrajectoryPoint[] trajectory;

		private int index;

		private float ballRadius;

		private Step liveStep;

		private bool didWin;

		private GolfCoursePinGoal pinGoal;

		private float minBoost;

		private bool aimAtPlanet;

		private RumbleOnImpact rumbleImpact;

		public bool isGrounded { get; private set; }

		public Vector3 BallVelocity => default;

		protected override void Awake()
		{
		base.Awake();
	}

		public void SetPlanets(List<Planet> _planets)
		{
		}

		private void Start()
		{
		}

		private void ProbActive(bool active)
		{
		}

		public override void OnAimStart()
		{
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		private void Project(Vector3 boost)
		{
		}

		public override void OnShoot(Vector3 boost)
		{
		StandardShoot(boost, 20f, 18f, 5f);
	}

		private void Update()
		{
		}

		private TrajectoryPoint[] CalculateTrajectory(Vector3 boost, float maxTime = -1f, bool stopOnCollision = false)
		{
			return null;
		}

		private Step CalculateStep(Step step)
		{
			return default;
		}

		private Vector3 CalcGravity(Vector3 ballPosition)
		{
			return default;
		}

		private bool IsOutOfBounds(Vector3 ballPosition)
		{
			return false;
		}

		public override void OnReset()
		{
		}

		protected override bool IsBlocking()
		{
			return false;
		}
	}
}
