using System.Collections.Generic;

namespace Amazon.Runtime.Internal.Transform
{
	public class KeyValueUnmarshaller<K, V, KUnmarshaller, VUnmarshaller> : IUnmarshaller<KeyValuePair<K, V>, XmlUnmarshallerContext>, IUnmarshaller<KeyValuePair<K, V>, JsonUnmarshallerContext> where KUnmarshaller : IUnmarshaller<K, XmlUnmarshallerContext>, IUnmarshaller<K, JsonUnmarshallerContext> where VUnmarshaller : IUnmarshaller<V, XmlUnmarshallerContext>, IUnmarshaller<V, JsonUnmarshallerContext>
	{
		private KUnmarshaller keyUnmarshaller;

		private VUnmarshaller valueUnmarshaller;

		public KeyValueUnmarshaller(KUnmarshaller keyUnmarshaller, VUnmarshaller valueUnmarshaller)
		{
		}

		public KeyValuePair<K, V> Unmarshall(XmlUnmarshallerContext context)
		{
			return default;
		}

		public KeyValuePair<K, V> Unmarshall(JsonUnmarshallerContext context)
		{
			return default;
		}
	}
}
