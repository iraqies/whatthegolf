using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001D0")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001D1")]
		public class EffectorLink
		{
			[Token(Token = "0x4000C3F")]
			[FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000C40")]
			[FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x4000C41")]
			[FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x4000C42")]
			[FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000D60")]
			[Address(RVA = "0x13514C8", Offset = "0x13514C8", VA = "0x13514C8")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000D61")]
			[Address(RVA = "0x13516D8", Offset = "0x13516D8", VA = "0x13516D8")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000C3E")]
		[FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000D5D")]
		[Address(RVA = "0x13BD798", Offset = "0x13BD798", VA = "0x13BD798")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000D5E")]
		[Address(RVA = "0x13BD85C", Offset = "0x13BD85C", VA = "0x13BD85C")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000D5F")]
		[Address(RVA = "0x13BD918", Offset = "0x13BD918", VA = "0x13BD918")]
		public OffsetPose()
		{
		}
	}
}
