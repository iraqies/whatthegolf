using Il2CppDummyDll;
using UnityEngine;

namespace Rewired
{
	[Token(Token = "0x2000067")]
	public interface IControllerTemplateStick : IControllerTemplateElement
	{
		[Token(Token = "0x1700011D")]
		Vector3 value
		{
			[Token(Token = "0x60002F0")]
			get;
		}

		[Token(Token = "0x1700011E")]
		Vector3 valuePrev
		{
			[Token(Token = "0x60002F1")]
			get;
		}

		[Token(Token = "0x1700011F")]
		IControllerTemplateAxis horizontal
		{
			[Token(Token = "0x60002F2")]
			get;
		}

		[Token(Token = "0x17000120")]
		IControllerTemplateAxis vertical
		{
			[Token(Token = "0x60002F3")]
			get;
		}

		[Token(Token = "0x17000121")]
		IControllerTemplateAxis rotation
		{
			[Token(Token = "0x60002F4")]
			get;
		}
	}
}
