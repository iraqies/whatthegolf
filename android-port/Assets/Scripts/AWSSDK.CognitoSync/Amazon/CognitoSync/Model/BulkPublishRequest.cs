using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x200000C")]
	public class BulkPublishRequest : AmazonCognitoSyncRequest
	{
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x30")]
		private string _identityPoolId;

		[Token(Token = "0x17000005")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2426C", Offset = "0x2426C")]
		public string IdentityPoolId
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x119079C", Offset = "0x119079C", VA = "0x119079C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x11907A4", Offset = "0x11907A4", VA = "0x11907A4")]
			set
			{
			}
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x11907AC", Offset = "0x11907AC", VA = "0x11907AC")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x11907BC", Offset = "0x11907BC", VA = "0x11907BC")]
		public BulkPublishRequest()
		{
		}
	}
}
