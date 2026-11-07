using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class RemoveTagsFromStreamRequest : AmazonKinesisRequest
	{
		private string _streamName;

		private List<string> _tagKeys;

		[AWSProperty]
		public string StreamName
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
		public List<string> TagKeys
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetStreamName()
		{
			return false;
		}

		internal bool IsSetTagKeys()
		{
			return false;
		}
	}
}
