using System.Collections.Generic;

namespace Amazon.Runtime.Internal.Transform
{
	public class ListUnmarshaller<I, IUnmarshaller> : IUnmarshaller<List<I>, XmlUnmarshallerContext>, IUnmarshaller<List<I>, JsonUnmarshallerContext> where IUnmarshaller : IUnmarshaller<I, XmlUnmarshallerContext>, IUnmarshaller<I, JsonUnmarshallerContext>
	{
		private IUnmarshaller iUnmarshaller;

		public ListUnmarshaller(IUnmarshaller iUnmarshaller)
		{
		}

		public List<I> Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		public List<I> Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}
	}
}
