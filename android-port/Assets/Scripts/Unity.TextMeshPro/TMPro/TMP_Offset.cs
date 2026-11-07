using Il2CppDummyDll;

namespace TMPro
{
	[Token(Token = "0x200000C")]
	public struct TMP_Offset
	{
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x0")]
		private float m_Left;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x4")]
		private float m_Right;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x8")]
		private float m_Top;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0xC")]
		private float m_Bottom;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x0")]
		private static readonly TMP_Offset k_ZeroOffset;

		[Token(Token = "0x17000003")]
		public float left
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x2A9B7C0", Offset = "0x2A9B7C0", VA = "0x2A9B7C0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000004")]
		public float right
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x2A9B7C8", Offset = "0x2A9B7C8", VA = "0x2A9B7C8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000005")]
		public float top
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x2A9B7D0", Offset = "0x2A9B7D0", VA = "0x2A9B7D0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000006")]
		public float bottom
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x2A9B7D8", Offset = "0x2A9B7D8", VA = "0x2A9B7D8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000007")]
		public static TMP_Offset zero
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x2A9B7E0", Offset = "0x2A9B7E0", VA = "0x2A9B7E0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2A9B848", Offset = "0x2A9B848", VA = "0x2A9B848")]
		public TMP_Offset(float left, float right, float top, float bottom)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2A9B854", Offset = "0x2A9B854", VA = "0x2A9B854")]
		public static bool operator ==(TMP_Offset lhs, TMP_Offset rhs)
		{
			return default;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2A9B878", Offset = "0x2A9B878", VA = "0x2A9B878")]
		public static TMP_Offset operator *(TMP_Offset a, float b)
		{
			return default;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2A9B88C", Offset = "0x2A9B88C", VA = "0x2A9B88C", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2A9B904", Offset = "0x2A9B904", VA = "0x2A9B904", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}
	}
}
