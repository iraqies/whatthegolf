using Il2CppDummyDll;
using UnityEngine;

namespace Rewired
{
	[Token(Token = "0x200006C")]
	public interface IControllerTemplateYoke : IControllerTemplateElement
	{
		[Token(Token = "0x1700013B")]
		Vector2 value
		{
			[Token(Token = "0x600030E")]
			get;
		}

		[Token(Token = "0x1700013C")]
		Vector2 valuePrev
		{
			[Token(Token = "0x600030F")]
			get;
		}

		[Token(Token = "0x1700013D")]
		IControllerTemplateAxis rotation
		{
			[Token(Token = "0x6000310")]
			get;
		}

		[Token(Token = "0x1700013E")]
		IControllerTemplateAxis pushPull
		{
			[Token(Token = "0x6000311")]
			get;
		}
	}
}
