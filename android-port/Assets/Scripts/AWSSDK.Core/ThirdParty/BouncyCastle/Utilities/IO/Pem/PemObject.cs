using System.Collections;
using Il2CppDummyDll;

namespace ThirdParty.BouncyCastle.Utilities.IO.Pem
{
	[Token(Token = "0x2000007")]
	public class PemObject : PemObjectGenerator
	{
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x10")]
		private string type;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x18")]
		private IList headers;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x20")]
		private byte[] content;

		[Token(Token = "0x17000004")]
		public string Type
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x1248C24", Offset = "0x1248C24", VA = "0x1248C24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		public IList Headers
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x1248C2C", Offset = "0x1248C2C", VA = "0x1248C2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public byte[] Content
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x1248C34", Offset = "0x1248C34", VA = "0x1248C34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x124869C", Offset = "0x124869C", VA = "0x124869C")]
		public PemObject(string type, byte[] content)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x12487B0", Offset = "0x12487B0", VA = "0x12487B0")]
		public PemObject(string type, IList headers, byte[] content)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1248C3C", Offset = "0x1248C3C", VA = "0x1248C3C", Slot = "4")]
		public PemObject Generate()
		{
			return null;
		}
	}
}
