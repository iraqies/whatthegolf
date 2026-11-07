using System;

namespace Amazon.Runtime.Internal.Transform
{
	public class NullableDateTimeUnmarshaller : IUnmarshaller<DateTime?, JsonUnmarshallerContext>
	{
		private static NullableDateTimeUnmarshaller _instance;

		public static NullableDateTimeUnmarshaller Instance => null;

		private NullableDateTimeUnmarshaller()
		{
		}

		public static NullableDateTimeUnmarshaller GetInstance()
		{
			return null;
		}

		public DateTime? Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}
	}
}
