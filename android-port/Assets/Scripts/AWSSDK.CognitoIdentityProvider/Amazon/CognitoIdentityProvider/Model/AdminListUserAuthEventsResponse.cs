using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200004E")]
	public class AdminListUserAuthEventsResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x28")]
		private List<AuthEventType> _authEvents;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x30")]
		private string _nextToken;

		[Token(Token = "0x1700005D")]
		public List<AuthEventType> AuthEvents
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x10B52F8", Offset = "0x10B52F8", VA = "0x10B52F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x10B5300", Offset = "0x10B5300", VA = "0x10B5300")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1BBE8", Offset = "0x1BBE8")]
		public string NextToken
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x10B5360", Offset = "0x10B5360", VA = "0x10B5360")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x10B5368", Offset = "0x10B5368", VA = "0x10B5368")]
			set
			{
			}
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x10B5308", Offset = "0x10B5308", VA = "0x10B5308")]
		internal bool IsSetAuthEvents()
		{
			return default;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x10B5370", Offset = "0x10B5370", VA = "0x10B5370")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x10B5380", Offset = "0x10B5380", VA = "0x10B5380")]
		public AdminListUserAuthEventsResponse()
		{
		}
	}
}
