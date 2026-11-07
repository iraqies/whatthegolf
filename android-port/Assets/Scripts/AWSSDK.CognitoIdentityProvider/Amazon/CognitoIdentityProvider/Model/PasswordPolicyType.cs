using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000F8")]
	public class PasswordPolicyType
	{
		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x10")]
		private int? _minimumLength;

		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x18")]
		private bool? _requireLowercase;

		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x1A")]
		private bool? _requireNumbers;

		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x1C")]
		private bool? _requireSymbols;

		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x1E")]
		private bool? _requireUppercase;

		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x20")]
		private int? _temporaryPasswordValidityDays;

		[Token(Token = "0x170001DD")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1FB88", Offset = "0x1FB88")]
		public int MinimumLength
		{
			[Token(Token = "0x600087E")]
			[Address(RVA = "0x113FAAC", Offset = "0x113FAAC", VA = "0x113FAAC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600087F")]
			[Address(RVA = "0x113FAEC", Offset = "0x113FAEC", VA = "0x113FAEC")]
			set
			{
			}
		}

		[Token(Token = "0x170001DE")]
		public bool RequireLowercase
		{
			[Token(Token = "0x6000881")]
			[Address(RVA = "0x113FBA0", Offset = "0x113FBA0", VA = "0x113FBA0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000882")]
			[Address(RVA = "0x113FBE0", Offset = "0x113FBE0", VA = "0x113FBE0")]
			set
			{
			}
		}

		[Token(Token = "0x170001DF")]
		public bool RequireNumbers
		{
			[Token(Token = "0x6000884")]
			[Address(RVA = "0x113FC94", Offset = "0x113FC94", VA = "0x113FC94")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000885")]
			[Address(RVA = "0x113FCD4", Offset = "0x113FCD4", VA = "0x113FCD4")]
			set
			{
			}
		}

		[Token(Token = "0x170001E0")]
		public bool RequireSymbols
		{
			[Token(Token = "0x6000887")]
			[Address(RVA = "0x113FD88", Offset = "0x113FD88", VA = "0x113FD88")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000888")]
			[Address(RVA = "0x113FDC8", Offset = "0x113FDC8", VA = "0x113FDC8")]
			set
			{
			}
		}

		[Token(Token = "0x170001E1")]
		public bool RequireUppercase
		{
			[Token(Token = "0x600088A")]
			[Address(RVA = "0x113FE7C", Offset = "0x113FE7C", VA = "0x113FE7C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600088B")]
			[Address(RVA = "0x113FEBC", Offset = "0x113FEBC", VA = "0x113FEBC")]
			set
			{
			}
		}

		[Token(Token = "0x170001E2")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1FBD0", Offset = "0x1FBD0")]
		public int TemporaryPasswordValidityDays
		{
			[Token(Token = "0x600088D")]
			[Address(RVA = "0x113FF70", Offset = "0x113FF70", VA = "0x113FF70")]
			get
			{
				return default;
			}
			[Token(Token = "0x600088E")]
			[Address(RVA = "0x113FFB0", Offset = "0x113FFB0", VA = "0x113FFB0")]
			set
			{
			}
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x113FB60", Offset = "0x113FB60", VA = "0x113FB60")]
		internal bool IsSetMinimumLength()
		{
			return default;
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x113FC54", Offset = "0x113FC54", VA = "0x113FC54")]
		internal bool IsSetRequireLowercase()
		{
			return default;
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x113FD48", Offset = "0x113FD48", VA = "0x113FD48")]
		internal bool IsSetRequireNumbers()
		{
			return default;
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x113FE3C", Offset = "0x113FE3C", VA = "0x113FE3C")]
		internal bool IsSetRequireSymbols()
		{
			return default;
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x113FF30", Offset = "0x113FF30", VA = "0x113FF30")]
		internal bool IsSetRequireUppercase()
		{
			return default;
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x1140024", Offset = "0x1140024", VA = "0x1140024")]
		internal bool IsSetTemporaryPasswordValidityDays()
		{
			return default;
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x1140064", Offset = "0x1140064", VA = "0x1140064")]
		public PasswordPolicyType()
		{
		}
	}
}
