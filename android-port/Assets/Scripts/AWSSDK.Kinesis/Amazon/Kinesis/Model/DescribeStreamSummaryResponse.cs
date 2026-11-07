using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class DescribeStreamSummaryResponse : AmazonWebServiceResponse
	{
		private StreamDescriptionSummary _streamDescriptionSummary;

		[AWSProperty]
		public StreamDescriptionSummary StreamDescriptionSummary
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetStreamDescriptionSummary()
		{
			return false;
		}
	}
}
