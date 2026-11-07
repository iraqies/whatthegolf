using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000EE")]
	public class ListUsersRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x30")]
		private List<string> _attributesToGet;

		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x38")]
		private string _filter;

		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x40")]
		private int? _limit;

		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x48")]
		private string _paginationToken;

		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x50")]
		private string _userPoolId;

		[Token(Token = "0x170001C4")]
		public List<string> AttributesToGet
		{
			[Token(Token = "0x6000821")]
			[Address(RVA = "0x113AF98", Offset = "0x113AF98", VA = "0x113AF98")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000822")]
			[Address(RVA = "0x113AFA0", Offset = "0x113AFA0", VA = "0x113AFA0")]
			set
			{
			}
		}

		[Token(Token = "0x170001C5")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F7B0", Offset = "0x1F7B0")]
		public string Filter
		{
			[Token(Token = "0x6000824")]
			[Address(RVA = "0x113B000", Offset = "0x113B000", VA = "0x113B000")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000825")]
			[Address(RVA = "0x113B008", Offset = "0x113B008", VA = "0x113B008")]
			set
			{
			}
		}

		[Token(Token = "0x170001C6")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F7E8", Offset = "0x1F7E8")]
		public int Limit
		{
			[Token(Token = "0x6000827")]
			[Address(RVA = "0x113B020", Offset = "0x113B020", VA = "0x113B020")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000828")]
			[Address(RVA = "0x113B060", Offset = "0x113B060", VA = "0x113B060")]
			set
			{
			}
		}

		[Token(Token = "0x170001C7")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F830", Offset = "0x1F830")]
		public string PaginationToken
		{
			[Token(Token = "0x600082A")]
			[Address(RVA = "0x113B114", Offset = "0x113B114", VA = "0x113B114")]
			get
			{
				return null;
			}
			[Token(Token = "0x600082B")]
			[Address(RVA = "0x113B11C", Offset = "0x113B11C", VA = "0x113B11C")]
			set
			{
			}
		}

		[Token(Token = "0x170001C8")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F868", Offset = "0x1F868")]
		public string UserPoolId
		{
			[Token(Token = "0x600082D")]
			[Address(RVA = "0x113B134", Offset = "0x113B134", VA = "0x113B134")]
			get
			{
				return null;
			}
			[Token(Token = "0x600082E")]
			[Address(RVA = "0x113B13C", Offset = "0x113B13C", VA = "0x113B13C")]
			set
			{
			}
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x113AFA8", Offset = "0x113AFA8", VA = "0x113AFA8")]
		internal bool IsSetAttributesToGet()
		{
			return default;
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x113B010", Offset = "0x113B010", VA = "0x113B010")]
		internal bool IsSetFilter()
		{
			return default;
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x113B0D4", Offset = "0x113B0D4", VA = "0x113B0D4")]
		internal bool IsSetLimit()
		{
			return default;
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x113B124", Offset = "0x113B124", VA = "0x113B124")]
		internal bool IsSetPaginationToken()
		{
			return default;
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x113B144", Offset = "0x113B144", VA = "0x113B144")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x113B154", Offset = "0x113B154", VA = "0x113B154")]
		public ListUsersRequest()
		{
		}
	}
}
