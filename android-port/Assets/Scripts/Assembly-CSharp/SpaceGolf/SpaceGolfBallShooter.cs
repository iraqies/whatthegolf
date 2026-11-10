using System;
using System.Collections.Generic;
using System.Linq;
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
		private float fullShootVelocity = 25f;

		[SerializeField]
		private float minShootVelocity = 13f;

		[SerializeField]
		private float sampleRate = 0.01f;

		[SerializeField]
		private float terminationVelocity = 10f;

		[SerializeField]
		private bool debug;

		[SerializeField]
		private float bounce = 0.75f;

		[SerializeField]
		private float simulatedTime = 2f;

		public OnCollisionAudio bounceCollisionSFX;

		public float test = 0.49f;

		private List<Planet> planets;

		private LineRenderer trajectoryProjection;

		private float shootTime;

		private TrajectoryPoint[] trajectory;

		private int index;

		private float ballRadius;

		private Step liveStep;

		private bool didWin;

		private GolfCoursePinGoal pinGoal;

		private float minBoost = 0.15f;

		private bool aimAtPlanet;

		private RumbleOnImpact rumbleImpact;

		public bool isGrounded { get; private set; }

		public Vector3 BallVelocity => liveStep.velocity;

		protected override void Awake()
		{
			base.Awake();
			pinGoal = FindObjectOfType<GolfCoursePinGoal>();
			liveStep = default;
			ballRadius = transform.localScale.x * 0.5f;
			rumbleImpact = GetComponent<RumbleOnImpact>();
		}

		public void SetPlanets(List<Planet> _planets)
		{
			planets = _planets;
		}

		private void Start()
		{
			Planet[] found = FindObjectsOfType<Planet>();
			planets = new List<Planet>();
			if (found != null)
			{
				for (int i = 0; i < found.Length; i++)
				{
					if (found[i] != null && found[i].gameObject.activeInHierarchy)
						planets.Add(found[i]);
				}
			}
			if (isVisual && trajectoryProjectionPrefab != null)
			{
				trajectoryProjection = Instantiate(trajectoryProjectionPrefab);
			}
			ProbActive(false);
			isGrounded = true;
		}

		private void ProbActive(bool active)
		{
			bool block = IsBlocking();
			if (!isVisual)
				return;
			bool shouldActive = active && !block;
			if (IsBlocking() && shouldActive)
				return;
			if (trajectoryProjection != null && trajectoryProjection.gameObject.activeInHierarchy != shouldActive)
			{
				trajectoryProjection.gameObject.SetActive(shouldActive);
			}
		}

		public override void OnAimStart()
		{
			base.OnAimStart();
			ProbActive(false);
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			Ray ray = new Ray(transform.position, boost.normalized);
			int planetMask = 1 << LayerMask.NameToLayer("Planet");
			aimAtPlanet = Physics.SphereCast(ray, test, 2f, planetMask);
			Project(boost);
			float roundedMag = (float)Math.Round(boost.magnitude * 100f) / 100f;
			ProbActive(roundedMag > minBoost && !aimAtPlanet);
		}

		private void Project(Vector3 boost)
		{
			TrajectoryPoint[] pts = CalculateTrajectory(boost, simulatedTime, true);
			if (pts == null)
				return;
			Vector3[] positions = pts.Select(x => x.point).ToArray();
			if (isVisual && !IsBlocking() && trajectoryProjection != null)
			{
				trajectoryProjection.positionCount = positions.Length;
				trajectoryProjection.SetPositions(positions);
			}
		}

		public override void OnShoot(Vector3 boost)
		{
			base.OnShoot(boost);
			if (!debug)
				ProbActive(false);
			isGrounded = false;
			Project(boost);
			trajectory = CalculateTrajectory(boost, -1f, false);
			shootTime = 0f;
			index = 0;
			if (liveTrajectory)
			{
				liveStep.position = transform.position;
				Vector3 baseVel = (liveStep.groundedPlanet != null) ? liveStep.groundedPlanet.currentVelocity : Vector3.zero;
				liveStep.velocity = baseVel + boost.normalized * Mathf.Lerp(minShootVelocity, fullShootVelocity, boost.magnitude);
				liveStep.run = true;
				liveStep.isGoal = false;
				liveStep.isOut = false;
				liveStep.isGrounded = false;
				liveStep.groundedPlanet = null;
				liveStep.sampleRate = sampleRate;
			}
		}

		private void Update()
		{
			if (trajectory == null)
				return;

			if (liveTrajectory)
			{
				liveStep.sampleRate = Time.deltaTime;
				bool wasGrounded = liveStep.isGrounded;
				liveStep = CalculateStep(liveStep);
				if (!liveStep.run && liveStep.isGrounded && liveStep.groundedPlanet != null)
				{
					transform.position = liveStep.groundedPlanet.transform.position + liveStep.groundedPlanetOffset;
					isGrounded = true;
				}
				else
				{
					transform.position = Vector3.MoveTowards(transform.position, liveStep.position, Time.deltaTime * liveStep.velocity.magnitude);
				}

				if (liveStep.isGoal && !didWin)
				{
					didWin = true;
					if (pinGoal != null)
						pinGoal.CheckObject(transform, false);
					liveStep.run = false;
				}
				if (liveStep.isOut && !didWin)
				{
					if (GolfBallController != null)
						GolfBallController.OutOfBounds("", GolfBallController.doReloadSceneWhenOutOfBounds ? 0.4f : 0f);
					trajectory = null;
					isGrounded = true;
				}
				if (liveStep.isBounce || (!wasGrounded && liveStep.isGrounded))
				{
					CustomCollision col = new CustomCollision
					{
						position = liveStep.position,
						relativeVelocity = liveStep.velocity,
						gameObject = gameObject,
						otherGameObject = gameObject
					};
					if (rumbleImpact != null)
						rumbleImpact.OnCollisionRemote(col);
					if (bounceCollisionSFX != null)
						bounceCollisionSFX.PlayAudioFromCollision(col);
				}
				return;
			}

			shootTime += Time.deltaTime;
			while (index + 1 < trajectory.Length - 1 && shootTime > trajectory[index + 1].time)
			{
				index++;
			}
			int nextIdx = Mathf.Min(index + 1, trajectory.Length - 1);
			TrajectoryPoint p0 = trajectory[index];
			TrajectoryPoint p1 = trajectory[nextIdx];
			float dt = p1.time - p0.time;
			float t = (dt > 0.0001f) ? ((shootTime - p0.time) / dt) : 1f;
			transform.position = Vector3.Lerp(p0.point, p1.point, Mathf.Clamp01(t));

			if (index == trajectory.Length - 2 && t >= 1f)
			{
				isGrounded = true;
				if (p1.goal && pinGoal != null)
				{
					pinGoal.CheckObject(transform, false);
				}
				if (p1.outOfBounds)
				{
					if (GolfBallController != null)
						GolfBallController.OutOfBounds("", GolfBallController.doReloadSceneWhenOutOfBounds ? 0.4f : 0f);
					trajectory = null;
				}
			}
		}

		private TrajectoryPoint[] CalculateTrajectory(Vector3 boost, float maxTime = -1f, bool stopOnCollision = false)
		{
			Vector3 pos = transform.position;
			float speed = Mathf.Lerp(minShootVelocity, fullShootVelocity, boost.magnitude);
			Vector3 vel = (boost.magnitude < minBoost) ? Vector3.zero : (boost.normalized * speed);
			List<TrajectoryPoint> points = new List<TrajectoryPoint>();
			points.Add(new TrajectoryPoint
			{
				time = 0f,
				point = pos,
				outOfBounds = false,
				goal = false
			});

			Step step = new Step
			{
				position = pos,
				velocity = vel,
				run = true,
				isGoal = false,
				isOut = false,
				isGrounded = false,
				groundedPlanet = null,
				groundedPlanetOffset = Vector3.zero,
				sampleRate = sampleRate,
				isBounce = false
			};

			float time = 0f;
			int iter = 0;
			while (step.run)
			{
				if (Mathf.Abs(step.velocity.z) > 0.01f)
				{
					step.velocity.z = 0f;
				}
				if (iter >= 10001)
				{
					step.run = false;
				}
				step = CalculateStep(step);
				if (maxTime >= 0f && time < maxTime)
				{
					// keep running
				}
				else if (maxTime >= 0f)
				{
					step.run = false;
				}
				if (stopOnCollision && step.isBounce && Vector3.Distance(step.position, transform.position) > 2f)
				{
					step.run = false;
				}
				points.Add(new TrajectoryPoint
				{
					time = time,
					point = step.position,
					outOfBounds = step.isOut,
					goal = step.isGoal
				});
				time += step.sampleRate;
				iter++;
			}
			return points.ToArray();
		}

		private Step CalculateStep(Step step)
		{
			if (!step.run)
				return step;

			if (IsOutOfBounds(step.position))
			{
				step.run = false;
				step.isOut = true;
			}
			step.isBounce = false;

			Vector3 probePos = step.position + step.velocity * (sampleRate * 1.5f);
			Collider[] hits = Physics.OverlapSphere(probePos, ballRadius - 0.05f);
			Collider hitCol = null;
			if (hits != null)
			{
				for (int i = 0; i < hits.Length; i++)
				{
					if (hits[i] != null && hits[i].transform != transform)
					{
						hitCol = hits[i];
						break;
					}
				}
			}

			if (hitCol != null)
			{
				Vector3 normal = (probePos - hitCol.transform.position).normalized;
				Planet planet = hitCol.transform.GetComponent<Planet>();
				Vector3 planetVel = Vector3.zero;
				float planetFactor = 1f;
				if (planet != null)
				{
					planetVel = planet.currentVelocity * 1.5f;
					if (planetVel.magnitude > 0f)
					{
						float angle = Vector3.Angle(planet.currentVelocity, -normal);
						planetFactor = (Mathf.Clamp01(angle / 180f) * 0.2f + 0.8f) * 0.8f;
					}
					else
					{
						planetFactor = 0.8f;
					}
				}

				if (hitCol.transform.GetComponentInParent<GolfCoursePinGoal>() != null)
				{
					step.isGoal = true;
				}
				else if (step.velocity.sqrMagnitude < terminationVelocity * terminationVelocity || (planet != null && planet.bounceMultiplier <= 0f))
				{
					step.groundedPlanet = planet;
					Vector3 offset = transform.position - hitCol.transform.position;
					step.groundedPlanetOffset = offset;
					if (hitCol is SphereCollider sc)
					{
						float r = ballRadius + sc.radius * hitCol.transform.localScale.x;
						step.groundedPlanetOffset = offset.normalized * r;
					}
					step.isGrounded = true;
					step.run = false;
				}
				else
				{
					Vector3 relVel = step.velocity - planetVel;
					Vector3 refl = Vector3.Reflect(relVel, normal) * bounce * planetFactor;
					float bMult = (planet != null) ? planet.bounceMultiplier : 1f;
					step.velocity = refl * bMult;
					step.velocity.z = 0f;
					step.isBounce = true;
				}
			}

			Vector3 grav = CalcGravity(step.position);
			step.position += step.velocity * step.sampleRate;
			step.velocity += grav * step.sampleRate;
			return step;
		}

		private Vector3 CalcGravity(Vector3 ballPosition)
		{
			Vector3 total = Vector3.zero;
			if (planets != null)
			{
				for (int i = 0; i < planets.Count; i++)
				{
					if (planets[i] != null)
						total += planets[i].CalcGrav(ballPosition);
				}
			}
			return total;
		}

		private bool IsOutOfBounds(Vector3 ballPosition)
		{
			if (CameraManager.Instance == null || CameraManager.Instance.Cameras == null || CameraManager.Instance.Cameras.Length == 0 || CameraManager.Instance.Cameras[0] == null)
				return false;
			Vector3 sp = CameraManager.Instance.Cameras[0].WorldToScreenPoint(ballPosition);
			if (sp.x < -Screen.width * 0.2f || sp.x > Screen.width * 1.2f)
				return true;
			if (sp.y < -Screen.height * 0.2f || sp.y > Screen.height * 1.2f)
				return true;
			return false;
		}

		public override void OnReset()
		{
			base.OnReset();
			ProbActive(false);
		}

		protected override bool IsBlocking()
		{
			bool block = isGrounded ? aimAtPlanet : true;
			if (GolfBallController != null)
				GolfBallController.isBlocking = block;
			return !isGrounded;
		}
	}
}
