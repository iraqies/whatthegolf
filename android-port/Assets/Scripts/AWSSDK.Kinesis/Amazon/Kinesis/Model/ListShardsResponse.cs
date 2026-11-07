using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class ListShardsResponse : AmazonWebServiceResponse
	{
		private string _nextToken;

		private List<Shard> _shards;

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

		public List<Shard> Shards
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetNextToken()
		{
			return false;
		}

		internal bool IsSetShards()
		{
			return false;
		}
	}
}
