using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x2000105")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x184CB8", Offset = "0x184CB8")]
	[Attribute(Name = "NullableAttribute", RVA = "0x184CB8", Offset = "0x184CB8")]
	internal class XProcessingInstructionWrapper : XObjectWrapper
	{
		[Token(Token = "0x1700017F")]
		[Attribute(Name = "NullableAttribute", RVA = "0x18F99C", Offset = "0x18F99C")]
		private XProcessingInstruction ProcessingInstruction
		{
			[Token(Token = "0x6000835")]
			[Address(RVA = "0x232B92C", Offset = "0x232B92C", VA = "0x232B92C")]
			[Attribute(Name = "NullableContextAttribute", RVA = "0x18AF40", Offset = "0x18AF40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000180")]
		public override string LocalName
		{
			[Token(Token = "0x6000837")]
			[Address(RVA = "0x232B9C0", Offset = "0x232B9C0", VA = "0x232B9C0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000181")]
		public override string Value
		{
			[Token(Token = "0x6000838")]
			[Address(RVA = "0x232BA5C", Offset = "0x232BA5C", VA = "0x232BA5C", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x23295C4", Offset = "0x23295C4", VA = "0x23295C4")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x18AF54", Offset = "0x18AF54")]
		public XProcessingInstructionWrapper(XProcessingInstruction processingInstruction)
		{
		}
	}
}
