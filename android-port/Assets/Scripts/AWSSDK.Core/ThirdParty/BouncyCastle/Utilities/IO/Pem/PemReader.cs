using System.IO;
using Il2CppDummyDll;

namespace ThirdParty.BouncyCastle.Utilities.IO.Pem
{
	[Token(Token = "0x200000A")]
	public class PemReader
	{
		[Token(Token = "0x4000016")]
		private const string BeginString = "-----BEGIN ";

		[Token(Token = "0x4000017")]
		private const string EndString = "-----END ";

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x10")]
		private readonly TextReader reader;

		[Token(Token = "0x17000007")]
		public TextReader Reader
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x1249724", Offset = "0x1249724", VA = "0x1249724")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1248C44", Offset = "0x1248C44", VA = "0x1248C44")]
		public PemReader(TextReader reader)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1248E2C", Offset = "0x1248E2C", VA = "0x1248E2C")]
		public PemObject ReadPemObject()
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x124972C", Offset = "0x124972C", VA = "0x124972C")]
		private PemObject LoadObject(string type)
		{
			return null;
		}
	}
}
