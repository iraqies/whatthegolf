using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x200015D")]
	public class FABRIKChain
	{
		[Token(Token = "0x4000864")]
		[FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x4000865")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35D1C", Offset = "0x35D1C")]
		public float pull;

		[Token(Token = "0x4000866")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35D34", Offset = "0x35D34")]
		public float pin;

		[Token(Token = "0x4000867")]
		[FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x1368D00", Offset = "0x1368D00", VA = "0x1368D00")]
		public bool IsValid(ref string message)
		{
			return default;
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x1368DD8", Offset = "0x1368DD8", VA = "0x1368DD8")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x1368DF8", Offset = "0x1368DF8", VA = "0x1368DF8")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x136908C", Offset = "0x136908C", VA = "0x136908C")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x1368ED0", Offset = "0x1368ED0", VA = "0x1368ED0")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default;
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x1369184", Offset = "0x1369184", VA = "0x1369184")]
		public FABRIKChain()
		{
		}
	}
}
