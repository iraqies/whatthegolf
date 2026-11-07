using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000E9")]
	public class ListUserPoolClientsResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x28")]
		private string _nextToken;

		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x30")]
		private List<UserPoolClientDescription> _userPoolClients;

		[Token(Token = "0x170001B8")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F560", Offset = "0x1F560")]
		public string NextToken
		{
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x1137068", Offset = "0x1137068", VA = "0x1137068")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x1137070", Offset = "0x1137070", VA = "0x1137070")]
			set
			{
			}
		}

		[Token(Token = "0x170001B9")]
		public List<UserPoolClientDescription> UserPoolClients
		{
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x1137088", Offset = "0x1137088", VA = "0x1137088")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x1137090", Offset = "0x1137090", VA = "0x1137090")]
			set
			{
			}
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x1137078", Offset = "0x1137078", VA = "0x1137078")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x1137098", Offset = "0x1137098", VA = "0x1137098")]
		internal bool IsSetUserPoolClients()
		{
			return default;
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x11370F0", Offset = "0x11370F0", VA = "0x11370F0")]
		public ListUserPoolClientsResponse()
		{
		}
	}
}
