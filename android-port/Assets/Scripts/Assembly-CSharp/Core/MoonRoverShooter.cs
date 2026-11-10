using System.Collections.Generic;
using UnityEngine;

namespace Core
{
	public class MoonRoverShooter : GolfBall2DShooterBase
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
		private float catchupToMinSpeedForce;

		[SerializeField]
		public List<WheelJoint2D> wheels;

		[SerializeField]
		private float groundDistance = 4f;

		[SerializeField]
		private float minimumSpeed;

		private float dir;

		private float currentDir;

		private float up;

		private JointMotor2D motor;

		private bool isGrounded;

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
			up = Mathf.Min(Mathf.Clamp01(angleUp / 55f), Mathf.Clamp01(angleDown / 55f)) + 0.05f;
			currentDir = (Vector2.Angle(Vector2.right, boost2D) < 90f) ? 1f : (-1f);

			if (flipAngleCorrectionForce > 0f && rigidbodyC != null)
			{
				Vector2 rightDir = new Vector2(transform.right.x * currentDir, transform.right.y * currentDir);
				float signedAngle = Vector2.SignedAngle(rightDir, boost2D);
				rigidbodyC.AddTorque(signedAngle * flipAngleCorrectionForce * up * Time.fixedDeltaTime);
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
			dir = Mathf.MoveTowards(dir, currentDir * up, Time.fixedDeltaTime * 15f);
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
						if (rigidbodyC != null)
						{
							Vector2 force = Vector2.right * (dir * 0.3f * Time.fixedDeltaTime * airControlForce) + Vector2.down * (Time.fixedDeltaTime * 0.5f);
							rigidbodyC.AddForceAtPosition(force, wheel.transform.position, ForceMode2D.Force);
						}
					}
				}
			}

			if (isGrounded && GolfBallController != null && GolfBallController.GetIsCharging(0) && rigidbodyC != null)
			{
				if (Mathf.Abs(rigidbodyC.velocity.x) < minimumSpeed)
				{
					rigidbodyC.AddForce(Vector2.right * (dir * Time.fixedDeltaTime * catchupToMinSpeedForce), ForceMode2D.Force);
				}
			}

			if (!isGrounded && GolfBallController != null && !GolfBallController.GetIsCharging(0) && IsBlocking() && rigidbodyC != null)
			{
				float angleToUp = Vector2.SignedAngle(transform.up, Vector2.up);
				rigidbodyC.AddTorque(angleToUp * airCorrectForce * Time.fixedDeltaTime);
			}

			if (rigidbodyC != null)
			{
				rigidbodyC.AddForce(Vector2.right * (dir * Time.fixedDeltaTime * airControlForce), ForceMode2D.Force);
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
			return !isGrounded;
		}

		public override void OnShoot(Vector3 boost)
		{
			currentDir = 0f;
			up = 0f;
			if (fullShootVelocity <= 0f)
				return;

			base.OnShoot(boost);
			if (rigidbodyC != null)
			{
				boost.x *= 0.25f;
				rigidbodyC.angularVelocity *= 0.05f;
			}
			StandardShoot(boost, 0f, minShootVelocity, fullShootVelocity, 0f);
		}
	}
}
