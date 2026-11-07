using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Interfaces
{
	[Token(Token = "0x2000176")]
	internal interface IUnifiedMouseSource
	{
		[Token(Token = "0x17000369")]
		InputSource inputSource
		{
			[Token(Token = "0x6000C38")]
			get;
		}

		[Token(Token = "0x1700036A")]
		HardwareControllerMap_Game hardwareMap
		{
			[Token(Token = "0x6000C39")]
			get;
		}

		[Token(Token = "0x1700036B")]
		int axisCount
		{
			[Token(Token = "0x6000C3A")]
			get;
		}

		[Token(Token = "0x1700036C")]
		int buttonCount
		{
			[Token(Token = "0x6000C3B")]
			get;
		}

		[Token(Token = "0x1700036D")]
		Vector2 mousePosition
		{
			[Token(Token = "0x6000C3C")]
			get;
		}

		[Token(Token = "0x1700036E")]
		Controller.Extension controllerExtension
		{
			[Token(Token = "0x6000C3D")]
			get;
		}

		[Token(Token = "0x6000C3E")]
		void UpdateInputData(ControllerDataUpdater dataUpdater);
	}
}
