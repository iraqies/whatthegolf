using System;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
	public class CarWithWheelColliderShooter : GolfBallShooterBase
	{
		[Serializable]
		public class AxleInfo
		{
			public WheelCollider leftWheel;

			public WheelCollider rightWheel;

			public bool motor;

			public bool steering;

			public bool rewerseSteering;

			public Transform leftWheelTransform;

			public Transform rightWheelTransform;
		}

		[SerializeField]
		public float fullShootVelocity;

		[SerializeField]
		public float minShootVelocity;

		[SerializeField]
		private float raycastDist;

		[SerializeField]
		private AnimationCurve shotDampenDurve;

		[SerializeField]
		private AnimationCurve BreakCurve;

		[SerializeField]
		private float shotDampenTime;

		[SerializeField]
		private float shotBoostThreshold;

		[SerializeField]
		private float shotBoostMultiplierIncrement;

		[SerializeField]
		private int shotBoostMaxMultiplierIncrements;

		public List<AxleInfo> axleInfos;

		public float maxMotorTorque;

		public float maxSteeringAngle;

		public float MaxSpeed;

		public float BreakSpeed;

		[SerializeField]
		private float dragInAir;

		[SerializeField]
		private Transform leftFlameTransform;

		[SerializeField]
		private Transform rightFlameTransform;

		private Vector3 lastShootVelocity;

		private float baseDrag;

		private float shotDampen;

		private float shotDampenTimer;

		private float resetTimer;

		private float shotDampenMult;

		private int boostIncrements;

		private void Start()
		{
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		public override void OnShoot(Vector3 boost)
		{
		base.OnShoot(boost);
		StandardShoot(boost, 15f, (minShootVelocity > 0f ? minShootVelocity : 5f), (fullShootVelocity > 0f ? fullShootVelocity : 22f), 5f);
	}

		private void Update()
		{
		}

		protected override void FixedUpdate()
		{
		base.FixedUpdate();
	}
	}
}
