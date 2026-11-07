using Il2CppDummyDll;

namespace ZXing.Common
{
	[Token(Token = "0x200006B")]
	public interface ECIInput
	{
		[Token(Token = "0x1700005D")]
		int Length
		{
			[Token(Token = "0x6000283")]
			get;
		}

		[Token(Token = "0x6000284")]
		char charAt(int index);

		[Token(Token = "0x6000285")]
		string subSequence(int start, int end);

		[Token(Token = "0x6000286")]
		bool isECI(int index);

		[Token(Token = "0x6000287")]
		int getECIValue(int index);
	}
}
