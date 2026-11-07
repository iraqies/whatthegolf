using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Amazon.Runtime.Internal.Transform
{
	public class XmlUnmarshallerContext : UnmarshallerContext
	{
		private static readonly XmlReaderSettings READER_SETTINGS;

		private static HashSet<XmlNodeType> nodesToSkip;

		private StreamReader streamReader;

		private XmlReader _xmlReader;

		private Stack<string> stack;

		private string stackString;

		private Dictionary<string, string> attributeValues;

		private List<string> attributeNames;

		private IEnumerator<string> attributeEnumerator;

		private XmlNodeType nodeType;

		private string nodeContent;

		private bool disposed;

		public Stream Stream => null;

		private XmlReader XmlReader => null;

		public override string CurrentPath => null;

		public override int CurrentDepth => 0;

		public override bool IsStartElement => false;

		public override bool IsEndElement => false;

		public override bool IsStartOfDocument => false;

		public bool IsAttribute => false;

		public XmlUnmarshallerContext(Stream responseStream, bool maintainResponseBody, IWebResponseData responseData, bool isException = false)
		{
		}

		public override bool Read()
		{
			return false;
		}

		public override string ReadText()
		{
			return null;
		}

		private static string StackToPath(Stack<string> stack)
		{
			return null;
		}

		private void ReadElement()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}
}
