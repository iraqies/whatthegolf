using UnityEngine;

namespace Rewired.Interfaces
{
	internal interface IUnifiedMouseSource
	{
		InputSource inputSource { get; }

		HardwareControllerMap_Game hardwareMap { get; }

		int axisCount { get; }

		int buttonCount { get; }

		Vector2 mousePosition { get; }

		Controller.Extension controllerExtension { get; }

		void UpdateInputData(ControllerDataUpdater dataUpdater);
	}
}
