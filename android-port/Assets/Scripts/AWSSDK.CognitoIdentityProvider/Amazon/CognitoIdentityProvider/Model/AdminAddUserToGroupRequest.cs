using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200002E")]
	public class AdminAddUserToGroupRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x30")]
		private string _groupName;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x38")]
		private string _username;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x40")]
		private string _userPoolId;

		[Token(Token = "0x1700000F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1AD80", Offset = "0x1AD80")]
		public string GroupName
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x109ACC4", Offset = "0x109ACC4", VA = "0x109ACC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x109ACCC", Offset = "0x109ACCC", VA = "0x109ACCC")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1ADD0", Offset = "0x1ADD0")]
		public string Username
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x109ACE4", Offset = "0x109ACE4", VA = "0x109ACE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x109ACEC", Offset = "0x109ACEC", VA = "0x109ACEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1AE20", Offset = "0x1AE20")]
		public string UserPoolId
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x109AD04", Offset = "0x109AD04", VA = "0x109AD04")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x109AD0C", Offset = "0x109AD0C", VA = "0x109AD0C")]
			set
			{
			}
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x109ACD4", Offset = "0x109ACD4", VA = "0x109ACD4")]
		internal bool IsSetGroupName()
		{
			return default;
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x109ACF4", Offset = "0x109ACF4", VA = "0x109ACF4")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x109AD14", Offset = "0x109AD14", VA = "0x109AD14")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x109AD24", Offset = "0x109AD24", VA = "0x109AD24")]
		public AdminAddUserToGroupRequest()
		{
		}
	}
}
