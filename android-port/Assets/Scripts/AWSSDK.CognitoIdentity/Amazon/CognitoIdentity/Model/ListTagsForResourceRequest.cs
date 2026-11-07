using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x200003D")]
	public class ListTagsForResourceRequest : AmazonCognitoIdentityRequest
	{
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x30")]
		private string _resourceArn;

		[Token(Token = "0x1700006C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x232E4", Offset = "0x232E4")]
		public string ResourceArn
		{
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x1090CF0", Offset = "0x1090CF0", VA = "0x1090CF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x1090CF8", Offset = "0x1090CF8", VA = "0x1090CF8")]
			set
			{
			}
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1090D00", Offset = "0x1090D00", VA = "0x1090D00")]
		internal bool IsSetResourceArn()
		{
			return default;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1090D10", Offset = "0x1090D10", VA = "0x1090D10")]
		public ListTagsForResourceRequest()
		{
		}
	}
}
