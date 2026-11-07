using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace MPuppet
{
	[Token(Token = "0x20011DA")]
	public class MPuppetGrabBehaviour : MonoBehaviour
	{
		[Token(Token = "0x20011DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4828C", Offset = "0x4828C")]
		private sealed class _003C_003Ec__DisplayClass33_0
		{
			[Token(Token = "0x4005FD2")]
			[FieldOffset(Offset = "0x10")]
			public MPuppetGrabBehaviour _003C_003E4__this;

			[Token(Token = "0x4005FD3")]
			[FieldOffset(Offset = "0x18")]
			public Collider heldCollider;

			[Token(Token = "0x600518E")]
			[Address(RVA = "0x17EF404", Offset = "0x17EF404", VA = "0x17EF404")]
			public _003C_003Ec__DisplayClass33_0()
			{
			}

			[Token(Token = "0x600518F")]
			[Address(RVA = "0x17EF40C", Offset = "0x17EF40C", VA = "0x17EF40C")]
			internal void _003CThrow_003Eb__1()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20011DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4829C", Offset = "0x4829C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4005FD4")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4005FD5")]
			[FieldOffset(Offset = "0x8")]
			public static Action<float> _003C_003E9__33_0;

			[Token(Token = "0x6005191")]
			[Address(RVA = "0x17EF3F8", Offset = "0x17EF3F8", VA = "0x17EF3F8")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6005192")]
			[Address(RVA = "0x17EF400", Offset = "0x17EF400", VA = "0x17EF400")]
			internal void _003CThrow_003Eb__33_0(float t)
			{
			}
		}

		[Token(Token = "0x4005FB9")]
		[FieldOffset(Offset = "0x18")]
		public MPuppetController controller;

		[Token(Token = "0x4005FBA")]
		[FieldOffset(Offset = "0x20")]
		public float throwForce;

		[Token(Token = "0x4005FBB")]
		[FieldOffset(Offset = "0x24")]
		public float connectMassScale;

		[Token(Token = "0x4005FBC")]
		[FieldOffset(Offset = "0x28")]
		public JointDriveSettings jointDrive;

		[Token(Token = "0x4005FBD")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 autoReachBoxSize;

		[Token(Token = "0x4005FBE")]
		[FieldOffset(Offset = "0x40")]
		public bool autoAim;

		[Token(Token = "0x4005FBF")]
		[FieldOffset(Offset = "0x44")]
		public float autoReachRadius;

		[Token(Token = "0x4005FC0")]
		[FieldOffset(Offset = "0x48")]
		public LayerMask grabIgnoreLayer;

		[Token(Token = "0x4005FC1")]
		[FieldOffset(Offset = "0x4C")]
		public Quaternion ReachUpper;

		[Token(Token = "0x4005FC2")]
		[FieldOffset(Offset = "0x5C")]
		public Quaternion ReachMiddle;

		[Token(Token = "0x4005FC3")]
		[FieldOffset(Offset = "0x6C")]
		public Quaternion ReachLower;

		[Token(Token = "0x4005FC4")]
		[FieldOffset(Offset = "0x7C")]
		public Quaternion HoldUpper;

		[Token(Token = "0x4005FC5")]
		[FieldOffset(Offset = "0x8C")]
		public bool AllowHoldingSameObjectWithBothHands;

		[Token(Token = "0x4005FC6")]
		[FieldOffset(Offset = "0x8D")]
		public bool DisableCollisionsWhileHolding;

		[Token(Token = "0x4005FC7")]
		[FieldOffset(Offset = "0x90")]
		public float IgnoreCollisionTime;

		[Token(Token = "0x4005FC8")]
		[FieldOffset(Offset = "0x94")]
		public bool UseAimDirectionAsDirection;

		[Token(Token = "0x4005FC9")]
		[FieldOffset(Offset = "0x98")]
		private ConfigJoint leftHand;

		[Token(Token = "0x4005FCA")]
		[FieldOffset(Offset = "0xA0")]
		private ConfigJoint rightHand;

		[Token(Token = "0x4005FCB")]
		[FieldOffset(Offset = "0xA8")]
		private ConfigJoint rootJoint;

		[Token(Token = "0x4005FCC")]
		[FieldOffset(Offset = "0xB0")]
		private FixedJoint leftHandJoint;

		[Token(Token = "0x4005FCD")]
		[FieldOffset(Offset = "0xB8")]
		private FixedJoint rightHandJoint;

		[Token(Token = "0x4005FCE")]
		[FieldOffset(Offset = "0xC0")]
		private bool reach;

		[Token(Token = "0x4005FCF")]
		[FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5754C", Offset = "0x5754C")]
		private Action<GameObject> m_OnGrab;

		[Token(Token = "0x4005FD0")]
		[FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5755C", Offset = "0x5755C")]
		private Action<GameObject, Vector3> m_OnThrow;

		[Token(Token = "0x4005FD1")]
		[FieldOffset(Offset = "0xD8")]
		private float adjustSpeed;

		[Token(Token = "0x170008C0")]
		public bool IsGrabbing
		{
			[Token(Token = "0x6005181")]
			[Address(RVA = "0x154EB28", Offset = "0x154EB28", VA = "0x154EB28")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1400008B")]
		public event Action<GameObject> OnGrab
		{
			[Token(Token = "0x600517D")]
			[Address(RVA = "0x154E898", Offset = "0x154E898", VA = "0x154E898")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70338", Offset = "0x70338")]
			add
			{
			}
			[Token(Token = "0x600517E")]
			[Address(RVA = "0x154E93C", Offset = "0x154E93C", VA = "0x154E93C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70348", Offset = "0x70348")]
			remove
			{
			}
		}

		[Token(Token = "0x1400008C")]
		public event Action<GameObject, Vector3> OnThrow
		{
			[Token(Token = "0x600517F")]
			[Address(RVA = "0x154E9E0", Offset = "0x154E9E0", VA = "0x154E9E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70358", Offset = "0x70358")]
			add
			{
			}
			[Token(Token = "0x6005180")]
			[Address(RVA = "0x154EA84", Offset = "0x154EA84", VA = "0x154EA84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70368", Offset = "0x70368")]
			remove
			{
			}
		}

		[Token(Token = "0x6005182")]
		[Address(RVA = "0x154EBF0", Offset = "0x154EBF0", VA = "0x154EBF0")]
		private void Start()
		{
		}

		[Token(Token = "0x6005183")]
		[Address(RVA = "0x154ED04", Offset = "0x154ED04", VA = "0x154ED04")]
		public void StartReach()
		{
		}

		[Token(Token = "0x6005184")]
		[Address(RVA = "0x154EE20", Offset = "0x154EE20", VA = "0x154EE20")]
		public void EndReach()
		{
		}

		[Token(Token = "0x6005185")]
		[Address(RVA = "0x154F45C", Offset = "0x154F45C", VA = "0x154F45C")]
		public void Throw(Vector3 aimDirection)
		{
		}

		[Token(Token = "0x6005186")]
		[Address(RVA = "0x154FA1C", Offset = "0x154FA1C", VA = "0x154FA1C")]
		private void SetArmReachRotations(Quaternion upper, bool both = true, bool right = true)
		{
		}

		[Token(Token = "0x6005187")]
		[Address(RVA = "0x154F144", Offset = "0x154F144", VA = "0x154F144")]
		private void ResetArm(IEnumerable<ConfigJoint> joints)
		{
		}

		[Token(Token = "0x6005188")]
		[Address(RVA = "0x154FCF0", Offset = "0x154FCF0", VA = "0x154FCF0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6005189")]
		[Address(RVA = "0x15502A8", Offset = "0x15502A8", VA = "0x15502A8")]
		private void HandleAutoReachHand(List<Collider> nearby, ConfigJoint upperArmJoint, ConfigJoint lowerArmJoint, ConfigJoint handJoint, FixedJoint fj)
		{
		}

		[Token(Token = "0x600518A")]
		[Address(RVA = "0x1550810", Offset = "0x1550810", VA = "0x1550810")]
		private void Controller_OnPuppetCollision(ConfigJoint joint, Collision collisionInfo)
		{
		}

		[Token(Token = "0x600518B")]
		[Address(RVA = "0x1551010", Offset = "0x1551010", VA = "0x1551010")]
		private FixedJoint InitJoint(GameObject hand, Rigidbody rigid)
		{
			return null;
		}

		[Token(Token = "0x600518C")]
		[Address(RVA = "0x15510E0", Offset = "0x15510E0", VA = "0x15510E0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600518D")]
		[Address(RVA = "0x1551238", Offset = "0x1551238", VA = "0x1551238")]
		public MPuppetGrabBehaviour()
		{
		}
	}
}
