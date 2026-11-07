using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000055")]
	public class AdminSetUserMFAPreferenceRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x30")]
		private SMSMfaSettingsType _smsMfaSettings;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x38")]
		private SoftwareTokenMfaSettingsType _softwareTokenMfaSettings;

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x40")]
		private string _username;

		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x48")]
		private string _userPoolId;

		[Token(Token = "0x17000071")]
		public SMSMfaSettingsType SMSMfaSettings
		{
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x10BC2D8", Offset = "0x10BC2D8", VA = "0x10BC2D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600033F")]
			[Address(RVA = "0x10BC2E0", Offset = "0x10BC2E0", VA = "0x10BC2E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public SoftwareTokenMfaSettingsType SoftwareTokenMfaSettings
		{
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x10BC2F8", Offset = "0x10BC2F8", VA = "0x10BC2F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x10BC300", Offset = "0x10BC300", VA = "0x10BC300")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1BF14", Offset = "0x1BF14")]
		public string Username
		{
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x10BC318", Offset = "0x10BC318", VA = "0x10BC318")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x10BC320", Offset = "0x10BC320", VA = "0x10BC320")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1BF64", Offset = "0x1BF64")]
		public string UserPoolId
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x10BC338", Offset = "0x10BC338", VA = "0x10BC338")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x10BC340", Offset = "0x10BC340", VA = "0x10BC340")]
			set
			{
			}
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x10BC2E8", Offset = "0x10BC2E8", VA = "0x10BC2E8")]
		internal bool IsSetSMSMfaSettings()
		{
			return default;
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x10BC308", Offset = "0x10BC308", VA = "0x10BC308")]
		internal bool IsSetSoftwareTokenMfaSettings()
		{
			return default;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x10BC328", Offset = "0x10BC328", VA = "0x10BC328")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x10BC348", Offset = "0x10BC348", VA = "0x10BC348")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x10BC358", Offset = "0x10BC358", VA = "0x10BC358")]
		public AdminSetUserMFAPreferenceRequest()
		{
		}
	}
}
