using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000064")]
	public class AnalyticsConfigurationType
	{
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x10")]
		private string _applicationId;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x18")]
		private string _externalId;

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x20")]
		private string _roleArn;

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x28")]
		private bool? _userDataShared;

		[Token(Token = "0x1700008A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C500", Offset = "0x1C500")]
		public string ApplicationId
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x10DC29C", Offset = "0x10DC29C", VA = "0x10DC29C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x10DC2A4", Offset = "0x10DC2A4", VA = "0x10DC2A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C534", Offset = "0x1C534")]
		public string ExternalId
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x10DC2BC", Offset = "0x10DC2BC", VA = "0x10DC2BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x10DC2C4", Offset = "0x10DC2C4", VA = "0x10DC2C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C568", Offset = "0x1C568")]
		public string RoleArn
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x10DC2DC", Offset = "0x10DC2DC", VA = "0x10DC2DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x10DC2E4", Offset = "0x10DC2E4", VA = "0x10DC2E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public bool UserDataShared
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x10DC2FC", Offset = "0x10DC2FC", VA = "0x10DC2FC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x10DC33C", Offset = "0x10DC33C", VA = "0x10DC33C")]
			set
			{
			}
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x10DC2AC", Offset = "0x10DC2AC", VA = "0x10DC2AC")]
		internal bool IsSetApplicationId()
		{
			return default;
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x10DC2CC", Offset = "0x10DC2CC", VA = "0x10DC2CC")]
		internal bool IsSetExternalId()
		{
			return default;
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x10DC2EC", Offset = "0x10DC2EC", VA = "0x10DC2EC")]
		internal bool IsSetRoleArn()
		{
			return default;
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x10DC3B0", Offset = "0x10DC3B0", VA = "0x10DC3B0")]
		internal bool IsSetUserDataShared()
		{
			return default;
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x10DC3F0", Offset = "0x10DC3F0", VA = "0x10DC3F0")]
		public AnalyticsConfigurationType()
		{
		}
	}
}
