using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x2000168")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x400090E")]
		[FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400090F")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35FC0", Offset = "0x35FC0")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000910")]
		[FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x1387A44", Offset = "0x1387A44", VA = "0x1387A44", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default;
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x1387AEC", Offset = "0x1387AEC", VA = "0x1387AEC")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x1387B60", Offset = "0x1387B60", VA = "0x1387B60")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x1387B7C", Offset = "0x1387B7C", VA = "0x1387B7C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x1387B9C", Offset = "0x1387B9C", VA = "0x1387B9C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x1387C34", Offset = "0x1387C34", VA = "0x1387C34")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x1387C50", Offset = "0x1387C50", VA = "0x1387C50")]
		public void WritePose(float solverWeight)
		{
		}
	}
}
