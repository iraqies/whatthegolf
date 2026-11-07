using System.Collections.Generic;
using System.IO;
using System.Text;
using ThirdParty.Json.LitJson;

namespace Amazon.Runtime.Internal.Transform
{
	public class JsonUnmarshallerContext : UnmarshallerContext
	{
		private enum PathSegmentType
		{
			Value = 0,
			Delimiter = 1
		}

		private struct PathSegment
		{
			internal PathSegmentType SegmentType { get; set; }

			internal string Value { get; set; }
		}

		private class JsonPathStack
		{
			private Stack<PathSegment> stack;

			private int currentDepth;

			private StringBuilder stackStringBuilder;

			private string stackString;

			public int CurrentDepth => 0;

			public string CurrentPath => null;

			public int Count => 0;

			internal void Push(PathSegment segment)
			{
			}

			internal PathSegment Pop()
			{
				return default;
			}

			internal PathSegment Peek()
			{
				return default;
			}
		}

		private const string DELIMITER = "/";

		private StreamReader streamReader;

		private JsonReader jsonReader;

		private JsonPathStack stack;

		private string currentField;

		private JsonToken? currentToken;

		private bool disposed;

		private bool wasPeeked;

		public override bool IsStartOfDocument => false;

		public override bool IsEndElement => false;

		public override bool IsStartElement => false;

		public override int CurrentDepth => 0;

		public override string CurrentPath => null;

		public JsonToken CurrentTokenType => JsonToken.None;

		public Stream Stream => null;

		public JsonUnmarshallerContext(Stream responseStream, bool maintainResponseBody, IWebResponseData responseData, bool isException = false)
		{
		}

		public override bool Read()
		{
			return false;
		}

		public bool Peek(JsonToken token)
		{
			return false;
		}

		public override string ReadText()
		{
			return null;
		}

		public int Peek()
		{
			return 0;
		}

		private int StreamPeek()
		{
			return 0;
		}

		private void UpdateContext()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}
}
