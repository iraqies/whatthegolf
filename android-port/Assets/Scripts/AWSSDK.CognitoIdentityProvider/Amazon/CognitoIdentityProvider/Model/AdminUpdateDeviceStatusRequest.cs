using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200005D")]
	public class AdminUpdateDeviceStatusRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x30")]
		private string _deviceKey;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x38")]
		private DeviceRememberedStatusType _deviceRememberedStatus;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x40")]
		private string _username;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x48")]
		private string _userPoolId;

		[Token(Token = "0x17000080")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C29C", Offset = "0x1C29C")]
		public string DeviceKey
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x10C202C", Offset = "0x10C202C", VA = "0x10C202C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x10C2034", Offset = "0x10C2034", VA = "0x10C2034")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public DeviceRememberedStatusType DeviceRememberedStatus
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x10C204C", Offset = "0x10C204C", VA = "0x10C204C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x10C2054", Offset = "0x10C2054", VA = "0x10C2054")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C2EC", Offset = "0x1C2EC")]
		public string Username
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x10C20D8", Offset = "0x10C20D8", VA = "0x10C20D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600037A")]
			[Address(RVA = "0x10C20E0", Offset = "0x10C20E0", VA = "0x10C20E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C33C", Offset = "0x1C33C")]
		public string UserPoolId
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x10C20F8", Offset = "0x10C20F8", VA = "0x10C20F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x10C2100", Offset = "0x10C2100", VA = "0x10C2100")]
			set
			{
			}
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x10C203C", Offset = "0x10C203C", VA = "0x10C203C")]
		internal bool IsSetDeviceKey()
		{
			return default;
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x10C205C", Offset = "0x10C205C", VA = "0x10C205C")]
		internal bool IsSetDeviceRememberedStatus()
		{
			return default;
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x10C20E8", Offset = "0x10C20E8", VA = "0x10C20E8")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x10C2108", Offset = "0x10C2108", VA = "0x10C2108")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x10C2118", Offset = "0x10C2118", VA = "0x10C2118")]
		public AdminUpdateDeviceStatusRequest()
		{
		}
	}
}
