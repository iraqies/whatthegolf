using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000BB")]
	public class GetGroupRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x30")]
		private string _groupName;

		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x38")]
		private string _userPoolId;

		[Token(Token = "0x1700015B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E454", Offset = "0x1E454")]
		public string GroupName
		{
			[Token(Token = "0x6000684")]
			[Address(RVA = "0x111A91C", Offset = "0x111A91C", VA = "0x111A91C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000685")]
			[Address(RVA = "0x111A924", Offset = "0x111A924", VA = "0x111A924")]
			set
			{
			}
		}

		[Token(Token = "0x1700015C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E4A4", Offset = "0x1E4A4")]
		public string UserPoolId
		{
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x111A93C", Offset = "0x111A93C", VA = "0x111A93C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x111A944", Offset = "0x111A944", VA = "0x111A944")]
			set
			{
			}
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x111A92C", Offset = "0x111A92C", VA = "0x111A92C")]
		internal bool IsSetGroupName()
		{
			return default;
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x111A94C", Offset = "0x111A94C", VA = "0x111A94C")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x111A95C", Offset = "0x111A95C", VA = "0x111A95C")]
		public GetGroupRequest()
		{
		}
	}
}
