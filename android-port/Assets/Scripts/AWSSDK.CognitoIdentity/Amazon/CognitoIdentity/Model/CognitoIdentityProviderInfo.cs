using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x200001B")]
	public class CognitoIdentityProviderInfo
	{
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x10")]
		private string _clientId;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x18")]
		private string _providerName;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x20")]
		private bool? _serverSideTokenCheck;

		[Token(Token = "0x1700001B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22484", Offset = "0x22484")]
		public string ClientId
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x107857C", Offset = "0x107857C", VA = "0x107857C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x1078584", Offset = "0x1078584", VA = "0x1078584")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x224CC", Offset = "0x224CC")]
		public string ProviderName
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x107859C", Offset = "0x107859C", VA = "0x107859C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x10785A4", Offset = "0x10785A4", VA = "0x10785A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public bool ServerSideTokenCheck
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x10785BC", Offset = "0x10785BC", VA = "0x10785BC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x10785FC", Offset = "0x10785FC", VA = "0x10785FC")]
			set
			{
			}
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x107858C", Offset = "0x107858C", VA = "0x107858C")]
		internal bool IsSetClientId()
		{
			return default;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x10785AC", Offset = "0x10785AC", VA = "0x10785AC")]
		internal bool IsSetProviderName()
		{
			return default;
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1078670", Offset = "0x1078670", VA = "0x1078670")]
		internal bool IsSetServerSideTokenCheck()
		{
			return default;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x10786B0", Offset = "0x10786B0", VA = "0x10786B0")]
		public CognitoIdentityProviderInfo()
		{
		}
	}
}
