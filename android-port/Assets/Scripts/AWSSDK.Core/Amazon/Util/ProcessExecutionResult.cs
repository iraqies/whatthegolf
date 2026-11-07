using Il2CppDummyDll;

namespace Amazon.Util
{
	[Token(Token = "0x2000065")]
	public class ProcessExecutionResult
	{
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x263B8", Offset = "0x263B8")]
		private int ExitCode__BackingField;

		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x263C8", Offset = "0x263C8")]
		private string StandardOutput__BackingField;

		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x263D8", Offset = "0x263D8")]
		private string StandardError__BackingField;

		[Token(Token = "0x170000B8")]
		public int ExitCode
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x124F628", Offset = "0x124F628", VA = "0x124F628")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2833C", Offset = "0x2833C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x124F630", Offset = "0x124F630", VA = "0x124F630")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2834C", Offset = "0x2834C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public string StandardOutput
		{
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x124F638", Offset = "0x124F638", VA = "0x124F638")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2835C", Offset = "0x2835C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x124F640", Offset = "0x124F640", VA = "0x124F640")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2836C", Offset = "0x2836C")]
			set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public string StandardError
		{
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x124F648", Offset = "0x124F648", VA = "0x124F648")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2837C", Offset = "0x2837C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x124F650", Offset = "0x124F650", VA = "0x124F650")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2838C", Offset = "0x2838C")]
			set
			{
			}
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x124F658", Offset = "0x124F658", VA = "0x124F658")]
		public ProcessExecutionResult()
		{
		}
	}
}
