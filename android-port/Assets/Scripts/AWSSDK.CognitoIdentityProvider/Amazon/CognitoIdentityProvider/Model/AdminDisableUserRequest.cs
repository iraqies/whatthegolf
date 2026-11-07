using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200003B")]
	public class AdminDisableUserRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x30")]
		private string _username;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x38")]
		private string _userPoolId;

		[Token(Token = "0x17000029")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B21C", Offset = "0x1B21C")]
		public string Username
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x10A5568", Offset = "0x10A5568", VA = "0x10A5568")]
			get
			{
				return null;
			}
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x10A5570", Offset = "0x10A5570", VA = "0x10A5570")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B26C", Offset = "0x1B26C")]
		public string UserPoolId
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x10A5588", Offset = "0x10A5588", VA = "0x10A5588")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x10A5590", Offset = "0x10A5590", VA = "0x10A5590")]
			set
			{
			}
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x10A5578", Offset = "0x10A5578", VA = "0x10A5578")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x10A5598", Offset = "0x10A5598", VA = "0x10A5598")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x10A55A8", Offset = "0x10A55A8", VA = "0x10A55A8")]
		public AdminDisableUserRequest()
		{
		}
	}
}
