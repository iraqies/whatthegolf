using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000C8")]
	public class GetUserResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x28")]
		private List<MFAOptionType> _mfaOptions;

		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x30")]
		private string _preferredMfaSetting;

		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x38")]
		private List<AttributeType> _userAttributes;

		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x40")]
		private List<string> _userMFASettingList;

		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x48")]
		private string _username;

		[Token(Token = "0x1700016F")]
		public List<MFAOptionType> MFAOptions
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x1124CC0", Offset = "0x1124CC0", VA = "0x1124CC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x1124CC8", Offset = "0x1124CC8", VA = "0x1124CC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000170")]
		public string PreferredMfaSetting
		{
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x1124D28", Offset = "0x1124D28", VA = "0x1124D28")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x1124D30", Offset = "0x1124D30", VA = "0x1124D30")]
			set
			{
			}
		}

		[Token(Token = "0x17000171")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E7EC", Offset = "0x1E7EC")]
		public List<AttributeType> UserAttributes
		{
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x1124D48", Offset = "0x1124D48", VA = "0x1124D48")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x1124D50", Offset = "0x1124D50", VA = "0x1124D50")]
			set
			{
			}
		}

		[Token(Token = "0x17000172")]
		public List<string> UserMFASettingList
		{
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x1124DB0", Offset = "0x1124DB0", VA = "0x1124DB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x1124DB8", Offset = "0x1124DB8", VA = "0x1124DB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000173")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E820", Offset = "0x1E820")]
		public string Username
		{
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x1124E18", Offset = "0x1124E18", VA = "0x1124E18")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x1124E20", Offset = "0x1124E20", VA = "0x1124E20")]
			set
			{
			}
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x1124CD0", Offset = "0x1124CD0", VA = "0x1124CD0")]
		internal bool IsSetMFAOptions()
		{
			return default;
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x1124D38", Offset = "0x1124D38", VA = "0x1124D38")]
		internal bool IsSetPreferredMfaSetting()
		{
			return default;
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x1124D58", Offset = "0x1124D58", VA = "0x1124D58")]
		internal bool IsSetUserAttributes()
		{
			return default;
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x1124DC0", Offset = "0x1124DC0", VA = "0x1124DC0")]
		internal bool IsSetUserMFASettingList()
		{
			return default;
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x1124E28", Offset = "0x1124E28", VA = "0x1124E28")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x1124E38", Offset = "0x1124E38", VA = "0x1124E38")]
		public GetUserResponse()
		{
		}
	}
}
