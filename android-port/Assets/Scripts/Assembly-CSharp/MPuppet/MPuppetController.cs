using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MPuppet
{
	public class MPuppetController : MonoBehaviour
	{
		public MPuppetSetup Setup;

		public float distanceToGround = 0.5f;

		public float moveForce = 15f;

		public float balanceZThreshold = 0.5f;

		public float stepDuration = 0.3f;

		public float stepHeight = 0.35f;

		public float feetMountForce = 5f;

		public float primaryLegMoveSpeed = 10f;

		public float secondaryLegMoveSpeed = 8f;

		public bool invertMovement;

		private float balanceZ;

		private Vector2 moveInput;

		private float stepTimer;

		private bool stepRight;

		private bool moveStart;

		private float speedModifier = 1f;

		[CompilerGenerated]
		private Action<ConfigJoint, Collision> m_OnPuppetCollision;

		[CompilerGenerated]
		private Action m_OnFootstep;

		public Vector3 CenterOfMass;

		public bool IsGrounded;

		public Vector3[] FeetPositions
		{
			get
			{
				if (Setup == null)
				{
					return new Vector3[0];
				}
				Vector3 p1 = Setup.LeftFootJoint != null ? Setup.LeftFootJoint.transform.position : transform.position;
				Vector3 p2 = Setup.RightFootJoint != null ? Setup.RightFootJoint.transform.position : transform.position;
				return new Vector3[2] { p1, p2 };
			}
		}

		private LayerMask groundLayerMask => ~0;

		public event Action<ConfigJoint, Collision> OnPuppetCollision
		{
			[CompilerGenerated]
			add
			{
				m_OnPuppetCollision = (Action<ConfigJoint, Collision>)Delegate.Combine(m_OnPuppetCollision, value);
			}
			[CompilerGenerated]
			remove
			{
				m_OnPuppetCollision = (Action<ConfigJoint, Collision>)Delegate.Remove(m_OnPuppetCollision, value);
			}
		}

		public event Action OnFootstep
		{
			[CompilerGenerated]
			add
			{
				m_OnFootstep = (Action)Delegate.Combine(m_OnFootstep, value);
			}
			[CompilerGenerated]
			remove
			{
				m_OnFootstep = (Action)Delegate.Remove(m_OnFootstep, value);
			}
		}

		private void Awake()
		{
			if (Setup == null)
			{
				Setup = GetComponent<MPuppetSetup>();
			}
			if (Setup != null)
			{
				Setup.Initialize();
				if (Setup.Joints != null)
				{
					for (int i = 0; i < Setup.Joints.Count; i++)
					{
						if (Setup.Joints[i] != null)
						{
							Setup.Joints[i].Puppet = this;
							Setup.Joints[i].OnJointCollision += Joint_OnJointCollision;
						}
					}
				}
			}
		}

		public void ActivateRagdoll()
		{
			if (Setup != null && Setup.Joints != null)
			{
				SetDrive(Setup.UnbalanceJointDrive, Setup.Joints);
			}
		}

		public void DeactivateRagdoll()
		{
			if (Setup != null && Setup.Joints != null)
			{
				SetDrive(Setup.BalanceJointDrive, Setup.Joints);
			}
		}

		private void Joint_OnJointCollision(ConfigJoint joint, Collision collisionInfo)
		{
			m_OnPuppetCollision?.Invoke(joint, collisionInfo);
		}

		public void SetMove(Vector2 move, float speed = 1f)
		{
			moveInput = invertMovement ? -move : move;
			speedModifier = speed;
		}

		private void Update()
		{
			if (Setup != null)
			{
				CenterOfMass = Setup.GetCenterOfMass();
			}
		}

		private void FixedUpdate()
		{
			CheckGrounded();
			CheckBalance();
			if (moveInput.sqrMagnitude > 0.01f)
			{
				Locomotion();
				Turning();
			}
			else
			{
				ResetAllLegs(true);
			}
		}

		private void CheckBalance()
		{
			if (Setup != null && Setup.RootJoint != null)
			{
				balanceZ = Vector3.Dot(Setup.RootJoint.transform.up, Vector3.up);
			}
		}

		private void CheckGrounded()
		{
			Vector3[] feet = FeetPositions;
			IsGrounded = false;
			for (int i = 0; i < feet.Length; i++)
			{
				if (Physics.Raycast(feet[i] + Vector3.up * 0.1f, Vector3.down, distanceToGround + 0.2f, groundLayerMask))
				{
					IsGrounded = true;
					break;
				}
			}
		}

		private void Locomotion()
		{
			stepTimer += Time.fixedDeltaTime;
			if (stepTimer >= Mathf.Max(0.1f, stepDuration))
			{
				SwapFoot();
			}
			if (Setup != null && Setup.RootJoint != null && Setup.RootJoint._rigidbody != null)
			{
				Vector3 dir = new Vector3(moveInput.x, 0f, moveInput.y).normalized;
				Setup.RootJoint._rigidbody.AddForce(dir * (moveForce * speedModifier), ForceMode.Acceleration);
			}
		}

		private void ResetAllLegs(bool pushDownFeet = true)
		{
			if (Setup == null)
			{
				return;
			}
			ResetJoint(Setup.UpperLeftLegJoint);
			ResetJoint(Setup.LowerLeftLegJoint);
			ResetJoint(Setup.UpperRightLegJoint);
			ResetJoint(Setup.LowerRightLegJoint);
		}

		private void ResetJoint(ConfigJoint joint)
		{
			if (joint != null && joint._joint != null)
			{
				joint._joint.targetRotation = joint.idleTargetRotation;
			}
		}

		private void SetLimbRotation(ConfigJoint joint, Quaternion rotation)
		{
			if (joint != null && joint._joint != null)
			{
				joint._joint.targetRotation = rotation;
			}
		}

		private void SetLimbRotation(ConfigurableJoint joint, Quaternion rotation)
		{
			if (joint != null)
			{
				joint.targetRotation = rotation;
			}
		}

		private void SwapFoot()
		{
			stepTimer = 0f;
			stepRight = !stepRight;
			m_OnFootstep?.Invoke();
		}

		private void HandleFrontFoot()
		{
		}

		private void Turning()
		{
			if (Setup != null && Setup.RootJoint != null && Setup.RootJoint._joint != null && moveInput.sqrMagnitude > 0.01f)
			{
				float angle = Mathf.Atan2(moveInput.x, moveInput.y) * Mathf.Rad2Deg;
				Setup.RootJoint._joint.targetRotation = Quaternion.Euler(0f, -angle, 0f);
			}
		}

		public void SetDrive(JointDrive jd, IEnumerable<ConfigJoint> cj)
		{
			if (cj == null)
			{
				return;
			}
			foreach (ConfigJoint item in cj)
			{
				if (item != null && item._joint != null)
				{
					SetDrive(jd, item._joint);
				}
			}
		}

		public void SetDrive(JointDrive jd, params ConfigJoint[] cj)
		{
			if (cj == null)
			{
				return;
			}
			for (int i = 0; i < cj.Length; i++)
			{
				if (cj[i] != null && cj[i]._joint != null)
				{
					SetDrive(jd, cj[i]._joint);
				}
			}
		}

		private void SetDrive(JointDrive jd, ConfigurableJoint cj)
		{
			if (cj != null)
			{
				cj.angularXDrive = jd;
				cj.angularYZDrive = jd;
			}
		}

		private float GetMissingForce(Vector3 velocity, Vector3 direction, float targetVelocity)
		{
			return Mathf.Max(0f, targetVelocity - Vector3.Dot(velocity, direction));
		}

		public Dictionary<LimbPosition, ConfigJoint> GetActiveLeg()
		{
			if (Setup == null)
			{
				return null;
			}
			return stepRight ? Setup.RightLeg : Setup.LeftLeg;
		}

		public Dictionary<LimbPosition, ConfigJoint> GetInactiveLeg()
		{
			if (Setup == null)
			{
				return null;
			}
			return stepRight ? Setup.LeftLeg : Setup.RightLeg;
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
