using System.IO;

namespace Amazon.Runtime.Internal.Transform
{
	public class EC2UnmarshallerContext : XmlUnmarshallerContext
	{
		public string RequestId { get; private set; }

		public EC2UnmarshallerContext(Stream responseStream, bool maintainResponseBody, IWebResponseData responseData, bool isException = false)
			: base(null, maintainResponseBody: false, null)
		{
		}

		public override bool Read()
		{
			return false;
		}
	}
}
