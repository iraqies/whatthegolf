using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x2000233")]
	public class ListUnmarshaller<I, IUnmarshaller> : IUnmarshaller<List<I>, XmlUnmarshallerContext>, IUnmarshaller<List<I>, JsonUnmarshallerContext> where IUnmarshaller : IUnmarshaller<I, XmlUnmarshallerContext>, IUnmarshaller<I, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40007DC")]
		[FieldOffset(Offset = "0x0")]
		private IUnmarshaller iUnmarshaller;

		[Token(Token = "0x60010B1")]
		public ListUnmarshaller(IUnmarshaller iUnmarshaller)
		{
		}

		[Token(Token = "0x60010B2")]
		public List<I> Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60010B3")]
		public List<I> Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}
	}
}
