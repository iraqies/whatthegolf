using System.Reflection;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000C5")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x183F44", Offset = "0x183F44")]
	[Attribute(Name = "NullableAttribute", RVA = "0x183F44", Offset = "0x183F44")]
	public class ReflectionValueProvider : IValueProvider
	{
		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x10")]
		private readonly MemberInfo _memberInfo;

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x2320EAC", Offset = "0x2320EAC", VA = "0x2320EAC")]
		public ReflectionValueProvider(MemberInfo memberInfo)
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x2320F1C", Offset = "0x2320F1C", VA = "0x2320F1C", Slot = "4")]
		public void SetValue(object target, [Attribute(Name = "NullableAttribute", RVA = "0x18DCCC", Offset = "0x18DCCC")] object value)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x23210F4", Offset = "0x23210F4", VA = "0x23210F4", Slot = "5")]
		public object GetValue(object target)
		{
			return null;
		}
	}
}
