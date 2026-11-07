using System.IO;

namespace Amazon.Runtime.Internal.Transform
{
	public class MemoryStreamUnmarshaller : IUnmarshaller<MemoryStream, XmlUnmarshallerContext>, IUnmarshaller<MemoryStream, JsonUnmarshallerContext>
	{
		private static MemoryStreamUnmarshaller _instance;

		public static MemoryStreamUnmarshaller Instance => null;

		private MemoryStreamUnmarshaller()
		{
		}

		public static MemoryStreamUnmarshaller GetInstance()
		{
			return null;
		}

		public MemoryStream Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		public MemoryStream Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}
	}
}
