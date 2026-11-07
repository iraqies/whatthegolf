using Il2CppDummyDll;

namespace Amazon.Runtime.SharedInterfaces
{
	[Token(Token = "0x200010A")]
	public class GenerateDataKeyResult
	{
		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26D68", Offset = "0x26D68")]
		private byte[] KeyPlaintext__BackingField;

		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26D78", Offset = "0x26D78")]
		private byte[] KeyCiphertext__BackingField;

		[Token(Token = "0x17000265")]
		public byte[] KeyPlaintext
		{
			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x120CD74", Offset = "0x120CD74", VA = "0x120CD74")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2980C", Offset = "0x2980C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x120CD7C", Offset = "0x120CD7C", VA = "0x120CD7C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2981C", Offset = "0x2981C")]
			set
			{
			}
		}

		[Token(Token = "0x17000266")]
		public byte[] KeyCiphertext
		{
			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x120CD84", Offset = "0x120CD84", VA = "0x120CD84")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2982C", Offset = "0x2982C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x120CD8C", Offset = "0x120CD8C", VA = "0x120CD8C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2983C", Offset = "0x2983C")]
			set
			{
			}
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x120CD94", Offset = "0x120CD94", VA = "0x120CD94")]
		public GenerateDataKeyResult()
		{
		}
	}
}
