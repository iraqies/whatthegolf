using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000051")]
	public class AdminResetUserPasswordRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, string> _clientMetadata;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x38")]
		private string _username;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x40")]
		private string _userPoolId;

		[Token(Token = "0x17000062")]
		public Dictionary<string, string> ClientMetadata
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x10B75E0", Offset = "0x10B75E0", VA = "0x10B75E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600030E")]
			[Address(RVA = "0x10B75E8", Offset = "0x10B75E8", VA = "0x10B75E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1BD10", Offset = "0x1BD10")]
		public string Username
		{
			[Token(Token = "0x6000310")]
			[Address(RVA = "0x10B764C", Offset = "0x10B764C", VA = "0x10B764C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000311")]
			[Address(RVA = "0x10B7654", Offset = "0x10B7654", VA = "0x10B7654")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1BD60", Offset = "0x1BD60")]
		public string UserPoolId
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x10B766C", Offset = "0x10B766C", VA = "0x10B766C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x10B7674", Offset = "0x10B7674", VA = "0x10B7674")]
			set
			{
			}
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x10B75F0", Offset = "0x10B75F0", VA = "0x10B75F0")]
		internal bool IsSetClientMetadata()
		{
			return default;
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x10B765C", Offset = "0x10B765C", VA = "0x10B765C")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x10B767C", Offset = "0x10B767C", VA = "0x10B767C")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x10B768C", Offset = "0x10B768C", VA = "0x10B768C")]
		public AdminResetUserPasswordRequest()
		{
		}
	}
}
