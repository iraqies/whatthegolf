using System;
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
			}
		}

		public Rigidbody rigid;

		public BuoyancyTarget floater;

		public float startDelay;

		public MinMax shootWaitRange;

		public float minVelocity;

		public float maxVelocity;

		public float maxPitch;

		public Transform WaypointContainer;

		public float distanceThreshold;

		private float canShootTimer;

		private float nextRandomShootTimer;

		private int wpIndex;

		private Rigidbody[] rigidbodies;

		private WaypointInfo[] waypointInfos;

		public WaypointInfo CurrentWaypoint { get; private set; }

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private bool CanShoot()
		{
			return false;
		}

		private Vector3 PitchBoost(Vector3 boost)
		{
			return default;
		}
	}
}
