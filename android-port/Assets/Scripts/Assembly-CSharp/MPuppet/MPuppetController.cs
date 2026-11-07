using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MPuppet
{
	public class MPuppetController : MonoBehaviour
	{
		public MPuppetSetup Setup;

		public float distanceToGround;

		public float moveForce;

		public float balanceZThreshold;

		public float stepDuration;

		public float stepHeight;

		public float feetMountForce;

		public float primaryLegMoveSpeed;

		public float secondaryLegMoveSpeed;

		public bool invertMovement;

		private float balanceZ;

		private Vector2 moveInput;

		private float stepTimer;

		private bool stepRight;

		private bool moveStart;

		private float speedModifier;

		[CompilerGenerated]
		private Action<ConfigJoint, Collision> m_OnPuppetCollision;

		[CompilerGenerated]
		private Action m_OnFootstep;

		public Vector3 CenterOfMass;

		public bool IsGrounded;

		public Vector3[] FeetPositions => null;

		private LayerMask groundLayerMask => default;

		public event Action<ConfigJoint, Collision> OnPuppetCollision
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnFootstep
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		public void ActivateRagdoll()
		{
		}

		public void DeactivateRagdoll()
		{
		}

		private void Joint_OnJointCollision(ConfigJoint joint, Collision collisionInfo)
		{
		}

		public void SetMove(Vector2 move, float speed = 1f)
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void CheckBalance()
		{
		}

		private void CheckGrounded()
		{
		}

		private void Locomotion()
		{
		}

		private void ResetAllLegs(bool pushDownFeet = true)
		{
		}

		private void ResetJoint(ConfigJoint joint)
		{
		}

		private void SetLimbRotation(ConfigJoint joint, Quaternion rotation)
		{
		}

		private void SetLimbRotation(ConfigurableJoint joint, Quaternion rotation)
		{
		}

		private void SwapFoot()
		{
		}

		private void HandleFrontFoot()
		{
		}

		private void Turning()
		{
		}

		public void SetDrive(JointDrive jd, IEnumerable<ConfigJoint> cj)
		{
		}

		public void SetDrive(JointDrive jd, params ConfigJoint[] cj)
		{
		}

		private void SetDrive(JointDrive jd, ConfigurableJoint cj)
		{
		}

		private float GetMissingForce(Vector3 velocity, Vector3 direction, float targetVelocity)
		{
			return 0f;
		}

		public Dictionary<LimbPosition, ConfigJoint> GetActiveLeg()
		{
			return null;
		}

		public Dictionary<LimbPosition, ConfigJoint> GetInactiveLeg()
		{
			return null;
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
