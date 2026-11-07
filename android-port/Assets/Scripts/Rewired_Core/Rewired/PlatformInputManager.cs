using System;
using Il2CppDummyDll;
using Rewired.Interfaces;

namespace Rewired
{
	[Token(Token = "0x2000018")]
	internal abstract class PlatformInputManager
	{
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x10")]
		protected Action<BridgedController> _DeviceConnectedEvent;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x18")]
		protected Action<ControllerDisconnectedEventArgs> _DeviceDisconnectedEvent;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x20")]
		protected Action<UpdateControllerInfoEventArgs> _UpdateControllerInfoEvent;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x28")]
		protected Action _SystemDeviceConnectedEvent;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x30")]
		protected Action _SystemDeviceDisconnectedEvent;

		[Token(Token = "0x17000040")]
		public abstract PlatformInputManager primaryInputManager
		{
			[Token(Token = "0x6000095")]
			get;
		}

		[Token(Token = "0x17000041")]
		public abstract InputSource inputSourceType
		{
			[Token(Token = "0x6000096")]
			get;
		}

		[Token(Token = "0x14000001")]
		public event Action<BridgedController> DeviceConnectedEvent
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x23F0E48", Offset = "0x23F0E48", VA = "0x23F0E48")]
			add
			{
			}
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x23F0ECC", Offset = "0x23F0ECC", VA = "0x23F0ECC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event Action<ControllerDisconnectedEventArgs> DeviceDisconnectedEvent
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x23F0F50", Offset = "0x23F0F50", VA = "0x23F0F50")]
			add
			{
			}
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x23F0FD4", Offset = "0x23F0FD4", VA = "0x23F0FD4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event Action<UpdateControllerInfoEventArgs> UpdateControllerInfoEvent
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x23F1058", Offset = "0x23F1058", VA = "0x23F1058")]
			add
			{
			}
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x23F10DC", Offset = "0x23F10DC", VA = "0x23F10DC")]
			remove
			{
			}
		}

		[Token(Token = "0x6000097")]
		public abstract void Initialize();

		[Token(Token = "0x6000098")]
		public abstract void Update(UpdateLoopType currentUpdateLoop);

		[Token(Token = "0x6000099")]
		public abstract void OnDestroy();

		[Token(Token = "0x600009A")]
		public abstract void SystemDeviceConnected();

		[Token(Token = "0x600009B")]
		public abstract void SystemDeviceDisconnected();

		[Token(Token = "0x600009C")]
		public abstract void UpdateControllerData(int controllerId, ControllerDataUpdater data);

		[Token(Token = "0x600009D")]
		public abstract Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate();

		[Token(Token = "0x600009E")]
		public abstract void SetUnityJoystickId(int joystickId, int unityJoystickId);

		[Token(Token = "0x600009F")]
		public abstract IUnifiedMouseSource GetUnifiedMouseSource();

		[Token(Token = "0x60000A0")]
		public abstract IUnifiedKeyboardSource GetUnifiedKeyboardSource();

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x23DCBDC", Offset = "0x23DCBDC", VA = "0x23DCBDC")]
		protected PlatformInputManager()
		{
		}
	}
}
