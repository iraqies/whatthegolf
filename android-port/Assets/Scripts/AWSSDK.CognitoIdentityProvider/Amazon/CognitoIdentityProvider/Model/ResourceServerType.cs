using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000102")]
	public class ResourceServerType
	{
		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x10")]
		private string _identifier;

		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x18")]
		private string _name;

		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x20")]
		private List<ResourceServerScopeType> _scopes;

		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x28")]
		private string _userPoolId;

		[Token(Token = "0x170001F5")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1FEB4", Offset = "0x1FEB4")]
		public string Identifier
		{
			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x1145168", Offset = "0x1145168", VA = "0x1145168")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x1145170", Offset = "0x1145170", VA = "0x1145170")]
			set
			{
			}
		}

		[Token(Token = "0x170001F6")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1FEFC", Offset = "0x1FEFC")]
		public string Name
		{
			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x1145188", Offset = "0x1145188", VA = "0x1145188")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x1145190", Offset = "0x1145190", VA = "0x1145190")]
			set
			{
			}
		}

		[Token(Token = "0x170001F7")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1FF44", Offset = "0x1FF44")]
		public List<ResourceServerScopeType> Scopes
		{
			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x11451A8", Offset = "0x11451A8", VA = "0x11451A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008E4")]
			[Address(RVA = "0x11451B0", Offset = "0x11451B0", VA = "0x11451B0")]
			set
			{
			}
		}

		[Token(Token = "0x170001F8")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1FF7C", Offset = "0x1FF7C")]
		public string UserPoolId
		{
			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x1145210", Offset = "0x1145210", VA = "0x1145210")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x1145218", Offset = "0x1145218", VA = "0x1145218")]
			set
			{
			}
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x1145178", Offset = "0x1145178", VA = "0x1145178")]
		internal bool IsSetIdentifier()
		{
			return default;
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x1145198", Offset = "0x1145198", VA = "0x1145198")]
		internal bool IsSetName()
		{
			return default;
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x11451B8", Offset = "0x11451B8", VA = "0x11451B8")]
		internal bool IsSetScopes()
		{
			return default;
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x1145220", Offset = "0x1145220", VA = "0x1145220")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x1145230", Offset = "0x1145230", VA = "0x1145230")]
		public ResourceServerType()
		{
		}
	}
}
