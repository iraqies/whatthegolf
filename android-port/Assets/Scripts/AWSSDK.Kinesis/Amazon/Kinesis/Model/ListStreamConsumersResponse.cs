using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class ListStreamConsumersResponse : AmazonWebServiceResponse
	{
		private List<Consumer> _consumers;

		private string _nextToken;

		public List<Consumer> Consumers
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string NextToken
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetConsumers()
		{
			return false;
		}

		internal bool IsSetNextToken()
		{
			return false;
		}
	}
}
