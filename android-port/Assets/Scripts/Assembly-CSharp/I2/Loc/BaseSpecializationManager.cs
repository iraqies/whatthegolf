using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x20012E2")]
	public class BaseSpecializationManager
	{
		[Token(Token = "0x40065AF")]
		[FieldOffset(Offset = "0x10")]
		public string[] mSpecializations;

		[Token(Token = "0x40065B0")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, string> mSpecializationsFallbacks;

		[Token(Token = "0x600579E")]
		[Address(RVA = "0x1608D28", Offset = "0x1608D28", VA = "0x1608D28", Slot = "4")]
		public virtual void InitializeSpecializations()
		{
		}

		[Token(Token = "0x600579F")]
		[Address(RVA = "0x16091C0", Offset = "0x16091C0", VA = "0x16091C0", Slot = "5")]
		public virtual string GetCurrentSpecialization()
		{
			return null;
		}

		[Token(Token = "0x60057A0")]
		[Address(RVA = "0x1609224", Offset = "0x1609224", VA = "0x1609224", Slot = "6")]
		public virtual string GetFallbackSpecialization(string specialization)
		{
			return null;
		}

		[Token(Token = "0x60057A1")]
		[Address(RVA = "0x16092D8", Offset = "0x16092D8", VA = "0x16092D8")]
		public BaseSpecializationManager()
		{
		}
	}
}
