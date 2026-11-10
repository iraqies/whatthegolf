using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MPuppet
{
	public class MPuppetGrabBehaviour : MonoBehaviour
	{
		public MPuppetController controller;

		public float throwForce = 15f;

		public float connectMassScale = 1f;

		public JointDriveSettings jointDrive;

		public Vector3 autoReachBoxSize = Vector3.one;

		public bool autoAim = true;

		public float autoReachRadius = 1.5f;

		public LayerMask grabIgnoreLayer;

		public Quaternion ReachUpper = Quaternion.identity;

		public Quaternion ReachMiddle = Quaternion.identity;

		public Quaternion ReachLower = Quaternion.identity;

		public Quaternion HoldUpper = Quaternion.identity;

		public bool AllowHoldingSameObjectWithBothHands = true;

		public bool DisableCollisionsWhileHolding;

		public float IgnoreCollisionTime = 0.25f;

		public bool UseAimDirectionAsDirection = true;

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

		private float adjustSpeed = 5f;

		public bool IsGrabbing => leftHandJoint != null || rightHandJoint != null;

		public event Action<GameObject> OnGrab
		{
			[CompilerGenerated]
			add
			{
				m_OnGrab = (Action<GameObject>)Delegate.Combine(m_OnGrab, value);
			}
			[CompilerGenerated]
			remove
			{
				m_OnGrab = (Action<GameObject>)Delegate.Remove(m_OnGrab, value);
			}
		}

		public event Action<GameObject, Vector3> OnThrow
		{
			[CompilerGenerated]
			add
			{
				m_OnThrow = (Action<GameObject, Vector3>)Delegate.Combine(m_OnThrow, value);
			}
			[CompilerGenerated]
			remove
			{
				m_OnThrow = (Action<GameObject, Vector3>)Delegate.Remove(m_OnThrow, value);
			}
		}

		private void Start()
		{
			if (controller == null)
			{
				controller = GetComponent<MPuppetController>();
			}
			if (controller != null && controller.Setup != null)
			{
				controller.Setup.Initialize();
				leftHand = controller.Setup.LeftHandJoint;
				rightHand = controller.Setup.RightHandJoint;
				rootJoint = controller.Setup.RootJoint;
				controller.OnPuppetCollision += Controller_OnPuppetCollision;
			}
		}

		public void StartReach()
		{
			reach = true;
			SetArmReachRotations(ReachUpper, true, true);
		}

		public void EndReach()
		{
			reach = false;
			if (controller != null && controller.Setup != null)
			{
				if (leftHandJoint == null && controller.Setup.LeftArm != null)
				{
					ResetArm(controller.Setup.LeftArm.Values);
				}
				if (rightHandJoint == null && controller.Setup.RightArm != null)
				{
					ResetArm(controller.Setup.RightArm.Values);
				}
			}
		}

		public void Throw(Vector3 aimDirection)
		{
			reach = false;
			GameObject thrown = null;
			if (leftHandJoint != null)
			{
				Rigidbody rb = leftHandJoint.connectedBody;
				UnityEngine.Object.Destroy(leftHandJoint);
				leftHandJoint = null;
				if (rb != null)
				{
					thrown = rb.gameObject;
					rb.AddForce(aimDirection * throwForce, ForceMode.VelocityChange);
				}
			}
			if (rightHandJoint != null)
			{
				Rigidbody rb = rightHandJoint.connectedBody;
				UnityEngine.Object.Destroy(rightHandJoint);
				rightHandJoint = null;
				if (rb != null)
				{
					thrown = rb.gameObject;
					rb.AddForce(aimDirection * throwForce, ForceMode.VelocityChange);
				}
			}
			if (thrown != null)
			{
				m_OnThrow?.Invoke(thrown, aimDirection * throwForce);
			}
			EndReach();
		}

		private void SetArmReachRotations(Quaternion upper, bool both = true, bool right = true)
		{
			if (controller == null || controller.Setup == null)
			{
				return;
			}
			if ((both || right) && controller.Setup.UpperRightArmJoint != null && controller.Setup.UpperRightArmJoint._joint != null)
			{
				controller.Setup.UpperRightArmJoint._joint.targetRotation = upper;
			}
			if ((both || !right) && controller.Setup.UpperLeftArmJoint != null && controller.Setup.UpperLeftArmJoint._joint != null)
			{
				controller.Setup.UpperLeftArmJoint._joint.targetRotation = upper;
			}
		}

		private void ResetArm(IEnumerable<ConfigJoint> joints)
		{
			if (joints == null)
			{
				return;
			}
			foreach (ConfigJoint j in joints)
			{
				if (j != null && j._joint != null)
				{
					j._joint.targetRotation = j.idleTargetRotation;
				}
			}
		}

		private void FixedUpdate()
		{
		}

		private void HandleAutoReachHand(List<Collider> nearby, ConfigJoint upperArmJoint, ConfigJoint lowerArmJoint, ConfigJoint handJoint, FixedJoint fj)
		{
		}

		private void Controller_OnPuppetCollision(ConfigJoint joint, Collision collisionInfo)
		{
			if (!reach || collisionInfo == null || collisionInfo.rigidbody == null)
			{
				return;
			}
			if (joint == leftHand && leftHandJoint == null)
			{
				leftHandJoint = InitJoint(leftHand.gameObject, collisionInfo.rigidbody);
				m_OnGrab?.Invoke(collisionInfo.rigidbody.gameObject);
			}
			else if (joint == rightHand && rightHandJoint == null)
			{
				rightHandJoint = InitJoint(rightHand.gameObject, collisionInfo.rigidbody);
				m_OnGrab?.Invoke(collisionInfo.rigidbody.gameObject);
			}
		}

		private FixedJoint InitJoint(GameObject hand, Rigidbody rigid)
		{
			if (hand == null || rigid == null)
			{
				return null;
			}
			FixedJoint fj = hand.AddComponent<FixedJoint>();
			fj.connectedBody = rigid;
			fj.connectedMassScale = Mathf.Max(0.1f, connectMassScale);
			return fj;
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
