using Il2CppDummyDll;

namespace Audio.Conditions
{
	[Token(Token = "0x20013EB")]
	public abstract class AudioDelayCondition : AudioCondition
	{
		[Token(Token = "0x4006B2C")]
		[FieldOffset(Offset = "0x18")]
		public float delay;

		[Token(Token = "0x4006B2D")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AB94", Offset = "0x5AB94")]
		private float NextTime__BackingField;

		[Token(Token = "0x17000A82")]
		public float NextTime
		{
			[Token(Token = "0x6005CD8")]
			[Address(RVA = "0x142CE28", Offset = "0x142CE28", VA = "0x142CE28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72840", Offset = "0x72840")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005CD9")]
			[Address(RVA = "0x142CE30", Offset = "0x142CE30", VA = "0x142CE30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x72850", Offset = "0x72850")]
			protected set
			{
			}
		}

		[Token(Token = "0x6005CDA")]
		[Address(RVA = "0x142CE38", Offset = "0x142CE38", VA = "0x142CE38")]
		protected AudioDelayCondition()
		{
		}
	}
}
