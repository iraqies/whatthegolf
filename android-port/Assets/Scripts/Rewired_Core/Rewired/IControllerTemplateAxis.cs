using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x2000066")]
	public interface IControllerTemplateAxis : IControllerTemplateElement
	{
		[Token(Token = "0x1700011A")]
		float value
		{
			[Token(Token = "0x60002ED")]
			get;
		}

		[Token(Token = "0x1700011B")]
		float valuePrev
		{
			[Token(Token = "0x60002EE")]
			get;
		}

		[Token(Token = "0x1700011C")]
		new IControllerTemplateAxisSource source
		{
			[Token(Token = "0x60002EF")]
			get;
		}
	}
}
