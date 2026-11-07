using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x200009F")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x1839A8", Offset = "0x1839A8")]
	public interface IValueProvider
	{
		[Token(Token = "0x60003D9")]
		void SetValue(object target, [Attribute(Name = "NullableAttribute", RVA = "0x18CBD0", Offset = "0x18CBD0")] object value);

		[Token(Token = "0x60003DA")]
		object GetValue(object target);
	}
}
