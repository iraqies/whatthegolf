using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class AddTagsToStreamRequest : AmazonKinesisRequest
	{
		private string _streamName;

		private Dictionary<string, string> _tags;

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
		public Dictionary<string, string> Tags
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

		internal bool IsSetTags()
		{
			return false;
		}
	}
}
