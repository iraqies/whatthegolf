using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200008A")]
	public class DeleteGroupRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x30")]
		private string _groupName;

		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x38")]
		private string _userPoolId;

		[Token(Token = "0x1700010A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D740", Offset = "0x1D740")]
		public string GroupName
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x10FA510", Offset = "0x10FA510", VA = "0x10FA510")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x10FA518", Offset = "0x10FA518", VA = "0x10FA518")]
			set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D790", Offset = "0x1D790")]
		public string UserPoolId
		{
			[Token(Token = "0x6000554")]
			[Address(RVA = "0x10FA530", Offset = "0x10FA530", VA = "0x10FA530")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000555")]
			[Address(RVA = "0x10FA538", Offset = "0x10FA538", VA = "0x10FA538")]
			set
			{
			}
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x10FA520", Offset = "0x10FA520", VA = "0x10FA520")]
		internal bool IsSetGroupName()
		{
			return default;
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x10FA540", Offset = "0x10FA540", VA = "0x10FA540")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x10FA550", Offset = "0x10FA550", VA = "0x10FA550")]
		public DeleteGroupRequest()
		{
		}
	}
}
