using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000E4")]
	public class ListTagsForResourceRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x30")]
		private string _resourceArn;

		[Token(Token = "0x170001AE")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F2E8", Offset = "0x1F2E8")]
		public string ResourceArn
		{
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x1133474", Offset = "0x1133474", VA = "0x1133474")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x113347C", Offset = "0x113347C", VA = "0x113347C")]
			set
			{
			}
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x1133484", Offset = "0x1133484", VA = "0x1133484")]
		internal bool IsSetResourceArn()
		{
			return default;
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x1133494", Offset = "0x1133494", VA = "0x1133494")]
		public ListTagsForResourceRequest()
		{
		}
	}
}
