using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x200002F")]
	public class GetOpenIdTokenForDeveloperIdentityRequest : AmazonCognitoIdentityRequest
	{
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x30")]
		private string _identityId;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x38")]
		private string _identityPoolId;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, string> _logins;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x48")]
		private long? _tokenDuration;

		[Token(Token = "0x17000051")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22DB8", Offset = "0x22DB8")]
		public string IdentityId
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x1089094", Offset = "0x1089094", VA = "0x1089094")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x108909C", Offset = "0x108909C", VA = "0x108909C")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22E00", Offset = "0x22E00")]
		public string IdentityPoolId
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x10890B4", Offset = "0x10890B4", VA = "0x10890B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x10890BC", Offset = "0x10890BC", VA = "0x10890BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22E50", Offset = "0x22E50")]
		public Dictionary<string, string> Logins
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x10890D4", Offset = "0x10890D4", VA = "0x10890D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x10890DC", Offset = "0x10890DC", VA = "0x10890DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22E90", Offset = "0x22E90")]
		public long TokenDuration
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x1089140", Offset = "0x1089140", VA = "0x1089140")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x1089180", Offset = "0x1089180", VA = "0x1089180")]
			set
			{
			}
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x10890A4", Offset = "0x10890A4", VA = "0x10890A4")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x10890C4", Offset = "0x10890C4", VA = "0x10890C4")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x10890E4", Offset = "0x10890E4", VA = "0x10890E4")]
		internal bool IsSetLogins()
		{
			return default;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x10891F4", Offset = "0x10891F4", VA = "0x10891F4")]
		internal bool IsSetTokenDuration()
		{
			return default;
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1089234", Offset = "0x1089234", VA = "0x1089234")]
		public GetOpenIdTokenForDeveloperIdentityRequest()
		{
		}
	}
}
