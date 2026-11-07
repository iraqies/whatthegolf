using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Kilt.EasyRopes2D
{
	[Serializable]
	[Token(Token = "0x200009A")]
	public class RopesByBallons
	{
		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Rope2D m_rope;

		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<BalloonProperty> m_directBallons;

		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<BalloonProperty> m_indirectBallons;

		[Token(Token = "0x17000065")]
		public Rope2D Rope
		{
			[Token(Token = "0x600030E")]
			[Address(RVA = "0x13F2194", Offset = "0x13F2194", VA = "0x13F2194")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		public List<BalloonProperty> DirectBallons
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x13F219C", Offset = "0x13F219C", VA = "0x13F219C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000310")]
			[Address(RVA = "0x13F2218", Offset = "0x13F2218", VA = "0x13F2218")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public List<BalloonProperty> IndirectBallons
		{
			[Token(Token = "0x6000311")]
			[Address(RVA = "0x13F2220", Offset = "0x13F2220", VA = "0x13F2220")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x13F229C", Offset = "0x13F229C", VA = "0x13F229C")]
			set
			{
			}
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x13F22A4", Offset = "0x13F22A4", VA = "0x13F22A4")]
		public RopesByBallons()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x13F233C", Offset = "0x13F233C", VA = "0x13F233C")]
		public RopesByBallons(Rope2D p_rope)
		{
		}
	}
}
