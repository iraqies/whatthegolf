using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x200006A")]
	public interface IControllerTemplateThrottle : IControllerTemplateElement
	{
		[Token(Token = "0x1700012D")]
		float value
		{
			[Token(Token = "0x6000300")]
			get;
		}

		[Token(Token = "0x1700012E")]
		float valuePrev
		{
			[Token(Token = "0x6000301")]
			get;
		}

		[Token(Token = "0x1700012F")]
		IControllerTemplateAxis throttle
		{
			[Token(Token = "0x6000302")]
			get;
		}

		[Token(Token = "0x17000130")]
		IControllerTemplateButton minDetent
		{
			[Token(Token = "0x6000303")]
			get;
		}
	}
}
