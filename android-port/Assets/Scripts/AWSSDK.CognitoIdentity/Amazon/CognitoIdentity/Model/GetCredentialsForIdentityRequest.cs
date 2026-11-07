using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000029")]
	public class GetCredentialsForIdentityRequest : AmazonCognitoIdentityRequest
	{
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x30")]
		private string _customRoleArn;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x38")]
		private string _identityId;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, string> _logins;

		[Token(Token = "0x17000044")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22A80", Offset = "0x22A80")]
		public string CustomRoleArn
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x1084160", Offset = "0x1084160", VA = "0x1084160")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x1084168", Offset = "0x1084168", VA = "0x1084168")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22AC8", Offset = "0x22AC8")]
		public string IdentityId
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x1084180", Offset = "0x1084180", VA = "0x1084180")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x1084188", Offset = "0x1084188", VA = "0x1084188")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22B18", Offset = "0x22B18")]
		public Dictionary<string, string> Logins
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x10841A0", Offset = "0x10841A0", VA = "0x10841A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x10841A8", Offset = "0x10841A8", VA = "0x10841A8")]
			set
			{
			}
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1084170", Offset = "0x1084170", VA = "0x1084170")]
		internal bool IsSetCustomRoleArn()
		{
			return default;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1084190", Offset = "0x1084190", VA = "0x1084190")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x10841B0", Offset = "0x10841B0", VA = "0x10841B0")]
		internal bool IsSetLogins()
		{
			return default;
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x10725B8", Offset = "0x10725B8", VA = "0x10725B8")]
		public GetCredentialsForIdentityRequest()
		{
		}
	}
}
