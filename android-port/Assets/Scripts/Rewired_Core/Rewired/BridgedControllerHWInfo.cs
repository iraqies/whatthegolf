using System;
using Il2CppDummyDll;
using Rewired.Platforms;

namespace Rewired
{
	[Token(Token = "0x20000B1")]
	internal class BridgedControllerHWInfo
	{
		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x10")]
		public bool isMock;

		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0x14")]
		public InputSource inputManagerSource;

		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x18")]
		public InputSource inputSource;

		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0x1C")]
		public ControlDeviceType deviceType;

		[Token(Token = "0x40003CE")]
		[FieldOffset(Offset = "0x20")]
		public string hardwareIdentifier;

		[Token(Token = "0x40003CF")]
		[FieldOffset(Offset = "0x28")]
		public int hardwareAxisCount;

		[Token(Token = "0x40003D0")]
		[FieldOffset(Offset = "0x2C")]
		public int hardwareButtonCount;

		[Token(Token = "0x40003D1")]
		[FieldOffset(Offset = "0x30")]
		public int hardwareHatCount;

		[Token(Token = "0x40003D2")]
		[FieldOffset(Offset = "0x38")]
		public string hw_productName;

		[Token(Token = "0x40003D3")]
		[FieldOffset(Offset = "0x40")]
		public PidVid hw_pidVid;

		[Token(Token = "0x40003D4")]
		[FieldOffset(Offset = "0x44")]
		public Guid hw_deviceGuid;

		[Token(Token = "0x40003D5")]
		[FieldOffset(Offset = "0x54")]
		public int hw_productId;

		[Token(Token = "0x40003D6")]
		[FieldOffset(Offset = "0x58")]
		public string hw_bluetoothDeviceName;

		[Token(Token = "0x40003D7")]
		[FieldOffset(Offset = "0x60")]
		public bool hw_isBluetoothDevice;

		[Token(Token = "0x40003D8")]
		[FieldOffset(Offset = "0x61")]
		public bool hw_supportsVoice;

		[Token(Token = "0x40003D9")]
		[FieldOffset(Offset = "0x62")]
		public bool hw_supportsVibration;

		[Token(Token = "0x40003DA")]
		[FieldOffset(Offset = "0x64")]
		public XInputDeviceSubType hw_xInputSubType;

		[Token(Token = "0x40003DB")]
		[FieldOffset(Offset = "0x68")]
		public string hw_manufacturer;

		[Token(Token = "0x40003DC")]
		[FieldOffset(Offset = "0x70")]
		public string hw_serialNumber;

		[Token(Token = "0x40003DD")]
		[FieldOffset(Offset = "0x78")]
		public int hw_vendorId;

		[Token(Token = "0x40003DE")]
		[FieldOffset(Offset = "0x7C")]
		public int hw_version;

		[Token(Token = "0x40003DF")]
		[FieldOffset(Offset = "0x80")]
		public string hw_systemDeviceName;

		[Token(Token = "0x40003E0")]
		[FieldOffset(Offset = "0x88")]
		public bool hw_isSDL2Gamepad;

		[Token(Token = "0x40003E1")]
		[FieldOffset(Offset = "0x8C")]
		public WebGLWebBrowserType webGL_webBrowserType;

		[Token(Token = "0x40003E2")]
		[FieldOffset(Offset = "0x90")]
		public WebGLOSType webGL_osType;

		[Token(Token = "0x40003E3")]
		[FieldOffset(Offset = "0x94")]
		public WebGLGamepadMappingType webGL_mappingType;

		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0x98")]
		public string[] webGL_webBrowserVersionSplit;

		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0xA0")]
		public string[] webGL_osVersionSplit;

		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0xA8")]
		public int hw_localVibrationMotorCount;

		[Token(Token = "0x40003E7")]
		[FieldOffset(Offset = "0xB0")]
		public string definitionMatchTag;

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x234F82C", Offset = "0x234F82C", VA = "0x234F82C")]
		public BridgedControllerHWInfo()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x234F834", Offset = "0x234F834", VA = "0x234F834")]
		public BridgedControllerHWInfo(BridgedControllerHWInfo P_0)
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x234F86C", Offset = "0x234F86C", VA = "0x234F86C")]
		private void KGvHNOSFSLcIoKIKCrVnqZaTvqVy(BridgedControllerHWInfo P_0)
		{
		}
	}
}
