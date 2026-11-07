using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x2000111")]
	internal class BsonRegex : BsonToken
	{
		[Token(Token = "0x4000380")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1886E4", Offset = "0x1886E4")]
		private BsonString Pattern__BackingField;

		[Token(Token = "0x4000381")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1886F4", Offset = "0x1886F4")]
		private BsonString Options__BackingField;

		[Token(Token = "0x170001A3")]
		public BsonString Pattern
		{
			[Token(Token = "0x600088F")]
			[Address(RVA = "0x22AD878", Offset = "0x22AD878", VA = "0x22AD878")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18B114", Offset = "0x18B114")]
			set
			{
			}
		}

		[Token(Token = "0x170001A4")]
		public BsonString Options
		{
			[Token(Token = "0x6000890")]
			[Address(RVA = "0x22AD880", Offset = "0x22AD880", VA = "0x22AD880")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18B124", Offset = "0x18B124")]
			set
			{
			}
		}

		[Token(Token = "0x170001A5")]
		public override BsonType Type
		{
			[Token(Token = "0x6000892")]
			[Address(RVA = "0x22AD93C", Offset = "0x22AD93C", VA = "0x22AD93C", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x22AD888", Offset = "0x22AD888", VA = "0x22AD888")]
		public BsonRegex(string pattern, string options)
		{
		}
	}
}
