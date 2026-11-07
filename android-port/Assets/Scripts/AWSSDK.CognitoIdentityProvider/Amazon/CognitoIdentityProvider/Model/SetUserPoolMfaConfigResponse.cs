using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000110")]
	public class SetUserPoolMfaConfigResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x28")]
		private UserPoolMfaType _mfaConfiguration;

		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x30")]
		private SmsMfaConfigType _smsMfaConfiguration;

		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x38")]
		private SoftwareTokenMfaConfigType _softwareTokenMfaConfiguration;

		[Token(Token = "0x17000225")]
		public UserPoolMfaType MfaConfiguration
		{
			[Token(Token = "0x6000980")]
			[Address(RVA = "0x1151038", Offset = "0x1151038", VA = "0x1151038")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000981")]
			[Address(RVA = "0x1151040", Offset = "0x1151040", VA = "0x1151040")]
			set
			{
			}
		}

		[Token(Token = "0x17000226")]
		public SmsMfaConfigType SmsMfaConfiguration
		{
			[Token(Token = "0x6000983")]
			[Address(RVA = "0x11510C4", Offset = "0x11510C4", VA = "0x11510C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000984")]
			[Address(RVA = "0x11510CC", Offset = "0x11510CC", VA = "0x11510CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000227")]
		public SoftwareTokenMfaConfigType SoftwareTokenMfaConfiguration
		{
			[Token(Token = "0x6000986")]
			[Address(RVA = "0x11510E4", Offset = "0x11510E4", VA = "0x11510E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000987")]
			[Address(RVA = "0x11510EC", Offset = "0x11510EC", VA = "0x11510EC")]
			set
			{
			}
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x1151048", Offset = "0x1151048", VA = "0x1151048")]
		internal bool IsSetMfaConfiguration()
		{
			return default;
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x11510D4", Offset = "0x11510D4", VA = "0x11510D4")]
		internal bool IsSetSmsMfaConfiguration()
		{
			return default;
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x11510F4", Offset = "0x11510F4", VA = "0x11510F4")]
		internal bool IsSetSoftwareTokenMfaConfiguration()
		{
			return default;
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x1151104", Offset = "0x1151104", VA = "0x1151104")]
		public SetUserPoolMfaConfigResponse()
		{
		}
	}
}
