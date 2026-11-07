using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x200000E")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x18251C", Offset = "0x18251C")]
	public interface IArrayPool<T>
	{
		[Token(Token = "0x600000C")]
		T[] Rent(int minimumLength);

		[Token(Token = "0x600000D")]
		void Return([Attribute(Name = "NullableAttribute", RVA = "0x18B154", Offset = "0x18B154")] T[] array);
	}
}
