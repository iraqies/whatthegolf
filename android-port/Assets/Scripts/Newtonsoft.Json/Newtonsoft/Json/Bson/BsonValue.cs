using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x200010F")]
	internal class BsonValue : BsonToken
	{
		[Token(Token = "0x400037D")]
		[FieldOffset(Offset = "0x18")]
		private readonly object _value;

		[Token(Token = "0x400037E")]
		[FieldOffset(Offset = "0x20")]
		private readonly BsonType _type;

		[Token(Token = "0x170001A2")]
		public override BsonType Type
		{
			[Token(Token = "0x600088D")]
			[Address(RVA = "0x22AD988", Offset = "0x22AD988", VA = "0x22AD988", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x22AD944", Offset = "0x22AD944", VA = "0x22AD944")]
		public BsonValue(object value, BsonType type)
		{
		}
	}
}
