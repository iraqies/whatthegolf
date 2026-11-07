using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000E6")]
	public class ListUserImportJobsRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x2C")]
		private int? _maxResults;

		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x38")]
		private string _paginationToken;

		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x40")]
		private string _userPoolId;

		[Token(Token = "0x170001B0")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F338", Offset = "0x1F338")]
		public int MaxResults
		{
			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x1134AA8", Offset = "0x1134AA8", VA = "0x1134AA8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x1134AE8", Offset = "0x1134AE8", VA = "0x1134AE8")]
			set
			{
			}
		}

		[Token(Token = "0x170001B1")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F388", Offset = "0x1F388")]
		public string PaginationToken
		{
			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x1134B9C", Offset = "0x1134B9C", VA = "0x1134B9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x1134BA4", Offset = "0x1134BA4", VA = "0x1134BA4")]
			set
			{
			}
		}

		[Token(Token = "0x170001B2")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F3C0", Offset = "0x1F3C0")]
		public string UserPoolId
		{
			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x1134BBC", Offset = "0x1134BBC", VA = "0x1134BBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x1134BC4", Offset = "0x1134BC4", VA = "0x1134BC4")]
			set
			{
			}
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x1134B5C", Offset = "0x1134B5C", VA = "0x1134B5C")]
		internal bool IsSetMaxResults()
		{
			return default;
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x1134BAC", Offset = "0x1134BAC", VA = "0x1134BAC")]
		internal bool IsSetPaginationToken()
		{
			return default;
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x1134BCC", Offset = "0x1134BCC", VA = "0x1134BCC")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x1134BDC", Offset = "0x1134BDC", VA = "0x1134BDC")]
		public ListUserImportJobsRequest()
		{
		}
	}
}
