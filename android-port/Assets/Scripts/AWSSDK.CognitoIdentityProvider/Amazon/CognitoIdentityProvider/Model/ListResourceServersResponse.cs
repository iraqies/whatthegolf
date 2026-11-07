using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000E3")]
	public class ListResourceServersResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x28")]
		private string _nextToken;

		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x30")]
		private List<ResourceServerType> _resourceServers;

		[Token(Token = "0x170001AC")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F27C", Offset = "0x1F27C")]
		public string NextToken
		{
			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x113283C", Offset = "0x113283C", VA = "0x113283C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x1132844", Offset = "0x1132844", VA = "0x1132844")]
			set
			{
			}
		}

		[Token(Token = "0x170001AD")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F2B4", Offset = "0x1F2B4")]
		public List<ResourceServerType> ResourceServers
		{
			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x113285C", Offset = "0x113285C", VA = "0x113285C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x1132864", Offset = "0x1132864", VA = "0x1132864")]
			set
			{
			}
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x113284C", Offset = "0x113284C", VA = "0x113284C")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x113286C", Offset = "0x113286C", VA = "0x113286C")]
		internal bool IsSetResourceServers()
		{
			return default;
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x11328C4", Offset = "0x11328C4", VA = "0x11328C4")]
		public ListResourceServersResponse()
		{
		}
	}
}
