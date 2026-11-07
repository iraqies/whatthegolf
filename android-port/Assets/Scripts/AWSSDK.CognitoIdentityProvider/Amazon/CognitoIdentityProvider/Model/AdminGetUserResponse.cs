using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000044")]
	public class AdminGetUserResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x24")]
		private bool? _enabled;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x28")]
		private List<MFAOptionType> _mfaOptions;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x30")]
		private string _preferredMfaSetting;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x38")]
		private List<AttributeType> _userAttributes;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x40")]
		private DateTime? _userCreateDate;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x50")]
		private DateTime? _userLastModifiedDate;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x60")]
		private List<string> _userMFASettingList;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x68")]
		private string _username;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x70")]
		private UserStatusType _userStatus;

		[Token(Token = "0x17000036")]
		public bool Enabled
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x10AB5CC", Offset = "0x10AB5CC", VA = "0x10AB5CC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x10AB60C", Offset = "0x10AB60C", VA = "0x10AB60C")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public List<MFAOptionType> MFAOptions
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x10AB6C0", Offset = "0x10AB6C0", VA = "0x10AB6C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x10AB6C8", Offset = "0x10AB6C8", VA = "0x10AB6C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public string PreferredMfaSetting
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x10AB728", Offset = "0x10AB728", VA = "0x10AB728")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x10AB730", Offset = "0x10AB730", VA = "0x10AB730")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public List<AttributeType> UserAttributes
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x10AB748", Offset = "0x10AB748", VA = "0x10AB748")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x10AB750", Offset = "0x10AB750", VA = "0x10AB750")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public DateTime UserCreateDate
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x10AB7B0", Offset = "0x10AB7B0", VA = "0x10AB7B0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x10AB7F0", Offset = "0x10AB7F0", VA = "0x10AB7F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public DateTime UserLastModifiedDate
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x10AB8A4", Offset = "0x10AB8A4", VA = "0x10AB8A4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x10AB8E4", Offset = "0x10AB8E4", VA = "0x10AB8E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public List<string> UserMFASettingList
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x10AB998", Offset = "0x10AB998", VA = "0x10AB998")]
			get
			{
				return null;
			}
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x10AB9A0", Offset = "0x10AB9A0", VA = "0x10AB9A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x1B610", Offset = "0x1B610")]
		public string Username
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x10ABA00", Offset = "0x10ABA00", VA = "0x10ABA00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x10ABA08", Offset = "0x10ABA08", VA = "0x10ABA08")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public UserStatusType UserStatus
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x10ABA20", Offset = "0x10ABA20", VA = "0x10ABA20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x10ABA28", Offset = "0x10ABA28", VA = "0x10ABA28")]
			set
			{
			}
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x10AB680", Offset = "0x10AB680", VA = "0x10AB680")]
		internal bool IsSetEnabled()
		{
			return default;
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x10AB6D0", Offset = "0x10AB6D0", VA = "0x10AB6D0")]
		internal bool IsSetMFAOptions()
		{
			return default;
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x10AB738", Offset = "0x10AB738", VA = "0x10AB738")]
		internal bool IsSetPreferredMfaSetting()
		{
			return default;
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x10AB758", Offset = "0x10AB758", VA = "0x10AB758")]
		internal bool IsSetUserAttributes()
		{
			return default;
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x10AB864", Offset = "0x10AB864", VA = "0x10AB864")]
		internal bool IsSetUserCreateDate()
		{
			return default;
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x10AB958", Offset = "0x10AB958", VA = "0x10AB958")]
		internal bool IsSetUserLastModifiedDate()
		{
			return default;
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x10AB9A8", Offset = "0x10AB9A8", VA = "0x10AB9A8")]
		internal bool IsSetUserMFASettingList()
		{
			return default;
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x10ABA10", Offset = "0x10ABA10", VA = "0x10ABA10")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x10ABA30", Offset = "0x10ABA30", VA = "0x10ABA30")]
		internal bool IsSetUserStatus()
		{
			return default;
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x10ABAAC", Offset = "0x10ABAAC", VA = "0x10ABAAC")]
		public AdminGetUserResponse()
		{
		}
	}
}
