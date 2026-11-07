using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x200006F")]
	public interface IControllerTemplateAxisSource : IControllerTemplateElementSource
	{
		[Token(Token = "0x1700014A")]
		bool splitAxis
		{
			[Token(Token = "0x600031D")]
			get;
		}

		[Token(Token = "0x1700014B")]
		IControllerElementTarget fullTarget
		{
			[Token(Token = "0x600031E")]
			get;
		}

		[Token(Token = "0x1700014C")]
		IControllerElementTarget positiveTarget
		{
			[Token(Token = "0x600031F")]
			get;
		}

		[Token(Token = "0x1700014D")]
		IControllerElementTarget negativeTarget
		{
			[Token(Token = "0x6000320")]
			get;
		}
	}
}
