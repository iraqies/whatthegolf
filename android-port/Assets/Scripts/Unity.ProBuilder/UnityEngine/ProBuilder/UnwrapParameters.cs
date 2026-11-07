using System;
using Il2CppDummyDll;

namespace UnityEngine.ProBuilder
{
	[Serializable]
	[Token(Token = "0x2000022")]
	public sealed class UnwrapParameters
	{
		[Token(Token = "0x40000A3")]
		internal const float k_HardAngle = 88f;

		[Token(Token = "0x40000A4")]
		internal const float k_PackMargin = 20f;

		[Token(Token = "0x40000A5")]
		internal const float k_AngleError = 8f;

		[Token(Token = "0x40000A6")]
		internal const float k_AreaError = 15f;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1B65E4", Offset = "0x1B65E4")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B65E4", Offset = "0x1B65E4")]
		private float m_HardAngle;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1B664C", Offset = "0x1B664C")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B664C", Offset = "0x1B664C")]
		private float m_PackMargin;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1B66B4", Offset = "0x1B66B4")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B66B4", Offset = "0x1B66B4")]
		[SerializeField]
		private float m_AngleError;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B671C", Offset = "0x1B671C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x1B671C", Offset = "0x1B671C")]
		private float m_AreaError;

		[Token(Token = "0x17000050")]
		public float hardAngle
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x2A5A1CC", Offset = "0x2A5A1CC", VA = "0x2A5A1CC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x2A5A1D4", Offset = "0x2A5A1D4", VA = "0x2A5A1D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public float packMargin
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x2A5A1DC", Offset = "0x2A5A1DC", VA = "0x2A5A1DC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x2A5A1E4", Offset = "0x2A5A1E4", VA = "0x2A5A1E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public float angleError
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x2A5A1EC", Offset = "0x2A5A1EC", VA = "0x2A5A1EC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x2A5A1F4", Offset = "0x2A5A1F4", VA = "0x2A5A1F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public float areaError
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x2A5A1FC", Offset = "0x2A5A1FC", VA = "0x2A5A1FC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x2A5A204", Offset = "0x2A5A204", VA = "0x2A5A204")]
			set
			{
			}
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2A5A20C", Offset = "0x2A5A20C", VA = "0x2A5A20C")]
		public UnwrapParameters()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2A54234", Offset = "0x2A54234", VA = "0x2A54234")]
		public UnwrapParameters(UnwrapParameters other)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2A5A250", Offset = "0x2A5A250", VA = "0x2A5A250")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2A5A268", Offset = "0x2A5A268", VA = "0x2A5A268", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
