using System.IO;

namespace Amazon.Runtime.Internal.Transform
{
	public abstract class EC2ResponseUnmarshaller : XmlResponseUnmarshaller
	{
		public override AmazonWebServiceResponse Unmarshall(UnmarshallerContext input)
		{
			return null;
		}

		protected override UnmarshallerContext ConstructUnmarshallerContext(Stream responseStream, bool maintainResponseBody, IWebResponseData response, bool isException)
		{
			return null;
		}
	}
}
