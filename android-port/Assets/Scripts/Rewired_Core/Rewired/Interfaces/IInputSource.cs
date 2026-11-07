using System;
using System.Collections.Generic;

namespace Rewired.Interfaces
{
	internal interface IInputSource : IDisposable
	{
		event Action DeviceChangedEvent;

		void Update();

		void UpdateDevices(UpdateLoopType updateLoop);

		void UpdateFinished();

		IList<TJoy> GetJoysticks<TJoy>() where TJoy : class;
	}
}
