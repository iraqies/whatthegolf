using System;
using Il2CppDummyDll;

namespace WwiseXMLRTPCData
{
	[Serializable]
	[Token(Token = "0x2000F4C")]
	[AttributeAttribute(Name = "DesignerCategoryAttribute", RVA = "0x459C0", Offset = "0x459C0")]
	[AttributeAttribute(Name = "XmlTypeAttribute", RVA = "0x459C0", Offset = "0x459C0")]
	public class WwiseDocumentGameParametersWorkUnitChildrenListGameParameter
	{
		[Token(Token = "0x400529B")]
		[FieldOffset(Offset = "0x10")]
		private WwiseDocumentGameParametersWorkUnitChildrenListGameParameterProperty[] propertyListField;

		[Token(Token = "0x400529C")]
		[FieldOffset(Offset = "0x18")]
		private string nameField;

		[Token(Token = "0x400529D")]
		[FieldOffset(Offset = "0x20")]
		private string idField;

		[Token(Token = "0x17000762")]
		[AttributeAttribute(Name = "XmlArrayItemAttribute", RVA = "0x73244", Offset = "0x73244")]
		public WwiseDocumentGameParametersWorkUnitChildrenListGameParameterProperty[] PropertyList
		{
			[Token(Token = "0x6004775")]
			[Address(RVA = "0x175FB08", Offset = "0x175FB08", VA = "0x175FB08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000763")]
		[AttributeAttribute(Name = "XmlAttributeAttribute", RVA = "0x7328C", Offset = "0x7328C")]
		public string Name
		{
			[Token(Token = "0x6004776")]
			[Address(RVA = "0x175FB10", Offset = "0x175FB10", VA = "0x175FB10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000764")]
		[AttributeAttribute(Name = "XmlAttributeAttribute", RVA = "0x7329C", Offset = "0x7329C")]
		public string ID
		{
			[Token(Token = "0x6004777")]
			[Address(RVA = "0x175FB18", Offset = "0x175FB18", VA = "0x175FB18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004778")]
		[Address(RVA = "0x175FB20", Offset = "0x175FB20", VA = "0x175FB20")]
		public WwiseDocumentGameParametersWorkUnitChildrenListGameParameter()
		{
		}
	}
}
