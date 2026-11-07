using Il2CppDummyDll;
using UnityEngine;

namespace Rewired
{
	[Token(Token = "0x2000068")]
	public interface IControllerTemplateThumbStick : IControllerTemplateElement
	{
		[Token(Token = "0x17000122")]
		Vector2 value
		{
			[Token(Token = "0x60002F5")]
			get;
		}

		[Token(Token = "0x17000123")]
		Vector2 valuePrev
		{
			[Token(Token = "0x60002F6")]
			get;
		}

		[Token(Token = "0x17000124")]
		IControllerTemplateAxis horizontal
		{
			[Token(Token = "0x60002F7")]
			get;
		}

		[Token(Token = "0x17000125")]
		IControllerTemplateAxis vertical
		{
			[Token(Token = "0x60002F8")]
			get;
		}

		[Token(Token = "0x17000126")]
		IControllerTemplateButton press
		{
			[Token(Token = "0x60002F9")]
			get;
		}
	}
}
