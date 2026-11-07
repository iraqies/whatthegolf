using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000107")]
	public class SchemaAttributeType
	{
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x10")]
		private AttributeDataType _attributeDataType;

		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x18")]
		private bool? _developerOnlyAttribute;

		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x1A")]
		private bool? _mutable;

		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x20")]
		private string _name;

		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x28")]
		private NumberAttributeConstraintsType _numberAttributeConstraints;

		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x30")]
		private bool? _required;

		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x38")]
		private StringAttributeConstraintsType _stringAttributeConstraints;

		[Token(Token = "0x1700020C")]
		public AttributeDataType AttributeDataType
		{
			[Token(Token = "0x6000928")]
			[Address(RVA = "0x114A4A4", Offset = "0x114A4A4", VA = "0x114A4A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000929")]
			[Address(RVA = "0x114A4AC", Offset = "0x114A4AC", VA = "0x114A4AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700020D")]
		public bool DeveloperOnlyAttribute
		{
			[Token(Token = "0x600092B")]
			[Address(RVA = "0x114A530", Offset = "0x114A530", VA = "0x114A530")]
			get
			{
				return default;
			}
			[Token(Token = "0x600092C")]
			[Address(RVA = "0x114A570", Offset = "0x114A570", VA = "0x114A570")]
			set
			{
			}
		}

		[Token(Token = "0x1700020E")]
		public bool Mutable
		{
			[Token(Token = "0x600092E")]
			[Address(RVA = "0x114A624", Offset = "0x114A624", VA = "0x114A624")]
			get
			{
				return default;
			}
			[Token(Token = "0x600092F")]
			[Address(RVA = "0x114A664", Offset = "0x114A664", VA = "0x114A664")]
			set
			{
			}
		}

		[Token(Token = "0x1700020F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x201D8", Offset = "0x201D8")]
		public string Name
		{
			[Token(Token = "0x6000931")]
			[Address(RVA = "0x114A718", Offset = "0x114A718", VA = "0x114A718")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000932")]
			[Address(RVA = "0x114A720", Offset = "0x114A720", VA = "0x114A720")]
			set
			{
			}
		}

		[Token(Token = "0x17000210")]
		public NumberAttributeConstraintsType NumberAttributeConstraints
		{
			[Token(Token = "0x6000934")]
			[Address(RVA = "0x114A738", Offset = "0x114A738", VA = "0x114A738")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000935")]
			[Address(RVA = "0x114A740", Offset = "0x114A740", VA = "0x114A740")]
			set
			{
			}
		}

		[Token(Token = "0x17000211")]
		public bool Required
		{
			[Token(Token = "0x6000937")]
			[Address(RVA = "0x114A758", Offset = "0x114A758", VA = "0x114A758")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000938")]
			[Address(RVA = "0x114A798", Offset = "0x114A798", VA = "0x114A798")]
			set
			{
			}
		}

		[Token(Token = "0x17000212")]
		public StringAttributeConstraintsType StringAttributeConstraints
		{
			[Token(Token = "0x600093A")]
			[Address(RVA = "0x114A84C", Offset = "0x114A84C", VA = "0x114A84C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600093B")]
			[Address(RVA = "0x114A854", Offset = "0x114A854", VA = "0x114A854")]
			set
			{
			}
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x114A4B4", Offset = "0x114A4B4", VA = "0x114A4B4")]
		internal bool IsSetAttributeDataType()
		{
			return default;
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x114A5E4", Offset = "0x114A5E4", VA = "0x114A5E4")]
		internal bool IsSetDeveloperOnlyAttribute()
		{
			return default;
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x114A6D8", Offset = "0x114A6D8", VA = "0x114A6D8")]
		internal bool IsSetMutable()
		{
			return default;
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x114A728", Offset = "0x114A728", VA = "0x114A728")]
		internal bool IsSetName()
		{
			return default;
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0x114A748", Offset = "0x114A748", VA = "0x114A748")]
		internal bool IsSetNumberAttributeConstraints()
		{
			return default;
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x114A80C", Offset = "0x114A80C", VA = "0x114A80C")]
		internal bool IsSetRequired()
		{
			return default;
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x114A85C", Offset = "0x114A85C", VA = "0x114A85C")]
		internal bool IsSetStringAttributeConstraints()
		{
			return default;
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x114A86C", Offset = "0x114A86C", VA = "0x114A86C")]
		public SchemaAttributeType()
		{
		}
	}
}
