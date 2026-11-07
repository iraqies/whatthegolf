using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x200010E")]
	internal class BsonArray : BsonToken
	{
		[Token(Token = "0x400037C")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<BsonToken> _children;

		[Token(Token = "0x170001A1")]
		public override BsonType Type
		{
			[Token(Token = "0x600088B")]
			[Address(RVA = "0x22AD1B4", Offset = "0x22AD1B4", VA = "0x22AD1B4", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x22AD144", Offset = "0x22AD144", VA = "0x22AD144")]
		public void Add(BsonToken token)
		{
		}
	}
}
