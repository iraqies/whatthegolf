using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000057")]
	public class AdminSetUserPasswordRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x30")]
		private string _password;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x38")]
		private bool? _permanent;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x40")]
		private string _username;

		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x48")]
		private string _userPoolId;

		[Token(Token = "0x17000075")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1BFB4", Offset = "0x1BFB4")]
		public string Password
		{
			[Token(Token = "0x600034C")]
			[Address(RVA = "0x10BDA28", Offset = "0x10BDA28", VA = "0x10BDA28")]
			get
			{
				return null;
			}
			[Token(Token = "0x600034D")]
			[Address(RVA = "0x10BDA30", Offset = "0x10BDA30", VA = "0x10BDA30")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public bool Permanent
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x10BDA48", Offset = "0x10BDA48", VA = "0x10BDA48")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x10BDA88", Offset = "0x10BDA88", VA = "0x10BDA88")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C004", Offset = "0x1C004")]
		public string Username
		{
			[Token(Token = "0x6000352")]
			[Address(RVA = "0x10BDB3C", Offset = "0x10BDB3C", VA = "0x10BDB3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x10BDB44", Offset = "0x10BDB44", VA = "0x10BDB44")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C054", Offset = "0x1C054")]
		public string UserPoolId
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x10BDB5C", Offset = "0x10BDB5C", VA = "0x10BDB5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000356")]
			[Address(RVA = "0x10BDB64", Offset = "0x10BDB64", VA = "0x10BDB64")]
			set
			{
			}
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x10BDA38", Offset = "0x10BDA38", VA = "0x10BDA38")]
		internal bool IsSetPassword()
		{
			return default;
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x10BDAFC", Offset = "0x10BDAFC", VA = "0x10BDAFC")]
		internal bool IsSetPermanent()
		{
			return default;
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x10BDB4C", Offset = "0x10BDB4C", VA = "0x10BDB4C")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x10BDB6C", Offset = "0x10BDB6C", VA = "0x10BDB6C")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x10BDB7C", Offset = "0x10BDB7C", VA = "0x10BDB7C")]
		public AdminSetUserPasswordRequest()
		{
		}
	}
}
