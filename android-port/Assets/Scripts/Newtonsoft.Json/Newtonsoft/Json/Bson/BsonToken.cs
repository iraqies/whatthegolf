using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x200010C")]
	internal abstract class BsonToken
	{
		[Token(Token = "0x400037A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1886C4", Offset = "0x1886C4")]
		private BsonToken Parent__BackingField;

		[Token(Token = "0x1700019E")]
		public abstract BsonType Type
		{
			[Token(Token = "0x6000885")]
			get;
		}

		[Token(Token = "0x1700019F")]
		public BsonToken Parent
		{
			[Token(Token = "0x6000886")]
			[Address(RVA = "0x22AD980", Offset = "0x22AD980", VA = "0x22AD980")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x18B104", Offset = "0x18B104")]
			set
			{
			}
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x22AD934", Offset = "0x22AD934", VA = "0x22AD934")]
		protected BsonToken()
		{
		}
	}
}
