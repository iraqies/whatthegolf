using System;
using System.Collections.Generic;
using GolfCourse;
using UnityEngine;

namespace Buoyancy
{
	public class SwimmerSimpleAI : MonoBehaviour
	{
		[Serializable]
		public struct WaypointInfo
		{
			public bool isValid;

			public Vector3 position;

			public Collider triggerCollider;

			public GolfCoursePinGoal pin;

			public WaypointInfo(Transform wp)
			{
				isValid = false;
				position = default;
				triggerCollider = null;
				pin = null;
				if (wp != null)
				{
					pin = wp.GetComponentInChildren<GolfCoursePinGoal>();
					triggerCollider = wp.GetComponent<Collider>();
					if (triggerCollider != null)
					{
						position = triggerCollider.transform.position;
					}
					else
					{
						position = wp.position;
					}
					isValid = pin != null || triggerCollider != null;
				}
			}
		}

		public Rigidbody rigid;

		public BuoyancyTarget floater;

		public float startDelay = 3f;

		public MinMax shootWaitRange = new MinMax(0.7f, 1.5f);

		public float minVelocity;

		public float maxVelocity;

		public float maxPitch;

		public Transform WaypointContainer;

		public float distanceThreshold = 5f;

		private float canShootTimer;

		private float nextRandomShootTimer;

		private int wpIndex;

		private Rigidbody[] rigidbodies;

		private WaypointInfo[] waypointInfos;

		public WaypointInfo CurrentWaypoint { get; private set; }

		private void Start()
		{
			if (rigid != null)
			{
				rigidbodies = rigid.GetComponentsInChildren<Rigidbody>();
			}
			nextRandomShootTimer = startDelay + 0.1f;
			List<Transform> transforms = new List<Transform>();
			if (WaypointContainer != null)
			{
				WaypointContainer.GetComponentsInChildren(transforms);
				if (transforms.Count > 0)
				{
					transforms.RemoveAt(0);
				}
			}
			waypointInfos = new WaypointInfo[transforms.Count];
			for (int i = 0; i < transforms.Count; i++)
			{
				waypointInfos[i] = new WaypointInfo(transforms[i]);
			}
			if (waypointInfos.Length > 0)
			{
				CurrentWaypoint = waypointInfos[0];
			}
		}

		private void FixedUpdate()
		{
			if (!CurrentWaypoint.isValid || rigid == null)
				return;

			Vector3 dir = new Vector3(CurrentWaypoint.position.x - rigid.position.x, 0f, CurrentWaypoint.position.z - rigid.position.z);
			if (CanShoot())
			{
				canShootTimer += Time.fixedDeltaTime;
			}
			if (canShootTimer < nextRandomShootTimer)
				return;

			Vector3 normDir = dir.normalized;
			Vector3 boost = PitchBoost(normDir);
			Vector3 cross = Vector3.Cross(normDir, Vector3.up);
			if (rigidbodies != null)
			{
				for (int i = 0; i < rigidbodies.Length; i++)
				{
					if (rigidbodies[i] != rigid && rigidbodies[i] != null)
					{
						rigidbodies[i].velocity = boost * 0.1f;
						rigidbodies[i].angularVelocity = boost * 0.1f;
					}
				}
			}
			Vector3 normBoost = boost.normalized;
			float t = Mathf.Clamp01(boost.magnitude);
			Vector3 force = Vector3.Lerp(normBoost * minVelocity, normBoost * maxVelocity, t);
			rigid.AddForce(force, ForceMode.VelocityChange);
			rigid.AddTorque(cross * -40f, ForceMode.VelocityChange);
			canShootTimer = 0f;
			if (shootWaitRange != null)
			{
				nextRandomShootTimer = UnityEngine.Random.Range(shootWaitRange.min, shootWaitRange.max);
			}
		}

		private void OnTriggerEnter(Collider other)
		{
			if (other == CurrentWaypoint.triggerCollider)
			{
				wpIndex++;
				if (waypointInfos != null && wpIndex < waypointInfos.Length)
				{
					CurrentWaypoint = waypointInfos[wpIndex];
				}
			}
		}

		private bool CanShoot()
		{
			if (rigid == null)
				return false;
			if (rigid.velocity.sqrMagnitude >= 50f)
				return false;
			if (floater != null && floater.IsInWater)
				return floater.IsFloatingOnSurface;
			return true;
		}

		private Vector3 PitchBoost(Vector3 boost)
		{
			Vector3 axis = Vector3.Cross(boost, Vector3.up);
			return Quaternion.AngleAxis(maxPitch * boost.magnitude, axis) * boost;
		}
	}
}
