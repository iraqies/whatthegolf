using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x200009D")]
	public class RetryableDetails
	{
		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26788", Offset = "0x26788")]
		private bool Throttling__BackingField;

		[Token(Token = "0x1700016B")]
		public bool Throttling
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x1263E4C", Offset = "0x1263E4C", VA = "0x1263E4C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28BEC", Offset = "0x28BEC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x1263E54", Offset = "0x1263E54", VA = "0x1263E54")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28BFC", Offset = "0x28BFC")]
			private set
			{
			}
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x1263E20", Offset = "0x1263E20", VA = "0x1263E20")]
		public RetryableDetails(bool throttling)
		{
		}
	}
}
