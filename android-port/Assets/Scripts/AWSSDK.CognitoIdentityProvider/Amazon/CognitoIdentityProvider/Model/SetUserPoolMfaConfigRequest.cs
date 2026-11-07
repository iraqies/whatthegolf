using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200010F")]
	public class SetUserPoolMfaConfigRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x30")]
		private UserPoolMfaType _mfaConfiguration;

		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x38")]
		private SmsMfaConfigType _smsMfaConfiguration;

		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x40")]
		private SoftwareTokenMfaConfigType _softwareTokenMfaConfiguration;

		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x48")]
		private string _userPoolId;

		[Token(Token = "0x17000221")]
		public UserPoolMfaType MfaConfiguration
		{
			[Token(Token = "0x6000973")]
			[Address(RVA = "0x1150014", Offset = "0x1150014", VA = "0x1150014")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000974")]
			[Address(RVA = "0x115001C", Offset = "0x115001C", VA = "0x115001C")]
			set
			{
			}
		}

		[Token(Token = "0x17000222")]
		public SmsMfaConfigType SmsMfaConfiguration
		{
			[Token(Token = "0x6000976")]
			[Address(RVA = "0x11500A0", Offset = "0x11500A0", VA = "0x11500A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000977")]
			[Address(RVA = "0x11500A8", Offset = "0x11500A8", VA = "0x11500A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000223")]
		public SoftwareTokenMfaConfigType SoftwareTokenMfaConfiguration
		{
			[Token(Token = "0x6000979")]
			[Address(RVA = "0x11500C0", Offset = "0x11500C0", VA = "0x11500C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600097A")]
			[Address(RVA = "0x11500C8", Offset = "0x11500C8", VA = "0x11500C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000224")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x203EC", Offset = "0x203EC")]
		public string UserPoolId
		{
			[Token(Token = "0x600097C")]
			[Address(RVA = "0x11500E0", Offset = "0x11500E0", VA = "0x11500E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600097D")]
			[Address(RVA = "0x11500E8", Offset = "0x11500E8", VA = "0x11500E8")]
			set
			{
			}
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x1150024", Offset = "0x1150024", VA = "0x1150024")]
		internal bool IsSetMfaConfiguration()
		{
			return default;
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x11500B0", Offset = "0x11500B0", VA = "0x11500B0")]
		internal bool IsSetSmsMfaConfiguration()
		{
			return default;
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x11500D0", Offset = "0x11500D0", VA = "0x11500D0")]
		internal bool IsSetSoftwareTokenMfaConfiguration()
		{
			return default;
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x11500F0", Offset = "0x11500F0", VA = "0x11500F0")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x1150100", Offset = "0x1150100", VA = "0x1150100")]
		public SetUserPoolMfaConfigRequest()
		{
		}
	}
}
