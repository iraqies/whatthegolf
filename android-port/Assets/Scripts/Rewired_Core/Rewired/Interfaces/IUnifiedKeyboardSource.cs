using Il2CppDummyDll;

namespace Rewired.Interfaces
{
	[Token(Token = "0x2000177")]
	internal interface IUnifiedKeyboardSource
	{
		[Token(Token = "0x1700036F")]
		InputSource inputSource
		{
			[Token(Token = "0x6000C3F")]
			get;
		}

		[Token(Token = "0x17000370")]
		HardwareControllerMap_Game hardwareMap
		{
			[Token(Token = "0x6000C40")]
			get;
		}

		[Token(Token = "0x17000371")]
		Controller.Extension controllerExtension
		{
			[Token(Token = "0x6000C41")]
			get;
		}

		[Token(Token = "0x6000C42")]
		void UpdateInputData(ControllerDataUpdater dataUpdater);
	}
}
