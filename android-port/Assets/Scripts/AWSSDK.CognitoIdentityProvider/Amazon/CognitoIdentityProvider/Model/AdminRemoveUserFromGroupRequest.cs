using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200004F")]
	public class AdminRemoveUserFromGroupRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x30")]
		private string _groupName;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x38")]
		private string _username;

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x40")]
		private string _userPoolId;

		[Token(Token = "0x1700005F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1BC20", Offset = "0x1BC20")]
		public string GroupName
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x10B60D0", Offset = "0x10B60D0", VA = "0x10B60D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x10B60D8", Offset = "0x10B60D8", VA = "0x10B60D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1BC70", Offset = "0x1BC70")]
		public string Username
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x10B60F0", Offset = "0x10B60F0", VA = "0x10B60F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x10B60F8", Offset = "0x10B60F8", VA = "0x10B60F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1BCC0", Offset = "0x1BCC0")]
		public string UserPoolId
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x10B6110", Offset = "0x10B6110", VA = "0x10B6110")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x10B6118", Offset = "0x10B6118", VA = "0x10B6118")]
			set
			{
			}
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x10B60E0", Offset = "0x10B60E0", VA = "0x10B60E0")]
		internal bool IsSetGroupName()
		{
			return default;
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x10B6100", Offset = "0x10B6100", VA = "0x10B6100")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x10B6120", Offset = "0x10B6120", VA = "0x10B6120")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x10B6130", Offset = "0x10B6130", VA = "0x10B6130")]
		public AdminRemoveUserFromGroupRequest()
		{
		}
	}
}
