using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x2000065")]
	public interface IControllerTemplateButton : IControllerTemplateElement
	{
		[Token(Token = "0x17000113")]
		bool value
		{
			[Token(Token = "0x60002E6")]
			get;
		}

		[Token(Token = "0x17000114")]
		bool valuePrev
		{
			[Token(Token = "0x60002E7")]
			get;
		}

		[Token(Token = "0x17000115")]
		float pressure
		{
			[Token(Token = "0x60002E8")]
			get;
		}

		[Token(Token = "0x17000116")]
		float pressurePrev
		{
			[Token(Token = "0x60002E9")]
			get;
		}

		[Token(Token = "0x17000117")]
		bool justPressed
		{
			[Token(Token = "0x60002EA")]
			get;
		}

		[Token(Token = "0x17000118")]
		bool justReleased
		{
			[Token(Token = "0x60002EB")]
			get;
		}

		[Token(Token = "0x17000119")]
		new IControllerTemplateButtonSource source
		{
			[Token(Token = "0x60002EC")]
			get;
		}
	}
}
