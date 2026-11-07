using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200010C")]
	public class SetUICustomizationResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x28")]
		private UICustomizationType _uiCustomization;

		[Token(Token = "0x1700021D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20384", Offset = "0x20384")]
		public UICustomizationType UICustomization
		{
			[Token(Token = "0x6000964")]
			[Address(RVA = "0x114DE14", Offset = "0x114DE14", VA = "0x114DE14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000965")]
			[Address(RVA = "0x114DE1C", Offset = "0x114DE1C", VA = "0x114DE1C")]
			set
			{
			}
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x114DE24", Offset = "0x114DE24", VA = "0x114DE24")]
		internal bool IsSetUICustomization()
		{
			return default;
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x114DE34", Offset = "0x114DE34", VA = "0x114DE34")]
		public SetUICustomizationResponse()
		{
		}
	}
}
