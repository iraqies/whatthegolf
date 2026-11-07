using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000049")]
	public class SetIdentityPoolRolesRequest : AmazonCognitoIdentityRequest
	{
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x30")]
		private string _identityPoolId;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, RoleMapping> _roleMappings;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, string> _roles;

		[Token(Token = "0x17000083")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23844", Offset = "0x23844")]
		public string IdentityPoolId
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x117E768", Offset = "0x117E768", VA = "0x117E768")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x117E770", Offset = "0x117E770", VA = "0x117E770")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23894", Offset = "0x23894")]
		public Dictionary<string, RoleMapping> RoleMappings
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x117E788", Offset = "0x117E788", VA = "0x117E788")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x117E790", Offset = "0x117E790", VA = "0x117E790")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x238CC", Offset = "0x238CC")]
		public Dictionary<string, string> Roles
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x117E7F4", Offset = "0x117E7F4", VA = "0x117E7F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x117E7FC", Offset = "0x117E7FC", VA = "0x117E7FC")]
			set
			{
			}
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x117E778", Offset = "0x117E778", VA = "0x117E778")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x117E798", Offset = "0x117E798", VA = "0x117E798")]
		internal bool IsSetRoleMappings()
		{
			return default;
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x117E804", Offset = "0x117E804", VA = "0x117E804")]
		internal bool IsSetRoles()
		{
			return default;
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x117E860", Offset = "0x117E860", VA = "0x117E860")]
		public SetIdentityPoolRolesRequest()
		{
		}
	}
}
