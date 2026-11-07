using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class ListStreamsResponse : AmazonWebServiceResponse
	{
		private bool? _hasMoreStreams;

		private List<string> _streamNames;

		[AWSProperty]
		public bool HasMoreStreams
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[AWSProperty]
		public List<string> StreamNames
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetHasMoreStreams()
		{
			return false;
		}

		internal bool IsSetStreamNames()
		{
			return false;
		}
	}
}
