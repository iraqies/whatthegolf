using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x200001E")]
	public class GetIdentityPoolConfigurationRequest : AmazonCognitoSyncRequest
	{
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x30")]
		private string _identityPoolId;

		[Token(Token = "0x17000026")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24814", Offset = "0x24814")]
		public string IdentityPoolId
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x119B7CC", Offset = "0x119B7CC", VA = "0x119B7CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x119B7D4", Offset = "0x119B7D4", VA = "0x119B7D4")]
			set
			{
			}
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x119B7DC", Offset = "0x119B7DC", VA = "0x119B7DC")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x118E67C", Offset = "0x118E67C", VA = "0x118E67C")]
		public GetIdentityPoolConfigurationRequest()
		{
		}
	}
}
