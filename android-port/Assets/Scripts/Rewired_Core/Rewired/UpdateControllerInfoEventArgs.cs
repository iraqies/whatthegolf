using System;
using Rewired.Interfaces;

namespace Rewired
{
	internal class UpdateControllerInfoEventArgs : EventArgs
	{
		public readonly IInputManagerJoystickPublic sourceJoystick;

		public UpdateControllerInfoEventArgs(IInputManagerJoystickPublic P_0)
		{
		}
	}
}
