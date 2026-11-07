using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000096")]
	public class DeleteUserPoolRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x30")]
		private string _userPoolId;

		[Token(Token = "0x17000116")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1DAC8", Offset = "0x1DAC8")]
		public string UserPoolId
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x1102060", Offset = "0x1102060", VA = "0x1102060")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000583")]
			[Address(RVA = "0x1102068", Offset = "0x1102068", VA = "0x1102068")]
			set
			{
			}
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1102070", Offset = "0x1102070", VA = "0x1102070")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1102080", Offset = "0x1102080", VA = "0x1102080")]
		public DeleteUserPoolRequest()
		{
		}
	}
}
