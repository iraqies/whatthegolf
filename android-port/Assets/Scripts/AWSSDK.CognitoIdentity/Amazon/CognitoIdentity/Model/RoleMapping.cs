using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000047")]
	public class RoleMapping
	{
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x10")]
		private AmbiguousRoleResolutionType _ambiguousRoleResolution;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x18")]
		private RulesConfigurationType _rulesConfiguration;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x20")]
		private RoleMappingType _type;

		[Token(Token = "0x1700007F")]
		public AmbiguousRoleResolutionType AmbiguousRoleResolution
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x10966A0", Offset = "0x10966A0", VA = "0x10966A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x10966A8", Offset = "0x10966A8", VA = "0x10966A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public RulesConfigurationType RulesConfiguration
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x109672C", Offset = "0x109672C", VA = "0x109672C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x1096734", Offset = "0x1096734", VA = "0x1096734")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x237C0", Offset = "0x237C0")]
		public RoleMappingType Type
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x109674C", Offset = "0x109674C", VA = "0x109674C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x1096754", Offset = "0x1096754", VA = "0x1096754")]
			set
			{
			}
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x10966B0", Offset = "0x10966B0", VA = "0x10966B0")]
		internal bool IsSetAmbiguousRoleResolution()
		{
			return default;
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x109673C", Offset = "0x109673C", VA = "0x109673C")]
		internal bool IsSetRulesConfiguration()
		{
			return default;
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x109675C", Offset = "0x109675C", VA = "0x109675C")]
		internal bool IsSetType()
		{
			return default;
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x10967D8", Offset = "0x10967D8", VA = "0x10967D8")]
		public RoleMapping()
		{
		}
	}
}
