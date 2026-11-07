using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace MPuppet
{
	[Token(Token = "0x20011D9")]
	public class MPuppetController : MonoBehaviour
	{
		[Token(Token = "0x4005FA5")]
		[FieldOffset(Offset = "0x18")]
		public MPuppetSetup Setup;

		[Token(Token = "0x4005FA6")]
		[FieldOffset(Offset = "0x20")]
		public float distanceToGround;

		[Token(Token = "0x4005FA7")]
		[FieldOffset(Offset = "0x24")]
		public float moveForce;

		[Token(Token = "0x4005FA8")]
		[FieldOffset(Offset = "0x28")]
		public float balanceZThreshold;

		[Token(Token = "0x4005FA9")]
		[FieldOffset(Offset = "0x2C")]
		public float stepDuration;

		[Token(Token = "0x4005FAA")]
		[FieldOffset(Offset = "0x30")]
		public float stepHeight;

		[Token(Token = "0x4005FAB")]
		[FieldOffset(Offset = "0x34")]
		public float feetMountForce;

		[Token(Token = "0x4005FAC")]
		[FieldOffset(Offset = "0x38")]
		public float primaryLegMoveSpeed;

		[Token(Token = "0x4005FAD")]
		[FieldOffset(Offset = "0x3C")]
		public float secondaryLegMoveSpeed;

		[Token(Token = "0x4005FAE")]
		[FieldOffset(Offset = "0x40")]
		public bool invertMovement;

		[Token(Token = "0x4005FAF")]
		[FieldOffset(Offset = "0x44")]
		private float balanceZ;

		[Token(Token = "0x4005FB0")]
		[FieldOffset(Offset = "0x48")]
		private Vector2 moveInput;

		[Token(Token = "0x4005FB1")]
		[FieldOffset(Offset = "0x50")]
		private float stepTimer;

		[Token(Token = "0x4005FB2")]
		[FieldOffset(Offset = "0x54")]
		private bool stepRight;

		[Token(Token = "0x4005FB3")]
		[FieldOffset(Offset = "0x55")]
		private bool moveStart;

		[Token(Token = "0x4005FB4")]
		[FieldOffset(Offset = "0x58")]
		private float speedModifier;

		[Token(Token = "0x4005FB5")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5752C", Offset = "0x5752C")]
		private Action<ConfigJoint, Collision> m_OnPuppetCollision;

		[Token(Token = "0x4005FB6")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5753C", Offset = "0x5753C")]
		private Action m_OnFootstep;

		[Token(Token = "0x4005FB7")]
		[FieldOffset(Offset = "0x70")]
		public Vector3 CenterOfMass;

		[Token(Token = "0x4005FB8")]
		[FieldOffset(Offset = "0x7C")]
		public bool IsGrounded;

		[Token(Token = "0x170008BE")]
		public Vector3[] FeetPositions
		{
			[Token(Token = "0x6005161")]
			[Address(RVA = "0x154CE2C", Offset = "0x154CE2C", VA = "0x154CE2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008BF")]
		private LayerMask groundLayerMask
		{
			[Token(Token = "0x6005162")]
			[Address(RVA = "0x154CF20", Offset = "0x154CF20", VA = "0x154CF20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x14000089")]
		public event Action<ConfigJoint, Collision> OnPuppetCollision
		{
			[Token(Token = "0x600515D")]
			[Address(RVA = "0x154CC40", Offset = "0x154CC40", VA = "0x154CC40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702E8", Offset = "0x702E8")]
			add
			{
			}
			[Token(Token = "0x600515E")]
			[Address(RVA = "0x154CCE4", Offset = "0x154CCE4", VA = "0x154CCE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702F8", Offset = "0x702F8")]
			remove
			{
			}
		}

		[Token(Token = "0x1400008A")]
		public event Action OnFootstep
		{
			[Token(Token = "0x600515F")]
			[Address(RVA = "0x154CA7C", Offset = "0x154CA7C", VA = "0x154CA7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70308", Offset = "0x70308")]
			add
			{
			}
			[Token(Token = "0x6005160")]
			[Address(RVA = "0x154CD88", Offset = "0x154CD88", VA = "0x154CD88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70318", Offset = "0x70318")]
			remove
			{
			}
		}

		[Token(Token = "0x6005163")]
		[Address(RVA = "0x154CFE4", Offset = "0x154CFE4", VA = "0x154CFE4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005164")]
		[Address(RVA = "0x154D374", Offset = "0x154D374", VA = "0x154D374")]
		public void ActivateRagdoll()
		{
		}

		[Token(Token = "0x6005165")]
		[Address(RVA = "0x154D238", Offset = "0x154D238", VA = "0x154D238")]
		public void DeactivateRagdoll()
		{
		}

		[Token(Token = "0x6005166")]
		[Address(RVA = "0x154D7C0", Offset = "0x154D7C0", VA = "0x154D7C0")]
		private void Joint_OnJointCollision(ConfigJoint joint, Collision collisionInfo)
		{
		}

		[Token(Token = "0x6005167")]
		[Address(RVA = "0x154D838", Offset = "0x154D838", VA = "0x154D838")]
		public void SetMove(Vector2 move, float speed = 1f)
		{
		}

		[Token(Token = "0x6005168")]
		[Address(RVA = "0x154D8F4", Offset = "0x154D8F4", VA = "0x154D8F4")]
		private void Update()
		{
		}

		[Token(Token = "0x6005169")]
		[Address(RVA = "0x154DA74", Offset = "0x154DA74", VA = "0x154DA74")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600516A")]
		[Address(RVA = "0x154DA3C", Offset = "0x154DA3C", VA = "0x154DA3C")]
		private void CheckBalance()
		{
		}

		[Token(Token = "0x600516B")]
		[Address(RVA = "0x154D930", Offset = "0x154D930", VA = "0x154D930")]
		private void CheckGrounded()
		{
		}

		[Token(Token = "0x600516C")]
		[Address(RVA = "0x154DA98", Offset = "0x154DA98", VA = "0x154DA98")]
		private void Locomotion()
		{
		}

		[Token(Token = "0x600516D")]
		[Address(RVA = "0x154E1A8", Offset = "0x154E1A8", VA = "0x154E1A8")]
		private void ResetAllLegs(bool pushDownFeet = true)
		{
		}

		[Token(Token = "0x600516E")]
		[Address(RVA = "0x154E16C", Offset = "0x154E16C", VA = "0x154E16C")]
		private void ResetJoint(ConfigJoint joint)
		{
		}

		[Token(Token = "0x600516F")]
		[Address(RVA = "0x154E538", Offset = "0x154E538", VA = "0x154E538")]
		private void SetLimbRotation(ConfigJoint joint, Quaternion rotation)
		{
		}

		[Token(Token = "0x6005170")]
		[Address(RVA = "0x154E55C", Offset = "0x154E55C", VA = "0x154E55C")]
		private void SetLimbRotation(ConfigurableJoint joint, Quaternion rotation)
		{
		}

		[Token(Token = "0x6005171")]
		[Address(RVA = "0x154E198", Offset = "0x154E198", VA = "0x154E198")]
		private void SwapFoot()
		{
		}

		[Token(Token = "0x6005172")]
		[Address(RVA = "0x154DF94", Offset = "0x154DF94", VA = "0x154DF94")]
		private void HandleFrontFoot()
		{
		}

		[Token(Token = "0x6005173")]
		[Address(RVA = "0x154DEF4", Offset = "0x154DEF4", VA = "0x154DEF4")]
		private void Turning()
		{
		}

		[Token(Token = "0x6005174")]
		[Address(RVA = "0x154D3B0", Offset = "0x154D3B0", VA = "0x154D3B0")]
		public void SetDrive(JointDrive jd, IEnumerable<ConfigJoint> cj)
		{
		}

		[Token(Token = "0x6005175")]
		[Address(RVA = "0x154D700", Offset = "0x154D700", VA = "0x154D700")]
		public void SetDrive(JointDrive jd, params ConfigJoint[] cj)
		{
		}

		[Token(Token = "0x6005176")]
		[Address(RVA = "0x154E578", Offset = "0x154E578", VA = "0x154E578")]
		private void SetDrive(JointDrive jd, ConfigurableJoint cj)
		{
		}

		[Token(Token = "0x6005177")]
		[Address(RVA = "0x154E024", Offset = "0x154E024", VA = "0x154E024")]
		private float GetMissingForce(Vector3 velocity, Vector3 direction, float targetVelocity)
		{
			return default;
		}

		[Token(Token = "0x6005178")]
		[Address(RVA = "0x154E080", Offset = "0x154E080", VA = "0x154E080")]
		public Dictionary<LimbPosition, ConfigJoint> GetActiveLeg()
		{
			return null;
		}

		[Token(Token = "0x6005179")]
		[Address(RVA = "0x154E0B8", Offset = "0x154E0B8", VA = "0x154E0B8")]
		public Dictionary<LimbPosition, ConfigJoint> GetInactiveLeg()
		{
			return null;
		}

		[Token(Token = "0x600517A")]
		[Address(RVA = "0x154E5D8", Offset = "0x154E5D8", VA = "0x154E5D8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600517B")]
		[Address(RVA = "0x154E84C", Offset = "0x154E84C", VA = "0x154E84C")]
		public MPuppetController()
		{
		}

		[Token(Token = "0x600517C")]
		[Address(RVA = "0x154E0F0", Offset = "0x154E0F0", VA = "0x154E0F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70328", Offset = "0x70328")]
		private void _003CLocomotion_003Eg__MoveLeg_007C37_0(ConfigurableJoint joint, float val)
		{
		}
	}
}
