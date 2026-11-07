using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x2000234")]
	public class DictionaryUnmarshaller<TKey, TValue, TKeyUnmarshaller, TValueUnmarshaller> : IUnmarshaller<Dictionary<TKey, TValue>, XmlUnmarshallerContext>, IUnmarshaller<Dictionary<TKey, TValue>, JsonUnmarshallerContext> where TKeyUnmarshaller : IUnmarshaller<TKey, XmlUnmarshallerContext>, IUnmarshaller<TKey, JsonUnmarshallerContext> where TValueUnmarshaller : IUnmarshaller<TValue, XmlUnmarshallerContext>, IUnmarshaller<TValue, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40007DD")]
		[FieldOffset(Offset = "0x0")]
		private KeyValueUnmarshaller<TKey, TValue, TKeyUnmarshaller, TValueUnmarshaller> KVUnmarshaller;

		[Token(Token = "0x60010B4")]
		public DictionaryUnmarshaller(TKeyUnmarshaller kUnmarshaller, TValueUnmarshaller vUnmarshaller)
		{
		}

		[Token(Token = "0x60010B5")]
		public Dictionary<TKey, TValue> Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60010B6")]
		public Dictionary<TKey, TValue> Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}
	}
}
