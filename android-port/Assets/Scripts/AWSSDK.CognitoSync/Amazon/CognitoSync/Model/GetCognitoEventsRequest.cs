using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x200001C")]
	public class GetCognitoEventsRequest : AmazonCognitoSyncRequest
	{
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x30")]
		private string _identityPoolId;

		[Token(Token = "0x17000024")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2478C", Offset = "0x2478C")]
		public string IdentityPoolId
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x119A5DC", Offset = "0x119A5DC", VA = "0x119A5DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x119A5E4", Offset = "0x119A5E4", VA = "0x119A5E4")]
			set
			{
			}
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x119A5EC", Offset = "0x119A5EC", VA = "0x119A5EC")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x119A5FC", Offset = "0x119A5FC", VA = "0x119A5FC")]
		public GetCognitoEventsRequest()
		{
		}
	}
}
