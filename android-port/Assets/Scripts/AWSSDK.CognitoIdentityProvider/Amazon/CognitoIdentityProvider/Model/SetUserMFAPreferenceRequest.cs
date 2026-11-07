using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200010D")]
	public class SetUserMFAPreferenceRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x30")]
		private string _accessToken;

		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x38")]
		private SMSMfaSettingsType _smsMfaSettings;

		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x40")]
		private SoftwareTokenMfaSettingsType _softwareTokenMfaSettings;

		[Token(Token = "0x1700021E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x203B8", Offset = "0x203B8")]
		public string AccessToken
		{
			[Token(Token = "0x6000968")]
			[Address(RVA = "0x114E7FC", Offset = "0x114E7FC", VA = "0x114E7FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000969")]
			[Address(RVA = "0x114E804", Offset = "0x114E804", VA = "0x114E804")]
			set
			{
			}
		}

		[Token(Token = "0x1700021F")]
		public SMSMfaSettingsType SMSMfaSettings
		{
			[Token(Token = "0x600096B")]
			[Address(RVA = "0x114E81C", Offset = "0x114E81C", VA = "0x114E81C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600096C")]
			[Address(RVA = "0x114E824", Offset = "0x114E824", VA = "0x114E824")]
			set
			{
			}
		}

		[Token(Token = "0x17000220")]
		public SoftwareTokenMfaSettingsType SoftwareTokenMfaSettings
		{
			[Token(Token = "0x600096E")]
			[Address(RVA = "0x114E83C", Offset = "0x114E83C", VA = "0x114E83C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600096F")]
			[Address(RVA = "0x114E844", Offset = "0x114E844", VA = "0x114E844")]
			set
			{
			}
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x114E80C", Offset = "0x114E80C", VA = "0x114E80C")]
		internal bool IsSetAccessToken()
		{
			return default;
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x114E82C", Offset = "0x114E82C", VA = "0x114E82C")]
		internal bool IsSetSMSMfaSettings()
		{
			return default;
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x114E84C", Offset = "0x114E84C", VA = "0x114E84C")]
		internal bool IsSetSoftwareTokenMfaSettings()
		{
			return default;
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x114E85C", Offset = "0x114E85C", VA = "0x114E85C")]
		public SetUserMFAPreferenceRequest()
		{
		}
	}
}
