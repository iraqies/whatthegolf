using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x200001A")]
	public class GetBulkPublishDetailsRequest : AmazonCognitoSyncRequest
	{
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x30")]
		private string _identityPoolId;

		[Token(Token = "0x1700001E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x246F4", Offset = "0x246F4")]
		public string IdentityPoolId
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x1198F6C", Offset = "0x1198F6C", VA = "0x1198F6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x1198F74", Offset = "0x1198F74", VA = "0x1198F74")]
			set
			{
			}
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1198F7C", Offset = "0x1198F7C", VA = "0x1198F7C")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1198F8C", Offset = "0x1198F8C", VA = "0x1198F8C")]
		public GetBulkPublishDetailsRequest()
		{
		}
	}
}
