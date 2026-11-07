using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000035")]
	public class AdminDeleteUserAttributesRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x30")]
		private List<string> _userAttributeNames;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x38")]
		private string _username;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x40")]
		private string _userPoolId;

		[Token(Token = "0x17000022")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B040", Offset = "0x1B040")]
		public List<string> UserAttributeNames
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x10A13D0", Offset = "0x10A13D0", VA = "0x10A13D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x10A13D8", Offset = "0x10A13D8", VA = "0x10A13D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B074", Offset = "0x1B074")]
		public string Username
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x10A1438", Offset = "0x10A1438", VA = "0x10A1438")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x10A1440", Offset = "0x10A1440", VA = "0x10A1440")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B0C4", Offset = "0x1B0C4")]
		public string UserPoolId
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x10A1458", Offset = "0x10A1458", VA = "0x10A1458")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x10A1460", Offset = "0x10A1460", VA = "0x10A1460")]
			set
			{
			}
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x10A13E0", Offset = "0x10A13E0", VA = "0x10A13E0")]
		internal bool IsSetUserAttributeNames()
		{
			return default;
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x10A1448", Offset = "0x10A1448", VA = "0x10A1448")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x10A1468", Offset = "0x10A1468", VA = "0x10A1468")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x10A1478", Offset = "0x10A1478", VA = "0x10A1478")]
		public AdminDeleteUserAttributesRequest()
		{
		}
	}
}
