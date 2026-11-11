using System;
using System.Collections;
using UnityEngine;

namespace RootMotion.Demos
{
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		public enum MoveMode
		{
			Directional = 0,
			Strafe = 1
		}

		public struct AnimState
		{
			public Vector3 moveDirection;

			public bool jump;

			public bool crouch;

			public bool onGround;

			public bool isStrafing;

			public float yVelocity;

			public bool doubleJump;
		}

		public CharacterAnimationBase characterAnimation;

		public UserControlThirdPerson userControl;

		public CameraController cam;

		public MoveMode moveMode;

		public bool smoothPhysics;

		public float smoothAccelerationTime;

		public float linearAccelerationSpeed;

		public float platformFriction;

		public float groundStickyEffect;

		public float maxVerticalVelocityOnGround;

		public float velocityToGroundTangentWeight;

		public bool lookInCameraDirection;

		public float turnSpeed;

		public float stationaryTurnSpeedMlp;

		public bool smoothJump;

		public float airSpeed;

		public float airControl;

		public float jumpPower;

		public float jumpRepeatDelayTime;

		public bool doubleJumpEnabled;

		public float doubleJumpPowerMlp;

		public LayerMask wallRunLayers;

		public float wallRunMaxLength;

		public float wallRunMinMoveMag;

		public float wallRunMinVelocityY;

		public float wallRunRotationSpeed;

		public float wallRunMaxRotationAngle;

		public float wallRunWeightSpeed;

		public float crouchCapsuleScaleMlp;

		public AnimState animState;

		protected Vector3 moveDirection;

		private Animator animator;

		private Vector3 normal;

		private Vector3 platformVelocity;

		private Vector3 platformAngularVelocity;

		private RaycastHit hit;

		private float jumpLeg;

		private float jumpEndTime;

		private float forwardMlp;

		private float groundDistance;

		private float lastAirTime;

		private float stickyForce;

		private Vector3 wallNormal;

		private Vector3 moveDirectionVelocity;

		private float wallRunWeight;

		private float lastWallRunWeight;

		private Vector3 fixedDeltaPosition;

		private Quaternion fixedDeltaRotation;

		private bool fixedFrame;

		private float wallRunEndTime;

		private Vector3 gravity;

		private Vector3 verticalVelocity;

		private float velocityY;

		private bool doubleJumped;

		private bool jumpReleased;

		public bool onGround { get; private set; }

		public bool isJumping => Time.time < jumpEndTime;

		protected override void Start()
		{
		}

		private void OnAnimatorMove()
		{
		}

		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		private void FixedUpdate()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		private void WallRun()
		{
		}

		private bool CanWallRun()
		{
			return false;
		}

		private Vector3 GetMoveDirection()
		{
			return default;
		}

		protected virtual void Rotate()
		{
		}

		private Vector3 GetForwardDirection()
		{
			return default;
		}

		protected virtual bool Jump()
		{
			return false;
		}

		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		private void GroundCheck()
		{
		}
	}
}
