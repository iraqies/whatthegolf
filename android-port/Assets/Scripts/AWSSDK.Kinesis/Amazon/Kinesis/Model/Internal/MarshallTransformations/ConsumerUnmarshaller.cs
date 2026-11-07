using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	public class ConsumerUnmarshaller : IUnmarshaller<Consumer, XmlUnmarshallerContext>, IUnmarshaller<Consumer, JsonUnmarshallerContext>
	{
		private static ConsumerUnmarshaller _instance;

		public static ConsumerUnmarshaller Instance => null;

		Consumer IUnmarshaller<Consumer, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		public Consumer Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}
	}
}
