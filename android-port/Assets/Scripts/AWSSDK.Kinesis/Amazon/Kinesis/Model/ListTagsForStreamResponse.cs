using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
	public class ListTagsForStreamResponse : AmazonWebServiceResponse
	{
		private bool? _hasMoreTags;

		private List<Tag> _tags;

		[AWSProperty]
		public bool HasMoreTags
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
		public List<Tag> Tags
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetHasMoreTags()
		{
			return false;
		}

		internal bool IsSetTags()
		{
			return false;
		}
	}
}
