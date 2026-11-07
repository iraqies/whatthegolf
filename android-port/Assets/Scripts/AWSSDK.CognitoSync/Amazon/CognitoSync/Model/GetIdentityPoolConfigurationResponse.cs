using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x200001F")]
	public class GetIdentityPoolConfigurationResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x28")]
		private CognitoStreams _cognitoStreams;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x30")]
		private string _identityPoolId;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x38")]
		private PushSync _pushSync;

		[Token(Token = "0x17000027")]
		public CognitoStreams CognitoStreams
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x119BE1C", Offset = "0x119BE1C", VA = "0x119BE1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x119BE24", Offset = "0x119BE24", VA = "0x119BE24")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24864", Offset = "0x24864")]
		public string IdentityPoolId
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x119BE3C", Offset = "0x119BE3C", VA = "0x119BE3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x119BE44", Offset = "0x119BE44", VA = "0x119BE44")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public PushSync PushSync
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x119BE5C", Offset = "0x119BE5C", VA = "0x119BE5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x119BE64", Offset = "0x119BE64", VA = "0x119BE64")]
			set
			{
			}
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x119BE2C", Offset = "0x119BE2C", VA = "0x119BE2C")]
		internal bool IsSetCognitoStreams()
		{
			return default;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x119BE4C", Offset = "0x119BE4C", VA = "0x119BE4C")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x119BE6C", Offset = "0x119BE6C", VA = "0x119BE6C")]
		internal bool IsSetPushSync()
		{
			return default;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x119BE7C", Offset = "0x119BE7C", VA = "0x119BE7C")]
		public GetIdentityPoolConfigurationResponse()
		{
		}
	}
}
