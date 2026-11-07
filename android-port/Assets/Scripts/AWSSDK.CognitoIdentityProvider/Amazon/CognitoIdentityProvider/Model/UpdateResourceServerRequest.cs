using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000132")]
	public class UpdateResourceServerRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x30")]
		private string _identifier;

		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x38")]
		private string _name;

		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x40")]
		private List<ResourceServerScopeType> _scopes;

		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x48")]
		private string _userPoolId;

		[Token(Token = "0x17000266")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20E04", Offset = "0x20E04")]
		public string Identifier
		{
			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0x1165B58", Offset = "0x1165B58", VA = "0x1165B58")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x1165B60", Offset = "0x1165B60", VA = "0x1165B60")]
			set
			{
			}
		}

		[Token(Token = "0x17000267")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20E54", Offset = "0x20E54")]
		public string Name
		{
			[Token(Token = "0x6000A82")]
			[Address(RVA = "0x1165B78", Offset = "0x1165B78", VA = "0x1165B78")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x1165B80", Offset = "0x1165B80", VA = "0x1165B80")]
			set
			{
			}
		}

		[Token(Token = "0x17000268")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20EA4", Offset = "0x20EA4")]
		public List<ResourceServerScopeType> Scopes
		{
			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x1165B98", Offset = "0x1165B98", VA = "0x1165B98")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x1165BA0", Offset = "0x1165BA0", VA = "0x1165BA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000269")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20EDC", Offset = "0x20EDC")]
		public string UserPoolId
		{
			[Token(Token = "0x6000A88")]
			[Address(RVA = "0x1165C00", Offset = "0x1165C00", VA = "0x1165C00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x1165C08", Offset = "0x1165C08", VA = "0x1165C08")]
			set
			{
			}
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x1165B68", Offset = "0x1165B68", VA = "0x1165B68")]
		internal bool IsSetIdentifier()
		{
			return default;
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x1165B88", Offset = "0x1165B88", VA = "0x1165B88")]
		internal bool IsSetName()
		{
			return default;
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x1165BA8", Offset = "0x1165BA8", VA = "0x1165BA8")]
		internal bool IsSetScopes()
		{
			return default;
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x1165C10", Offset = "0x1165C10", VA = "0x1165C10")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x1165C20", Offset = "0x1165C20", VA = "0x1165C20")]
		public UpdateResourceServerRequest()
		{
		}
	}
}
