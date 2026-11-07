using Il2CppDummyDll;
using UnityEngine;

namespace Rewired
{
	[Token(Token = "0x200006B")]
	public interface IControllerTemplateHat : IControllerTemplateElement
	{
		[Token(Token = "0x17000131")]
		Vector2 value
		{
			[Token(Token = "0x6000304")]
			get;
		}

		[Token(Token = "0x17000132")]
		Vector2 valuePrev
		{
			[Token(Token = "0x6000305")]
			get;
		}

		[Token(Token = "0x17000133")]
		IControllerTemplateButton up
		{
			[Token(Token = "0x6000306")]
			get;
		}

		[Token(Token = "0x17000134")]
		IControllerTemplateButton upRight
		{
			[Token(Token = "0x6000307")]
			get;
		}

		[Token(Token = "0x17000135")]
		IControllerTemplateButton right
		{
			[Token(Token = "0x6000308")]
			get;
		}

		[Token(Token = "0x17000136")]
		IControllerTemplateButton downRight
		{
			[Token(Token = "0x6000309")]
			get;
		}

		[Token(Token = "0x17000137")]
		IControllerTemplateButton down
		{
			[Token(Token = "0x600030A")]
			get;
		}

		[Token(Token = "0x17000138")]
		IControllerTemplateButton downLeft
		{
			[Token(Token = "0x600030B")]
			get;
		}

		[Token(Token = "0x17000139")]
		IControllerTemplateButton left
		{
			[Token(Token = "0x600030C")]
			get;
		}

		[Token(Token = "0x1700013A")]
		IControllerTemplateButton upLeft
		{
			[Token(Token = "0x600030D")]
			get;
		}
	}
}
