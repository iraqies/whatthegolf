using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000147")]
	public class RetryCapacity
	{
		[Token(Token = "0x400050A")]
		[FieldOffset(Offset = "0x10")]
		private readonly int _maxCapacity;

		[Token(Token = "0x400050B")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27088", Offset = "0x27088")]
		private int AvailableCapacity__BackingField;

		[Token(Token = "0x170002A8")]
		public int AvailableCapacity
		{
			[Token(Token = "0x6000A72")]
			[Address(RVA = "0x1260488", Offset = "0x1260488", VA = "0x1260488")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x29F14", Offset = "0x29F14")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000A73")]
			[Address(RVA = "0x1260490", Offset = "0x1260490", VA = "0x1260490")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x29F24", Offset = "0x29F24")]
			set
			{
			}
		}

		[Token(Token = "0x170002A9")]
		public int MaxCapacity
		{
			[Token(Token = "0x6000A74")]
			[Address(RVA = "0x1260498", Offset = "0x1260498", VA = "0x1260498")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x12604A0", Offset = "0x12604A0", VA = "0x12604A0")]
		public RetryCapacity(int maxCapacity)
		{
		}
	}
}
