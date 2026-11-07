using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Token(Token = "0x200000D")]
	public struct HighlightState
	{
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x0")]
		public Color32 color;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x4")]
		public TMP_Offset padding;

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2A7A530", Offset = "0x2A7A530", VA = "0x2A7A530")]
		public HighlightState(Color32 color, TMP_Offset padding)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2A7A540", Offset = "0x2A7A540", VA = "0x2A7A540")]
		public static bool operator ==(HighlightState lhs, HighlightState rhs)
		{
			return default;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2A7A650", Offset = "0x2A7A650", VA = "0x2A7A650")]
		public static bool operator !=(HighlightState lhs, HighlightState rhs)
		{
			return default;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2A7A730", Offset = "0x2A7A730", VA = "0x2A7A730", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2A7A7B0", Offset = "0x2A7A7B0", VA = "0x2A7A7B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}
	}
}
