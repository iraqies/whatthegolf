using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200012E")]
	public class UpdateGroupRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x30")]
		private string _description;

		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x38")]
		private string _groupName;

		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x40")]
		private int? _precedence;

		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x48")]
		private string _roleArn;

		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x50")]
		private string _userPoolId;

		[Token(Token = "0x1700025A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20B90", Offset = "0x20B90")]
		public string Description
		{
			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x1162594", Offset = "0x1162594", VA = "0x1162594")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A58")]
			[Address(RVA = "0x116259C", Offset = "0x116259C", VA = "0x116259C")]
			set
			{
			}
		}

		[Token(Token = "0x1700025B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20BC8", Offset = "0x20BC8")]
		public string GroupName
		{
			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0x11625B4", Offset = "0x11625B4", VA = "0x11625B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0x11625BC", Offset = "0x11625BC", VA = "0x11625BC")]
			set
			{
			}
		}

		[Token(Token = "0x1700025C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20C18", Offset = "0x20C18")]
		public int Precedence
		{
			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0x11625D4", Offset = "0x11625D4", VA = "0x11625D4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0x1162614", Offset = "0x1162614", VA = "0x1162614")]
			set
			{
			}
		}

		[Token(Token = "0x1700025D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20C50", Offset = "0x20C50")]
		public string RoleArn
		{
			[Token(Token = "0x6000A60")]
			[Address(RVA = "0x11626C8", Offset = "0x11626C8", VA = "0x11626C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x11626D0", Offset = "0x11626D0", VA = "0x11626D0")]
			set
			{
			}
		}

		[Token(Token = "0x1700025E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20C98", Offset = "0x20C98")]
		public string UserPoolId
		{
			[Token(Token = "0x6000A63")]
			[Address(RVA = "0x11626E8", Offset = "0x11626E8", VA = "0x11626E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A64")]
			[Address(RVA = "0x11626F0", Offset = "0x11626F0", VA = "0x11626F0")]
			set
			{
			}
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x11625A4", Offset = "0x11625A4", VA = "0x11625A4")]
		internal bool IsSetDescription()
		{
			return default;
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x11625C4", Offset = "0x11625C4", VA = "0x11625C4")]
		internal bool IsSetGroupName()
		{
			return default;
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x1162688", Offset = "0x1162688", VA = "0x1162688")]
		internal bool IsSetPrecedence()
		{
			return default;
		}

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x11626D8", Offset = "0x11626D8", VA = "0x11626D8")]
		internal bool IsSetRoleArn()
		{
			return default;
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x11626F8", Offset = "0x11626F8", VA = "0x11626F8")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x1162708", Offset = "0x1162708", VA = "0x1162708")]
		public UpdateGroupRequest()
		{
		}
	}
}
