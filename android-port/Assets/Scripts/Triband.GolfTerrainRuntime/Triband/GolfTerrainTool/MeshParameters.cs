using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Triband.GolfTerrainTool
{
	[Serializable]
	[Token(Token = "0x2000006")]
	public sealed class MeshParameters : ScriptableObject
	{
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_BevelWidth;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1AFC14", Offset = "0x1AFC14")]
		[SerializeField]
		private float m_BevelAngle;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_SkirtExtent;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1AFC68", Offset = "0x1AFC68")]
		[SerializeField]
		private float m_SkirtAngle;

		[Token(Token = "0x1700001A")]
		public float bevelWidth
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x29FCADC", Offset = "0x29FCADC", VA = "0x29FCADC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x29FCAE4", Offset = "0x29FCAE4", VA = "0x29FCAE4")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public float bevelAngle
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x29FCAEC", Offset = "0x29FCAEC", VA = "0x29FCAEC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x29FCAF4", Offset = "0x29FCAF4", VA = "0x29FCAF4")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public float skirtExtent
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x29FCAFC", Offset = "0x29FCAFC", VA = "0x29FCAFC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x29FCB04", Offset = "0x29FCB04", VA = "0x29FCB04")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public float skirtAngle
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x29FCB0C", Offset = "0x29FCB0C", VA = "0x29FCB0C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x29FCB14", Offset = "0x29FCB14", VA = "0x29FCB14")]
			set
			{
			}
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x29FCAA4", Offset = "0x29FCAA4", VA = "0x29FCAA4")]
		public MeshParameters()
		{
		}
	}
}
