using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000E1")]
	public class ListIdentityProvidersResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x28")]
		private string _nextToken;

		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x30")]
		private List<ProviderDescription> _providers;

		[Token(Token = "0x170001A7")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F124", Offset = "0x1F124")]
		public string NextToken
		{
			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x1130F40", Offset = "0x1130F40", VA = "0x1130F40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x1130F48", Offset = "0x1130F48", VA = "0x1130F48")]
			set
			{
			}
		}

		[Token(Token = "0x170001A8")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F15C", Offset = "0x1F15C")]
		public List<ProviderDescription> Providers
		{
			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x1130F60", Offset = "0x1130F60", VA = "0x1130F60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x1130F68", Offset = "0x1130F68", VA = "0x1130F68")]
			set
			{
			}
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x1130F50", Offset = "0x1130F50", VA = "0x1130F50")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x1130F70", Offset = "0x1130F70", VA = "0x1130F70")]
		internal bool IsSetProviders()
		{
			return default;
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x1130FC8", Offset = "0x1130FC8", VA = "0x1130FC8")]
		public ListIdentityProvidersResponse()
		{
		}
	}
}
