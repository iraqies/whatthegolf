using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	[Token(Token = "0x200010D")]
	internal class BsonObject : BsonToken
	{
		[Token(Token = "0x400037B")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<BsonProperty> _children;

		[Token(Token = "0x170001A0")]
		public override BsonType Type
		{
			[Token(Token = "0x6000889")]
			[Address(RVA = "0x22AD2EC", Offset = "0x22AD2EC", VA = "0x22AD2EC", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x22AD1BC", Offset = "0x22AD1BC", VA = "0x22AD1BC")]
		public void Add(string name, BsonToken token)
		{
		}
	}
}
