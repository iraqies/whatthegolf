using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x2000232")]
	public class KeyValueUnmarshaller<K, V, KUnmarshaller, VUnmarshaller> : IUnmarshaller<KeyValuePair<K, V>, XmlUnmarshallerContext>, IUnmarshaller<KeyValuePair<K, V>, JsonUnmarshallerContext> where KUnmarshaller : IUnmarshaller<K, XmlUnmarshallerContext>, IUnmarshaller<K, JsonUnmarshallerContext> where VUnmarshaller : IUnmarshaller<V, XmlUnmarshallerContext>, IUnmarshaller<V, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40007DA")]
		[FieldOffset(Offset = "0x0")]
		private KUnmarshaller keyUnmarshaller;

		[Token(Token = "0x40007DB")]
		[FieldOffset(Offset = "0x0")]
		private VUnmarshaller valueUnmarshaller;

		[Token(Token = "0x60010AE")]
		public KeyValueUnmarshaller(KUnmarshaller keyUnmarshaller, VUnmarshaller valueUnmarshaller)
		{
		}

		[Token(Token = "0x60010AF")]
		public KeyValuePair<K, V> Unmarshall(XmlUnmarshallerContext context)
		{
			return default;
		}

		[Token(Token = "0x60010B0")]
		public KeyValuePair<K, V> Unmarshall(JsonUnmarshallerContext context)
		{
			return default;
		}
	}
}
