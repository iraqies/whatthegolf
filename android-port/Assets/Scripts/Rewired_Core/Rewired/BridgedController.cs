using System;
using Il2CppDummyDll;
using Rewired.Interfaces;
using Rewired.Platforms.Custom;

namespace Rewired
{
	[Token(Token = "0x20000B2")]
	internal class BridgedController : BridgedControllerHWInfo
	{
		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0xB8")]
		public IInputManagerJoystickPublic sourceJoystick;

		[Token(Token = "0x40003E9")]
		[FieldOffset(Offset = "0xC0")]
		public HardwareControllerMap_Game gameHardwareMap;

		[Token(Token = "0x40003EA")]
		[FieldOffset(Offset = "0xC8")]
		public Guid controllerTypeGuid;

		[Token(Token = "0x40003EB")]
		[FieldOffset(Offset = "0xD8")]
		public Controller.Extension controllerExtension;

		[Token(Token = "0x40003EC")]
		[FieldOffset(Offset = "0xE0")]
		public string instanceName;

		[Token(Token = "0x40003ED")]
		[FieldOffset(Offset = "0xE8")]
		public string productName;

		[Token(Token = "0x40003EE")]
		[FieldOffset(Offset = "0xF0")]
		public bool isXInputDevice;

		[Token(Token = "0x40003EF")]
		[FieldOffset(Offset = "0xF4")]
		public int axisCount;

		[Token(Token = "0x40003F0")]
		[FieldOffset(Offset = "0xF8")]
		public int buttonCount;

		[Token(Token = "0x40003F1")]
		[FieldOffset(Offset = "0x100")]
		public bool[] isButtonPressureSensitive;

		[Token(Token = "0x40003F2")]
		[FieldOffset(Offset = "0x108")]
		public UnknownControllerHat[] unknownControllerHats;

		[Token(Token = "0x40003F3")]
		[FieldOffset(Offset = "0x110")]
		public CustomInputSource customInputSource;

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x234F824", Offset = "0x234F824", VA = "0x234F824")]
		public BridgedController()
		{
		}
	}
}
