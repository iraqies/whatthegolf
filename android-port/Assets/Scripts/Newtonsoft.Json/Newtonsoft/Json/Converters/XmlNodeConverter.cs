using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x200010A")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x184DF8", Offset = "0x184DF8")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x184DF8", Offset = "0x184DF8")]
	public class XmlNodeConverter : JsonConverter
	{
		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly List<IXmlNode> EmptyChildNodes;

		[Token(Token = "0x400036E")]
		private const string TextName = "#text";

		[Token(Token = "0x400036F")]
		private const string CommentName = "#comment";

		[Token(Token = "0x4000370")]
		private const string CDataName = "#cdata-section";

		[Token(Token = "0x4000371")]
		private const string WhitespaceName = "#whitespace";

		[Token(Token = "0x4000372")]
		private const string SignificantWhitespaceName = "#significant-whitespace";

		[Token(Token = "0x4000373")]
		private const string DeclarationName = "?xml";

		[Token(Token = "0x4000374")]
		private const string JsonNamespaceUri = "http://james.newtonking.com/projects/json";

		[Token(Token = "0x4000375")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x188648", Offset = "0x188648")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188648", Offset = "0x188648")]
		private string DeserializeRootElementName__BackingField;

		[Token(Token = "0x4000376")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188684", Offset = "0x188684")]
		private bool WriteArrayAttribute__BackingField;

		[Token(Token = "0x4000377")]
		[FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188694", Offset = "0x188694")]
		private bool OmitRootObject__BackingField;

		[Token(Token = "0x4000378")]
		[FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1886A4", Offset = "0x1886A4")]
		private bool EncodeSpecialCharacters__BackingField;

		[Token(Token = "0x17000199")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18FA3C", Offset = "0x18FA3C")]
		public string DeserializeRootElementName
		{
			[Token(Token = "0x600085B")]
			[Address(RVA = "0x232C8A8", Offset = "0x232C8A8", VA = "0x232C8A8")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18B01C", Offset = "0x18B01C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18B01C", Offset = "0x18B01C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600085C")]
			[Address(RVA = "0x232C8B0", Offset = "0x232C8B0", VA = "0x232C8B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18B058", Offset = "0x18B058")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18B058", Offset = "0x18B058")]
			set
			{
			}
		}

		[Token(Token = "0x1700019A")]
		public bool WriteArrayAttribute
		{
			[Token(Token = "0x600085D")]
			[Address(RVA = "0x232C8B8", Offset = "0x232C8B8", VA = "0x232C8B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18B094", Offset = "0x18B094")]
			get
			{
				return default;
			}
			[Token(Token = "0x600085E")]
			[Address(RVA = "0x232C8C0", Offset = "0x232C8C0", VA = "0x232C8C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18B0A4", Offset = "0x18B0A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700019B")]
		public bool OmitRootObject
		{
			[Token(Token = "0x600085F")]
			[Address(RVA = "0x232C8C8", Offset = "0x232C8C8", VA = "0x232C8C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18B0B4", Offset = "0x18B0B4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000860")]
			[Address(RVA = "0x232C8D0", Offset = "0x232C8D0", VA = "0x232C8D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18B0C4", Offset = "0x18B0C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700019C")]
		public bool EncodeSpecialCharacters
		{
			[Token(Token = "0x6000861")]
			[Address(RVA = "0x232C8D8", Offset = "0x232C8D8", VA = "0x232C8D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18B0D4", Offset = "0x18B0D4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000862")]
			[Address(RVA = "0x232C8E0", Offset = "0x232C8E0", VA = "0x232C8E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18B0E4", Offset = "0x18B0E4")]
			set
			{
			}
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x232C8E8", Offset = "0x232C8E8", VA = "0x232C8E8", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E550", Offset = "0x18E550")] object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x232CA28", Offset = "0x232CA28", VA = "0x232CA28")]
		private IXmlNode WrapXml(object value)
		{
			return null;
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x232CB60", Offset = "0x232CB60", VA = "0x232CB60")]
		private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager)
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x232ED90", Offset = "0x232ED90", VA = "0x232ED90")]
		private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager)
		{
			return null;
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x232F188", Offset = "0x232F188", VA = "0x232F188")]
		private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager)
		{
			return null;
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x232F66C", Offset = "0x232F66C", VA = "0x232F66C")]
		private bool IsArray(IXmlNode node)
		{
			return default;
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x232FA60", Offset = "0x232FA60", VA = "0x232FA60")]
		private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x2330418", Offset = "0x2330418", VA = "0x2330418")]
		private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, List<IXmlNode> groupedNodes, string elementNames)
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x2330588", Offset = "0x2330588", VA = "0x2330588")]
		private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, IXmlNode node, string elementNames)
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x232D20C", Offset = "0x232D20C", VA = "0x232D20C")]
		private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x2330658", Offset = "0x2330658", VA = "0x2330658")]
		private static bool AllSameName(IXmlNode node)
		{
			return default;
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x2330CC4", Offset = "0x2330CC4", VA = "0x2330CC4", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E564", Offset = "0x18E564")] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x2332254", Offset = "0x2332254", VA = "0x2332254")]
		private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode)
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x2331670", Offset = "0x2331670", VA = "0x2331670")]
		private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager)
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x2334868", Offset = "0x2334868", VA = "0x2334868")]
		private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E578", Offset = "0x18E578")] string elementPrefix, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E58C", Offset = "0x18E58C")] Dictionary<string, string> attributeNameValues)
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x2334488", Offset = "0x2334488", VA = "0x2334488")]
		private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, string attributeName, XmlNamespaceManager manager, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E604", Offset = "0x18E604")] string attributePrefix)
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x2332888", Offset = "0x2332888", VA = "0x2332888")]
		private static string ConvertTokenToXmlValue(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x2333A68", Offset = "0x2333A68", VA = "0x2333A68")]
		private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager)
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x23351B8", Offset = "0x23351B8", VA = "0x23351B8")]
		private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document)
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x2333E48", Offset = "0x2333E48", VA = "0x2333E48")]
		private bool ShouldReadInto(JsonReader reader)
		{
			return default;
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x2333E8C", Offset = "0x2333E8C", VA = "0x2333E8C")]
		private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager)
		{
			return null;
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x233309C", Offset = "0x233309C", VA = "0x233309C")]
		private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName)
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x23335E4", Offset = "0x23335E4", VA = "0x23335E4")]
		private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode)
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x2334F8C", Offset = "0x2334F8C", VA = "0x2334F8C")]
		private IXmlElement CreateElement(string elementName, IXmlDocument document, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E618", Offset = "0x18E618")] string elementPrefix, XmlNamespaceManager manager)
		{
			return null;
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x2331A20", Offset = "0x2331A20", VA = "0x2331A20")]
		private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode)
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x2335548", Offset = "0x2335548", VA = "0x2335548")]
		private bool IsNamespaceAttribute(string attributeName, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E62C", Offset = "0x18E62C")] out string prefix)
		{
			return default;
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x2330960", Offset = "0x2330960", VA = "0x2330960")]
		private bool ValueAttributes(List<IXmlNode> c)
		{
			return default;
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x2335630", Offset = "0x2335630", VA = "0x2335630", Slot = "6")]
		public override bool CanConvert(Type valueType)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Token(Token = "0x600087F")]
		[Address(RVA = "0x2335700", Offset = "0x2335700", VA = "0x2335700")]
		private bool IsXObject(Type valueType)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Token(Token = "0x6000880")]
		[Address(RVA = "0x23357A8", Offset = "0x23357A8", VA = "0x23357A8")]
		private bool IsXmlNode(Type valueType)
		{
			return default;
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x2335850", Offset = "0x2335850", VA = "0x2335850")]
		public XmlNodeConverter()
		{
		}
	}
}
