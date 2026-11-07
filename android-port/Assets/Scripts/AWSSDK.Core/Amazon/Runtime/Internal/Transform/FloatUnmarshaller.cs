namespace Amazon.Runtime.Internal.Transform
{
	public class FloatUnmarshaller : IUnmarshaller<float, XmlUnmarshallerContext>, IUnmarshaller<float, JsonUnmarshallerContext>
	{
		private static FloatUnmarshaller _instance;

		public static FloatUnmarshaller Instance => null;

		private FloatUnmarshaller()
		{
		}

		public static FloatUnmarshaller GetInstance()
		{
			return null;
		}

		public float Unmarshall(XmlUnmarshallerContext context)
		{
			return 0f;
		}

		public float Unmarshall(JsonUnmarshallerContext context)
		{
			return 0f;
		}
	}
}
