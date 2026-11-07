using System;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	[Serializable]
	public class JsonReaderException : JsonException
	{
		private readonly int LineNumber;

		private readonly int LinePosition;

		private readonly string Path;

		public JsonReaderException()
		{
		}

		public JsonReaderException(SerializationInfo info, StreamingContext context)
		{
		}

		public JsonReaderException(string message, string path, int lineNumber, int linePosition, Exception innerException)
		{
		}

		internal static JsonReaderException Create(JsonReader reader, string message)
		{
			return null;
		}

		internal static JsonReaderException Create(JsonReader reader, string message, Exception ex)
		{
			return null;
		}

		internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex)
		{
			return null;
		}
	}
}
