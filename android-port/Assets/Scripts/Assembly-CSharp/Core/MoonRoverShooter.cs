using System.Collections.Generic;
using UnityEngine;

namespace Core
{
	public class MoonRoverShooter : GolfBall2DShooterBase
	{
		[SerializeField]
		public float minShootVelocity;

		[SerializeField]
		public float fullShootVelocity;

		[SerializeField]
		public LayerMask groundLayers;

		[SerializeField]
		private float motorSpeed;

		[SerializeField]
		private float motorTorque;

		[SerializeField]
		private float airControlForce;

		[SerializeField]
		private float flipAngleCorrectionForce;

		[SerializeField]
		private float airCorrectForce;

		[SerializeField]
		private float catchupToMinSpeedForce;

		[SerializeField]
		public List<WheelJoint2D> wheels;

		[SerializeField]
		private float groundDistance;

		[SerializeField]
		private float minimumSpeed;

		private float dir;

		private float currentDir;

		private float up;

		private JointMotor2D motor;

		private bool isGrounded;

		public override void OnActivate()
		{
		}

		private void OnEnable()
		{
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		private void Update()
		{
		}

		protected override void FixedUpdate()
		{
		base.FixedUpdate();
	}

		public override void OnCancel()
		{
		}

		protected override bool IsBlocking()
		{
			return false;
		}

		public override void OnShoot(Vector3 boost)
		{
		StandardShoot(boost, 20f, 18f, 5f);
	}
	}
}
