using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x20000B0")]
	public interface IControllerElementTarget
	{
		[Token(Token = "0x1700018B")]
		int elementIdentifierId
		{
			[Token(Token = "0x60003E1")]
			get;
		}

		[Token(Token = "0x1700018C")]
		AxisRange axisRange
		{
			[Token(Token = "0x60003E2")]
			get;
		}

		[Token(Token = "0x1700018D")]
		bool hasTarget
		{
			[Token(Token = "0x60003E3")]
			get;
		}

		[Token(Token = "0x1700018E")]
		ControllerElementType elementType
		{
			[Token(Token = "0x60003E4")]
			get;
		}

		[Token(Token = "0x1700018F")]
		string descriptiveName
		{
			[Token(Token = "0x60003E5")]
			get;
		}

		[Token(Token = "0x17000190")]
		Controller controller
		{
			[Token(Token = "0x60003E6")]
			get;
		}

		[Token(Token = "0x17000191")]
		Controller.Element element
		{
			[Token(Token = "0x60003E7")]
			get;
		}
	}
}
