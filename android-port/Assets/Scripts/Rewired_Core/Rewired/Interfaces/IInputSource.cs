using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Rewired.Interfaces
{
	[Token(Token = "0x2000173")]
	internal interface IInputSource : IDisposable
	{
		[Token(Token = "0x1400001C")]
		event Action DeviceChangedEvent;

		[Token(Token = "0x6000C2F")]
		void Update();

		[Token(Token = "0x6000C30")]
		void UpdateDevices(UpdateLoopType updateLoop);

		[Token(Token = "0x6000C31")]
		void UpdateFinished();

		[Token(Token = "0x6000C32")]
		IList<TJoy> GetJoysticks<TJoy>() where TJoy : class;
	}
}
