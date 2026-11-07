using Il2CppDummyDll;
using UnityEngine;

namespace Rewired
{
	[Token(Token = "0x200006D")]
	public interface IControllerTemplateStick6D : IControllerTemplateElement
	{
		[Token(Token = "0x1700013F")]
		Vector3 position
		{
			[Token(Token = "0x6000312")]
			get;
		}

		[Token(Token = "0x17000140")]
		Vector3 positionPrev
		{
			[Token(Token = "0x6000313")]
			get;
		}

		[Token(Token = "0x17000141")]
		Vector3 rotation
		{
			[Token(Token = "0x6000314")]
			get;
		}

		[Token(Token = "0x17000142")]
		Vector3 rotationPrev
		{
			[Token(Token = "0x6000315")]
			get;
		}

		[Token(Token = "0x17000143")]
		IControllerTemplateAxis positionX
		{
			[Token(Token = "0x6000316")]
			get;
		}

		[Token(Token = "0x17000144")]
		IControllerTemplateAxis positionY
		{
			[Token(Token = "0x6000317")]
			get;
		}

		[Token(Token = "0x17000145")]
		IControllerTemplateAxis positionZ
		{
			[Token(Token = "0x6000318")]
			get;
		}

		[Token(Token = "0x17000146")]
		IControllerTemplateAxis rotationX
		{
			[Token(Token = "0x6000319")]
			get;
		}

		[Token(Token = "0x17000147")]
		IControllerTemplateAxis rotationY
		{
			[Token(Token = "0x600031A")]
			get;
		}

		[Token(Token = "0x17000148")]
		IControllerTemplateAxis rotationZ
		{
			[Token(Token = "0x600031B")]
			get;
		}
	}
}
