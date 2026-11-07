namespace Amazon.Runtime.Internal.Transform
{
	public class DoubleUnmarshaller : IUnmarshaller<double, XmlUnmarshallerContext>, IUnmarshaller<double, JsonUnmarshallerContext>
	{
		private static DoubleUnmarshaller _instance;

		public static DoubleUnmarshaller Instance => null;

		private DoubleUnmarshaller()
		{
		}

		public static DoubleUnmarshaller GetInstance()
		{
			return null;
		}

		public double Unmarshall(XmlUnmarshallerContext context)
		{
			return 0.0;
		}

		public double Unmarshall(JsonUnmarshallerContext context)
		{
			return 0.0;
		}
	}
}
