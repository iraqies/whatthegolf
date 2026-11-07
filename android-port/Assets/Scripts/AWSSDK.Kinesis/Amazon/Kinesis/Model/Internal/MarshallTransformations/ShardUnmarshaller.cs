using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	public class ShardUnmarshaller : IUnmarshaller<Shard, XmlUnmarshallerContext>, IUnmarshaller<Shard, JsonUnmarshallerContext>
	{
		private static ShardUnmarshaller _instance;

		public static ShardUnmarshaller Instance => null;

		Shard IUnmarshaller<Shard, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		public Shard Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}
	}
}
