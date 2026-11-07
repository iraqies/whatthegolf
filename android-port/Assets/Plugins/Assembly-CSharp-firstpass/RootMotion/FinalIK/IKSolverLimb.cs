using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x200017D")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x200017E")]
		public enum BendModifier
		{
			[Token(Token = "0x40009B1")]
			Animation = 0,
			[Token(Token = "0x40009B2")]
			Target = 1,
			[Token(Token = "0x40009B3")]
			Parent = 2,
			[Token(Token = "0x40009B4")]
			Arm = 3,
			[Token(Token = "0x40009B5")]
			Goal = 4
		}

		[Serializable]
		[Token(Token = "0x200017F")]
		public struct AxisDirection
		{
			[Token(Token = "0x40009B6")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x40009B7")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x40009B8")]
			[FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0x133FB88", Offset = "0x133FB88", VA = "0x133FB88")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x40009A0")]
		[FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x40009A1")]
		[FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x40009A2")]
		[FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36188", Offset = "0x36188")]
		public float maintainRotationWeight;

		[Token(Token = "0x40009A3")]
		[FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x361A0", Offset = "0x361A0")]
		public float bendModifierWeight;

		[Token(Token = "0x40009A4")]
		[FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x40009A5")]
		[FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x40009A6")]
		[FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x40009A7")]
		[FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x40009A8")]
		[FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x40009A9")]
		[FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x40009AA")]
		[FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x40009AB")]
		[FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x40009AC")]
		[FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x40009AD")]
		[FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x40009AE")]
		[FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x40009AF")]
		[FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000164")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0x13965AC", Offset = "0x13965AC", VA = "0x13965AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x1395478", Offset = "0x1395478", VA = "0x1395478")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x13954CC", Offset = "0x13954CC", VA = "0x13954CC")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x139551C", Offset = "0x139551C", VA = "0x139551C", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x1395994", Offset = "0x1395994", VA = "0x1395994", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x1396338", Offset = "0x1396338", VA = "0x1396338", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x13963E4", Offset = "0x13963E4", VA = "0x13963E4")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x1396528", Offset = "0x1396528", VA = "0x1396528")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x1395808", Offset = "0x1395808", VA = "0x1395808")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x1395A64", Offset = "0x1395A64", VA = "0x1395A64")]
		private Vector3 GetModifiedBendNormal()
		{
			return default;
		}
	}
}
