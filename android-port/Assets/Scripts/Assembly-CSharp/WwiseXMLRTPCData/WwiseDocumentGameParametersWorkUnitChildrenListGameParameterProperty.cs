using System;
using Il2CppDummyDll;

namespace WwiseXMLRTPCData
{
	[Serializable]
	[Token(Token = "0x2000F4D")]
	[AttributeAttribute(Name = "DesignerCategoryAttribute", RVA = "0x45A1C", Offset = "0x45A1C")]
	[AttributeAttribute(Name = "XmlTypeAttribute", RVA = "0x45A1C", Offset = "0x45A1C")]
	public class WwiseDocumentGameParametersWorkUnitChildrenListGameParameterProperty
	{
		[Token(Token = "0x400529E")]
		[FieldOffset(Offset = "0x10")]
		private string nameField;

		[Token(Token = "0x400529F")]
		[FieldOffset(Offset = "0x18")]
		private byte valueField;

		[Token(Token = "0x17000765")]
		[AttributeAttribute(Name = "XmlAttributeAttribute", RVA = "0x732AC", Offset = "0x732AC")]
		public string Name
		{
			[Token(Token = "0x6004779")]
			[Address(RVA = "0x175FB28", Offset = "0x175FB28", VA = "0x175FB28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000766")]
		[AttributeAttribute(Name = "XmlAttributeAttribute", RVA = "0x732BC", Offset = "0x732BC")]
		public byte Value
		{
			[Token(Token = "0x600477A")]
			[Address(RVA = "0x175FB30", Offset = "0x175FB30", VA = "0x175FB30")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600477B")]
		[Address(RVA = "0x175FB38", Offset = "0x175FB38", VA = "0x175FB38")]
		public WwiseDocumentGameParametersWorkUnitChildrenListGameParameterProperty()
		{
		}
	}
}
