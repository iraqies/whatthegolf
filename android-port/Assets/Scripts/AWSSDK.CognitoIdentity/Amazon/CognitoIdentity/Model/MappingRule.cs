using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000041")]
	public class MappingRule
	{
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x10")]
		private string _claim;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x18")]
		private MappingRuleMatchType _matchType;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x20")]
		private string _roleARN;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x28")]
		private string _value;

		[Token(Token = "0x17000076")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23514", Offset = "0x23514")]
		public string Claim
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x1093EA8", Offset = "0x1093EA8", VA = "0x1093EA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x1093EB0", Offset = "0x1093EB0", VA = "0x1093EB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23564", Offset = "0x23564")]
		public MappingRuleMatchType MatchType
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x1093EC8", Offset = "0x1093EC8", VA = "0x1093EC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x1093ED0", Offset = "0x1093ED0", VA = "0x1093ED0")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23598", Offset = "0x23598")]
		public string RoleARN
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x1093F54", Offset = "0x1093F54", VA = "0x1093F54")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x1093F5C", Offset = "0x1093F5C", VA = "0x1093F5C")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x235E8", Offset = "0x235E8")]
		public string Value
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x1093F74", Offset = "0x1093F74", VA = "0x1093F74")]
			get
			{
				return null;
			}
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x1093F7C", Offset = "0x1093F7C", VA = "0x1093F7C")]
			set
			{
			}
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1093EB8", Offset = "0x1093EB8", VA = "0x1093EB8")]
		internal bool IsSetClaim()
		{
			return default;
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1093ED8", Offset = "0x1093ED8", VA = "0x1093ED8")]
		internal bool IsSetMatchType()
		{
			return default;
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1093F64", Offset = "0x1093F64", VA = "0x1093F64")]
		internal bool IsSetRoleARN()
		{
			return default;
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1093F84", Offset = "0x1093F84", VA = "0x1093F84")]
		internal bool IsSetValue()
		{
			return default;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1093F94", Offset = "0x1093F94", VA = "0x1093F94")]
		public MappingRule()
		{
		}
	}
}
