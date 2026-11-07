namespace Amazon.Runtime.Internal.Transform
{
	public class LongUnmarshaller : IUnmarshaller<long, XmlUnmarshallerContext>, IUnmarshaller<long, JsonUnmarshallerContext>
	{
		private static LongUnmarshaller _instance;

		public static LongUnmarshaller Instance => null;

		private LongUnmarshaller()
		{
		}

		public static LongUnmarshaller GetInstance()
		{
			return null;
		}

		public long Unmarshall(XmlUnmarshallerContext context)
		{
			return 0L;
		}

		public long Unmarshall(JsonUnmarshallerContext context)
		{
			return 0L;
		}
	}
}
