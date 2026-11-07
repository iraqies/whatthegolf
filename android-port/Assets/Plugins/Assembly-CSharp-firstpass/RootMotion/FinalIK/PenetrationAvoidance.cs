using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001D2")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20001D3")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20001D4")]
			public class EffectorLink
			{
				[Token(Token = "0x4000C4E")]
				[FieldOffset(Offset = "0x10")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000C4F")]
				[FieldOffset(Offset = "0x14")]
				public float weight;

				[Token(Token = "0x6000D68")]
				[Address(RVA = "0x135AEC8", Offset = "0x135AEC8", VA = "0x135AEC8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000C44")]
			[FieldOffset(Offset = "0x10")]
			public Transform[] raycastFrom;

			[Token(Token = "0x4000C45")]
			[FieldOffset(Offset = "0x18")]
			public Transform raycastTo;

			[Token(Token = "0x4000C46")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36ABC", Offset = "0x36ABC")]
			public float raycastRadius;

			[Token(Token = "0x4000C47")]
			[FieldOffset(Offset = "0x28")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000C48")]
			[FieldOffset(Offset = "0x30")]
			public float smoothTimeIn;

			[Token(Token = "0x4000C49")]
			[FieldOffset(Offset = "0x34")]
			public float smoothTimeOut;

			[Token(Token = "0x4000C4A")]
			[FieldOffset(Offset = "0x38")]
			public LayerMask layers;

			[Token(Token = "0x4000C4B")]
			[FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x4000C4C")]
			[FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x4000C4D")]
			[FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x6000D64")]
			[Address(RVA = "0x1351A9C", Offset = "0x1351A9C", VA = "0x1351A9C")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000D65")]
			[Address(RVA = "0x1351BE0", Offset = "0x1351BE0", VA = "0x1351BE0")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default;
			}

			[Token(Token = "0x6000D66")]
			[Address(RVA = "0x1351CD8", Offset = "0x1351CD8", VA = "0x1351CD8")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default;
			}

			[Token(Token = "0x6000D67")]
			[Address(RVA = "0x1351EAC", Offset = "0x1351EAC", VA = "0x1351EAC")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x4000C43")]
		[FieldOffset(Offset = "0x30")]
		public Avoider[] avoiders;

		[Token(Token = "0x6000D62")]
		[Address(RVA = "0x13BE3BC", Offset = "0x13BE3BC", VA = "0x13BE3BC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000D63")]
		[Address(RVA = "0x13BE444", Offset = "0x13BE444", VA = "0x13BE444")]
		public PenetrationAvoidance()
		{
		}
	}
}
