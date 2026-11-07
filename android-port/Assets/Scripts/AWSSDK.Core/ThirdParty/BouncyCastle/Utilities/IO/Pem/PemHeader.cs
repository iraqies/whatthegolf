using Il2CppDummyDll;

namespace ThirdParty.BouncyCastle.Utilities.IO.Pem
{
	[Token(Token = "0x2000006")]
	public class PemHeader
	{
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x10")]
		private string name;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x18")]
		private string val;

		[Token(Token = "0x17000002")]
		public virtual string Name
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x1248540", Offset = "0x1248540", VA = "0x1248540", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		public virtual string Value
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x1248548", Offset = "0x1248548", VA = "0x1248548", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1248508", Offset = "0x1248508", VA = "0x1248508")]
		public PemHeader(string name, string val)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1248550", Offset = "0x1248550", VA = "0x1248550", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x12485D8", Offset = "0x12485D8", VA = "0x12485D8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x12485B8", Offset = "0x12485B8", VA = "0x12485B8")]
		private int GetHashCode(string s)
		{
			return default;
		}
	}
}
