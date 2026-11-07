using Il2CppDummyDll;

namespace Amazon.Util.Internal
{
	[Token(Token = "0x2000083")]
	public sealed class EnvironmentVariableSource
	{
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly EnvironmentVariableSource instance;

		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26668", Offset = "0x26668")]
		private IEnvironmentVariableRetriever EnvironmentVariableRetriever__BackingField;

		[Token(Token = "0x1700013E")]
		public IEnvironmentVariableRetriever EnvironmentVariableRetriever
		{
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x1200188", Offset = "0x1200188", VA = "0x1200188")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2892C", Offset = "0x2892C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x1200190", Offset = "0x1200190", VA = "0x1200190")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2893C", Offset = "0x2893C")]
			set
			{
			}
		}

		[Token(Token = "0x1700013F")]
		public static EnvironmentVariableSource Instance
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x1200198", Offset = "0x1200198", VA = "0x1200198")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1200070", Offset = "0x1200070", VA = "0x1200070")]
		private EnvironmentVariableSource()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x12000DC", Offset = "0x12000DC", VA = "0x12000DC")]
		static EnvironmentVariableSource()
		{
		}
	}
}
