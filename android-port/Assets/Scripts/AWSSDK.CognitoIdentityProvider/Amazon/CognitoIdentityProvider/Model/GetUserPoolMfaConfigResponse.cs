using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000C6")]
	public class GetUserPoolMfaConfigResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x28")]
		private UserPoolMfaType _mfaConfiguration;

		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x30")]
		private SmsMfaConfigType _smsMfaConfiguration;

		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x38")]
		private SoftwareTokenMfaConfigType _softwareTokenMfaConfiguration;

		[Token(Token = "0x1700016B")]
		public UserPoolMfaType MfaConfiguration
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x112357C", Offset = "0x112357C", VA = "0x112357C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x1123584", Offset = "0x1123584", VA = "0x1123584")]
			set
			{
			}
		}

		[Token(Token = "0x1700016C")]
		public SmsMfaConfigType SmsMfaConfiguration
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x1123608", Offset = "0x1123608", VA = "0x1123608")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x1123610", Offset = "0x1123610", VA = "0x1123610")]
			set
			{
			}
		}

		[Token(Token = "0x1700016D")]
		public SoftwareTokenMfaConfigType SoftwareTokenMfaConfiguration
		{
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x1123628", Offset = "0x1123628", VA = "0x1123628")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x1123630", Offset = "0x1123630", VA = "0x1123630")]
			set
			{
			}
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x112358C", Offset = "0x112358C", VA = "0x112358C")]
		internal bool IsSetMfaConfiguration()
		{
			return default;
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x1123618", Offset = "0x1123618", VA = "0x1123618")]
		internal bool IsSetSmsMfaConfiguration()
		{
			return default;
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x1123638", Offset = "0x1123638", VA = "0x1123638")]
		internal bool IsSetSoftwareTokenMfaConfiguration()
		{
			return default;
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x1123648", Offset = "0x1123648", VA = "0x1123648")]
		public GetUserPoolMfaConfigResponse()
		{
		}
	}
}
