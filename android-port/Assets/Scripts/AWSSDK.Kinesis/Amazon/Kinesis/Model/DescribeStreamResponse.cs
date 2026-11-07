using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class DescribeStreamResponse : AmazonWebServiceResponse
	{
		private StreamDescription _streamDescription;

		[AWSProperty]
		public StreamDescription StreamDescription
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetStreamDescription()
		{
			return false;
		}
	}
}
