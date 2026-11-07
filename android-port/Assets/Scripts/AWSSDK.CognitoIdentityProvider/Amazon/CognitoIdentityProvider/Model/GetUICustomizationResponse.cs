using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000C2")]
	public class GetUICustomizationResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x28")]
		private UICustomizationType _uiCustomization;

		[Token(Token = "0x17000165")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E6B0", Offset = "0x1E6B0")]
		public UICustomizationType UICustomization
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x111FFD0", Offset = "0x111FFD0", VA = "0x111FFD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x111FFD8", Offset = "0x111FFD8", VA = "0x111FFD8")]
			set
			{
			}
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x111FFE0", Offset = "0x111FFE0", VA = "0x111FFE0")]
		internal bool IsSetUICustomization()
		{
			return default;
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x111FFF0", Offset = "0x111FFF0", VA = "0x111FFF0")]
		public GetUICustomizationResponse()
		{
		}
	}
}
