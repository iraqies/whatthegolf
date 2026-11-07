using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MPuppet
{
	public class MPuppetGrabBehaviour : MonoBehaviour
	{
		public MPuppetController controller;

		public float throwForce;

		public float connectMassScale;

		public JointDriveSettings jointDrive;

		public Vector3 autoReachBoxSize;

		public bool autoAim;

		public float autoReachRadius;

		public LayerMask grabIgnoreLayer;

		public Quaternion ReachUpper;

		public Quaternion ReachMiddle;

		public Quaternion ReachLower;

		public Quaternion HoldUpper;

		public bool AllowHoldingSameObjectWithBothHands;

		public bool DisableCollisionsWhileHolding;

		public float IgnoreCollisionTime;

		public bool UseAimDirectionAsDirection;

		private ConfigJoint leftHand;

		private ConfigJoint rightHand;

		private ConfigJoint rootJoint;

		private FixedJoint leftHandJoint;

		private FixedJoint rightHandJoint;

		private bool reach;

		[CompilerGenerated]
		private Action<GameObject> m_OnGrab;

		[CompilerGenerated]
		private Action<GameObject, Vector3> m_OnThrow;

		private float adjustSpeed;

		public bool IsGrabbing => false;

		public event Action<GameObject> OnGrab
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

		public event Action<GameObject, Vector3> OnThrow
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

		private void Start()
		{
		}

		public void StartReach()
		{
		}

		public void EndReach()
		{
		}

		public void Throw(Vector3 aimDirection)
		{
		}

		private void SetArmReachRotations(Quaternion upper, bool both = true, bool right = true)
		{
		}

		private void ResetArm(IEnumerable<ConfigJoint> joints)
		{
		}

		private void FixedUpdate()
		{
		}

		private void HandleAutoReachHand(List<Collider> nearby, ConfigJoint upperArmJoint, ConfigJoint lowerArmJoint, ConfigJoint handJoint, FixedJoint fj)
		{
		}

		private void Controller_OnPuppetCollision(ConfigJoint joint, Collision collisionInfo)
		{
		}

		private FixedJoint InitJoint(GameObject hand, Rigidbody rigid)
		{
			return null;
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
