using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Serializable]
	[Token(Token = "0x20012EA")]
	public class LanguageData
	{
		[Token(Token = "0x40065C2")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x40065C3")]
		[FieldOffset(Offset = "0x18")]
		public string Code;

		[Token(Token = "0x40065C4")]
		[FieldOffset(Offset = "0x20")]
		public byte Flags;

		[NonSerialized]
		[Token(Token = "0x40065C5")]
		[FieldOffset(Offset = "0x21")]
		public bool Compressed;

		[Token(Token = "0x60057B7")]
		[Address(RVA = "0x15023B0", Offset = "0x15023B0", VA = "0x15023B0")]
		public bool IsEnabled()
		{
			return default;
		}

		[Token(Token = "0x60057B8")]
		[Address(RVA = "0x15023C0", Offset = "0x15023C0", VA = "0x15023C0")]
		public bool IsLoaded()
		{
			return default;
		}

		[Token(Token = "0x60057B9")]
		[Address(RVA = "0x15023D0", Offset = "0x15023D0", VA = "0x15023D0")]
		public bool CanBeUnloaded()
		{
			return default;
		}

		[Token(Token = "0x60057BA")]
		[Address(RVA = "0x15023E0", Offset = "0x15023E0", VA = "0x15023E0")]
		public void SetLoaded(bool loaded)
		{
		}

		[Token(Token = "0x60057BB")]
		[Address(RVA = "0x1502400", Offset = "0x1502400", VA = "0x1502400")]
		public LanguageData()
		{
		}
	}
}
