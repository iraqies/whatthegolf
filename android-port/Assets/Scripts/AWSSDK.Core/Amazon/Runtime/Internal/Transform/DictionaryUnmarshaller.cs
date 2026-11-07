using System.Collections.Generic;

namespace Amazon.Runtime.Internal.Transform
{
	public class DictionaryUnmarshaller<TKey, TValue, TKeyUnmarshaller, TValueUnmarshaller> : IUnmarshaller<Dictionary<TKey, TValue>, XmlUnmarshallerContext>, IUnmarshaller<Dictionary<TKey, TValue>, JsonUnmarshallerContext> where TKeyUnmarshaller : IUnmarshaller<TKey, XmlUnmarshallerContext>, IUnmarshaller<TKey, JsonUnmarshallerContext> where TValueUnmarshaller : IUnmarshaller<TValue, XmlUnmarshallerContext>, IUnmarshaller<TValue, JsonUnmarshallerContext>
	{
		private KeyValueUnmarshaller<TKey, TValue, TKeyUnmarshaller, TValueUnmarshaller> KVUnmarshaller;

		public DictionaryUnmarshaller(TKeyUnmarshaller kUnmarshaller, TValueUnmarshaller vUnmarshaller)
		{
		}

		public Dictionary<TKey, TValue> Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		public Dictionary<TKey, TValue> Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}
	}
}
