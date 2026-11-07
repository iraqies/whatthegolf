using System.Collections.Generic;
using System.IO;
using System.Xml;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x2000237")]
	public class XmlUnmarshallerContext : UnmarshallerContext
	{
		[Token(Token = "0x40007E5")]
		[FieldOffset(Offset = "0x0")]
		private static readonly XmlReaderSettings READER_SETTINGS;

		[Token(Token = "0x40007E6")]
		[FieldOffset(Offset = "0x8")]
		private static HashSet<XmlNodeType> nodesToSkip;

		[Token(Token = "0x40007E7")]
		[FieldOffset(Offset = "0x38")]
		private StreamReader streamReader;

		[Token(Token = "0x40007E8")]
		[FieldOffset(Offset = "0x40")]
		private XmlReader _xmlReader;

		[Token(Token = "0x40007E9")]
		[FieldOffset(Offset = "0x48")]
		private Stack<string> stack;

		[Token(Token = "0x40007EA")]
		[FieldOffset(Offset = "0x50")]
		private string stackString;

		[Token(Token = "0x40007EB")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<string, string> attributeValues;

		[Token(Token = "0x40007EC")]
		[FieldOffset(Offset = "0x60")]
		private List<string> attributeNames;

		[Token(Token = "0x40007ED")]
		[FieldOffset(Offset = "0x68")]
		private IEnumerator<string> attributeEnumerator;

		[Token(Token = "0x40007EE")]
		[FieldOffset(Offset = "0x70")]
		private XmlNodeType nodeType;

		[Token(Token = "0x40007EF")]
		[FieldOffset(Offset = "0x78")]
		private string nodeContent;

		[Token(Token = "0x40007F0")]
		[FieldOffset(Offset = "0x80")]
		private bool disposed;

		[Token(Token = "0x17000433")]
		public Stream Stream
		{
			[Token(Token = "0x60010D8")]
			[Address(RVA = "0x1283BA4", Offset = "0x1283BA4", VA = "0x1283BA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000434")]
		private XmlReader XmlReader
		{
			[Token(Token = "0x60010D9")]
			[Address(RVA = "0x1283BC8", Offset = "0x1283BC8", VA = "0x1283BC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000435")]
		public override string CurrentPath
		{
			[Token(Token = "0x60010DB")]
			[Address(RVA = "0x1283C8C", Offset = "0x1283C8C", VA = "0x1283C8C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000436")]
		public override int CurrentDepth
		{
			[Token(Token = "0x60010DC")]
			[Address(RVA = "0x1283C94", Offset = "0x1283C94", VA = "0x1283C94", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000437")]
		public override bool IsStartElement
		{
			[Token(Token = "0x60010DF")]
			[Address(RVA = "0x1284628", Offset = "0x1284628", VA = "0x1284628", Slot = "9")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000438")]
		public override bool IsEndElement
		{
			[Token(Token = "0x60010E0")]
			[Address(RVA = "0x1284638", Offset = "0x1284638", VA = "0x1284638", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000439")]
		public override bool IsStartOfDocument
		{
			[Token(Token = "0x60010E1")]
			[Address(RVA = "0x1284648", Offset = "0x1284648", VA = "0x1284648", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700043A")]
		public bool IsAttribute
		{
			[Token(Token = "0x60010E2")]
			[Address(RVA = "0x128467C", Offset = "0x128467C", VA = "0x128467C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60010DA")]
		[Address(RVA = "0x12839AC", Offset = "0x12839AC", VA = "0x12839AC")]
		public XmlUnmarshallerContext(Stream responseStream, bool maintainResponseBody, IWebResponseData responseData, bool isException = false)
		{
		}

		[Token(Token = "0x60010DD")]
		[Address(RVA = "0x1283CE0", Offset = "0x1283CE0", VA = "0x1283CE0", Slot = "7")]
		public override bool Read()
		{
			return default;
		}

		[Token(Token = "0x60010DE")]
		[Address(RVA = "0x1284528", Offset = "0x1284528", VA = "0x1284528", Slot = "8")]
		public override string ReadText()
		{
			return null;
		}

		[Token(Token = "0x60010E3")]
		[Address(RVA = "0x128412C", Offset = "0x128412C", VA = "0x128412C")]
		private static string StackToPath(Stack<string> stack)
		{
			return null;
		}

		[Token(Token = "0x60010E4")]
		[Address(RVA = "0x1284280", Offset = "0x1284280", VA = "0x1284280")]
		private void ReadElement()
		{
		}

		[Token(Token = "0x60010E5")]
		[Address(RVA = "0x128468C", Offset = "0x128468C", VA = "0x128468C", Slot = "12")]
		protected override void Dispose(bool disposing)
		{
		}
	}
}
