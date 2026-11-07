using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x200002D")]
	public class GetIdRequest : AmazonCognitoIdentityRequest
	{
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x30")]
		private string _accountId;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x38")]
		private string _identityPoolId;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, string> _logins;

		[Token(Token = "0x1700004D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22CA0", Offset = "0x22CA0")]
		public string AccountId
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x1085D1C", Offset = "0x1085D1C", VA = "0x1085D1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x1085D24", Offset = "0x1085D24", VA = "0x1085D24")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22CE8", Offset = "0x22CE8")]
		public string IdentityPoolId
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x1085D3C", Offset = "0x1085D3C", VA = "0x1085D3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x1085D44", Offset = "0x1085D44", VA = "0x1085D44")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22D38", Offset = "0x22D38")]
		public Dictionary<string, string> Logins
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x1085D5C", Offset = "0x1085D5C", VA = "0x1085D5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x1085D64", Offset = "0x1085D64", VA = "0x1085D64")]
			set
			{
			}
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1085D2C", Offset = "0x1085D2C", VA = "0x1085D2C")]
		internal bool IsSetAccountId()
		{
			return default;
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1085D4C", Offset = "0x1085D4C", VA = "0x1085D4C")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1085D6C", Offset = "0x1085D6C", VA = "0x1085D6C")]
		internal bool IsSetLogins()
		{
			return default;
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1076C94", Offset = "0x1076C94", VA = "0x1076C94")]
		public GetIdRequest()
		{
		}
	}
}
