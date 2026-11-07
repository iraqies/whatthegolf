using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x200016E")]
	internal class ServiceMetadata : IServiceMetadata
	{
		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27258", Offset = "0x27258")]
		private readonly string ServiceId__BackingField;

		[Token(Token = "0x400058C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27268", Offset = "0x27268")]
		private readonly IDictionary<string, string> OperationNameMapping__BackingField;

		[Token(Token = "0x17000317")]
		public string ServiceId
		{
			[Token(Token = "0x6000BA2")]
			[Address(RVA = "0x1271CA4", Offset = "0x1271CA4", VA = "0x1271CA4", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A2F4", Offset = "0x2A2F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000318")]
		public IDictionary<string, string> OperationNameMapping
		{
			[Token(Token = "0x6000BA3")]
			[Address(RVA = "0x1271CAC", Offset = "0x1271CAC", VA = "0x1271CAC", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A304", Offset = "0x2A304")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x1271CB4", Offset = "0x1271CB4", VA = "0x1271CB4")]
		public ServiceMetadata()
		{
		}
	}
}
