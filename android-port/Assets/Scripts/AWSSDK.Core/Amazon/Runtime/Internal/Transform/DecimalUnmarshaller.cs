namespace Amazon.Runtime.Internal.Transform
{
	public class DecimalUnmarshaller : IUnmarshaller<decimal, XmlUnmarshallerContext>, IUnmarshaller<decimal, JsonUnmarshallerContext>
	{
		private static DecimalUnmarshaller _instance;

		public static DecimalUnmarshaller Instance => null;

		private DecimalUnmarshaller()
		{
		}

		public static DecimalUnmarshaller GetInstance()
		{
			return null;
		}

		public decimal Unmarshall(XmlUnmarshallerContext context)
		{
			return 0m;
		}

		public decimal Unmarshall(JsonUnmarshallerContext context)
		{
			return 0m;
		}
	}
}
