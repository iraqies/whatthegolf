using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x200000F")]
	public interface IJsonLineInfo
	{
		[Token(Token = "0x17000001")]
		int LineNumber
		{
			[Token(Token = "0x600000F")]
			get;
		}

		[Token(Token = "0x17000002")]
		int LinePosition
		{
			[Token(Token = "0x6000010")]
			get;
		}

		[Token(Token = "0x600000E")]
		bool HasLineInfo();
	}
}
