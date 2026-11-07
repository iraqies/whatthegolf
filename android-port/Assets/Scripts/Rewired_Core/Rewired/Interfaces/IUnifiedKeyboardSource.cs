namespace Rewired.Interfaces
{
	internal interface IUnifiedKeyboardSource
	{
		InputSource inputSource { get; }

		HardwareControllerMap_Game hardwareMap { get; }

		Controller.Extension controllerExtension { get; }

		void UpdateInputData(ControllerDataUpdater dataUpdater);
	}
}
