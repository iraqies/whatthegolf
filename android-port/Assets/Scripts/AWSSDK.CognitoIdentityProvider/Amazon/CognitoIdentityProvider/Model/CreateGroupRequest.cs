using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200007B")]
	public class CreateGroupRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x30")]
		private string _description;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x38")]
		private string _groupName;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x40")]
		private int? _precedence;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x48")]
		private string _roleArn;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x50")]
		private string _userPoolId;

		[Token(Token = "0x170000C8")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1CCE8", Offset = "0x1CCE8")]
		public string Description
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x10EB45C", Offset = "0x10EB45C", VA = "0x10EB45C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x10EB464", Offset = "0x10EB464", VA = "0x10EB464")]
			set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1CD20", Offset = "0x1CD20")]
		public string GroupName
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x10EB47C", Offset = "0x10EB47C", VA = "0x10EB47C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x10EB484", Offset = "0x10EB484", VA = "0x10EB484")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1CD70", Offset = "0x1CD70")]
		public int Precedence
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x10EB49C", Offset = "0x10EB49C", VA = "0x10EB49C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x10EB4DC", Offset = "0x10EB4DC", VA = "0x10EB4DC")]
			set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1CDA8", Offset = "0x1CDA8")]
		public string RoleArn
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x10EB590", Offset = "0x10EB590", VA = "0x10EB590")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x10EB598", Offset = "0x10EB598", VA = "0x10EB598")]
			set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1CDF0", Offset = "0x1CDF0")]
		public string UserPoolId
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x10EB5B0", Offset = "0x10EB5B0", VA = "0x10EB5B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x10EB5B8", Offset = "0x10EB5B8", VA = "0x10EB5B8")]
			set
			{
			}
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x10EB46C", Offset = "0x10EB46C", VA = "0x10EB46C")]
		internal bool IsSetDescription()
		{
			return default;
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x10EB48C", Offset = "0x10EB48C", VA = "0x10EB48C")]
		internal bool IsSetGroupName()
		{
			return default;
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x10EB550", Offset = "0x10EB550", VA = "0x10EB550")]
		internal bool IsSetPrecedence()
		{
			return default;
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x10EB5A0", Offset = "0x10EB5A0", VA = "0x10EB5A0")]
		internal bool IsSetRoleArn()
		{
			return default;
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x10EB5C0", Offset = "0x10EB5C0", VA = "0x10EB5C0")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x10EB5D0", Offset = "0x10EB5D0", VA = "0x10EB5D0")]
		public CreateGroupRequest()
		{
		}
	}
}
