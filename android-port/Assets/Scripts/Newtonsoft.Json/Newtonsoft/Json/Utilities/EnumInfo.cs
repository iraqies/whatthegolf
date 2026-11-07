using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000056")]
	[Attribute(Name = "NullableAttribute", RVA = "0x183054", Offset = "0x183054")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x183054", Offset = "0x183054")]
	internal class EnumInfo
	{
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x10")]
		public readonly bool IsFlags;

		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x18")]
		public readonly ulong[] Values;

		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x20")]
		public readonly string[] Names;

		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x28")]
		public readonly string[] ResolvedNames;

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x22C538C", Offset = "0x22C538C", VA = "0x22C538C")]
		public EnumInfo(bool isFlags, ulong[] values, string[] names, string[] resolvedNames)
		{
		}
	}
}
