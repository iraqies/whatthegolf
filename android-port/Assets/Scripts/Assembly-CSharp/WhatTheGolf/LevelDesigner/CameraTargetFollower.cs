using UnityEngine;
using WhatTheGolf.LevelDesigner.Selectables;

namespace WhatTheGolf.LevelDesigner
{
	public class CameraTargetFollower : MonoBehaviour
	{
		private const float startupSmoothTime = 1.2f;

		private const float continuousSmoothTime = 0.4f;

		private const float continuousTrackingDelay = 0.4f;

		private float timeUntilContinuousTracking;

		private Transform target;

		private WhatTheGolf.LevelDesigner.Selectables.Ball ball;

		private Vector3 currentVel;

		public void SetTarget(WhatTheGolf.LevelDesigner.Selectables.Ball ball, Transform target)
		{
		}

		private void Controller_OnShoot(Vector3 obj)
		{
		}

		private void HandleReset()
		{
		}

		private void Update()
		{
		}
	}
}
