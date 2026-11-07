using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000038")]
	public class SetIdentityPoolConfigurationRequest : AmazonCognitoSyncRequest
	{
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x30")]
		private CognitoStreams _cognitoStreams;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x38")]
		private string _identityPoolId;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x40")]
		private PushSync _pushSync;

		[Token(Token = "0x17000064")]
		public CognitoStreams CognitoStreams
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x11A8980", Offset = "0x11A8980", VA = "0x11A8980")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x11A8988", Offset = "0x11A8988", VA = "0x11A8988")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24EAC", Offset = "0x24EAC")]
		public string IdentityPoolId
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x11A89A0", Offset = "0x11A89A0", VA = "0x11A89A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x11A89A8", Offset = "0x11A89A8", VA = "0x11A89A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public PushSync PushSync
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x11A89C0", Offset = "0x11A89C0", VA = "0x11A89C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x11A89C8", Offset = "0x11A89C8", VA = "0x11A89C8")]
			set
			{
			}
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x11A8990", Offset = "0x11A8990", VA = "0x11A8990")]
		internal bool IsSetCognitoStreams()
		{
			return default;
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x11A89B0", Offset = "0x11A89B0", VA = "0x11A89B0")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x11A89D0", Offset = "0x11A89D0", VA = "0x11A89D0")]
		internal bool IsSetPushSync()
		{
			return default;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x11A89E0", Offset = "0x11A89E0", VA = "0x11A89E0")]
		public SetIdentityPoolConfigurationRequest()
		{
		}
	}
}
