namespace Amazon.Runtime.Internal.Transform
{
	public class BoolUnmarshaller : IUnmarshaller<bool, XmlUnmarshallerContext>, IUnmarshaller<bool, JsonUnmarshallerContext>
	{
		private static BoolUnmarshaller _instance;

		public static BoolUnmarshaller Instance => null;

		private BoolUnmarshaller()
		{
		}

		public static BoolUnmarshaller GetInstance()
		{
			return null;
		}

		public bool Unmarshall(XmlUnmarshallerContext context)
		{
			return false;
		}

		public bool Unmarshall(JsonUnmarshallerContext context)
		{
			return false;
		}
	}
}
