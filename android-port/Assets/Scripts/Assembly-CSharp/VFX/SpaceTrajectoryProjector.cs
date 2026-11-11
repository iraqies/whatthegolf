using System;
using System.Collections.Generic;
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
		private float fullShootVelocity = 25f;

		[SerializeField]
		private float pitch;

		[SerializeField]
		private float ballRadius = 1f;

		[SerializeField]
		private int maxSamples = 1000;

		[SerializeField]
		private float sampleRate = 0.01f;

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
			golfBallController = GetComponent<GolfBallController>();
			constantForce = GetComponent<ConstantForce>();
			rigidbody = GetComponent<Rigidbody>();
			planets = UnityEngine.Object.FindObjectsOfType<Planet>();
			if (trajectoryProjectionPrefab != null)
			{
				trajectoryProjection = UnityEngine.Object.Instantiate(trajectoryProjectionPrefab);
				circle = UnityEngine.Object.Instantiate(trajectoryProjectionPrefab);
				if (circle != null)
				{
					circle.loop = true;
				}
			}
			ProbActive(false);
			if (golfBallController != null)
			{
				golfBallController.OnAimUpdate += delegate(Vector3 boost, bool isCancelled)
				{
					if (base.enabled)
					{
						ProbActive(true);
						OnAim(boost);
					}
				};
				golfBallController.OnShoot += delegate
				{
					if (!debug)
					{
						ProbActive(false);
					}
				};
				golfBallController.OnReset += delegate
				{
					ProbActive(false);
				};
			}
		}

		private void Update()
		{
			Debug.DrawLine(prev, base.transform.position, Color.yellow, 10f);
			prev = base.transform.position;
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (collision != null && collision.contacts != null && collision.contacts.Length != 0)
			{
				Debug.DrawRay(collision.contacts[0].point, collision.contacts[0].normal, Color.magenta, 1f);
			}
		}

		private void ProbActive(bool active)
		{
			if (trajectoryProjection != null)
			{
				trajectoryProjection.gameObject.SetActive(active);
			}
			if (circle != null)
			{
				circle.gameObject.SetActive(active);
			}
		}

		private void OnAim(Vector3 boost)
		{
			Debug.DrawRay(base.transform.position, Vector3.up * ballRadius, Color.blue);
			Vector3 axis = Vector3.Cross(boost, Vector3.up);
			Vector3 vector = Quaternion.AngleAxis(pitch, axis) * boost * fullShootVelocity;
			List<Vector3> list = new List<Vector3> { base.transform.position };
			Vector3 vector2 = base.transform.position;
			bool flag = false;
			for (int i = 1; i < maxSamples && !flag; i++)
			{
				Ray ray = new Ray(vector2, vector);
				if (Physics.SphereCast(ray, ballRadius, out var hitInfo, (vector * sampleRate).magnitude))
				{
					DrawCircle(hitInfo.point);
					flag = true;
				}
				Vector3 vector3 = ((rigidbody != null) ? (vector * rigidbody.drag * sampleRate) : Vector3.zero);
				Vector3 vector4 = CalcGravity(vector2);
				vector2 += vector * sampleRate;
				list.Add(vector2);
				vector = vector + vector4 * sampleRate - vector3;
			}
			if (circle != null)
			{
				circle.gameObject.SetActive(flag);
			}
			Debug.DrawRay(vector2, Vector3.up);
			if (trajectoryProjection != null)
			{
				trajectoryProjection.positionCount = list.Count;
				trajectoryProjection.SetPositions(list.ToArray());
			}
		}

		private Vector3 CalcGravity(Vector3 ballPosition)
		{
			Vector3 vector = ((rigidbody != null && constantForce != null) ? (constantForce.force / rigidbody.mass) : Vector3.zero);
			Vector3 zero = Vector3.zero;
			if (planets != null)
			{
				for (int i = 0; i < planets.Length; i++)
				{
					if (planets[i] != null)
					{
						zero += planets[i].CalcGrav(ballPosition);
					}
				}
			}
			Vector3 vector2 = ((rigidbody != null && rigidbody.useGravity) ? Physics.gravity : Vector3.zero);
			return zero + (vector + vector2);
		}

		private void DrawCircle(Vector3 worldPosition)
		{
			if (trajectoryProjection == null || circle == null)
			{
				return;
			}
			List<Vector3> list = new List<Vector3>();
			for (float num = 0f; num < (float)Math.PI * 2f; num += 0.1f)
			{
				float startWidth = trajectoryProjection.startWidth;
				list.Add(new Vector3(worldPosition.x + Mathf.Sin(num), worldPosition.y + startWidth, worldPosition.z + Mathf.Cos(num)));
			}
			circle.positionCount = list.Count;
			circle.SetPositions(list.ToArray());
		}
	}
}
