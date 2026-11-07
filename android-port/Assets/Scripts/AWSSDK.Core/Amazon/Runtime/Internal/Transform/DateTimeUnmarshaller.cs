using System;

namespace Amazon.Runtime.Internal.Transform
{
	public class DateTimeUnmarshaller : IUnmarshaller<DateTime, XmlUnmarshallerContext>, IUnmarshaller<DateTime, JsonUnmarshallerContext>
	{
		private static DateTimeUnmarshaller _instance;

		public static DateTimeUnmarshaller Instance => null;

		private DateTimeUnmarshaller()
		{
		}

		public static DateTimeUnmarshaller GetInstance()
		{
			return null;
		}

		public DateTime Unmarshall(XmlUnmarshallerContext context)
		{
			return default;
		}

		public DateTime Unmarshall(JsonUnmarshallerContext context)
		{
			return default;
		}

		internal static DateTime? UnmarshallInternal(string text, bool treatAsNullable)
		{
			return null;
		}
	}
}
