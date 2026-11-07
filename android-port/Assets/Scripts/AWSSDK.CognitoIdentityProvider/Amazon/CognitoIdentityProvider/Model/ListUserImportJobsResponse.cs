using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000E7")]
	public class ListUserImportJobsResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x28")]
		private string _paginationToken;

		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x30")]
		private List<UserImportJobType> _userImportJobs;

		[Token(Token = "0x170001B3")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F410", Offset = "0x1F410")]
		public string PaginationToken
		{
			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x113576C", Offset = "0x113576C", VA = "0x113576C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x1135774", Offset = "0x1135774", VA = "0x1135774")]
			set
			{
			}
		}

		[Token(Token = "0x170001B4")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F448", Offset = "0x1F448")]
		public List<UserImportJobType> UserImportJobs
		{
			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x113578C", Offset = "0x113578C", VA = "0x113578C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x1135794", Offset = "0x1135794", VA = "0x1135794")]
			set
			{
			}
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x113577C", Offset = "0x113577C", VA = "0x113577C")]
		internal bool IsSetPaginationToken()
		{
			return default;
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x113579C", Offset = "0x113579C", VA = "0x113579C")]
		internal bool IsSetUserImportJobs()
		{
			return default;
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x11357F4", Offset = "0x11357F4", VA = "0x11357F4")]
		public ListUserImportJobsResponse()
		{
		}
	}
}
