using Il2CppDummyDll;
using UnityEngine;

namespace Rewired
{
	[Token(Token = "0x2000069")]
	public interface IControllerTemplateDPad : IControllerTemplateElement
	{
		[Token(Token = "0x17000127")]
		Vector2 value
		{
			[Token(Token = "0x60002FA")]
			get;
		}

		[Token(Token = "0x17000128")]
		Vector2 valuePrev
		{
			[Token(Token = "0x60002FB")]
			get;
		}

		[Token(Token = "0x17000129")]
		IControllerTemplateButton up
		{
			[Token(Token = "0x60002FC")]
			get;
		}

		[Token(Token = "0x1700012A")]
		IControllerTemplateButton right
		{
			[Token(Token = "0x60002FD")]
			get;
		}

		[Token(Token = "0x1700012B")]
		IControllerTemplateButton down
		{
			[Token(Token = "0x60002FE")]
			get;
		}

		[Token(Token = "0x1700012C")]
		IControllerTemplateButton left
		{
			[Token(Token = "0x60002FF")]
			get;
		}
	}
}
