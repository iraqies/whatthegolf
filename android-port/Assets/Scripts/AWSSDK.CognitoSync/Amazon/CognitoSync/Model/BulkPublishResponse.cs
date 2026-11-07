using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x200000D")]
	public class BulkPublishResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x28")]
		private string _identityPoolId;

		[Token(Token = "0x17000006")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x242BC", Offset = "0x242BC")]
		public string IdentityPoolId
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x1190F08", Offset = "0x1190F08", VA = "0x1190F08")]
			get
			{
				return null;
			}
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x1190F10", Offset = "0x1190F10", VA = "0x1190F10")]
			set
			{
			}
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1190F18", Offset = "0x1190F18", VA = "0x1190F18")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1190F28", Offset = "0x1190F28", VA = "0x1190F28")]
		public BulkPublishResponse()
		{
		}
	}
}
