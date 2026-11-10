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
		public float fullShootVelocity = 25f;

		[SerializeField]
		public float minShootVelocity;

		[SerializeField]
		private float raycastDist = 3f;

		[SerializeField]
		private AnimationCurve shotDampenDurve;

		[SerializeField]
		private AnimationCurve BreakCurve;

		[SerializeField]
		private float shotDampenTime;

		[SerializeField]
		private float shotBoostThreshold = 0.2f;

		[SerializeField]
		private float shotBoostMultiplierIncrement = 0.25f;

		[SerializeField]
		private int shotBoostMaxMultiplierIncrements = 4;

		public List<AxleInfo> axleInfos;

		public float maxMotorTorque;

		public float maxSteeringAngle;

		public float MaxSpeed = 70f;

		public float BreakSpeed = 300f;

		[SerializeField]
		private float dragInAir = -1f;

		[SerializeField]
		private Transform leftFlameTransform;

		[SerializeField]
		private Transform rightFlameTransform;

		private Vector3 lastShootVelocity;

		private float baseDrag;

		private float shotDampen;

		private float shotDampenTimer = 1f;

		private float resetTimer;

		private float shotDampenMult;

		private int boostIncrements;

		private void Start()
		{
			if (rigidbodyC != null)
				baseDrag = rigidbodyC.drag;
			if (dragInAir < 0f)
				dragInAir = baseDrag;
			if (axleInfos != null)
			{
				foreach (AxleInfo axle in axleInfos)
				{
					if (axle == null) continue;
					if (axle.leftWheel != null)
						axle.leftWheel.ConfigureVehicleSubsteps(5f, 12, 15);
					if (axle.rightWheel != null)
						axle.rightWheel.ConfigureVehicleSubsteps(5f, 12, 15);
				}
			}
			shotDampenTimer = 1f;
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			if (!onlyAimArrow)
				lastShootVelocity = boost.normalized;
		}

		public override void OnShoot(Vector3 boost)
		{
			base.OnShoot(boost);
			lastShootVelocity = boost.normalized;
			if (shotDampenTimer < shotBoostThreshold)
			{
				boostIncrements = Mathf.Min(boostIncrements + 1, shotBoostMaxMultiplierIncrements);
				shotDampenMult = 1f + shotBoostMultiplierIncrement * boostIncrements;
			}
			else
			{
				boostIncrements = 0;
				shotDampenMult = 1f;
			}
			shotDampenTimer = 0f;
		}

		private void Update()
		{
			if (leftFlameTransform != null)
			{
				leftFlameTransform.localRotation = Quaternion.Euler(0f, 0f, UnityEngine.Random.Range(-20, 20));
				if (shotDampenDurve != null)
					leftFlameTransform.localScale = Vector3.one * (shotDampenDurve.Evaluate(shotDampenTimer) * shotDampenMult * 0.75f);
			}
			if (rightFlameTransform != null)
			{
				rightFlameTransform.localRotation = Quaternion.Euler(0f, 0f, UnityEngine.Random.Range(-20, 20));
				if (shotDampenDurve != null)
					rightFlameTransform.localScale = Vector3.one * (shotDampenDurve.Evaluate(shotDampenTimer) * shotDampenMult * 0.75f);
			}
		}

		protected override void FixedUpdate()
		{
			Vector3 rayOrigin = transform.position + Vector3.up * 0.5f;
			int mask = ~LayerMask.GetMask("GolfBall");
			bool grounded = Physics.Raycast(rayOrigin, Vector3.down, raycastDist, mask, QueryTriggerInteraction.Ignore);
			if (rigidbodyC != null)
				rigidbodyC.drag = grounded ? baseDrag : dragInAir;
			if (GolfBallController != null)
				GolfBallController.isBlocking = !grounded;

			Vector3 fwdFlat = new Vector3(transform.forward.x, 0f, transform.forward.z).normalized;
			Vector3 targetFlat = new Vector3(lastShootVelocity.x, 0f, lastShootVelocity.z).normalized;
			float dot = Vector3.Dot(fwdFlat, targetFlat);

			float torque = 0f;
			if (rigidbodyC != null && rigidbodyC.velocity.magnitude < MaxSpeed)
			{
				torque = maxMotorTorque * shotDampen * Mathf.Sign(dot) * shotDampenMult;
			}

			float dirSign = Mathf.Sign(dot);
			float signedAngle = Vector3.SignedAngle(fwdFlat * dirSign, targetFlat, transform.up);
			float steer = Mathf.Clamp(signedAngle * dirSign, -maxSteeringAngle, maxSteeringAngle);

			bool anyWheelGrounded = false;
			if (axleInfos != null)
			{
				foreach (AxleInfo axle in axleInfos)
				{
					if (axle == null) continue;
					if (axle.steering)
					{
						float s = axle.rewerseSteering ? (steer * -0.5f) : steer;
						if (axle.leftWheel != null)
							axle.leftWheel.steerAngle = s;
						if (axle.rightWheel != null)
							axle.rightWheel.steerAngle = s;
						if (axle.leftWheel != null && axle.leftWheelTransform != null)
						{
							axle.leftWheel.GetWorldPose(out Vector3 pos, out Quaternion rot);
							axle.leftWheelTransform.position = pos;
							axle.leftWheelTransform.rotation = Quaternion.RotateTowards(axle.leftWheelTransform.rotation, rot, Time.deltaTime * 500f);
						}
						if (axle.rightWheel != null && axle.rightWheelTransform != null)
						{
							axle.rightWheel.GetWorldPose(out Vector3 pos, out Quaternion rot);
							axle.rightWheelTransform.position = pos;
							axle.rightWheelTransform.rotation = Quaternion.RotateTowards(axle.rightWheelTransform.rotation, rot, Time.deltaTime * 500f);
						}
					}
					if (axle.motor)
					{
						if (axle.leftWheel != null)
							axle.leftWheel.motorTorque = torque;
						if (axle.rightWheel != null)
							axle.rightWheel.motorTorque = torque;
						if (BreakCurve != null)
						{
							float brake = BreakCurve.Evaluate(shotDampenTimer) * maxMotorTorque;
							if (axle.leftWheel != null)
								axle.leftWheel.brakeTorque = brake;
							if (axle.rightWheel != null)
								axle.rightWheel.brakeTorque = brake;
						}
					}
					if ((axle.leftWheel != null && axle.leftWheel.isGrounded) || (axle.rightWheel != null && axle.rightWheel.isGrounded))
						anyWheelGrounded = true;
				}
			}

			if (transform.up.y < 0.5f && Physics.Raycast(transform.position, Vector3.down, raycastDist, mask) && rigidbodyC != null && rigidbodyC.velocity.magnitude <= 1f)
			{
				resetTimer += Time.deltaTime;
				if (resetTimer > 2f)
				{
					resetTimer = 0f;
					shotDampen = 0f;
					shotDampenTimer = 1f;
					transform.position += Vector3.up * 3f;
					transform.rotation = Quaternion.LookRotation(Vector3.forward, Vector3.up);
				}
			}
			else
			{
				resetTimer = 0f;
			}

			if (shotDampenDurve != null)
				shotDampen = shotDampenDurve.Evaluate(shotDampenTimer);

			if (anyWheelGrounded)
			{
				if (shotDampenTime > 0f)
					shotDampenTimer += Time.deltaTime * (1f / shotDampenTime);
				else
					shotDampenTimer += Time.deltaTime;
			}
			else
			{
				shotDampen = 0f;
			}
		}
	}
}
