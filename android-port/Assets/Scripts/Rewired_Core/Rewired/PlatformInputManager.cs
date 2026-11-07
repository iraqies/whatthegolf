using System;
using Rewired.Interfaces;

namespace Rewired
{
	internal abstract class PlatformInputManager
	{
		protected Action<BridgedController> _DeviceConnectedEvent;

		protected Action<ControllerDisconnectedEventArgs> _DeviceDisconnectedEvent;

		protected Action<UpdateControllerInfoEventArgs> _UpdateControllerInfoEvent;

		protected Action _SystemDeviceConnectedEvent;

		protected Action _SystemDeviceDisconnectedEvent;

		public abstract PlatformInputManager primaryInputManager { get; }

		public abstract InputSource inputSourceType { get; }

		public event Action<BridgedController> DeviceConnectedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<ControllerDisconnectedEventArgs> DeviceDisconnectedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<UpdateControllerInfoEventArgs> UpdateControllerInfoEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public abstract void Initialize();

		public abstract void Update(UpdateLoopType currentUpdateLoop);

		public abstract void OnDestroy();

		public abstract void SystemDeviceConnected();

		public abstract void SystemDeviceDisconnected();

		public abstract void UpdateControllerData(int controllerId, ControllerDataUpdater data);

		public abstract Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate();

		public abstract void SetUnityJoystickId(int joystickId, int unityJoystickId);

		public abstract IUnifiedMouseSource GetUnifiedMouseSource();

		public abstract IUnifiedKeyboardSource GetUnifiedKeyboardSource();
	}
}
