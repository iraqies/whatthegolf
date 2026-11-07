using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x200002C")]
	public class GetIdentityPoolRolesResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x28")]
		private string _identityPoolId;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, RoleMapping> _roleMappings;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, string> _roles;

		[Token(Token = "0x1700004A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22BE8", Offset = "0x22BE8")]
		public string IdentityPoolId
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x108819C", Offset = "0x108819C", VA = "0x108819C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x10881A4", Offset = "0x10881A4", VA = "0x10881A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22C30", Offset = "0x22C30")]
		public Dictionary<string, RoleMapping> RoleMappings
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x10881BC", Offset = "0x10881BC", VA = "0x10881BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x10881C4", Offset = "0x10881C4", VA = "0x10881C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22C68", Offset = "0x22C68")]
		public Dictionary<string, string> Roles
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x1088228", Offset = "0x1088228", VA = "0x1088228")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x1088230", Offset = "0x1088230", VA = "0x1088230")]
			set
			{
			}
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x10881AC", Offset = "0x10881AC", VA = "0x10881AC")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x10881CC", Offset = "0x10881CC", VA = "0x10881CC")]
		internal bool IsSetRoleMappings()
		{
			return default;
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1088238", Offset = "0x1088238", VA = "0x1088238")]
		internal bool IsSetRoles()
		{
			return default;
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1088294", Offset = "0x1088294", VA = "0x1088294")]
		public GetIdentityPoolRolesResponse()
		{
		}
	}
}
