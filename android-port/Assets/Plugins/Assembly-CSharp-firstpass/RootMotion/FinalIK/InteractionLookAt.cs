using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x2000191")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000AE0")]
		[FieldOffset(Offset = "0x10")]
		public LookAtIK ik;

		[Token(Token = "0x4000AE1")]
		[FieldOffset(Offset = "0x18")]
		public float lerpSpeed;

		[Token(Token = "0x4000AE2")]
		[FieldOffset(Offset = "0x1C")]
		public float weightSpeed;

		[Token(Token = "0x4000AE3")]
		[FieldOffset(Offset = "0x20")]
		public bool isPaused;

		[Token(Token = "0x4000AE4")]
		[FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000AE5")]
		[FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000AE6")]
		[FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000AE7")]
		[FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x13A0B98", Offset = "0x13A0B98", VA = "0x13A0B98")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x13A0CBC", Offset = "0x13A0CBC", VA = "0x13A0CBC")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x13A0D78", Offset = "0x13A0D78", VA = "0x13A0D78")]
		public void Update()
		{
		}

		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x13A0F90", Offset = "0x13A0F90", VA = "0x13A0F90")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x13A1060", Offset = "0x13A1060", VA = "0x13A1060")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x13A1134", Offset = "0x13A1134", VA = "0x13A1134")]
		public InteractionLookAt()
		{
		}
	}
}
