using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x2000164")]
	public class IKConstraintBend
	{
		[Token(Token = "0x40008C6")]
		[FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x40008C7")]
		[FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x40008C8")]
		[FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x40008C9")]
		[FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x40008CA")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x40008CB")]
		[FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40008CC")]
		[FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35F40", Offset = "0x35F40")]
		public float weight;

		[Token(Token = "0x40008CD")]
		[FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x40008CE")]
		[FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x40008CF")]
		[FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x40008D0")]
		[FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x40008D1")]
		[FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x40008D2")]
		[FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x40008D3")]
		[FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x40008D4")]
		[FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x40008D5")]
		[FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x40008D6")]
		[FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35F58", Offset = "0x35F58")]
		private bool initiated__BackingField;

		[Token(Token = "0x40008D7")]
		[FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000142")]
		public bool initiated
		{
			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x1385544", Offset = "0x1385544", VA = "0x1385544")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A01C", Offset = "0x3A01C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x138554C", Offset = "0x138554C", VA = "0x138554C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3A02C", Offset = "0x3A02C")]
			private set
			{
			}
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x1385554", Offset = "0x1385554", VA = "0x1385554")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x1385594", Offset = "0x1385594", VA = "0x1385594")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x13855A0", Offset = "0x13855A0", VA = "0x13855A0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x1385930", Offset = "0x1385930", VA = "0x1385930")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x1385C80", Offset = "0x1385C80", VA = "0x1385C80")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default;
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x13857D8", Offset = "0x13857D8", VA = "0x13857D8")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default;
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x1385884", Offset = "0x1385884", VA = "0x1385884")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default;
		}
	}
}
