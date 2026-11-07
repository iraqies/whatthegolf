using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x200000D")]
	public enum TestEnum
	{
		[Token(Token = "0x400002F")]
		None = 0,
		[Token(Token = "0x4000030")]
		B = 1,
		[Token(Token = "0x4000031")]
		C = 2,
		[Token(Token = "0x4000032")]
		D = 4,
		[Token(Token = "0x4000033")]
		E = 8,
		[Token(Token = "0x4000034")]
		F = 16,
		[Token(Token = "0x4000035")]
		All = -1
	}
}
