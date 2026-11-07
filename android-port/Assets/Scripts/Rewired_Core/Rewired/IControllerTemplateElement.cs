using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x2000064")]
	public interface IControllerTemplateElement
	{
		[Token(Token = "0x1700010E")]
		int id
		{
			[Token(Token = "0x60002E1")]
			get;
		}

		[Token(Token = "0x1700010F")]
		string descriptiveName
		{
			[Token(Token = "0x60002E2")]
			get;
		}

		[Token(Token = "0x17000110")]
		ControllerTemplateElementType type
		{
			[Token(Token = "0x60002E3")]
			get;
		}

		[Token(Token = "0x17000111")]
		bool exists
		{
			[Token(Token = "0x60002E4")]
			get;
		}

		[Token(Token = "0x17000112")]
		IControllerTemplateElementSource source
		{
			[Token(Token = "0x60002E5")]
			get;
		}
	}
}
