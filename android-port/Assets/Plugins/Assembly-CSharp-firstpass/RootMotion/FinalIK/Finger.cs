using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x200013F")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x2000140")]
		public enum DOF
		{
			[Token(Token = "0x40007B8")]
			One = 0,
			[Token(Token = "0x40007B9")]
			Three = 1
		}

		[Token(Token = "0x40007A6")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35AC0", Offset = "0x35AC0")]
		public float weight;

		[Token(Token = "0x40007A7")]
		[FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35AD8", Offset = "0x35AD8")]
		public float rotationWeight;

		[Token(Token = "0x40007A8")]
		[FieldOffset(Offset = "0x18")]
		public DOF rotationDOF;

		[Token(Token = "0x40007A9")]
		[FieldOffset(Offset = "0x1C")]
		public bool fixBone1Twist;

		[Token(Token = "0x40007AA")]
		[FieldOffset(Offset = "0x20")]
		public Transform bone1;

		[Token(Token = "0x40007AB")]
		[FieldOffset(Offset = "0x28")]
		public Transform bone2;

		[Token(Token = "0x40007AC")]
		[FieldOffset(Offset = "0x30")]
		public Transform bone3;

		[Token(Token = "0x40007AD")]
		[FieldOffset(Offset = "0x38")]
		public Transform tip;

		[Token(Token = "0x40007AE")]
		[FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x40007AF")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35AF0", Offset = "0x35AF0")]
		private bool initiated__BackingField;

		[Token(Token = "0x40007B0")]
		[FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x40007B1")]
		[FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x40007B2")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x40007B3")]
		[FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x40007B4")]
		[FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x40007B5")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x40007B6")]
		[FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x17000123")]
		public bool initiated
		{
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x1370EA4", Offset = "0x1370EA4", VA = "0x1370EA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38FB4", Offset = "0x38FB4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x1370EAC", Offset = "0x1370EAC", VA = "0x1370EAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38FC4", Offset = "0x38FC4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000124")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x1370EB4", Offset = "0x1370EB4", VA = "0x1370EB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000125")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x1370ED4", Offset = "0x1370ED4", VA = "0x1370ED4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x1370EF4", Offset = "0x1370EF4", VA = "0x1370EF4")]
			set
			{
			}
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x1370F14", Offset = "0x1370F14", VA = "0x1370F14")]
		public bool IsValid(ref string errorMessage)
		{
			return default;
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x1371034", Offset = "0x1371034", VA = "0x1371034")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x13714F0", Offset = "0x13714F0", VA = "0x13714F0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x13715D4", Offset = "0x13715D4", VA = "0x13715D4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x13716A4", Offset = "0x13716A4", VA = "0x13716A4")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x1371BE8", Offset = "0x1371BE8", VA = "0x1371BE8")]
		public Finger()
		{
		}
	}
}
