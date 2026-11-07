using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	public class TagUnmarshaller : IUnmarshaller<Tag, XmlUnmarshallerContext>, IUnmarshaller<Tag, JsonUnmarshallerContext>
	{
		private static TagUnmarshaller _instance;

		public static TagUnmarshaller Instance => null;

		Tag IUnmarshaller<Tag, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		public Tag Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}
	}
}
