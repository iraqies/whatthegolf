using Il2CppDummyDll;
using UnityEngine;

namespace Triband.GolfTerrainTool
{
	[Token(Token = "0x2000003")]
	public sealed class Brush : ScriptableObject
	{
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BrushShape m_Shape;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_Size;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Attribute(Name = "RangeAttribute", RVA = "0x1AFAF0", Offset = "0x1AFAF0")]
		private float m_Round;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Attribute(Name = "RangeAttribute", RVA = "0x1AFB30", Offset = "0x1AFB30")]
		private float m_AspectRatio;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Attribute(Name = "RangeAttribute", RVA = "0x1AFB70", Offset = "0x1AFB70")]
		private float m_Rotation;

		[Token(Token = "0x17000009")]
		public BrushShape shape
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x29FA3F4", Offset = "0x29FA3F4", VA = "0x29FA3F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x29FA3FC", Offset = "0x29FA3FC", VA = "0x29FA3FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public float size
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x29FA404", Offset = "0x29FA404", VA = "0x29FA404")]
			get
			{
				return default;
			}
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x29FA40C", Offset = "0x29FA40C", VA = "0x29FA40C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public float round
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x29FA414", Offset = "0x29FA414", VA = "0x29FA414")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x29FA41C", Offset = "0x29FA41C", VA = "0x29FA41C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public float aspectRatio
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x29FA424", Offset = "0x29FA424", VA = "0x29FA424")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x29FA42C", Offset = "0x29FA42C", VA = "0x29FA42C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public float rotation
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x29FA434", Offset = "0x29FA434", VA = "0x29FA434")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x29FA43C", Offset = "0x29FA43C", VA = "0x29FA43C")]
			set
			{
			}
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x29FA3B8", Offset = "0x29FA3B8", VA = "0x29FA3B8")]
		public Brush()
		{
		}
	}
}
