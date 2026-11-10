using System.Collections.Generic;
using Audio;
using UnityEngine;

namespace Core
{
	public class Bike2DShooter : GolfBall2DShooterBase
	{
		[SerializeField]
		public float minShootVelocity = 5f;

		[SerializeField]
		public float fullShootVelocity = 25f;

		[SerializeField]
		public LayerMask groundLayers;

		[SerializeField]
		private float motorSpeed = 2800f;

		[SerializeField]
		private float motorTorque = 600f;

		[SerializeField]
		private float airControlForce = 5000f;

		[SerializeField]
		private float flipAngleCorrectionForce = 8f;

		[SerializeField]
		private float airCorrectForce = 90f;

		[SerializeField]
		public List<WheelJoint2D> wheels;

		[SerializeField]
		private float groundDistance = 4f;

		[SerializeField]
		private float isGroundedInAirThreshold = 0.04f;

		[SerializeField]
		private ClipSettingsCollection sfxOnJump;

		[SerializeField]
		private RotateAxis2D pedals;

		[SerializeField]
		private float pedalsSpeedMod = 1f;

		private float dir;

		private float currentDir;

		private float up;

		private JointMotor2D motor;

		private bool isGrounded;

		private float lastIsGroundedTime;

		public override void OnActivate()
		{
			base.OnActivate();
			if (rigidbodyC != null)
				rigidbodyC.isKinematic = false;
		}

		private void OnEnable()
		{
			currentDir = 0f;
			up = 0f;
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			base.OnAimUpdate(boost, onlyAimArrow);
			if (onlyAimArrow)
				return;

			Vector2 boost2D = new Vector2(boost.x, boost.y);
			float angleUp = Vector2.Angle(Vector2.up, boost2D);
			float angleDown = Vector2.Angle(Vector2.down, boost2D);
			up = Mathf.Min(Mathf.Clamp01(angleUp / 35f), Mathf.Clamp01(angleDown / 35f)) + 0.1f;
			currentDir = (Vector2.Angle(Vector2.right, boost2D) < 90f) ? 1f : (-1f);

			if (flipAngleCorrectionForce > 0f && Vector3.Angle(transform.up, Vector3.up) > 50f && rigidbodyC != null)
			{
				Vector2 rightDir = new Vector2(transform.right.x * currentDir, transform.right.y * currentDir);
				Vector2 scaledBoost = new Vector2(boost.x, boost.y * 0.1f);
				float signedAngle = Vector2.SignedAngle(rightDir, scaledBoost);
				rigidbodyC.angularVelocity = signedAngle * flipAngleCorrectionForce * up;
			}
		}

		private void Update()
		{
			if (GolfBallController != null)
				GolfBallController.isBlocking = IsBlocking();
		}

		protected override void FixedUpdate()
		{
			base.FixedUpdate();
			dir = Mathf.MoveTowards(dir, currentDir * up, Time.fixedDeltaTime * 7f);
			motor.maxMotorTorque = motorTorque * TweenFunctions.Exponential(Mathf.Abs(dir));
			motor.motorSpeed = motorSpeed * dir;

			isGrounded = false;
			if (wheels != null)
			{
				foreach (WheelJoint2D wheel in wheels)
				{
					if (wheel == null) continue;
					wheel.motor = motor;
					RaycastHit2D hit = Physics2D.Raycast(wheel.transform.position, Vector2.down, groundDistance, groundLayers);
					if (hit)
					{
						isGrounded = true;
						lastIsGroundedTime = Time.time;
						if (rigidbodyC != null)
						{
							Vector2 force = Vector2.right * (dir * 0.4f * Time.fixedDeltaTime * airControlForce) + Vector2.down * (Time.fixedDeltaTime * 0.5f);
							rigidbodyC.AddForceAtPosition(force, wheel.transform.position, ForceMode2D.Force);
						}
					}
				}
			}

			if (!isGrounded && GolfBallController != null && !GolfBallController.IsAiming && IsBlocking() && rigidbodyC != null)
			{
				float angleToUp = Vector2.SignedAngle(transform.up, Vector2.up);
				rigidbodyC.AddTorque(angleToUp * airCorrectForce * Time.fixedDeltaTime);
			}

			if (rigidbodyC != null)
			{
				rigidbodyC.AddForce(Vector2.right * (dir * Time.fixedDeltaTime * airControlForce), ForceMode2D.Force);
				if (pedals != null)
					pedals.Speed = rigidbodyC.velocity.x * pedalsSpeedMod;
			}
		}

		public override void OnCancel()
		{
			currentDir = 0f;
			up = 0f;
			base.OnCancel();
		}

		protected override bool IsBlocking()
		{
			return Time.time - lastIsGroundedTime > isGroundedInAirThreshold;
		}

		public override void OnShoot(Vector3 boost)
		{
			currentDir = 0f;
			up = 0f;
			if (fullShootVelocity <= 0f)
				return;

			base.OnShoot(boost);
			if (sfxOnJump != null)
				sfxOnJump.Play(null, Vector3.zero, 1f, 1f);

			float mag = boost.magnitude;
			Vector3 jumpBoost = Vector3.up * (mag * 0.6f) + Vector3.right * (boost.x * 0.2f) + boost * 0.2f;
			if (rigidbodyC != null)
				rigidbodyC.angularVelocity *= 0.02f;

			StandardShoot(jumpBoost, 0f, minShootVelocity, fullShootVelocity, 0f);
		}
	}
}
