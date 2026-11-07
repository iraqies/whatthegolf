using System;

namespace Rewired.Interfaces
{
	internal interface IInputManagerJoystickPublic
	{
		int rewiredId { get; }

		int inputManagerId { get; }

		string name { get; }

		long? systemId { get; }

		int unityId { get; }

		Controller.Extension extension { get; }

		Guid persistentGuid { get; }

		void SetVibration(float amount, int motorIndex);

		void StopVibration();
	}
}
