using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000A8")]
	public class DeviceConfigurationType
	{
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x10")]
		private bool? _challengeRequiredOnNewDevice;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x12")]
		private bool? _deviceOnlyRememberedOnUserPrompt;

		[Token(Token = "0x1700012B")]
		public bool ChallengeRequiredOnNewDevice
		{
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x110E69C", Offset = "0x110E69C", VA = "0x110E69C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x110E6DC", Offset = "0x110E6DC", VA = "0x110E6DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700012C")]
		public bool DeviceOnlyRememberedOnUserPrompt
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x110E790", Offset = "0x110E790", VA = "0x110E790")]
			get
			{
				return default;
			}
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x110E7D0", Offset = "0x110E7D0", VA = "0x110E7D0")]
			set
			{
			}
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x110E750", Offset = "0x110E750", VA = "0x110E750")]
		internal bool IsSetChallengeRequiredOnNewDevice()
		{
			return default;
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x110E844", Offset = "0x110E844", VA = "0x110E844")]
		internal bool IsSetDeviceOnlyRememberedOnUserPrompt()
		{
			return default;
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x110E884", Offset = "0x110E884", VA = "0x110E884")]
		public DeviceConfigurationType()
		{
		}
	}
}
