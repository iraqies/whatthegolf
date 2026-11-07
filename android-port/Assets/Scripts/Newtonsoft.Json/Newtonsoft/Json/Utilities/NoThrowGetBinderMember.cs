using System.Dynamic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000053")]
	[Attribute(Name = "NullableAttribute", RVA = "0x182F94", Offset = "0x182F94")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x182F94", Offset = "0x182F94")]
	internal class NoThrowGetBinderMember : GetMemberBinder
	{
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x28")]
		private readonly GetMemberBinder _innerBinder;

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x231C6E0", Offset = "0x231C6E0", VA = "0x231C6E0")]
		public NoThrowGetBinderMember(GetMemberBinder innerBinder)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x231C71C", Offset = "0x231C71C", VA = "0x231C71C", Slot = "9")]
		public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion)
		{
			return null;
		}
	}
}
