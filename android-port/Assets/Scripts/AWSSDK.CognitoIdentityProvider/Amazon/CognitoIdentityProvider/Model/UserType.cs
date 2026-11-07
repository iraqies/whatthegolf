using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200014C")]
	public class UserType
	{
		[Token(Token = "0x4000354")]
		[FieldOffset(Offset = "0x10")]
		private List<AttributeType> _attributes;

		[Token(Token = "0x4000355")]
		[FieldOffset(Offset = "0x18")]
		private bool? _enabled;

		[Token(Token = "0x4000356")]
		[FieldOffset(Offset = "0x20")]
		private List<MFAOptionType> _mfaOptions;

		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0x28")]
		private DateTime? _userCreateDate;

		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x38")]
		private DateTime? _userLastModifiedDate;

		[Token(Token = "0x4000359")]
		[FieldOffset(Offset = "0x48")]
		private string _username;

		[Token(Token = "0x400035A")]
		[FieldOffset(Offset = "0x50")]
		private UserStatusType _userStatus;

		[Token(Token = "0x170002E1")]
		public List<AttributeType> Attributes
		{
			[Token(Token = "0x6000C27")]
			[Address(RVA = "0x1178668", Offset = "0x1178668", VA = "0x1178668")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C28")]
			[Address(RVA = "0x1178670", Offset = "0x1178670", VA = "0x1178670")]
			set
			{
			}
		}

		[Token(Token = "0x170002E2")]
		public bool Enabled
		{
			[Token(Token = "0x6000C2A")]
			[Address(RVA = "0x11786D0", Offset = "0x11786D0", VA = "0x11786D0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000C2B")]
			[Address(RVA = "0x1178710", Offset = "0x1178710", VA = "0x1178710")]
			set
			{
			}
		}

		[Token(Token = "0x170002E3")]
		public List<MFAOptionType> MFAOptions
		{
			[Token(Token = "0x6000C2D")]
			[Address(RVA = "0x11787C4", Offset = "0x11787C4", VA = "0x11787C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C2E")]
			[Address(RVA = "0x11787CC", Offset = "0x11787CC", VA = "0x11787CC")]
			set
			{
			}
		}

		[Token(Token = "0x170002E4")]
		public DateTime UserCreateDate
		{
			[Token(Token = "0x6000C30")]
			[Address(RVA = "0x117882C", Offset = "0x117882C", VA = "0x117882C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000C31")]
			[Address(RVA = "0x117886C", Offset = "0x117886C", VA = "0x117886C")]
			set
			{
			}
		}

		[Token(Token = "0x170002E5")]
		public DateTime UserLastModifiedDate
		{
			[Token(Token = "0x6000C33")]
			[Address(RVA = "0x1178920", Offset = "0x1178920", VA = "0x1178920")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000C34")]
			[Address(RVA = "0x1178960", Offset = "0x1178960", VA = "0x1178960")]
			set
			{
			}
		}

		[Token(Token = "0x170002E6")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x21DEC", Offset = "0x21DEC")]
		public string Username
		{
			[Token(Token = "0x6000C36")]
			[Address(RVA = "0x1178A14", Offset = "0x1178A14", VA = "0x1178A14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C37")]
			[Address(RVA = "0x1178A1C", Offset = "0x1178A1C", VA = "0x1178A1C")]
			set
			{
			}
		}

		[Token(Token = "0x170002E7")]
		public UserStatusType UserStatus
		{
			[Token(Token = "0x6000C39")]
			[Address(RVA = "0x1178A34", Offset = "0x1178A34", VA = "0x1178A34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C3A")]
			[Address(RVA = "0x1178A3C", Offset = "0x1178A3C", VA = "0x1178A3C")]
			set
			{
			}
		}

		[Token(Token = "0x6000C29")]
		[Address(RVA = "0x1178678", Offset = "0x1178678", VA = "0x1178678")]
		internal bool IsSetAttributes()
		{
			return default;
		}

		[Token(Token = "0x6000C2C")]
		[Address(RVA = "0x1178784", Offset = "0x1178784", VA = "0x1178784")]
		internal bool IsSetEnabled()
		{
			return default;
		}

		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0x11787D4", Offset = "0x11787D4", VA = "0x11787D4")]
		internal bool IsSetMFAOptions()
		{
			return default;
		}

		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x11788E0", Offset = "0x11788E0", VA = "0x11788E0")]
		internal bool IsSetUserCreateDate()
		{
			return default;
		}

		[Token(Token = "0x6000C35")]
		[Address(RVA = "0x11789D4", Offset = "0x11789D4", VA = "0x11789D4")]
		internal bool IsSetUserLastModifiedDate()
		{
			return default;
		}

		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x1178A24", Offset = "0x1178A24", VA = "0x1178A24")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x1178A44", Offset = "0x1178A44", VA = "0x1178A44")]
		internal bool IsSetUserStatus()
		{
			return default;
		}

		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x1178AC0", Offset = "0x1178AC0", VA = "0x1178AC0")]
		public UserType()
		{
		}
	}
}
