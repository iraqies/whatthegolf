using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x2000114")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x184E70", Offset = "0x184E70")]
	public class BsonWriter : JsonWriter
	{
		[Token(Token = "0x4000399")]
		[FieldOffset(Offset = "0x60")]
		private BsonToken _root;

		[Token(Token = "0x400039A")]
		[FieldOffset(Offset = "0x68")]
		private BsonToken _parent;

		[Token(Token = "0x400039B")]
		[FieldOffset(Offset = "0x70")]
		private string _propertyName;

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x22AD990", Offset = "0x22AD990", VA = "0x22AD990")]
		private void AddValue(object value, BsonType type)
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x22ADA10", Offset = "0x22ADA10", VA = "0x22ADA10")]
		internal void AddToken(BsonToken token)
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x22AD500", Offset = "0x22AD500", VA = "0x22AD500")]
		public void WriteObjectId(byte[] value)
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x22ADC4C", Offset = "0x22ADC4C", VA = "0x22ADC4C")]
		public void WriteRegex(string pattern, string options)
		{
		}
	}
}
