using System.Dynamic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000054")]
	[Attribute(Name = "NullableAttribute", RVA = "0x182FD4", Offset = "0x182FD4")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x182FD4", Offset = "0x182FD4")]
	internal class NoThrowSetBinderMember : SetMemberBinder
	{
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x28")]
		private readonly SetMemberBinder _innerBinder;

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x231C894", Offset = "0x231C894", VA = "0x231C894")]
		public NoThrowSetBinderMember(SetMemberBinder innerBinder)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x231C8D0", Offset = "0x231C8D0", VA = "0x231C8D0", Slot = "9")]
		public override DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion)
		{
			return null;
		}
	}
}
